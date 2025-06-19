using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 20;
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }

        private void gameTamerEvent(object sender, EventArgs e)
        {

            flappyBird.Top += gravity;
            pipeButtom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score " + score;

            if(pipeButtom.Left < -150)
            {
                pipeButtom.Left = 500;
                score++;
            }
            if(pipeTop.Left < -300)
            {
                pipeTop.Left = 650;
                score++;
            }

            if(flappyBird.Bounds.IntersectsWith(pipeButtom.Bounds) ||
               flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
               flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
               flappyBird.Top < -25
                )
            {
                endGame();
            }


            if(score > 5)
            {
                pipeSpeed = 15;
            };
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }

        private void endGame()
        {
            gameTamer.Stop();
            scoreText.Text += " Fin del juego!!!";
        }
    }
}
