namespace RentOpsDesktop
{
    partial class Landing
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
            lblTitle = new Label();
            lblSlogan = new Label();
            picLogo = new PictureBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 48.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(583, 164);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(368, 108);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "RentOps";
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI Semibold", 15.8000011F, FontStyle.Bold);
            lblSlogan.ForeColor = Color.FromArgb(135, 66, 62);
            lblSlogan.Location = new Point(546, 313);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(463, 37);
            lblSlogan.TabIndex = 1;
            lblSlogan.Text = " RentOps, the Smarter Way to Equip.";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.rentOpsLogo;
            picLogo.Location = new Point(69, 86);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(384, 408);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(139, 128, 116);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(677, 410);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(172, 47);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(btnLogin);
            Controls.Add(picLogo);
            Controls.Add(lblSlogan);
            Controls.Add(lblTitle);
            Name = "Landing";
            Text = "Landing";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSlogan;
        private PictureBox picLogo;
        private Button btnLogin;
    }
}