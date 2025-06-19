using System;
using System.Windows.Forms;

namespace MiniGameHub
{
    public partial class GameSelectionForm : Form
    {
        private Label lblWelcome;
        private Button btnPlayFlappyBird;
        private Button btnPlayDoodleJump;
        private Button btnLogout;

        public GameSelectionForm()
        {
            InitializeComponent();
            // You can pass the username from LoginForm and set it here if desired
            // For now, a static message.
            lblWelcome.Text = "Welcome! Choose a game to play:";
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnPlayFlappyBird = new System.Windows.Forms.Button();
            this.btnPlayDoodleJump = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblWelcome
            //
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(30, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(250, 20); // Adjusted size for longer text
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome! Choose a game to play:"; // Placeholder, set in constructor
            //
            // btnPlayFlappyBird
            //
            this.btnPlayFlappyBird.Location = new System.Drawing.Point(60, 80);
            this.btnPlayFlappyBird.Name = "btnPlayFlappyBird";
            this.btnPlayFlappyBird.Size = new System.Drawing.Size(200, 40);
            this.btnPlayFlappyBird.TabIndex = 1;
            this.btnPlayFlappyBird.Text = "Play Flappy Bird";
            this.btnPlayFlappyBird.UseVisualStyleBackColor = true;
            this.btnPlayFlappyBird.Click += new System.EventHandler(this.BtnPlayFlappyBird_Click);
            //
            // btnPlayDoodleJump
            //
            this.btnPlayDoodleJump.Location = new System.Drawing.Point(60, 140);
            this.btnPlayDoodleJump.Name = "btnPlayDoodleJump";
            this.btnPlayDoodleJump.Size = new System.Drawing.Size(200, 40);
            this.btnPlayDoodleJump.TabIndex = 2;
            this.btnPlayDoodleJump.Text = "Play Doodle Jump";
            this.btnPlayDoodleJump.UseVisualStyleBackColor = true;
            this.btnPlayDoodleJump.Click += new System.EventHandler(this.BtnPlayDoodleJump_Click);
            //
            // btnLogout
            //
            this.btnLogout.Location = new System.Drawing.Point(100, 200);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            //
            // GameSelectionForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 260); // Adjusted size
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPlayDoodleJump);
            this.Controls.Add(this.btnPlayFlappyBird);
            this.Controls.Add(this.lblWelcome);
            this.Name = "GameSelectionForm";
            this.Text = "Select a Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Center the form
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameSelectionForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnPlayFlappyBird_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Launching Flappy Bird...", "Flappy Bird", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide(); // Hide the selection form
            using (FlappyBirdGame.FlappyBirdMainForm flappyBirdForm = new FlappyBirdGame.FlappyBirdMainForm())
            {
                flappyBirdForm.ShowDialog();
            }
            this.Show(); // Show the selection form again after the game closes
        }

        private void BtnPlayDoodleJump_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Launching Doodle Jump...", "Doodle Jump", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide(); // Hide the selection form
            using (DoodleJumpGame.DoodleJumpMainForm doodleJumpForm = new DoodleJumpGame.DoodleJumpMainForm())
            {
                doodleJumpForm.ShowDialog();
            }
            this.Show(); // Show the selection form again after the game closes
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // This will close the GameSelectionForm.
            // Since LoginForm called this with ShowDialog() and then Close(),
            // closing this form will allow LoginForm to proceed to its own Close() call,
            // effectively ending the application or returning control if LoginForm wasn't the entry point.
            this.Close();
        }

        private void GameSelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This event is triggered when the form is closed.
            // If we wanted to explicitly show LoginForm again, we would do it here,
            // but that would require passing the LoginForm instance or creating a new one.
            // For now, this simply allows the application flow as designed in LoginForm.
        }
    }
}
