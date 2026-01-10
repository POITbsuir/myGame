using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invorement;

namespace myGame
{
    public partial class Game : Form
    {
       
        FileClass fileClass = new FileClass();
        public Game()
        {
            InitializeComponent();
            KeyPreview = true;
            test.Text = "Ваш текущий счет: " + Convert.ToString(fileClass.ReadFromFile());
            test.SendToBack();
            
            this.ClientSize = new Size(540, 420);
            test.BackColor = Color.Transparent;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            { 
                Close();
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            GameForm frm = new GameForm();
            frm.ShowDialog();
        }

        private void tStart_Tick(object sender, EventArgs e)
        {
            int speed = 5;
            pBox.Top += speed;
            if (pBox.Top > 480)
                pBox.Top = 0;
        }

        private void pBox_Click(object sender, EventArgs e)
        {

        }

        private void bImpromevent_Click(object sender, EventArgs e)
        {
            InvorementForm frm = new InvorementForm();
            frm.Show();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
