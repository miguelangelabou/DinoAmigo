namespace Flappy_bird
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pipeTop = new PictureBox();
            flappyBird = new PictureBox();
            pipeButtom = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            gameTamer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeButtom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Image = (Image)resources.GetObject("pipeTop.Image");
            pipeTop.Location = new Point(511, 2);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(259, 168);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.pterodactilo___2_;
            flappyBird.Location = new Point(12, 232);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(107, 76);
            flappyBird.SizeMode = PictureBoxSizeMode.CenterImage;
            flappyBird.TabIndex = 1;
            flappyBird.TabStop = false;
            flappyBird.Click += flappyBird_Click;
            // 
            // pipeButtom
            // 
            pipeButtom.Image = (Image)resources.GetObject("pipeButtom.Image");
            pipeButtom.Location = new Point(384, 329);
            pipeButtom.Name = "pipeButtom";
            pipeButtom.Size = new Size(174, 251);
            pipeButtom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeButtom.TabIndex = 2;
            pipeButtom.TabStop = false;
            // 
            // ground
            // 
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(-6, 572);
            ground.Name = "ground";
            ground.Size = new Size(790, 81);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Transparent;
            scoreText.Font = new Font("Kristen ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(24, 589);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(193, 54);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            scoreText.Click += label1_Click;
            // 
            // gameTamer
            // 
            gameTamer.Enabled = true;
            gameTamer.Tick += gameTamerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(773, 652);
            Controls.Add(scoreText);
            Controls.Add(flappyBird);
            Controls.Add(ground);
            Controls.Add(pipeButtom);
            Controls.Add(pipeTop);
            Name = "Form1";
            Text = "Flappy bird";
            Load += Form1_Load;
            KeyDown += gamekeydown;
            KeyUp += gamekeyup;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeButtom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox flappyBird;
        private PictureBox pipeButtom;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTamer;
    }
}
