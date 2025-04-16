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
            btnEquipmentInformation = new Button();
            btnReturnRecords = new Button();
            btnRentalTransactions = new Button();
            btnRentalDashboard = new Button();
            btnLogout = new Button();
            btnRentalRequests = new Button();
            btnEquipmentDashboard = new Button();
            picLogo = new PictureBox();
            lblProfile = new Label();
            lblFirstName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            btnEditProfile = new Button();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(187, 178, 169);
            panel1.Controls.Add(btnEquipmentInformation);
            panel1.Controls.Add(btnReturnRecords);
            panel1.Controls.Add(btnRentalTransactions);
            panel1.Controls.Add(btnRentalDashboard);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnRentalRequests);
            panel1.Controls.Add(btnEquipmentDashboard);
            panel1.Controls.Add(picLogo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 979);
            panel1.TabIndex = 0;
            // 
            // btnEquipmentInformation
            // 
            btnEquipmentInformation.BackColor = Color.FromArgb(187, 178, 169);
            btnEquipmentInformation.BackgroundImageLayout = ImageLayout.None;
            btnEquipmentInformation.FlatAppearance.BorderSize = 0;
            btnEquipmentInformation.FlatStyle = FlatStyle.Flat;
            btnEquipmentInformation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEquipmentInformation.ForeColor = Color.White;
            btnEquipmentInformation.Location = new Point(20, 701);
            btnEquipmentInformation.Margin = new Padding(5);
            btnEquipmentInformation.Name = "btnEquipmentInformation";
            btnEquipmentInformation.Size = new Size(374, 82);
            btnEquipmentInformation.TabIndex = 28;
            btnEquipmentInformation.Text = "Equipment Information";
            btnEquipmentInformation.UseVisualStyleBackColor = false;
            // 
            // btnReturnRecords
            // 
            btnReturnRecords.BackColor = Color.FromArgb(187, 178, 169);
            btnReturnRecords.BackgroundImageLayout = ImageLayout.None;
            btnReturnRecords.FlatAppearance.BorderSize = 0;
            btnReturnRecords.FlatStyle = FlatStyle.Flat;
            btnReturnRecords.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnReturnRecords.ForeColor = Color.White;
            btnReturnRecords.Location = new Point(37, 605);
            btnReturnRecords.Margin = new Padding(5);
            btnReturnRecords.Name = "btnReturnRecords";
            btnReturnRecords.Size = new Size(335, 82);
            btnReturnRecords.TabIndex = 27;
            btnReturnRecords.Text = "Return Records";
            btnReturnRecords.UseVisualStyleBackColor = false;
            // 
            // btnRentalTransactions
            // 
            btnRentalTransactions.BackColor = Color.FromArgb(187, 178, 169);
            btnRentalTransactions.BackgroundImageLayout = ImageLayout.None;
            btnRentalTransactions.FlatAppearance.BorderSize = 0;
            btnRentalTransactions.FlatStyle = FlatStyle.Flat;
            btnRentalTransactions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRentalTransactions.ForeColor = Color.White;
            btnRentalTransactions.Location = new Point(37, 509);
            btnRentalTransactions.Margin = new Padding(5);
            btnRentalTransactions.Name = "btnRentalTransactions";
            btnRentalTransactions.Size = new Size(335, 82);
            btnRentalTransactions.TabIndex = 26;
            btnRentalTransactions.Text = "Rental Transactions";
            btnRentalTransactions.UseVisualStyleBackColor = false;
            // 
            // btnRentalDashboard
            // 
            btnRentalDashboard.BackColor = Color.FromArgb(187, 178, 169);
            btnRentalDashboard.BackgroundImageLayout = ImageLayout.None;
            btnRentalDashboard.FlatAppearance.BorderSize = 0;
            btnRentalDashboard.FlatStyle = FlatStyle.Flat;
            btnRentalDashboard.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnRentalDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            btnRentalDashboard.Location = new Point(18, 322);
            btnRentalDashboard.Margin = new Padding(5);
            btnRentalDashboard.Name = "btnRentalDashboard";
            btnRentalDashboard.Size = new Size(411, 82);
            btnRentalDashboard.TabIndex = 25;
            btnRentalDashboard.Text = "Rental Dashboard";
            btnRentalDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnRentalDashboard.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(139, 128, 116);
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(37, 867);
            btnLogout.Margin = new Padding(5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(337, 85);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRentalRequests
            // 
            btnRentalRequests.BackColor = Color.FromArgb(187, 178, 169);
            btnRentalRequests.BackgroundImageLayout = ImageLayout.None;
            btnRentalRequests.FlatAppearance.BorderSize = 0;
            btnRentalRequests.FlatStyle = FlatStyle.Flat;
            btnRentalRequests.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRentalRequests.ForeColor = Color.White;
            btnRentalRequests.Location = new Point(37, 413);
            btnRentalRequests.Margin = new Padding(5);
            btnRentalRequests.Name = "btnRentalRequests";
            btnRentalRequests.Size = new Size(335, 82);
            btnRentalRequests.TabIndex = 22;
            btnRentalRequests.Text = "Rental Requests";
            btnRentalRequests.UseVisualStyleBackColor = false;
            // 
            // btnEquipmentDashboard
            // 
            btnEquipmentDashboard.BackColor = Color.FromArgb(187, 178, 169);
            btnEquipmentDashboard.BackgroundImageLayout = ImageLayout.None;
            btnEquipmentDashboard.FlatAppearance.BorderSize = 0;
            btnEquipmentDashboard.FlatStyle = FlatStyle.Flat;
            btnEquipmentDashboard.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnEquipmentDashboard.ForeColor = Color.White;
            btnEquipmentDashboard.Location = new Point(20, 248);
            btnEquipmentDashboard.Margin = new Padding(5);
            btnEquipmentDashboard.Name = "btnEquipmentDashboard";
            btnEquipmentDashboard.Size = new Size(411, 82);
            btnEquipmentDashboard.TabIndex = 21;
            btnEquipmentDashboard.Text = "Equipment Dashboard";
            btnEquipmentDashboard.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.rentOpsLogo;
            picLogo.Location = new Point(106, 19);
            picLogo.Margin = new Padding(5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(197, 192);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblProfile.ForeColor = Color.FromArgb(135, 66, 62);
            lblProfile.Location = new Point(596, 88);
            lblProfile.Margin = new Padding(5, 0, 5, 0);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(328, 82);
            lblProfile.TabIndex = 2;
            lblProfile.Text = "My Profile";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 17.8000011F);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(581, 255);
            lblFirstName.Margin = new Padding(5, 0, 5, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(255, 65);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 17.8000011F);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(596, 583);
            lblPhone.Margin = new Padding(5, 0, 5, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(349, 65);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 17.8000011F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(596, 747);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(141, 65);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.FromArgb(139, 128, 116);
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(1398, 88);
            btnEditProfile.Margin = new Padding(5);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(281, 75);
            btnEditProfile.TabIndex = 29;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(1024, 753);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(596, 57);
            txtEmail.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(1024, 589);
            txtPhone.Margin = new Padding(5);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(596, 57);
            txtPhone.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14F);
            txtFirstName.Location = new Point(1024, 261);
            txtFirstName.Margin = new Padding(5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(596, 57);
            txtFirstName.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14F);
            txtLastName.Location = new Point(1024, 425);
            txtLastName.Margin = new Padding(5);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(596, 57);
            txtLastName.TabIndex = 31;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 17.8000011F);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(596, 419);
            lblLastName.Margin = new Padding(5, 0, 5, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(240, 65);
            lblLastName.TabIndex = 30;
            lblLastName.Text = "Username";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 978);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(btnEditProfile);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFirstName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblFirstName);
            Controls.Add(lblProfile);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox picLogo;
        private Label lblProfile;
        private Label lblFirstName;
        private Label lblPhone;
        private Label lblEmail;
        private Button btnEquipmentInformation;
        private Button btnReturnRecords;
        private Button btnRentalTransactions;
        private Button btnRentalDashboard;
        private Button btnLogout;
        private Button btnRentalRequests;
        private Button btnEquipmentDashboard;
        private Button btnEditProfile;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
    }
}