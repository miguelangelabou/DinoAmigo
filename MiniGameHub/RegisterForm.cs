using System;
using System.Windows.Forms;

namespace MiniGameHub
{
    public partial class RegisterForm : Form
    {
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnRegister;
        private Label lblFeedback;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
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
            this.txtPassword.TabIndex = 2; // Changed to 2 from 3 for correct tab order
            //
            // btnRegister
            //
            this.btnRegister.Location = new System.Drawing.Point(120, 110);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.TabIndex = 3; // Changed to 3 from 4
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            //
            // lblFeedback
            //
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(30, 160);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 16); // Initially empty
            this.lblFeedback.TabIndex = 5;
            //
            // RegisterForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 203); // Adjusted size
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "RegisterForm";
            this.Text = "Register New User";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblFeedback.Text = "Username and password cannot be empty.";
                lblFeedback.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // More specific validation can be added here (e.g., password complexity)

            try
            {
                string hashedPassword = DatabaseHelper.HashPassword(password);
                bool success = DatabaseHelper.RegisterUser(username, hashedPassword);

                if (success)
                {
                    lblFeedback.Text = "Registration successful!";
                    lblFeedback.ForeColor = System.Drawing.Color.Green;
                    txtUsername.Clear();
                    txtPassword.Clear();
                    // Optionally, close the form or navigate elsewhere
                    // this.Close();
                }
                else
                {
                    // Check if username is taken (this requires DatabaseHelper to distinguish errors)
                    // For now, a generic message. A more robust way would be to have RegisterUser return specific error codes/messages.
                    lblFeedback.Text = "Registration failed. Username might be taken or database error.";
                    lblFeedback.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                // Log the exception ex.ToString()
                lblFeedback.Text = "An error occurred during registration.";
                lblFeedback.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
