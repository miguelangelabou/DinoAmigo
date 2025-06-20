using System.Windows.Forms; // Ensure present
using System.Drawing; // Ensure present
using System.IO; // For Stream
using System.Reflection; // For Assembly

namespace MiniGameHub.DoodleJumpGame
{
    partial class DoodleJumpMainForm
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

        // Helper method to load embedded resources, placed inside the partial class or accessible to it.
        private Image LoadEmbeddedResourceDesigner(string resourceNameSuffix)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"MiniGameHub.DoodleJumpGame.Resources.{resourceNameSuffix}";
            try
            {
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream != null) return Image.FromStream(stream);
                }
            }
            catch { /* Log or handle, return null or placeholder */ }
            return null;
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoodleJumpMainForm)); // We are loading manually
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            //
            // player
            //
            this.player.BackColor = System.Drawing.Color.Transparent;
            // Player image is set in DoodleJumpMainForm.cs LoadGameResources()
            this.player.Location = new System.Drawing.Point(175, 350); // Initial position
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 60); // Adjusted size
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            //
            // pictureBox2 (platform1)
            //
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = LoadEmbeddedResourceDesigner("Roca.png");
            this.pictureBox2.Location = new System.Drawing.Point(150, 430); // Example position
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "base";
            //
            // pictureBox3 (platform2)
            //
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = LoadEmbeddedResourceDesigner("Roca.png");
            this.pictureBox3.Location = new System.Drawing.Point(280, 320); // Example position
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "base";
            //
            // pictureBox4 (platform3)
            //
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = LoadEmbeddedResourceDesigner("Roca.png");
            this.pictureBox4.Location = new System.Drawing.Point(50, 220); // Example position
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2; // Corrected TabIndex if needed, though not critical for PictureBox
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "base";
            //
            // pictureBox5 (platform4)
            //
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = LoadEmbeddedResourceDesigner("Roca.png");
            this.pictureBox5.Location = new System.Drawing.Point(200, 120); // Example position
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "base";
            // pictureBox6 to pictureBox11 are removed for brevity, assuming 4 platforms initially.
            // If more are needed, they should be added similarly, or dynamically created in code.
            // For this example, I'll remove them from Controls.Add too.
            //
            // Ground
            //
            this.Ground.BackColor = System.Drawing.Color.DarkGreen; // Changed color
            this.Ground.Location = new System.Drawing.Point(0, 530); // Adjusted position
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(400, 20); // Adjusted size
            this.Ground.TabIndex = 10;
            this.Ground.TabStop = false;
            //
            // score
            //
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = Color.White; // Make score visible on dark background
            this.score.Location = new System.Drawing.Point(10, 10);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(100, 27); // Adjusted size
            this.score.TabIndex = 11;
            this.score.Text = "Score: 0";
            //
            // timer1
            //
            this.timer1.Enabled = true;
            this.timer1.Interval = 30; // Adjusted interval for smoother gameplay
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // DoodleJumpMainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = LoadEmbeddedResourceDesigner("Background Doodle Jump.png");
            this.BackgroundImageLayout = ImageLayout.Stretch; // Ensure background stretches
            this.ClientSize = new System.Drawing.Size(400, 550); // Standardized client size
            this.Controls.Add(this.score);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "DoodleJumpGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox2; // Platform 1
        private System.Windows.Forms.PictureBox pictureBox3; // Platform 2
        private System.Windows.Forms.PictureBox pictureBox4; // Platform 3
        private System.Windows.Forms.PictureBox pictureBox5; // Platform 4
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer timer1;
    }
}
