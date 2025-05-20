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
            lblEmail = new Label();
            lblPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblLogin.ForeColor = Color.FromArgb(135, 66, 62);
            lblLogin.Location = new Point(999, 137);
            lblLogin.Margin = new Padding(6, 0, 6, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(192, 82);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.rentOpsLogo;
            picLogo.Location = new Point(102, 181);
            picLogo.Margin = new Padding(6, 4, 6, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(566, 572);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(774, 314);
            txtEmail.Margin = new Padding(6, 4, 6, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(700, 71);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(774, 465);
            txtPassword.Margin = new Padding(6, 4, 6, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(700, 71);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(139, 128, 116);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(923, 638);
            btnLogin.Margin = new Padding(6, 4, 6, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(375, 94);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(784, 265);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(217, 40);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email Address: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(784, 421);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(148, 40);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 977);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(picLogo);
            Controls.Add(lblLogin);
            Margin = new Padding(6, 4, 6, 4);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
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
        private Label lblEmail;
        private Label lblPassword;
    }
}