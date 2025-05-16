namespace RentOpsDesktop
{
    partial class UserEquipmentDashboard
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
            pnlNavigationSideBar = new Panel();
            btnEquipmentInformation = new Button();
            btnReturnRecords = new Button();
            btnRentalTransactions = new Button();
            btnRentalDashboard = new Button();
            btnLogout = new Button();
            btnProfile = new Button();
            btnRentalRequests = new Button();
            btnEquipmentDashboard = new Button();
            dgvEquipment = new DataGridView();
            lblEquipmentDashboard = new Label();
            lblFrequentlyRented = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblEquipmentCount = new Label();
            groupBox3 = new GroupBox();
            lblDamagedEquipment = new Label();
            groupBox4 = new GroupBox();
            lblAvailableForRental = new Label();
            picLogo = new PictureBox();
            pnlNavigationSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlNavigationSideBar
            // 
            pnlNavigationSideBar.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigationSideBar.Controls.Add(picLogo);
            pnlNavigationSideBar.Controls.Add(btnEquipmentInformation);
            pnlNavigationSideBar.Controls.Add(btnReturnRecords);
            pnlNavigationSideBar.Controls.Add(btnRentalTransactions);
            pnlNavigationSideBar.Controls.Add(btnRentalDashboard);
            pnlNavigationSideBar.Controls.Add(btnLogout);
            pnlNavigationSideBar.Controls.Add(btnProfile);
            pnlNavigationSideBar.Controls.Add(btnRentalRequests);
            pnlNavigationSideBar.Controls.Add(btnEquipmentDashboard);
            pnlNavigationSideBar.Location = new Point(0, 0);
            pnlNavigationSideBar.Margin = new Padding(0);
            pnlNavigationSideBar.Name = "pnlNavigationSideBar";
            pnlNavigationSideBar.Size = new Size(227, 458);
            pnlNavigationSideBar.TabIndex = 20;
            // 
            // btnEquipmentInformation
            // 
            btnEquipmentInformation.BackColor = Color.FromArgb(187, 178, 169);
            btnEquipmentInformation.BackgroundImageLayout = ImageLayout.None;
            btnEquipmentInformation.FlatAppearance.BorderSize = 0;
            btnEquipmentInformation.FlatStyle = FlatStyle.Flat;
            btnEquipmentInformation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEquipmentInformation.ForeColor = Color.White;
            btnEquipmentInformation.Location = new Point(12, 336);
            btnEquipmentInformation.Margin = new Padding(3, 2, 3, 2);
            btnEquipmentInformation.Name = "btnEquipmentInformation";
            btnEquipmentInformation.Size = new Size(201, 38);
            btnEquipmentInformation.TabIndex = 20;
            btnEquipmentInformation.Text = "Equipment Information";
            btnEquipmentInformation.UseVisualStyleBackColor = false;
            btnEquipmentInformation.Click += btnEquipmentInformation_Click;
            // 
            // btnReturnRecords
            // 
            btnReturnRecords.BackColor = Color.FromArgb(187, 178, 169);
            btnReturnRecords.BackgroundImageLayout = ImageLayout.None;
            btnReturnRecords.FlatAppearance.BorderSize = 0;
            btnReturnRecords.FlatStyle = FlatStyle.Flat;
            btnReturnRecords.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnReturnRecords.ForeColor = Color.White;
            btnReturnRecords.Location = new Point(23, 297);
            btnReturnRecords.Margin = new Padding(3, 2, 3, 2);
            btnReturnRecords.Name = "btnReturnRecords";
            btnReturnRecords.Size = new Size(180, 38);
            btnReturnRecords.TabIndex = 19;
            btnReturnRecords.Text = "Return Records";
            btnReturnRecords.UseVisualStyleBackColor = false;
            btnReturnRecords.Click += btnReturnRecords_Click;
            // 
            // btnRentalTransactions
            // 
            btnRentalTransactions.BackColor = Color.FromArgb(187, 178, 169);
            btnRentalTransactions.BackgroundImageLayout = ImageLayout.None;
            btnRentalTransactions.FlatAppearance.BorderSize = 0;
            btnRentalTransactions.FlatStyle = FlatStyle.Flat;
            btnRentalTransactions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRentalTransactions.ForeColor = Color.White;
            btnRentalTransactions.Location = new Point(23, 252);
            btnRentalTransactions.Margin = new Padding(3, 2, 3, 2);
            btnRentalTransactions.Name = "btnRentalTransactions";
            btnRentalTransactions.Size = new Size(180, 38);
            btnRentalTransactions.TabIndex = 18;
            btnRentalTransactions.Text = "Rental Transactions";
            btnRentalTransactions.UseVisualStyleBackColor = false;
            btnRentalTransactions.Click += btnRentalTransactions_Click;
            // 
            // btnRentalDashboard
            // 
            btnRentalDashboard.BackColor = Color.FromArgb(187, 178, 169);
            btnRentalDashboard.BackgroundImageLayout = ImageLayout.None;
            btnRentalDashboard.FlatAppearance.BorderSize = 0;
            btnRentalDashboard.FlatStyle = FlatStyle.Flat;
            btnRentalDashboard.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnRentalDashboard.ForeColor = Color.White;
            btnRentalDashboard.Location = new Point(3, 151);
            btnRentalDashboard.Margin = new Padding(3, 2, 3, 2);
            btnRentalDashboard.Name = "btnRentalDashboard";
            btnRentalDashboard.Size = new Size(221, 38);
            btnRentalDashboard.TabIndex = 17;
            btnRentalDashboard.Text = "Rental Dashboard";
            btnRentalDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnRentalDashboard.UseVisualStyleBackColor = false;
            btnRentalDashboard.Click += btnRentalDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(139, 128, 116);
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(123, 398);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(82, 40);
            btnLogout.TabIndex = 16;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(139, 128, 116);
            btnProfile.BackgroundImageLayout = ImageLayout.None;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(22, 398);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(82, 40);
            btnProfile.TabIndex = 15;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnRentalRequests
            // 
            btnRentalRequests.BackColor = Color.FromArgb(187, 178, 169);
            btnRentalRequests.BackgroundImageLayout = ImageLayout.None;
            btnRentalRequests.FlatAppearance.BorderSize = 0;
            btnRentalRequests.FlatStyle = FlatStyle.Flat;
            btnRentalRequests.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRentalRequests.ForeColor = Color.White;
            btnRentalRequests.Location = new Point(23, 207);
            btnRentalRequests.Margin = new Padding(3, 2, 3, 2);
            btnRentalRequests.Name = "btnRentalRequests";
            btnRentalRequests.Size = new Size(180, 38);
            btnRentalRequests.TabIndex = 12;
            btnRentalRequests.Text = "Rental Requests";
            btnRentalRequests.UseVisualStyleBackColor = false;
            btnRentalRequests.Click += btnRentalRequests_Click;
            // 
            // btnEquipmentDashboard
            // 
            btnEquipmentDashboard.BackColor = Color.FromArgb(187, 178, 169);
            btnEquipmentDashboard.BackgroundImageLayout = ImageLayout.None;
            btnEquipmentDashboard.FlatAppearance.BorderSize = 0;
            btnEquipmentDashboard.FlatStyle = FlatStyle.Flat;
            btnEquipmentDashboard.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnEquipmentDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            btnEquipmentDashboard.Location = new Point(3, 109);
            btnEquipmentDashboard.Margin = new Padding(3, 2, 3, 2);
            btnEquipmentDashboard.Name = "btnEquipmentDashboard";
            btnEquipmentDashboard.Size = new Size(221, 38);
            btnEquipmentDashboard.TabIndex = 10;
            btnEquipmentDashboard.Text = "Equipment Dashboard";
            btnEquipmentDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnEquipmentDashboard.UseVisualStyleBackColor = false;
            btnEquipmentDashboard.Click += btnEquipmentDashboard_Click;
            // 
            // dgvEquipment
            // 
            dgvEquipment.BackgroundColor = Color.WhiteSmoke;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Location = new Point(242, 162);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersWidth = 51;
            dgvEquipment.Size = new Size(695, 276);
            dgvEquipment.TabIndex = 28;
            // 
            // lblEquipmentDashboard
            // 
            lblEquipmentDashboard.AutoSize = true;
            lblEquipmentDashboard.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblEquipmentDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            lblEquipmentDashboard.Location = new Point(242, 9);
            lblEquipmentDashboard.Name = "lblEquipmentDashboard";
            lblEquipmentDashboard.Size = new Size(341, 42);
            lblEquipmentDashboard.TabIndex = 31;
            lblEquipmentDashboard.Text = "Equipment Dashboard";
            // 
            // lblFrequentlyRented
            // 
            lblFrequentlyRented.AutoSize = true;
            lblFrequentlyRented.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrequentlyRented.Location = new Point(63, 32);
            lblFrequentlyRented.Name = "lblFrequentlyRented";
            lblFrequentlyRented.Size = new Size(20, 17);
            lblFrequentlyRented.TabIndex = 40;
            lblFrequentlyRented.Text = "10";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFrequentlyRented);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(397, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(163, 63);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Frequently Rented";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblEquipmentCount);
            groupBox2.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox2.Location = new Point(238, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(152, 63);
            groupBox2.TabIndex = 48;
            groupBox2.TabStop = false;
            groupBox2.Text = "Equipment Count";
            // 
            // lblEquipmentCount
            // 
            lblEquipmentCount.AutoSize = true;
            lblEquipmentCount.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentCount.Location = new Point(59, 32);
            lblEquipmentCount.Name = "lblEquipmentCount";
            lblEquipmentCount.Size = new Size(20, 17);
            lblEquipmentCount.TabIndex = 40;
            lblEquipmentCount.Text = "10";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblDamagedEquipment);
            groupBox3.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox3.Location = new Point(567, 77);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(185, 63);
            groupBox3.TabIndex = 49;
            groupBox3.TabStop = false;
            groupBox3.Text = "Damaged Equipment";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lblDamagedEquipment
            // 
            lblDamagedEquipment.AutoSize = true;
            lblDamagedEquipment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDamagedEquipment.Location = new Point(74, 32);
            lblDamagedEquipment.Name = "lblDamagedEquipment";
            lblDamagedEquipment.Size = new Size(20, 17);
            lblDamagedEquipment.TabIndex = 40;
            lblDamagedEquipment.Text = "10";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblAvailableForRental);
            groupBox4.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox4.Location = new Point(759, 77);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(178, 63);
            groupBox4.TabIndex = 50;
            groupBox4.TabStop = false;
            groupBox4.Text = "Available for Rental";
            // 
            // lblAvailableForRental
            // 
            lblAvailableForRental.AutoSize = true;
            lblAvailableForRental.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableForRental.Location = new Point(76, 32);
            lblAvailableForRental.Name = "lblAvailableForRental";
            lblAvailableForRental.Size = new Size(20, 17);
            lblAvailableForRental.TabIndex = 40;
            lblAvailableForRental.Text = "10";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.rentOpsLogo;
            picLogo.Location = new Point(47, 9);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(106, 90);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 51;
            picLogo.TabStop = false;
            // 
            // UserEquipmentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblEquipmentDashboard);
            Controls.Add(dgvEquipment);
            Controls.Add(pnlNavigationSideBar);
            Name = "UserEquipmentDashboard";
            Text = "UserEquipmentDashboard";
            Load += UserEquipmentDashboard_Load;
            pnlNavigationSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavigationSideBar;
        private Button btnEquipmentInformation;
        private Button btnReturnRecords;
        private Button btnRentalTransactions;
        private Button btnRentalDashboard;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnRentalRequests;
        private Button btnEquipmentDashboard;
        private DataGridView dgvEquipment;
        private Label lblEquipmentDashboard;
        private Label lblFrequentlyRented;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblEquipmentCount;
        private GroupBox groupBox3;
        private Label lblDamagedEquipment;
        private GroupBox groupBox4;
        private Label lblAvailableForRental;
        private PictureBox picLogo;
    }
}