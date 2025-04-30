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
            btnBack = new Button();
            btnUpdateEquipment = new Button();
            btnReset = new Button();
            dgvEquipment = new DataGridView();
            lblEquipmentDashboard = new Label();
            txtReturnID = new TextBox();
            lblReturnID = new Label();
            lblFrequentlyRented = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblEquipmentCount = new Label();
            groupBox3 = new GroupBox();
            lblDamagedEquipment = new Label();
            groupBox4 = new GroupBox();
            lblAvailableForRental = new Label();
            btnSearch = new Button();
            pnlNavigationSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavigationSideBar
            // 
            pnlNavigationSideBar.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigationSideBar.Controls.Add(btnEquipmentInformation);
            pnlNavigationSideBar.Controls.Add(btnReturnRecords);
            pnlNavigationSideBar.Controls.Add(btnRentalTransactions);
            pnlNavigationSideBar.Controls.Add(btnRentalDashboard);
            pnlNavigationSideBar.Controls.Add(btnLogout);
            pnlNavigationSideBar.Controls.Add(btnProfile);
            pnlNavigationSideBar.Controls.Add(btnRentalRequests);
            pnlNavigationSideBar.Controls.Add(btnEquipmentDashboard);
            pnlNavigationSideBar.Controls.Add(btnBack);
            pnlNavigationSideBar.Location = new Point(0, 0);
            pnlNavigationSideBar.Margin = new Padding(0);
            pnlNavigationSideBar.Name = "pnlNavigationSideBar";
            pnlNavigationSideBar.Size = new Size(259, 611);
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
            btnEquipmentInformation.Location = new Point(15, 427);
            btnEquipmentInformation.Name = "btnEquipmentInformation";
            btnEquipmentInformation.Size = new Size(230, 51);
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
            btnReturnRecords.Location = new Point(26, 367);
            btnReturnRecords.Name = "btnReturnRecords";
            btnReturnRecords.Size = new Size(206, 51);
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
            btnRentalTransactions.Location = new Point(26, 307);
            btnRentalTransactions.Name = "btnRentalTransactions";
            btnRentalTransactions.Size = new Size(206, 51);
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
            btnRentalDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            btnRentalDashboard.Location = new Point(2, 172);
            btnRentalDashboard.Name = "btnRentalDashboard";
            btnRentalDashboard.Size = new Size(253, 51);
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
            btnLogout.Location = new Point(141, 531);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 53);
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
            btnProfile.Location = new Point(25, 531);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(94, 53);
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
            btnRentalRequests.Location = new Point(26, 247);
            btnRentalRequests.Name = "btnRentalRequests";
            btnRentalRequests.Size = new Size(206, 51);
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
            btnEquipmentDashboard.ForeColor = Color.White;
            btnEquipmentDashboard.Location = new Point(3, 116);
            btnEquipmentDashboard.Name = "btnEquipmentDashboard";
            btnEquipmentDashboard.Size = new Size(253, 51);
            btnEquipmentDashboard.TabIndex = 10;
            btnEquipmentDashboard.Text = "Equipment Dashboard";
            btnEquipmentDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnEquipmentDashboard.UseVisualStyleBackColor = false;
            btnEquipmentDashboard.Click += btnEquipmentDashboard_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(35, 28);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(177, 59);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnUpdateEquipment
            // 
            btnUpdateEquipment.BackColor = Color.FromArgb(121, 86, 76);
            btnUpdateEquipment.BackgroundImageLayout = ImageLayout.None;
            btnUpdateEquipment.FlatAppearance.BorderSize = 0;
            btnUpdateEquipment.FlatStyle = FlatStyle.Flat;
            btnUpdateEquipment.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateEquipment.ForeColor = Color.FromArgb(241, 240, 234);
            btnUpdateEquipment.Location = new Point(816, 219);
            btnUpdateEquipment.Margin = new Padding(0);
            btnUpdateEquipment.Name = "btnUpdateEquipment";
            btnUpdateEquipment.Size = new Size(255, 52);
            btnUpdateEquipment.TabIndex = 29;
            btnUpdateEquipment.Text = "Update Equipment";
            btnUpdateEquipment.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(121, 86, 76);
            btnReset.BackgroundImageLayout = ImageLayout.None;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(241, 240, 234);
            btnReset.Location = new Point(607, 219);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(102, 41);
            btnReset.TabIndex = 27;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // dgvEquipment
            // 
            dgvEquipment.BackgroundColor = Color.WhiteSmoke;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Location = new Point(277, 287);
            dgvEquipment.Margin = new Padding(3, 4, 3, 4);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersWidth = 51;
            dgvEquipment.Size = new Size(794, 297);
            dgvEquipment.TabIndex = 28;
            // 
            // lblEquipmentDashboard
            // 
            lblEquipmentDashboard.AutoSize = true;
            lblEquipmentDashboard.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblEquipmentDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            lblEquipmentDashboard.Location = new Point(277, 12);
            lblEquipmentDashboard.Name = "lblEquipmentDashboard";
            lblEquipmentDashboard.Size = new Size(428, 52);
            lblEquipmentDashboard.TabIndex = 31;
            lblEquipmentDashboard.Text = "Equipment Dashboard";
            // 
            // txtReturnID
            // 
            txtReturnID.BorderStyle = BorderStyle.FixedSingle;
            txtReturnID.Location = new Point(314, 225);
            txtReturnID.Margin = new Padding(3, 4, 3, 4);
            txtReturnID.Name = "txtReturnID";
            txtReturnID.Size = new Size(72, 27);
            txtReturnID.TabIndex = 38;
            // 
            // lblReturnID
            // 
            lblReturnID.AutoSize = true;
            lblReturnID.Location = new Point(295, 203);
            lblReturnID.Name = "lblReturnID";
            lblReturnID.Size = new Size(121, 20);
            lblReturnID.TabIndex = 37;
            lblReturnID.Text = "Rental Record ID";
            // 
            // lblFrequentlyRented
            // 
            lblFrequentlyRented.AutoSize = true;
            lblFrequentlyRented.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrequentlyRented.Location = new Point(72, 43);
            lblFrequentlyRented.Name = "lblFrequentlyRented";
            lblFrequentlyRented.Size = new Size(26, 23);
            lblFrequentlyRented.TabIndex = 40;
            lblFrequentlyRented.Text = "10";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFrequentlyRented);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(454, 103);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(186, 84);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Frequently Rented";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblEquipmentCount);
            groupBox2.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox2.Location = new Point(272, 103);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(174, 84);
            groupBox2.TabIndex = 48;
            groupBox2.TabStop = false;
            groupBox2.Text = "Equipment Count";
            // 
            // lblEquipmentCount
            // 
            lblEquipmentCount.AutoSize = true;
            lblEquipmentCount.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentCount.Location = new Point(67, 43);
            lblEquipmentCount.Name = "lblEquipmentCount";
            lblEquipmentCount.Size = new Size(26, 23);
            lblEquipmentCount.TabIndex = 40;
            lblEquipmentCount.Text = "10";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblDamagedEquipment);
            groupBox3.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox3.Location = new Point(648, 103);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(211, 84);
            groupBox3.TabIndex = 49;
            groupBox3.TabStop = false;
            groupBox3.Text = "Damaged Equipment";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lblDamagedEquipment
            // 
            lblDamagedEquipment.AutoSize = true;
            lblDamagedEquipment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDamagedEquipment.Location = new Point(85, 43);
            lblDamagedEquipment.Name = "lblDamagedEquipment";
            lblDamagedEquipment.Size = new Size(26, 23);
            lblDamagedEquipment.TabIndex = 40;
            lblDamagedEquipment.Text = "10";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblAvailableForRental);
            groupBox4.Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox4.Location = new Point(867, 103);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(203, 84);
            groupBox4.TabIndex = 50;
            groupBox4.TabStop = false;
            groupBox4.Text = "Available for Rental";
            // 
            // lblAvailableForRental
            // 
            lblAvailableForRental.AutoSize = true;
            lblAvailableForRental.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableForRental.Location = new Point(87, 43);
            lblAvailableForRental.Name = "lblAvailableForRental";
            lblAvailableForRental.Size = new Size(26, 23);
            lblAvailableForRental.TabIndex = 40;
            lblAvailableForRental.Text = "10";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(121, 86, 76);
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnSearch.ForeColor = Color.FromArgb(241, 240, 234);
            btnSearch.Location = new Point(487, 219);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 41);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // UserEquipmentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtReturnID);
            Controls.Add(lblReturnID);
            Controls.Add(lblEquipmentDashboard);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdateEquipment);
            Controls.Add(btnReset);
            Controls.Add(dgvEquipment);
            Controls.Add(pnlNavigationSideBar);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnBack;
        private Button btnUpdateEquipment;
        private Button btnReset;
        private DataGridView dgvEquipment;
        private Label lblEquipmentDashboard;
        private TextBox txtReturnID;
        private Label lblReturnID;
        private Label lblFrequentlyRented;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblEquipmentCount;
        private GroupBox groupBox3;
        private Label lblDamagedEquipment;
        private GroupBox groupBox4;
        private Label lblAvailableForRental;
        private Button btnSearch;
    }
}