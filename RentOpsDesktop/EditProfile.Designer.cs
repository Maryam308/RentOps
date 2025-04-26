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
            btnCancel = new Button();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblProfile.ForeColor = Color.FromArgb(135, 66, 62);
            lblProfile.Location = new Point(319, 39);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(169, 42);
            lblProfile.TabIndex = 15;
            lblProfile.Text = "My Profile";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(139, 128, 116);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(773, 22);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 44);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 459);
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
            btnEquipmentInformation.Location = new Point(11, 329);
            btnEquipmentInformation.Margin = new Padding(3, 2, 3, 2);
            btnEquipmentInformation.Name = "btnEquipmentInformation";
            btnEquipmentInformation.Size = new Size(201, 38);
            btnEquipmentInformation.TabIndex = 28;
            btnEquipmentInformation.Text = "Equipment Information";
            btnEquipmentInformation.UseVisualStyleBackColor = false;
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
            btnReturnRecords.Location = new Point(20, 284);
            btnReturnRecords.Margin = new Padding(3, 2, 3, 2);
            btnReturnRecords.Name = "btnReturnRecords";
            btnReturnRecords.Size = new Size(180, 38);
            btnReturnRecords.TabIndex = 27;
            btnReturnRecords.Text = "Return Records";
            btnReturnRecords.UseVisualStyleBackColor = false;
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
            btnRentalTransactions.Location = new Point(20, 239);
            btnRentalTransactions.Margin = new Padding(3, 2, 3, 2);
            btnRentalTransactions.Name = "btnRentalTransactions";
            btnRentalTransactions.Size = new Size(180, 38);
            btnRentalTransactions.TabIndex = 26;
            btnRentalTransactions.Text = "Rental Transactions";
            btnRentalTransactions.UseVisualStyleBackColor = false;
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
            btnRentalDashboard.Location = new Point(10, 151);
            btnRentalDashboard.Margin = new Padding(3, 2, 3, 2);
            btnRentalDashboard.Name = "btnRentalDashboard";
            btnRentalDashboard.Size = new Size(221, 38);
            btnRentalDashboard.TabIndex = 25;
            btnRentalDashboard.Text = "Rental Dashboard";
            btnRentalDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnRentalDashboard.UseVisualStyleBackColor = false;
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
            btnLogout.Location = new Point(20, 406);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(181, 40);
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
            btnRentalRequests.Location = new Point(20, 194);
            btnRentalRequests.Margin = new Padding(3, 2, 3, 2);
            btnRentalRequests.Name = "btnRentalRequests";
            btnRentalRequests.Size = new Size(180, 38);
            btnRentalRequests.TabIndex = 22;
            btnRentalRequests.Text = "Rental Requests";
            btnRentalRequests.UseVisualStyleBackColor = false;
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
            btnEquipmentDashboard.Location = new Point(10, 115);
            btnEquipmentDashboard.Margin = new Padding(3, 2, 3, 2);
            btnEquipmentDashboard.Name = "btnEquipmentDashboard";
            btnEquipmentDashboard.Size = new Size(221, 38);
            btnEquipmentDashboard.TabIndex = 21;
            btnEquipmentDashboard.Text = "Equipment Dashboard";
            btnEquipmentDashboard.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.rentOpsLogo;
            picLogo.Location = new Point(57, 9);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(106, 90);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 14F);
            txtLastName.Location = new Point(547, 192);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(323, 32);
            txtLastName.TabIndex = 39;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 17.8000011F);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(317, 187);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(121, 32);
            lblLastName.TabIndex = 38;
            lblLastName.Text = "Username";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(547, 317);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 32);
            txtEmail.TabIndex = 37;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(547, 255);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(323, 32);
            txtPhone.TabIndex = 36;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 14F);
            txtFirstName.Location = new Point(547, 130);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(323, 32);
            txtFirstName.TabIndex = 35;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 17.8000011F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(317, 314);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 17.8000011F);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(317, 251);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(177, 32);
            lblPhone.TabIndex = 33;
            lblPhone.Text = "Phone Number";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 17.8000011F);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(317, 124);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(129, 32);
            lblFirstName.TabIndex = 32;
            lblFirstName.Text = "First Name";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(139, 128, 116);
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(773, 391);
            btnSaveChanges.Margin = new Padding(3, 2, 3, 2);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(155, 44);
            btnSaveChanges.TabIndex = 40;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
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
            Controls.Add(btnCancel);
            Controls.Add(lblProfile);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnCancel;
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
    }
}