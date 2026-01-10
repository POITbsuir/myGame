using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace myGame
{
    public class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int _speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();
        private int _damage = 1;

        private List<PictureBox> BulletList = new List<PictureBox>(5);


        public Bullet() { }

        public PictureBox GetBulletPictureBox()
        {
            return bullet;
        }

        public int GetBalletDamage()
        {
            return _damage; 
        }
        public void MakeBullet(Form form)
        {
            if (BulletList.Count <= 5)
            {
                bullet.BackColor = Color.Black;
                bullet.Size = new Size(5, 5);
                bullet.Tag = "bullet";
                bullet.Top = bulletTop;
                bullet.Left = bulletLeft;


                form.Controls.Add(bullet);
                bullet.BringToFront();

                bulletTimer.Interval = _speed;
                bulletTimer.Tick += new EventHandler(BulletTimerEvent);

                bulletTimer.Start();
            }
            else if (BulletList.Count >= 5)
                return;
           
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            bullet.Left += _speed;  
            if (bullet.Left > 800)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
            }
        }
    }
}
