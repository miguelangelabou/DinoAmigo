using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doodle_Jump
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int lb_score;

        void game_over()
        {
            if(player.Bounds.IntersectsWith(Ground.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Fin del juego!!");
            }
        }

        void Game_logic()
        {
            foreach (Control x in this.Controls) 
            {
                if (x is PictureBox && x.Tag == "base")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.Top = x.Top - player.Height;
                        if(player.Top > 200)
                        {
                            player.Top -= 100;
                        }
                    }
                    if(player.Bounds.IntersectsWith(x.Bounds) == player.Top > 200)
                    {
                        x.Top += 10;
                        if (x.Top > 500)
                        {
                            lb_score += 1;
                            score.Text = "Score: " +lb_score;
                            x.Top = 0;
                        }
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    player.Image = Properties.Resources.dinosaurio_derecha;
                    if (player.Right < 380)
                        player.Left += 10;
                    if (player.Top > 200)
                        player.Top -= 10;
                    break;
                case Keys.Left:
                    player.Image = Properties.Resources.dinosaurio;
                        if(player.Left > 0)
                        player.Left -= 10;
                        if(player.Top > 200)
                        player.Top -= 10;
                        break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game_logic();
            player.Top += 10;
            game_over();
        }
    }
}
