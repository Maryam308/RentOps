namespace RentOpsDesktop
{
    partial class EditProfile
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
            lblProfile = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            btnEquipmentInformation = new Button();
            btnReturnRecords = new Button();
            btnRentalTransactions = new Button();
            btnRentalDashboard = new Button();
            btnLogout = new Button();
            btnRentalRequests = new Button();
            btnEquipmentDashboard = new Button();
            picLogo = new PictureBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtFirstName = new TextBox();
            lblEmail = new Label();
            lblPhone = new Label();
            lblFirstName = new Label();
            btnSaveChanges = new Button();
            lblFirstNameError = new Label();
            lblLastNameError = new Label();
            lblPhoneNumberError = new Label();
            lblEmailError = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblProfile.ForeColor = Color.FromArgb(135, 66, 62);
            lblProfile.Location = new Point(592, 83);
            lblProfile.Margin = new Padding(6, 0, 6, 0);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(328, 82);
            lblProfile.TabIndex = 15;
            lblProfile.Text = "My Profile";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(139, 128, 116);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1436, 47);
            btnClose.Margin = new Padding(6, 4, 6, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(288, 94);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            panel1.Margin = new Padding(6, 4, 6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 979);
            panel1.TabIndex = 25;
            // 
            // btnEquipmentInformation
            // 
            btnEquipmentInformation.BackColor = Color.FromArgb(187, 178, 169);
            btnEquipmentInformation.BackgroundImageLayout = ImageLayout.None;
            btnEquipmentInformation.Enabled = false;
            btnEquipmentInformation.FlatAppearance.BorderSize = 0;
            btnEquipmentInformation.FlatStyle = FlatStyle.Flat;
            btnEquipmentInformation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEquipmentInformation.ForeColor = Color.White;
            btnEquipmentInformation.Location = new Point(20, 702);
            btnEquipmentInformation.Margin = new Padding(6, 4, 6, 4);
            btnEquipmentInformation.Name = "btnEquipmentInformation";
            btnEquipmentInformation.Size = new Size(373, 81);
            btnEquipmentInformation.TabIndex = 28;
            btnEquipmentInformation.Text = "Equipment Information";
            btnEquipmentInformation.UseVisualStyleBackColor = false;
            btnEquipmentInformation.Click += btnEquipmentInformation_Click;
            // 
            // btnReturnRecords
            // 
            btnReturnRecords.BackColor = Color.FromArgb(187, 178, 169);
            btnReturnRecords.BackgroundImageLayout = ImageLayout.None;
            btnReturnRecords.Enabled = false;
            btnReturnRecords.FlatAppearance.BorderSize = 0;
            btnReturnRecords.FlatStyle = FlatStyle.Flat;
            btnReturnRecords.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnReturnRecords.ForeColor = Color.White;
            btnReturnRecords.Location = new Point(37, 606);
            btnReturnRecords.Margin = new Padding(6, 4, 6, 4);
            btnReturnRecords.Name = "btnReturnRecords";
            btnReturnRecords.Size = new Size(334, 81);
            btnReturnRecords.TabIndex = 27;
            btnReturnRecords.Text = "Return Records";
            btnReturnRecords.UseVisualStyleBackColor = false;
            btnReturnRecords.Click += btnReturnRecords_Click;
            // 
            // btnRentalTransactions
            // 
            btnRentalTransactions.BackColor = Color.FromArgb(187, 178, 169);
            btnRentalTransactions.BackgroundImageLayout = ImageLayout.None;
            btnRentalTransactions.Enabled = false;
            btnRentalTransactions.FlatAppearance.BorderSize = 0;
            btnRentalTransactions.FlatStyle = FlatStyle.Flat;
            btnRentalTransactions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRentalTransactions.ForeColor = Color.White;
            btnRentalTransactions.Location = new Point(37, 510);
            btnRentalTransactions.Margin = new Padding(6, 4, 6, 4);
            btnRentalTransactions.Name = "btnRentalTransactions";
            btnRentalTransactions.Size = new Size(334, 81);
            btnRentalTransactions.TabIndex = 26;
            btnRentalTransactions.Text = "Rental Transactions";
            btnRentalTransactions.UseVisualStyleBackColor = false;
            btnRentalTransactions.Click += btnRentalTransactions_Click;
            // 
            // btnRentalDashboard
            // 
            btnRentalDashboard.BackColor = Color.FromArgb(187, 178, 169);
            btnRentalDashboard.BackgroundImageLayout = ImageLayout.None;
            btnRentalDashboard.Enabled = false;
            btnRentalDashboard.FlatAppearance.BorderSize = 0;
            btnRentalDashboard.FlatStyle = FlatStyle.Flat;
            btnRentalDashboard.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnRentalDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            btnRentalDashboard.Location = new Point(19, 322);
            btnRentalDashboard.Margin = new Padding(6, 4, 6, 4);
            btnRentalDashboard.Name = "btnRentalDashboard";
            btnRentalDashboard.Size = new Size(410, 81);
            btnRentalDashboard.TabIndex = 25;
            btnRentalDashboard.Text = "Rental Dashboard";
            btnRentalDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnRentalDashboard.UseVisualStyleBackColor = false;
            btnRentalDashboard.Click += btnRentalDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(139, 128, 116);
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.Enabled = false;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(37, 866);
            btnLogout.Margin = new Padding(6, 4, 6, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(336, 85);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRentalRequests
            // 
            btnRentalRequests.BackColor = Color.FromArgb(187, 178, 169);
            btnRentalRequests.BackgroundImageLayout = ImageLayout.None;
            btnRentalRequests.Enabled = false;
            btnRentalRequests.FlatAppearance.BorderSize = 0;
            btnRentalRequests.FlatStyle = FlatStyle.Flat;
            btnRentalRequests.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRentalRequests.ForeColor = Color.White;
            btnRentalRequests.Location = new Point(37, 414);
            btnRentalRequests.Margin = new Padding(6, 4, 6, 4);
            btnRentalRequests.Name = "btnRentalRequests";
            btnRentalRequests.Size = new Size(334, 81);
            btnRentalRequests.TabIndex = 22;
            btnRentalRequests.Text = "Rental Requests";
            btnRentalRequests.UseVisualStyleBackColor = false;
            btnRentalRequests.Click += btnRentalRequests_Click;
            // 
            // btnEquipmentDashboard
            // 
            btnEquipmentDashboard.BackColor = Color.FromArgb(187, 178, 169);
            btnEquipmentDashboard.BackgroundImageLayout = ImageLayout.None;
            btnEquipmentDashboard.Enabled = false;
            btnEquipmentDashboard.FlatAppearance.BorderSize = 0;
            btnEquipmentDashboard.FlatStyle = FlatStyle.Flat;
            btnEquipmentDashboard.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnEquipmentDashboard.ForeColor = Color.White;
            btnEquipmentDashboard.Location = new Point(19, 245);
            btnEquipmentDashboard.Margin = new Padding(6, 4, 6, 4);
            btnEquipmentDashboard.Name = "btnEquipmentDashboard";
            btnEquipmentDashboard.Size = new Size(410, 81);
            btnEquipmentDashboard.TabIndex = 21;
            btnEquipmentDashboard.Text = "Equipment Dashboard";
            btnEquipmentDashboard.UseVisualStyleBackColor = false;
            btnEquipmentDashboard.Click += btnEquipmentDashboard_Click;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.rentOpsLogo;
            picLogo.Location = new Point(106, 19);
            picLogo.Margin = new Padding(6, 4, 6, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(197, 192);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 14F);
            txtLastName.Location = new Point(1016, 410);
            txtLastName.Margin = new Padding(6, 4, 6, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(598, 57);
            txtLastName.TabIndex = 39;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 17.8000011F);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(589, 399);
            lblLastName.Margin = new Padding(6, 0, 6, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(250, 65);
            lblLastName.TabIndex = 38;
            lblLastName.Text = "Last Name";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(1016, 676);
            txtEmail.Margin = new Padding(6, 4, 6, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(598, 57);
            txtEmail.TabIndex = 37;
            txtEmail.TextChanged += txtEmailError_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(1016, 544);
            txtPhone.Margin = new Padding(6, 4, 6, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(598, 57);
            txtPhone.TabIndex = 36;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 14F);
            txtFirstName.Location = new Point(1016, 277);
            txtFirstName.Margin = new Padding(6, 4, 6, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(598, 57);
            txtFirstName.TabIndex = 35;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 17.8000011F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(589, 670);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(141, 65);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 17.8000011F);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(589, 535);
            lblPhone.Margin = new Padding(6, 0, 6, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(349, 65);
            lblPhone.TabIndex = 33;
            lblPhone.Text = "Phone Number";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 17.8000011F);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(589, 265);
            lblFirstName.Margin = new Padding(6, 0, 6, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(255, 65);
            lblFirstName.TabIndex = 32;
            lblFirstName.Text = "First Name";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(139, 128, 116);
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(1436, 834);
            btnSaveChanges.Margin = new Padding(6, 4, 6, 4);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(288, 94);
            btnSaveChanges.TabIndex = 40;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstNameError.ForeColor = Color.Red;
            lblFirstNameError.Location = new Point(1016, 338);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(72, 32);
            lblFirstNameError.TabIndex = 41;
            lblFirstNameError.Text = "Error";
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastNameError.ForeColor = Color.Red;
            lblLastNameError.Location = new Point(1016, 471);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(72, 32);
            lblLastNameError.TabIndex = 42;
            lblLastNameError.Text = "Error";
            // 
            // lblPhoneNumberError
            // 
            lblPhoneNumberError.AutoSize = true;
            lblPhoneNumberError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumberError.ForeColor = Color.Red;
            lblPhoneNumberError.Location = new Point(1016, 605);
            lblPhoneNumberError.Name = "lblPhoneNumberError";
            lblPhoneNumberError.Size = new Size(72, 32);
            lblPhoneNumberError.TabIndex = 43;
            lblPhoneNumberError.Text = "Error";
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(1016, 737);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(72, 32);
            lblEmailError.TabIndex = 44;
            lblEmailError.Text = "Error";
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 977);
            Controls.Add(lblEmailError);
            Controls.Add(lblPhoneNumberError);
            Controls.Add(lblLastNameError);
            Controls.Add(lblFirstNameError);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFirstName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblFirstName);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(lblProfile);
            Margin = new Padding(6, 4, 6, 4);
            Name = "EditProfile";
            Text = "EditProfile";
            Load += EditProfile_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProfile;
        private Button btnClose;
        private Panel panel1;
        private Button btnEquipmentInformation;
        private Button btnReturnRecords;
        private Button btnRentalTransactions;
        private Button btnRentalDashboard;
        private Button btnRentalRequests;
        private Button btnEquipmentDashboard;
        private PictureBox picLogo;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtFirstName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblFirstName;
        private Button btnSaveChanges;
        private Button btnLogout;
        private Label lblFirstNameError;
        private Label lblLastNameError;
        private Label lblPhoneNumberError;
        private Label lblEmailError;
    }
}