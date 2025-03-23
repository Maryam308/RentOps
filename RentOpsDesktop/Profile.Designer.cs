namespace RentOpsDesktop
{
    partial class Profile
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
            panel1 = new Panel();
            btnLogout = new Button();
            btnProfile = new Button();
            lblEquipmentInfo = new Label();
            lblReturnRecord = new Label();
            lblTransactions = new Label();
            lblRentalRequest = new Label();
            picLogo = new PictureBox();
            lblProfile = new Label();
            btnEditProfile = new Button();
            lblUsername = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            txtUsername = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(187, 178, 169);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(lblEquipmentInfo);
            panel1.Controls.Add(lblReturnRecord);
            panel1.Controls.Add(lblTransactions);
            panel1.Controls.Add(lblRentalRequest);
            panel1.Controls.Add(picLogo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 612);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(139, 128, 116);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(159, 541);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 47);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(139, 128, 116);
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(12, 541);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(126, 47);
            btnProfile.TabIndex = 11;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // lblEquipmentInfo
            // 
            lblEquipmentInfo.AutoSize = true;
            lblEquipmentInfo.Font = new Font("Segoe UI", 14.8000011F);
            lblEquipmentInfo.ForeColor = Color.White;
            lblEquipmentInfo.Location = new Point(12, 435);
            lblEquipmentInfo.Name = "lblEquipmentInfo";
            lblEquipmentInfo.Size = new Size(273, 35);
            lblEquipmentInfo.TabIndex = 14;
            lblEquipmentInfo.Text = "Equipment Information";
            // 
            // lblReturnRecord
            // 
            lblReturnRecord.AutoSize = true;
            lblReturnRecord.Font = new Font("Segoe UI", 14.8000011F);
            lblReturnRecord.ForeColor = Color.White;
            lblReturnRecord.Location = new Point(56, 369);
            lblReturnRecord.Name = "lblReturnRecord";
            lblReturnRecord.Size = new Size(183, 35);
            lblReturnRecord.TabIndex = 13;
            lblReturnRecord.Text = "Return Records";
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI", 14.8000011F);
            lblTransactions.ForeColor = Color.White;
            lblTransactions.Location = new Point(31, 292);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(227, 35);
            lblTransactions.TabIndex = 12;
            lblTransactions.Text = "Rental Transactions";
            // 
            // lblRentalRequest
            // 
            lblRentalRequest.AutoSize = true;
            lblRentalRequest.Font = new Font("Segoe UI", 14.8000011F);
            lblRentalRequest.ForeColor = Color.White;
            lblRentalRequest.Location = new Point(56, 232);
            lblRentalRequest.Name = "lblRentalRequest";
            lblRentalRequest.Size = new Size(189, 35);
            lblRentalRequest.TabIndex = 11;
            lblRentalRequest.Text = "Rental Requests";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.rentOpsLogo;
            picLogo.Location = new Point(31, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(196, 180);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblProfile.ForeColor = Color.FromArgb(135, 66, 62);
            lblProfile.Location = new Point(370, 45);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(210, 52);
            lblProfile.TabIndex = 2;
            lblProfile.Text = "My Profile";
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.FromArgb(139, 128, 116);
            btnEditProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(877, 45);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(172, 47);
            btnEditProfile.TabIndex = 7;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 17.8000011F);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(370, 226);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(152, 41);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 17.8000011F);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(370, 320);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(220, 41);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 17.8000011F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(370, 414);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(88, 41);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14F);
            txtUsername.Location = new Point(633, 232);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(368, 39);
            txtUsername.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(633, 325);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(368, 39);
            txtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(633, 414);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(368, 39);
            txtEmail.TabIndex = 13;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtUsername);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblUsername);
            Controls.Add(btnEditProfile);
            Controls.Add(lblProfile);
            Controls.Add(panel1);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox picLogo;
        private Label lblProfile;
        private Label lblRentalRequest;
        private Button btnEditProfile;
        private Label lblUsername;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblEquipmentInfo;
        private Label lblReturnRecord;
        private Label lblTransactions;
        private Button btnLogout;
        private Button btnProfile;
        private TextBox txtUsername;
        private TextBox txtPhone;
        private TextBox txtEmail;
    }
}