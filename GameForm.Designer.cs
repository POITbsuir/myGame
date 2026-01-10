namespace myGame
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelBullet = new System.Windows.Forms.Label();
            this.poisonFlower = new System.Windows.Forms.PictureBox();
            this.flower = new System.Windows.Forms.PictureBox();
            this.ai = new System.Windows.Forms.PictureBox();
            this.sprite = new System.Windows.Forms.PictureBox();
            this.pHealth3 = new System.Windows.Forms.PictureBox();
            this.pHealth2 = new System.Windows.Forms.PictureBox();
            this.pHealth1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.poisonFlower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHealth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMap)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 120;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // labelBullet
            // 
            this.labelBullet.AutoSize = true;
            this.labelBullet.Location = new System.Drawing.Point(0, 0);
            this.labelBullet.Name = "labelBullet";
            this.labelBullet.Size = new System.Drawing.Size(0, 16);
            this.labelBullet.TabIndex = 10;
            // 
            // poisonFlower
            // 
            this.poisonFlower.Image = global::myGame.ResourceGame.poisonFlower;
            this.poisonFlower.Location = new System.Drawing.Point(413, 45);
            this.poisonFlower.Name = "poisonFlower";
            this.poisonFlower.Size = new System.Drawing.Size(37, 54);
            this.poisonFlower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poisonFlower.TabIndex = 9;
            this.poisonFlower.TabStop = false;
            this.poisonFlower.Click += new System.EventHandler(this.poisonFlower_Click);
            // 
            // flower
            // 
            this.flower.Image = global::myGame.ResourceGame.FlowerCoins;
            this.flower.Location = new System.Drawing.Point(147, 71);
            this.flower.Name = "flower";
            this.flower.Size = new System.Drawing.Size(28, 28);
            this.flower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flower.TabIndex = 8;
            this.flower.TabStop = false;
            this.flower.Click += new System.EventHandler(this.flower_Click);
            // 
            // ai
            // 
            this.ai.Image = global::myGame.ResourceGame.Swardan;
            this.ai.Location = new System.Drawing.Point(463, 291);
            this.ai.Name = "ai";
            this.ai.Size = new System.Drawing.Size(51, 50);
            this.ai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ai.TabIndex = 6;
            this.ai.TabStop = false;
            // 
            // sprite
            // 
            this.sprite.Image = global::myGame.ResourceGame.homeGame;
            this.sprite.Location = new System.Drawing.Point(636, 436);
            this.sprite.Name = "sprite";
            this.sprite.Size = new System.Drawing.Size(72, 72);
            this.sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sprite.TabIndex = 5;
            this.sprite.TabStop = false;
            // 
            // pHealth3
            // 
            this.pHealth3.Location = new System.Drawing.Point(650, 8);
            this.pHealth3.Name = "pHealth3";
            this.pHealth3.Size = new System.Drawing.Size(15, 15);
            this.pHealth3.TabIndex = 4;
            this.pHealth3.TabStop = false;
            // 
            // pHealth2
            // 
            this.pHealth2.Location = new System.Drawing.Point(675, 8);
            this.pHealth2.Name = "pHealth2";
            this.pHealth2.Size = new System.Drawing.Size(15, 15);
            this.pHealth2.TabIndex = 3;
            this.pHealth2.TabStop = false;
            // 
            // pHealth1
            // 
            this.pHealth1.Location = new System.Drawing.Point(700, 8);
            this.pHealth1.Name = "pHealth1";
            this.pHealth1.Size = new System.Drawing.Size(15, 15);
            this.pHealth1.TabIndex = 2;
            this.pHealth1.TabStop = false;
            this.pHealth1.Click += new System.EventHandler(this.pHealth1_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Image = global::myGame.ResourceGame.Player;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(48, 48);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // pMap
            // 
            this.pMap.BackColor = System.Drawing.Color.Lime;
            this.pMap.Enabled = false;
            this.pMap.Image = global::myGame.ResourceGame.MapGame;
            this.pMap.Location = new System.Drawing.Point(0, 0);
            this.pMap.Name = "pMap";
            this.pMap.Size = new System.Drawing.Size(720, 520);
            this.pMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pMap.TabIndex = 0;
            this.pMap.TabStop = false;
            this.pMap.Click += new System.EventHandler(this.pMap_Click);
            this.pMap.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pMap_ControlAdded);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(720, 520);
            this.Controls.Add(this.labelBullet);
            this.Controls.Add(this.poisonFlower);
            this.Controls.Add(this.flower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ai);
            this.Controls.Add(this.sprite);
            this.Controls.Add(this.pHealth3);
            this.Controls.Add(this.pHealth2);
            this.Controls.Add(this.pHealth1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Deactivate += new System.EventHandler(this.GameForm_Deactivate);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.GameForm_ControlAdded);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.GameForm_ControlRemoved);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.poisonFlower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHealth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pMap;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pHealth1;
        private System.Windows.Forms.PictureBox pHealth2;
        private System.Windows.Forms.PictureBox pHealth3;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.PictureBox sprite;
        private System.Windows.Forms.PictureBox ai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox flower;
        private System.Windows.Forms.PictureBox poisonFlower;
        private System.Windows.Forms.Label labelBullet;
    }
}