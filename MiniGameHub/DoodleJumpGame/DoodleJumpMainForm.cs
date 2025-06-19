using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // For Stream
using System.Reflection; // For Assembly

namespace MiniGameHub.DoodleJumpGame
{
    public partial class DoodleJumpMainForm : Form
    {
        private Image playerRightImage;
        private Image playerLeftImage;
        // Other images can be preloaded if needed, e.g., platformImage

        public DoodleJumpMainForm()
        {
            InitializeComponent();
            LoadGameResources(); // Load resources on initialization
        }

        private Image LoadEmbeddedResource(string resourceNameSuffix)
        {
            var assembly = Assembly.GetExecutingAssembly();
            // Construct the full resource name. Assumes resources are in a 'Resources' folder.
            var resourceName = $"MiniGameHub.DoodleJumpGame.Resources.{resourceNameSuffix}";
            try
            {
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception (e.g., return a default placeholder image)
                Console.WriteLine($"Error loading embedded resource '{resourceName}': {ex.Message}");
            }
            return null; // Or a placeholder image
        }

        private void LoadGameResources()
        {
            playerRightImage = LoadEmbeddedResource("dinosaurio.derecha.png");
            playerLeftImage = LoadEmbeddedResource("dinosaurio.png");
            // platformImage = LoadEmbeddedResource("Roca.png"); // If platforms are set in code later

            // Set initial player image
            if (playerLeftImage != null)
            {
                player.Image = playerLeftImage;
            }
            else
            {
                player.BackColor = Color.Red; // Fallback if image loading failed
            }
        }


        private void DoodleJumpMainForm_Load(object sender, EventArgs e)
        {
            // Any setup to do on form load, though much is in InitializeComponent or constructor
        }

        int lb_score;
        int verticalSpeed = 20; // Initial jump speed
        int gravity = 2;
        int playerSpeed = 15;
        bool isJumping = false;
        int force = 20; // jump force

        void game_over()
        {
            if (player.Bounds.IntersectsWith(Ground.Bounds) || player.Top > ClientSize.Height)
            {
                timer1.Stop();
                MessageBox.Show($"Game Over! Your score: {lb_score}. Press OK to exit.");
                this.Close(); // Close the game form
            }
        }

        void Game_logic()
        {
            // Player movement with gravity
            player.Top += verticalSpeed;
            verticalSpeed += gravity;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && "base".Equals(x.Tag?.ToString())) // Safe check for Tag
                {
                    // Check for collision from above (player landing on platform)
                    if (player.Bounds.IntersectsWith(x.Bounds) && verticalSpeed > 0 && player.Bottom < x.Bottom + player.Height / 2)
                    {
                        player.Top = x.Top - player.Height; // Land on top of platform
                        verticalSpeed = -force; // Jump
                        isJumping = true; // Redundant if using force directly

                        // Move platforms down if player is high enough
                        if (player.Top < ClientSize.Height / 2.5) // When player is in the upper part of screen
                        {
                            x.Top += force / 2; // Move platform down
                            // player.Top += force / 2; // Keep player relatively static on screen
                        }
                    }

                    // If platform goes off screen, reset its position to the top and update score
                    if (x.Top > ClientSize.Height)
                    {
                        x.Top = -x.Height; // Reset above the screen
                        x.Left = GetRandomXPosition(x.Width); // Randomize X position
                        lb_score++;
                        score.Text = "Score: " + lb_score;
                    }
                }
            }
        }

        private Random random = new Random();
        private int GetRandomXPosition(int controlWidth)
        {
            return random.Next(0, ClientSize.Width - controlWidth);
        }


        private void DoodleJumpMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (playerRightImage != null) player.Image = playerRightImage;
                    if (player.Right < ClientSize.Width)
                        player.Left += playerSpeed;
                    break;
                case Keys.Left:
                    if (playerLeftImage != null) player.Image = playerLeftImage;
                    if (player.Left > 0)
                        player.Left -= playerSpeed;
                    break;
                // Optional: Space to jump from ground if you add that feature
                // case Keys.Space:
                //    if (!isJumping && player.Bounds.IntersectsWith(Ground.Bounds)) // Example: jump from ground
                //    {
                //        verticalSpeed = -force;
                //        isJumping = true;
                //    }
                //    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game_logic();
            // player.Top += 10; // This direct downward movement is now handled by verticalSpeed and gravity
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
