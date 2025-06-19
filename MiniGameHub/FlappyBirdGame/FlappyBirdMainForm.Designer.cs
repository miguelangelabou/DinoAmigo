using System.Windows.Forms; // Ensure this is present
using System.Drawing; // Ensure this is present

namespace MiniGameHub.FlappyBirdGame
{
    partial class FlappyBirdMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container(); // Added 'this.'
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBirdMainForm)); // Changed Form1 to FlappyBirdMainForm
            this.pipeTop = new System.Windows.Forms.PictureBox(); // Added 'this.' and full namespace
            this.flappyBird = new System.Windows.Forms.PictureBox(); // Added 'this.' and full namespace
            this.pipeButtom = new System.Windows.Forms.PictureBox(); // Added 'this.' and full namespace
            this.ground = new System.Windows.Forms.PictureBox(); // Added 'this.' and full namespace
            this.scoreText = new System.Windows.Forms.Label(); // Added 'this.' and full namespace
            this.gameTamer = new System.Windows.Forms.Timer(this.components); // Added 'this.'
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            //
            // pipeTop
            //
            this.pipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop.Image"))); // Type cast
            this.pipeTop.Location = new System.Drawing.Point(450, -50); // Adjusted position
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(150, 250); // Adjusted size
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            //
            // flappyBird
            //
            // Load image from embedded resource
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            // IMPORTANT: Ensure this resource name matches the path in .csproj and actual file name including spaces.
            // Filename is "pterodactilo  (2).gif" (two spaces before (2))
            var resourceName = "MiniGameHub.FlappyBirdGame.Resources.pterodactilo  (2).gif";
            try {
                using (System.IO.Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        this.flappyBird.Image = Image.FromStream(stream);
                    }
                    else
                    {
                        // Fallback or error handling if resource isn't found
                        this.flappyBird.BackColor = Color.Red; // Indicate error
                        // Consider throwing an exception or logging this
                        // For now, setting text to show the resource name it tried to load.
                        // this.flappyBird.Controls.Add(new Label() { Text = resourceName, Dock = DockStyle.Fill, ForeColor = Color.White });
                    }
                }
            } catch (System.Exception ex) { /* Log ex.ToString() */ this.flappyBird.BackColor = Color.DarkRed; }

            this.flappyBird.Location = new System.Drawing.Point(50, 150); // Adjusted Start Position
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(80, 60); // Adjusted size
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Changed to Stretch for better appearance if size is constrained
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.flappyBird_Click); // Ensure event handler name matches if changed in Form.cs
            //
            // pipeButtom
            //
            this.pipeButtom.Image = ((System.Drawing.Image)(resources.GetObject("pipeButtom.Image"))); // Type cast
            this.pipeButtom.Location = new System.Drawing.Point(350, 300); // Adjusted position
            this.pipeButtom.Name = "pipeButtom";
            this.pipeButtom.Size = new System.Drawing.Size(150, 250); // Adjusted size
            this.pipeButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeButtom.TabIndex = 2;
            this.pipeButtom.TabStop = false;
            //
            // ground
            //
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image"))); // Type cast
            this.ground.Location = new System.Drawing.Point(0, 450); // Adjusted position
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(600, 100); // Adjusted size
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            //
            // scoreText
            //
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Smaller font
            this.scoreText.Location = new System.Drawing.Point(10, 10); // Top-left corner
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(148, 40); // Adjusted
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click); // Ensure event handler name matches
            //
            // gameTamer
            //
            this.gameTamer.Enabled = true;
            this.gameTamer.Interval = 100; // Added Interval, default is 100ms. Adjust for game speed.
            this.gameTamer.Tick += new System.EventHandler(this.gameTamerEvent); // Ensure event handler name matches
            //
            // FlappyBirdMainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Adjusted for common settings
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua; // Changed from Cyan for common name
            this.ClientSize = new System.Drawing.Size(582, 553); // Standard default size
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeButtom);
            this.Controls.Add(this.pipeTop);
            this.Name = "FlappyBirdMainForm"; // Changed Form1 to FlappyBirdMainForm
            this.Text = "Flappy Bird"; // Changed from "Flappy bird"
            this.Load += new System.EventHandler(this.FlappyBirdMainForm_Load); // Ensure event handler name matches
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown); // Ensure event handler name matches
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup); // Ensure event handler name matches
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop; // Full namespace
        private System.Windows.Forms.PictureBox flappyBird; // Full namespace
        private System.Windows.Forms.PictureBox pipeButtom; // Full namespace
        private System.Windows.Forms.PictureBox ground; // Full namespace
        private System.Windows.Forms.Label scoreText; // Full namespace
        private System.Windows.Forms.Timer gameTamer; // Full namespace
    }
}
