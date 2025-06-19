using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; // Added for potential resource loading, though might not be needed here directly

namespace MiniGameHub.FlappyBirdGame
{
    public partial class FlappyBirdMainForm : Form
    {

        int pipeSpeed = 8; // Adjusted from 20 for playability
        int gravity = 10; // Adjusted from 15
        int score = 0;

        public FlappyBirdMainForm()
        {
            InitializeComponent();
        }

        private void FlappyBirdMainForm_Load(object sender, EventArgs e)
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

            if(pipeButtom.Left < -pipeButtom.Width) // Make it relative to pipe width
            {
                pipeButtom.Left = this.ClientSize.Width + 200; // Reset off-screen to the right
                score++;
            }
            if(pipeTop.Left < -pipeTop.Width) // Make it relative to pipe width
            {
                pipeTop.Left = this.ClientSize.Width + 200; // Reset off-screen to the right
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


            if(score > 5 && score <= 10)
            {
                pipeSpeed = 12; // Increase speed gradually
            }
            else if (score > 10)
            {
                pipeSpeed = 15; // Further increase
            }
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Space)
            {
                gravity = -10; // Adjusted
            }

        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 10; // Adjusted
            }
            // Optional: Add a key to restart the game
            if (e.KeyCode == Keys.R && !gameTamer.Enabled)
            {
                RestartGame();
            }
        }

        private void endGame()
        {
            gameTamer.Stop();
            scoreText.Text += " Game Over! Press R to Restart";
        }

        private void RestartGame()
        {
            flappyBird.Top = this.ClientSize.Height / 2 - flappyBird.Height / 2; // Reset bird position
            pipeTop.Left = this.ClientSize.Width + 200;
            pipeButtom.Left = this.ClientSize.Width + 200;

            score = 0;
            pipeSpeed = 8;
            gravity = 10; // Ensure gravity is reset to downward if space was held
            scoreText.Text = "Score: 0";
            gameTamer.Start();
        }
    }
}
