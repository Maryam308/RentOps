namespace RentOpsDesktop
{
    partial class RentalDashboard
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
            lblRentalDashboard = new Label();
            groupBox2 = new GroupBox();
            lblTotalIncome = new Label();
            groupBox1 = new GroupBox();
            lblAverageRentalPeriod = new Label();
            groupBox3 = new GroupBox();
            lblAvailableEquipments = new Label();
            groupBox4 = new GroupBox();
            lblTodayRentalRequest = new Label();
            groupBox5 = new GroupBox();
            lblLastMonthRentals = new Label();
            groupBox6 = new GroupBox();
            lblCurrentlyRented = new Label();
            btnRefreshStatistics = new Button();
            btnOverdueReturns = new Button();
            btnReports = new Button();
            pnlNavigationSideBar.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
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
            pnlNavigationSideBar.TabIndex = 15;
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
            // lblRentalDashboard
            // 
            lblRentalDashboard.AutoSize = true;
            lblRentalDashboard.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblRentalDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            lblRentalDashboard.Location = new Point(509, 28);
            lblRentalDashboard.Name = "lblRentalDashboard";
            lblRentalDashboard.Size = new Size(350, 52);
            lblRentalDashboard.TabIndex = 13;
            lblRentalDashboard.Text = "Rental Dashboard";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotalIncome);
            groupBox2.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox2.Location = new Point(285, 160);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(254, 111);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total Income";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblTotalIncome.Location = new Point(101, 56);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(34, 30);
            lblTotalIncome.TabIndex = 40;
            lblTotalIncome.Text = "10";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAverageRentalPeriod);
            groupBox1.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(545, 160);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(254, 111);
            groupBox1.TabIndex = 53;
            groupBox1.TabStop = false;
            groupBox1.Text = "Avarage Rental Period";
            // 
            // lblAverageRentalPeriod
            // 
            lblAverageRentalPeriod.AutoSize = true;
            lblAverageRentalPeriod.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblAverageRentalPeriod.Location = new Point(101, 56);
            lblAverageRentalPeriod.Name = "lblAverageRentalPeriod";
            lblAverageRentalPeriod.Size = new Size(34, 30);
            lblAverageRentalPeriod.TabIndex = 40;
            lblAverageRentalPeriod.Text = "10";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblAvailableEquipments);
            groupBox3.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox3.Location = new Point(806, 160);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(254, 111);
            groupBox3.TabIndex = 54;
            groupBox3.TabStop = false;
            groupBox3.Text = "Available Equipments";
            // 
            // lblAvailableEquipments
            // 
            lblAvailableEquipments.AutoSize = true;
            lblAvailableEquipments.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblAvailableEquipments.Location = new Point(101, 56);
            lblAvailableEquipments.Name = "lblAvailableEquipments";
            lblAvailableEquipments.Size = new Size(34, 30);
            lblAvailableEquipments.TabIndex = 40;
            lblAvailableEquipments.Text = "10";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblTodayRentalRequest);
            groupBox4.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox4.Location = new Point(806, 307);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(254, 111);
            groupBox4.TabIndex = 57;
            groupBox4.TabStop = false;
            groupBox4.Text = "Today's Rental Requests";
            // 
            // lblTodayRentalRequest
            // 
            lblTodayRentalRequest.AutoSize = true;
            lblTodayRentalRequest.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblTodayRentalRequest.Location = new Point(101, 56);
            lblTodayRentalRequest.Name = "lblTodayRentalRequest";
            lblTodayRentalRequest.Size = new Size(34, 30);
            lblTodayRentalRequest.TabIndex = 40;
            lblTodayRentalRequest.Text = "10";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblLastMonthRentals);
            groupBox5.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox5.Location = new Point(545, 307);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(254, 111);
            groupBox5.TabIndex = 56;
            groupBox5.TabStop = false;
            groupBox5.Text = "Last Month's Rentals";
            // 
            // lblLastMonthRentals
            // 
            lblLastMonthRentals.AutoSize = true;
            lblLastMonthRentals.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblLastMonthRentals.Location = new Point(101, 56);
            lblLastMonthRentals.Name = "lblLastMonthRentals";
            lblLastMonthRentals.Size = new Size(34, 30);
            lblLastMonthRentals.TabIndex = 40;
            lblLastMonthRentals.Text = "10";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblCurrentlyRented);
            groupBox6.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold | FontStyle.Italic);
            groupBox6.Location = new Point(285, 307);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(254, 111);
            groupBox6.TabIndex = 55;
            groupBox6.TabStop = false;
            groupBox6.Text = "Currently Rented";
            // 
            // lblCurrentlyRented
            // 
            lblCurrentlyRented.AutoSize = true;
            lblCurrentlyRented.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            lblCurrentlyRented.Location = new Point(101, 56);
            lblCurrentlyRented.Name = "lblCurrentlyRented";
            lblCurrentlyRented.Size = new Size(34, 30);
            lblCurrentlyRented.TabIndex = 40;
            lblCurrentlyRented.Text = "10";
            // 
            // btnRefreshStatistics
            // 
            btnRefreshStatistics.BackColor = Color.FromArgb(121, 86, 76);
            btnRefreshStatistics.BackgroundImageLayout = ImageLayout.None;
            btnRefreshStatistics.FlatAppearance.BorderSize = 0;
            btnRefreshStatistics.FlatStyle = FlatStyle.Flat;
            btnRefreshStatistics.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshStatistics.ForeColor = Color.FromArgb(241, 240, 234);
            btnRefreshStatistics.Location = new Point(385, 479);
            btnRefreshStatistics.Margin = new Padding(0);
            btnRefreshStatistics.Name = "btnRefreshStatistics";
            btnRefreshStatistics.Size = new Size(255, 52);
            btnRefreshStatistics.TabIndex = 58;
            btnRefreshStatistics.Text = "Refresh Statistics";
            btnRefreshStatistics.UseVisualStyleBackColor = false;
            btnRefreshStatistics.Click += btnRefreshStatistics_Click;
            // 
            // btnOverdueReturns
            // 
            btnOverdueReturns.BackColor = Color.FromArgb(121, 86, 76);
            btnOverdueReturns.BackgroundImageLayout = ImageLayout.None;
            btnOverdueReturns.FlatAppearance.BorderSize = 0;
            btnOverdueReturns.FlatStyle = FlatStyle.Flat;
            btnOverdueReturns.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOverdueReturns.ForeColor = Color.FromArgb(241, 240, 234);
            btnOverdueReturns.Location = new Point(681, 479);
            btnOverdueReturns.Margin = new Padding(0);
            btnOverdueReturns.Name = "btnOverdueReturns";
            btnOverdueReturns.Size = new Size(255, 52);
            btnOverdueReturns.TabIndex = 59;
            btnOverdueReturns.Text = "Overdue Returns";
            btnOverdueReturns.UseVisualStyleBackColor = false;
            btnOverdueReturns.Click += btnOverdueReturns_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(121, 86, 76);
            btnReports.BackgroundImageLayout = ImageLayout.None;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.FromArgb(241, 240, 234);
            btnReports.Location = new Point(681, 532);
            btnReports.Margin = new Padding(0);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(255, 52);
            btnReports.TabIndex = 60;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // RentalDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(btnReports);
            Controls.Add(btnOverdueReturns);
            Controls.Add(btnRefreshStatistics);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox6);
            Controls.Add(pnlNavigationSideBar);
            Controls.Add(groupBox2);
            Controls.Add(lblRentalDashboard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RentalDashboard";
            Text = "RentalDashboard";
            Load += RentalDashboard_Load;
            pnlNavigationSideBar.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlNavigationSideBar;
        private Button btnBack;
        private Label lblRentalDashboard;
        private Button btnRentalDashboard;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnEquipmentInformation;
        private Button btnReturnRecords;
        private Button btnRentalTransactions;
        private Button btnRentalRequests;
        private Button btnEquipmentDashboard;
        private GroupBox groupBox2;
        private Label lblTotalIncome;
        private GroupBox groupBox1;
        private Label lblAverageRentalPeriod;
        private GroupBox groupBox3;
        private Label lblAvailableEquipments;
        private GroupBox groupBox4;
        private Label lblTodayRentalRequest;
        private GroupBox groupBox5;
        private Label lblLastMonthRentals;
        private GroupBox groupBox6;
        private Label lblCurrentlyRented;
        private Button btnRefreshStatistics;
        private Button btnOverdueReturns;
        private Button btnReports;
    }
}