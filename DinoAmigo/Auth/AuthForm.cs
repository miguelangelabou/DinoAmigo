using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsTimer = System.Windows.Forms.Timer;
using DinoAmigoApp.MiniGames;
using DinoAmigoApp.Utils.Database.DatabaseHelper;

namespace DinoAmigoApp.Auth
{
    public partial class AuthForm : Form
    {
        // --- Paneles Principales ---
        private Panel loginPanel;
        private Panel registerPanel;

        // --- Controles de Login ---
        private Label lblLoginTitle;
        private TextBox txtLoginEmail;
        private TextBox txtLoginPassword;
        private Button btnLogin;
        private LinkLabel linkGoToRegister;
        private Label lblLoginFeedback;

        // --- Controles de Registro ---
        private Label lblRegisterTitle;
        private TextBox txtRegisterUsername;
        private TextBox txtRegisterEmail;
        private TextBox txtRegisterPassword;
        private Button btnRegister;
        private LinkLabel linkGoToLogin;
        private Label lblRegisterFeedback;

        // --- Paleta de Colores Temática ---
        private readonly Color backColor = Color.FromArgb(38, 70, 83);
        private readonly Color panelColor = Color.FromArgb(42, 157, 143);
        private readonly Color textColor = Color.FromArgb(233, 196, 106);
        private readonly Color accentColor = Color.FromArgb(231, 111, 81);
        private readonly Color accentHoverColor = Color.FromArgb(244, 162, 97);
        private readonly Color inputBackColor = Color.FromArgb(43, 85, 98);
        private readonly Color placeholderColor = Color.LightGray;


        public AuthForm()
        {
            InitializeComponent();
            ApplyDinosaurTheme();
            InitializePlaceholders();
        }

        private void InitializeComponent()
        {
            loginPanel = new Panel();
            lblLoginTitle = new Label();
            txtLoginEmail = new TextBox();
            txtLoginPassword = new TextBox();
            btnLogin = new Button();
            linkGoToRegister = new LinkLabel();
            lblLoginFeedback = new Label();
            registerPanel = new Panel();
            lblRegisterTitle = new Label();
            txtRegisterUsername = new TextBox();
            txtRegisterEmail = new TextBox();
            txtRegisterPassword = new TextBox();
            btnRegister = new Button();
            linkGoToLogin = new LinkLabel();
            lblRegisterFeedback = new Label();
            loginPanel.SuspendLayout();
            registerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(lblLoginTitle);
            loginPanel.Controls.Add(txtLoginEmail);
            loginPanel.Controls.Add(txtLoginPassword);
            loginPanel.Controls.Add(btnLogin);
            loginPanel.Controls.Add(linkGoToRegister);
            loginPanel.Controls.Add(lblLoginFeedback);
            loginPanel.Location = new Point(225, 100);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(350, 400);
            loginPanel.TabIndex = 0;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLoginTitle.Location = new Point(68, 20);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(233, 46);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Iniciar Sesión";
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Location = new Point(50, 100);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.PlaceholderText = "Email";
            txtLoginEmail.Size = new Size(250, 27);
            txtLoginEmail.TabIndex = 1;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(50, 160);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PlaceholderText = "Contraseña";
            txtLoginPassword.Size = new Size(250, 27);
            txtLoginPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(75, 230);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 50);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Entrar";
            btnLogin.Click += BtnLogin_Click;
            // 
            // linkGoToRegister
            // 
            linkGoToRegister.AutoSize = true;
            linkGoToRegister.Cursor = Cursors.Hand;
            linkGoToRegister.Location = new Point(75, 290);
            linkGoToRegister.Name = "linkGoToRegister";
            linkGoToRegister.Size = new Size(205, 20);
            linkGoToRegister.TabIndex = 4;
            linkGoToRegister.TabStop = true;
            linkGoToRegister.Text = "¿No tienes cuenta? Regístrate";
            linkGoToRegister.LinkClicked += LinkGoToRegister_LinkClicked;
            // 
            // lblLoginFeedback
            // 
            lblLoginFeedback.Location = new Point(75, 170);
            lblLoginFeedback.Name = "lblLoginFeedback";
            lblLoginFeedback.Size = new Size(250, 40);
            lblLoginFeedback.TabIndex = 5;
            lblLoginFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerPanel
            // 
            registerPanel.Controls.Add(lblRegisterTitle);
            registerPanel.Controls.Add(txtRegisterUsername);
            registerPanel.Controls.Add(txtRegisterEmail);
            registerPanel.Controls.Add(txtRegisterPassword);
            registerPanel.Controls.Add(btnRegister);
            registerPanel.Controls.Add(linkGoToLogin);
            registerPanel.Controls.Add(lblRegisterFeedback);
            registerPanel.Location = new Point(225, 100);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(350, 400);
            registerPanel.TabIndex = 1;
            registerPanel.Visible = false;
            // 
            // lblRegisterTitle
            // 
            lblRegisterTitle.AutoSize = true;
            lblRegisterTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblRegisterTitle.Location = new Point(83, 20);
            lblRegisterTitle.Name = "lblRegisterTitle";
            lblRegisterTitle.Size = new Size(181, 46);
            lblRegisterTitle.TabIndex = 0;
            lblRegisterTitle.Text = "Regístrate";
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(50, 100);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(250, 27);
            txtRegisterUsername.TabIndex = 1;
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.Location = new Point(50, 150);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.Size = new Size(250, 27);
            txtRegisterEmail.TabIndex = 2;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(50, 200);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(250, 27);
            txtRegisterPassword.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(75, 260);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 50);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Crear Cuenta";
            btnRegister.Click += BtnRegister_Click;
            // 
            // linkGoToLogin
            // 
            linkGoToLogin.AutoSize = true;
            linkGoToLogin.Location = new Point(75, 320);
            linkGoToLogin.Name = "linkGoToLogin";
            linkGoToLogin.Size = new Size(215, 20);
            linkGoToLogin.TabIndex = 5;
            linkGoToLogin.TabStop = true;
            linkGoToLogin.Text = "¿Ya tienes cuenta? Inicia Sesión";
            linkGoToLogin.LinkClicked += LinkGoToLogin_LinkClicked;
            // 
            // lblRegisterFeedback
            // 
            lblRegisterFeedback.Location = new Point(85, 230);
            lblRegisterFeedback.Name = "lblRegisterFeedback";
            lblRegisterFeedback.Size = new Size(250, 40);
            lblRegisterFeedback.TabIndex = 6;
            lblRegisterFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuthForm
            // 
            AccessibleName = "";
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(882, 616);
            Controls.Add(loginPanel);
            Controls.Add(registerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DinoAmigo - Identificate";
            Load += AuthForm_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            registerPanel.ResumeLayout(false);
            registerPanel.PerformLayout();
            ResumeLayout(false);
        }

        private void ApplyDinosaurTheme()
        {
            this.BackColor = backColor;

            foreach (Control control in loginPanel.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = textColor;
                }
                if (control is TextBox)
                {
                    control.BackColor = inputBackColor;
                    control.ForeColor = textColor;
                    control.Font = new Font("Segoe UI", 12F);
                    ((TextBox)control).BorderStyle = BorderStyle.None;
                }
            }

            foreach (Control control in registerPanel.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = textColor;
                }
                if (control is TextBox)
                {
                    control.BackColor = inputBackColor;
                    control.ForeColor = textColor;
                    control.Font = new Font("Segoe UI", 12F);
                    ((TextBox)control).BorderStyle = BorderStyle.None;
                }
            }

            lblLoginTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRegisterTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            Button[] buttons = { btnLogin, btnRegister };
            foreach (var btn in buttons)
            {
                btn.BackColor = accentColor;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                btn.MouseEnter += (s, e) => btn.BackColor = accentHoverColor;
                btn.MouseLeave += (s, e) => btn.BackColor = accentColor;
            }

            LinkLabel[] links = { linkGoToRegister, linkGoToLogin };
            foreach (var link in links)
            {
                link.LinkColor = accentHoverColor;
                link.ActiveLinkColor = accentColor;
                link.VisitedLinkColor = accentHoverColor;
                link.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            }
        }

        private void InitializePlaceholders()
        {
            AddPlaceholder(txtLoginEmail, "Email");
            AddPlaceholder(txtLoginPassword, "Contraseña", true);
            AddPlaceholder(txtRegisterUsername, "Nombre de Usuario");
            AddPlaceholder(txtRegisterEmail, "Email");
            AddPlaceholder(txtRegisterPassword, "Contraseña", true);
        }

        private void AddPlaceholder(TextBox textBox, string placeholder, bool isPassword = false)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = placeholderColor;
            if (isPassword)
            {
                textBox.PasswordChar = '\0';
            }

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = textColor;
                    if (isPassword)
                    {
                        textBox.PasswordChar = '*';
                    }
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = placeholderColor;
                    if (isPassword)
                    {
                        textBox.PasswordChar = '\0';
                    }
                }
            };
        }


        private void LinkGoToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginPanel.Visible = false;
            registerPanel.Visible = true;
        }

        private void LinkGoToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerPanel.Visible = false;
            loginPanel.Visible = true;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text.Trim();
            string password = txtLoginPassword.Text.Trim();

            if (email == "Email" || password == "Contraseña" || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblLoginFeedback.ForeColor = accentColor;
                lblLoginFeedback.Text = "Email y contraseña no pueden estar vacíos.";
                return;
            }

            try
            {
                string hashedPassword = DatabaseHelper.HashPassword(password);
                bool success = await DatabaseHelper.LoginUser(email, hashedPassword);

                if (success)
                {
                    lblLoginFeedback.ForeColor = Color.LightGreen;
                    lblLoginFeedback.Text = "¡Login exitoso!";

                    this.Hide();
                    GameSelectionForm gameSelectionForm = new GameSelectionForm();
                    gameSelectionForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblLoginFeedback.ForeColor = accentColor;
                    lblLoginFeedback.Text = "Login fallido. Revisa tu email y contraseña.";
                }
            }
            catch
            {
                lblLoginFeedback.ForeColor = accentColor;
                lblLoginFeedback.Text = "Ocurrió un error durante el login.";
            }
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegisterUsername.Text.Trim();
            string email = txtRegisterEmail.Text.Trim();
            string password = txtRegisterPassword.Text.Trim();

            if (username == "Nombre de Usuario" || email == "Email" || password == "Contraseña" || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblRegisterFeedback.ForeColor = accentColor;
                lblRegisterFeedback.Text = "Todos los campos son obligatorios.";
                return;
            }

            try
            {
                string hashedPassword = DatabaseHelper.HashPassword(password);
                bool success = await DatabaseHelper.RegisterUser(username, email, hashedPassword);

                if (success)
                {
                    lblRegisterFeedback.ForeColor = Color.LightGreen;
                    lblRegisterFeedback.Text = "¡Registro exitoso! Ahora inicia sesión.";

                    WinFormsTimer timer = new WinFormsTimer { Interval = 2000 };
                    timer.Tick += (s, args) =>
                    {
                        timer.Stop();
                        LinkGoToLogin_LinkClicked(null, null);
                    };
                    timer.Start();
                }
                else
                {
                    lblRegisterFeedback.ForeColor = accentColor;
                    lblRegisterFeedback.Text = "El registro falló. El email puede ya estar en uso.";
                }
            }
            catch
            {
                lblRegisterFeedback.ForeColor = accentColor;
                lblRegisterFeedback.Text = "Ocurrió un error durante el registro.";
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
    }
}