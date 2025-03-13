namespace RentOpsDesktop
{
    partial class Login
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            picLogo = new PictureBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblForgotPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblLogin.ForeColor = Color.FromArgb(135, 66, 62);
            lblLogin.Location = new Point(615, 85);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(122, 52);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.rentOpsLogo;
            picLogo.Location = new Point(63, 113);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(348, 357);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(476, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(431, 47);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(476, 290);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(431, 47);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(139, 128, 116);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(580, 442);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(172, 47);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.FromArgb(139, 128, 116);
            lblForgotPassword.Location = new Point(740, 368);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(167, 28);
            lblForgotPassword.TabIndex = 7;
            lblForgotPassword.Text = "Forgot Password?";
            lblForgotPassword.Click += lblForgotPassword_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(lblForgotPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(picLogo);
            Controls.Add(lblLogin);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private PictureBox picLogo;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblForgotPassword;
    }
}