namespace myGame
{
    partial class Game
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bStart = new System.Windows.Forms.Button();
            this.tStart = new System.Windows.Forms.Timer(this.components);
            this.test = new System.Windows.Forms.Label();
            this.bImpromevent = new System.Windows.Forms.Button();
            this.bSettings = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.YellowGreen;
            this.bStart.Location = new System.Drawing.Point(260, 64);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(173, 60);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "СТАРТ";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tStart
            // 
            this.tStart.Enabled = true;
            this.tStart.Interval = 60;
            this.tStart.Tick += new System.EventHandler(this.tStart_Tick);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.ForeColor = System.Drawing.Color.Gold;
            this.test.Location = new System.Drawing.Point(0, -1);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(90, 29);
            this.test.TabIndex = 2;
            this.test.Text = "label1";
            // 
            // bImpromevent
            // 
            this.bImpromevent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bImpromevent.Location = new System.Drawing.Point(260, 160);
            this.bImpromevent.Name = "bImpromevent";
            this.bImpromevent.Size = new System.Drawing.Size(173, 60);
            this.bImpromevent.TabIndex = 3;
            this.bImpromevent.Text = "УЛУЧШЕНИЕ";
            this.bImpromevent.UseVisualStyleBackColor = false;
            this.bImpromevent.Click += new System.EventHandler(this.bImpromevent_Click);
            // 
            // bSettings
            // 
            this.bSettings.BackColor = System.Drawing.Color.Green;
            this.bSettings.Location = new System.Drawing.Point(260, 257);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(173, 60);
            this.bSettings.TabIndex = 4;
            this.bSettings.Text = "НАСТРОЙКИ";
            this.bSettings.UseVisualStyleBackColor = false;
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.Red;
            this.pBox.Image = global::myGame.ResourceGame.Swardan;
            this.pBox.Location = new System.Drawing.Point(96, 12);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(45, 45);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::myGame.ResourceGame.exitButton;
            this.pictureBox1.Location = new System.Drawing.Point(630, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(670, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.bImpromevent);
            this.Controls.Add(this.test);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.bStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer tStart;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Button bImpromevent;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

