using Invorement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGame
{
    public partial class GameForm : Form
    {
        public double healthPlayer = 3;
        public List<PictureBox> pictureBoxes = new List<PictureBox>();
        public bool direction = true;
        public int maxCoins = 25;
        public int currentCoins = 0;
        public FileClass fileClass = new FileClass();
        public List<PictureBox> AIList = new List<PictureBox>(5);
       
        public Timer timerSwardan = new Timer();

        Random random = new Random();
        public int maxSteps = 50;
        public int currentSteps = 0;
        public string currentDirection;

        private Dictionary<PictureBox, (string direction, int steps)> aiStates 
            = new Dictionary<PictureBox, (string, int)>();

        public int currentBullet = 5;
        public PictureBox ammoBox = null;

        public GameForm()
        {
            InitializeComponent();
            pMap.Enabled = false;
            player.Location = new Point(0, 0);
            player.BringToFront();
            this.BackgroundImage = ResourceGame.MapGame;
            this.ClientSize = new Size(720, 520);

           

            KeyPreview = true;
            this.KeyDown += GameForm_KeyDown;
            UpdateBullet();
            this.Focus();
            timerGame.Enabled = true;

            this.ControlAdded += pMap_ControlAdded;
            this.ControlAdded += GameForm_ControlAdded;
            this.ControlRemoved += GameForm_ControlRemoved;
            timerGame.Tick += timerGame_Tick;

            timerSwardan.Interval = 15;
            timerSwardan.Tick += MoveAllSwardans;
            timerSwardan.Start();

            ColorHealth();
            ai.Location = new Point(410, 240);

            Image image = poisonFlower.Image;
            Image transparent = RemoveWhiteBackgroundSimple(image);
            poisonFlower.Image = transparent;
            poisonFlower.BackColor = Color.Transparent;

            sprite.BringToFront();


            Image imagePlayer = ResourceGame.GrayPlayer1;
            Image transparentImagePlayer = RemoveWhiteBackgroundSimple(imagePlayer);
            player.Image = transparentImagePlayer;
            player.BackColor = Color.Transparent;
            player.ClientSize = new Size(64, 64);

        }

        private void UpdateBullet()
        {
            labelBullet.Location = new Point(0, 5);
            labelBullet.Text = $"Боепотронов {currentBullet}";

            if (currentBullet <= 0 && ammoBox == null)
            {
                // Создаём коробку один раз
                ammoBox = new PictureBox();
                int x = random.Next(50, 400);
                int y = random.Next(50, 250);
                Image img = RemoveWhiteBackgroundSimple(ResourceGame.bulletImage);

                ammoBox.Image = img;
                ammoBox.Size = new Size(28, 28);
                ammoBox.BackColor = Color.Transparent;
                ammoBox.Location = new Point(x, y);
                ammoBox.Tag = "ammo";
                this.Controls.Add(ammoBox);
                ammoBox.BringToFront();
            }
        }

        private Image RemoveWhiteBackgroundSimple(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            Color transparentColor = Color.FromArgb(255, 255, 255);
            bmp.MakeTransparent(transparentColor);
            return bmp;
        }

        private void PoisonFlowerMove()
        {
            int speed = 1;
            int x = poisonFlower.Location.X;
            int y = poisonFlower.Location.Y;
            int minX, minY, maxX, maxY;
            minX = 0; minY = 0; maxX = 720; maxY = 520;
            
            if (currentDirection == null || currentSteps >= maxSteps)
            {
                string[] directionArray = { "up", "right", "down", "left" };
                int index = random.Next(directionArray.Length);
                currentDirection = directionArray[index];
                currentSteps = 0;
            }
           
            bool moved = false;
           
            if (currentDirection == "up" && y > minY)
            {
                poisonFlower.Location = new Point(x, y - speed);
                moved = true;
            }
            else if (currentDirection == "right" && x < maxX)
            {
                poisonFlower.Location = new Point(x + speed, y);
                moved = true;
            }
            else if (currentDirection == "down" && y < maxY)
            {
                poisonFlower.Location = new Point(x, y + speed);
                moved = true;
            }
            else if (currentDirection == "left" && x > minX)
            {
                poisonFlower.Location = new Point(x - speed, y);
                moved = true;
            }

            if (moved)
            { currentSteps++; }
            else 
            {
                currentDirection = null;
                currentSteps = maxSteps;
            }
            if (player.Bounds.IntersectsWith(poisonFlower.Bounds))
            {
                healthPlayer = 0;
                UpdateHealth();
            }
        }
        public void BoundsFlower()
        {
            Random random = new Random();
            
            int x = flower.Location.X;
            int y = flower.Location.Y;
            if (player.Bounds.IntersectsWith(flower.Bounds))
            {
                currentCoins++;
                x = random.Next(0, 504);
                y = random.Next(0, 300);
                flower.Location = new Point(x, y);
            }
            if (currentCoins >= 0)
                fileClass.WriteToFile(currentCoins);
        }

        public void StatisticLabel()
        {
            if (maxCoins > currentCoins)
            {
                label1.Text =  $"Собрано {currentCoins} / {maxCoins} монет";
            }
            if (maxCoins <= currentCoins)
            { label1.Text = "Можете вернуться в главное меню"; }
        }

        public void ColorHealth()
        { 
            pHealth1.BackColor = Color.Red;   
            pHealth2.BackColor = Color.Red;   
            pHealth3.BackColor = Color.Red;   
        }

        public void UpdateHealth()
        {
            if(healthPlayer < 3)
                pHealth1.BackColor = Color.Gray;
            if(healthPlayer < 2)
                pHealth2.BackColor = Color.Gray;
            if(healthPlayer < 1)
            {
               
                pHealth3.BackColor = Color.Gray;
                timerGame.Stop();
                timerSwardan.Stop();
                MessageBox.Show("Вы проиграли");
                this.Close();
            }   
        }

        private void MakeSwardan()
        {
            PictureBox ai = new PictureBox();
            Random randomLocation = new Random();
            int x = randomLocation.Next(15, 340);
            int y = randomLocation.Next(15, 340);
            int speed = 15;
            if (AIList.Count < 3)
            {
                ai.Size = new Size(32, 32);
                ai.Tag = "Swardan";
                ai.BackColor = Color.BlueViolet;
                ai.Image = ResourceGame.Swardan;
                ai.SizeMode = PictureBoxSizeMode.StretchImage;
                ai.Location = new Point(x, y);
                AIList.Add(ai);
                ai.Left += speed;
                ai.Top += speed - 3;
                this.Controls.Add(ai);
                ai.BringToFront();
            }
            if (AIList.Count >= 3)
                return;
        }

        private void MoveAllSwardans(object sender, EventArgs e)
        {
            foreach (PictureBox swardan in AIList.ToList()) 
            {
                if (!aiStates.ContainsKey(swardan))
                {
                    aiStates[swardan] = (null, 0);
                }

                var (currentDirection, currentSteps) = aiStates[swardan];

                int speed = 1;
                int x = swardan.Location.X;
                int y = swardan.Location.Y;
                int minX, minY, maxX, maxY;
                minX = 0; minY = 0; maxX = 720; maxY = 520;

                if (currentDirection == null || currentSteps >= maxSteps)
                {
                    string[] directionArray = { "up", "right", "down", "left" };
                    int index = random.Next(directionArray.Length);
                    currentDirection = directionArray[index];
                    currentSteps = 0;
                }

                bool moved = false;

                if (currentDirection == "up" && y > minY)
                {
                    swardan.Location = new Point(x, y - speed);
                    moved = true;
                }
                else if (currentDirection == "right" && x < maxX)
                {
                    swardan.Location = new Point(x + speed, y);
                    moved = true;
                }
                else if (currentDirection == "down" && y < maxY)
                {
                    swardan.Location = new Point(x, y + speed);
                    moved = true;
                }
                else if (currentDirection == "left" && x > minX)
                {
                    swardan.Location = new Point(x - speed, y);
                    moved = true;
                }

                if (moved)
                { currentSteps++; }
                else
                {
                    currentDirection = null;
                    currentSteps = maxSteps;
                }

                if (player.Bounds.IntersectsWith(swardan.Bounds))
                {
                    healthPlayer = healthPlayer - 0.05;
                    UpdateHealth();

                }

                aiStates[swardan] = (currentDirection, currentSteps);
            }
        }

        public void Collision()
        {
            foreach (var i in pictureBoxes)
            { 
                if(i.Name == "sprite")
                    player.Location = new Point(player.Location.X - 5, player.Location.Y - 5); 
               
            }
            player.Location = new Point(player.Location.X - 5, player.Location.Y - 5);

        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
               Close();
            if(e.KeyCode == Keys.W && player.Location.Y > 20)
            {
                if (player.Bounds.IntersectsWith(sprite.Bounds))
                    Collision();
                else
                    player.Location = new Point(player.Location.X, player.Location.Y - 5);
            }
            if (e.KeyCode == Keys.A && player.Location.X > 0)
            {
                if (player.Bounds.IntersectsWith(sprite.Bounds))
                    Collision();
                else
                    player.Location = new Point(player.Location.X - 5, player.Location.Y);
            }
            if (e.KeyCode == Keys.D && player.Location.X < 690)
            {
                if (player.Bounds.IntersectsWith(sprite.Bounds))
                    Collision();
                else
                    player.Location = new Point(player.Location.X + 5, player.Location.Y);
            }
            if (e.KeyCode == Keys.S && player.Location.Y < 485)
            {
                if (player.Bounds.IntersectsWith(sprite.Bounds))
                    Collision();
                else
                    player.Location = new Point(player.Location.X, player.Location.Y + 5);
            }
            if (e.KeyCode == Keys.B && (player.Location.X < 504 && player.Location.Y > 0))
            {
                if (player.Bounds.IntersectsWith(sprite.Bounds))
                    Collision();
                else
                    player.Location = new Point(player.Location.X + 5, player.Location.Y - 5);
            }
            if (e.KeyCode == Keys.C && (player.Location.X > 0 && player.Location.Y < 382))
            {
                if (player.Bounds.IntersectsWith(sprite.Bounds))
                    Collision();
                else
                    player.Location = new Point(player.Location.X - 5, player.Location.Y + 5);
            }
            if (e.KeyCode == Keys.Space)
            {
                ShootBullet();  
            } 
        }

        private void ShootBullet()
        {
            if (currentBullet <= 5 && currentBullet > 0)
            {
                Bullet bullet = new Bullet();
                bullet.direction = "right";
                bullet.bulletLeft = player.Left + (player.Width / 2);
                bullet.bulletTop = player.Top + (player.Height / 2) - 5;
                bullet.MakeBullet(this);
                CheckCollisionForBullet(bullet.GetBulletPictureBox());
                currentBullet--;
                UpdateBullet();
            }
            else if (currentBullet <= 0)
                return;
            if (player.Bounds.IntersectsWith(sprite.Bounds))
            {
                currentBullet = 5;
                UpdateBullet();
            }
        }

        private void CheckCollisionForBullet(PictureBox bullet)
        {
            Timer collisionTimer = new Timer();
            collisionTimer.Interval = 10; 
            collisionTimer.Tag = bullet; 

            collisionTimer.Tick += (sender, e) =>
            {
                Timer timer = (Timer)sender;
                PictureBox currentBullet = (PictureBox)timer.Tag;

                if (currentBullet.IsDisposed)
                {
                    timer.Stop();
                    timer.Dispose();
                    return;
                }

               
                foreach (PictureBox enemy in AIList.ToList())
                {
                    if (currentBullet.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        
                        this.Controls.Remove(enemy);
                        AIList.Remove(enemy);
                        enemy.Dispose();

                        this.Controls.Remove(currentBullet);
                        currentBullet.Dispose();

                        timer.Stop();
                        timer.Dispose();
                        return;
                    }
                }
            };

            collisionTimer.Start();
        }

        public void MoveAI()
        {
            int speedAI = 2;
            int x = ai.Location.X;
            int y = ai.Location.Y;
            if (direction)
            {
                ai.Location = new Point(x + speedAI, y + speedAI);
                if (x > 500 && y > 300)
                    direction = false;
            }
            else 
            {
                ai.Location = new Point(x - speedAI, y - speedAI);
                if (x < 440 && y < 240)
                    direction = true;
            }
            if (player.Bounds.IntersectsWith(ai.Bounds))
            {
                healthPlayer--;
                UpdateHealth();
            }    
                
        }

        private void pHealth1_Click(object sender, EventArgs e) {}

        private void timerGame_Tick(object sender, EventArgs e)
        {
            MoveAI();
            BoundsFlower();
            StatisticLabel();
            MakeSwardan();
            PoisonFlowerMove();

            if (ammoBox != null && player.Bounds.IntersectsWith(ammoBox.Bounds))
            {
                currentBullet = 5;
                UpdateBullet();

                this.Controls.Remove(ammoBox);
                ammoBox.Dispose();
                ammoBox = null; 
            }

        }

        private void pMap_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is PictureBox pictureBox)
            {
                if (!pictureBoxes.Contains(pictureBox))
                { 
                    pictureBoxes.Add(pictureBox);
                }
            }
        }

        private void GameForm_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is PictureBox pictureBox)
            {
                if (!pictureBoxes.Contains(pictureBox))
                {
                    pictureBoxes.Add(pictureBox);
                }
            }
        }

        private void GameForm_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control is PictureBox pictureBox)
            {
                pictureBoxes.Remove(pictureBox);
            }
        }

        private void flower_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Игровая валюта");
        }

        private void GameForm_Deactivate(object sender, EventArgs e)
        {
            timerGame.Stop();
        }

        private void pMap_Click(object sender, EventArgs e)
        {

        }

        private void poisonFlower_Click(object sender, EventArgs e)
        {

        }
    }
}
