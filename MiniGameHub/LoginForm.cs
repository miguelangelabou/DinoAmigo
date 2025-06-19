using System;
using System.Windows.Forms;

namespace MiniGameHub
{
    public partial class LoginForm : Form
    {
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblFeedback;
        private LinkLabel linkLblRegister;

        // Placeholder for GameSelectionForm - assume it exists for now
        // Form gameSelectionForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.linkLblRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            //
            // txtUsername
            //
            this.txtUsername.Location = new System.Drawing.Point(120, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.TabIndex = 1;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            //
            // txtPassword
            //
            this.txtPassword.Location = new System.Drawing.Point(120, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 2;
            //
            // btnLogin
            //
            this.btnLogin.Location = new System.Drawing.Point(120, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            //
            // lblFeedback
            //
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(30, 150); // Adjusted position
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 16);
            this.lblFeedback.TabIndex = 4;
            this.lblFeedback.ForeColor = System.Drawing.Color.Red; // Default to red for errors
            //
            // linkLblRegister
            //
            this.linkLblRegister.AutoSize = true;
            this.linkLblRegister.Location = new System.Drawing.Point(117, 180); // Adjusted position
            this.linkLblRegister.Name = "linkLblRegister";
            this.linkLblRegister.Size = new System.Drawing.Size(180, 16);
            this.linkLblRegister.TabIndex = 5;
            this.linkLblRegister.TabStop = true;
            this.linkLblRegister.Text = "Don't have an account? Register";
            this.linkLblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblRegister_LinkClicked);
            //
            // LoginForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 223); // Adjusted size
            this.Controls.Add(this.linkLblRegister);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblFeedback.Text = "Username and password cannot be empty.";
                return;
            }

            try
            {
                string hashedPassword = DatabaseHelper.HashPassword(password);
                bool success = DatabaseHelper.VerifyUser(username, hashedPassword);

                if (success)
                {
                    lblFeedback.Text = "Login successful!";
                    lblFeedback.ForeColor = System.Drawing.Color.Green;

                    // Hide this form and show the GameSelectionForm
                    this.Hide();
                    // Assuming GameSelectionForm exists. If not, this will cause a compile error later.
                    GameSelectionForm gameSelectionForm = new GameSelectionForm();
                    gameSelectionForm.ShowDialog(); // Show as dialog to keep focus
                    this.Close(); // Close login form after game selection is closed
                }
                else
                {
                    lblFeedback.Text = "Login failed. Please check your username and password.";
                    lblFeedback.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                // Log ex.ToString()
                lblFeedback.Text = "An error occurred during login.";
                lblFeedback.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void LinkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog(); // Show as dialog to keep focus until registration is done
        }
    }
}
