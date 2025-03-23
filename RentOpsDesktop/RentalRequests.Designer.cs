namespace RentOpsDesktop
{
    partial class RentalRequests
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
            btnSearch = new Button();
            dgvUserRentals = new DataGridView();
            pnlNavigationSideBar = new Panel();
            btnUpdateRentalRequest = new Button();
            btnLogout = new Button();
            btnProfile = new Button();
            btnBack = new Button();
            lblRentalDashboard = new Label();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUserRentals).BeginInit();
            pnlNavigationSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(121, 86, 76);
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(241, 240, 234);
            btnSearch.Location = new Point(495, 132);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(319, 65);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvUserRentals
            // 
            dgvUserRentals.BackgroundColor = Color.WhiteSmoke;
            dgvUserRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserRentals.Location = new Point(379, 250);
            dgvUserRentals.Margin = new Padding(4, 5, 4, 5);
            dgvUserRentals.Name = "dgvUserRentals";
            dgvUserRentals.RowHeadersWidth = 62;
            dgvUserRentals.Size = new Size(969, 480);
            dgvUserRentals.TabIndex = 20;
            // 
            // pnlNavigationSideBar
            // 
            pnlNavigationSideBar.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigationSideBar.Controls.Add(btnUpdateRentalRequest);
            pnlNavigationSideBar.Controls.Add(btnLogout);
            pnlNavigationSideBar.Controls.Add(btnProfile);
            pnlNavigationSideBar.Controls.Add(btnBack);
            pnlNavigationSideBar.Location = new Point(1, 0);
            pnlNavigationSideBar.Margin = new Padding(0);
            pnlNavigationSideBar.Name = "pnlNavigationSideBar";
            pnlNavigationSideBar.Size = new Size(336, 763);
            pnlNavigationSideBar.TabIndex = 19;
            // 
            // btnUpdateRentalRequest
            // 
            btnUpdateRentalRequest.BackColor = Color.FromArgb(187, 178, 169);
            btnUpdateRentalRequest.BackgroundImageLayout = ImageLayout.None;
            btnUpdateRentalRequest.FlatAppearance.BorderSize = 0;
            btnUpdateRentalRequest.FlatStyle = FlatStyle.Flat;
            btnUpdateRentalRequest.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnUpdateRentalRequest.ForeColor = Color.FromArgb(135, 66, 62);
            btnUpdateRentalRequest.Location = new Point(4, 132);
            btnUpdateRentalRequest.Margin = new Padding(4, 3, 4, 3);
            btnUpdateRentalRequest.Name = "btnUpdateRentalRequest";
            btnUpdateRentalRequest.Size = new Size(316, 63);
            btnUpdateRentalRequest.TabIndex = 17;
            btnUpdateRentalRequest.Text = "Update Rental Request";
            btnUpdateRentalRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateRentalRequest.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(139, 128, 116);
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(176, 663);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 67);
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
            btnProfile.Location = new Point(31, 663);
            btnProfile.Margin = new Padding(4, 3, 4, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(117, 67);
            btnProfile.TabIndex = 15;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(44, 35);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(221, 73);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblRentalDashboard
            // 
            lblRentalDashboard.AutoSize = true;
            lblRentalDashboard.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblRentalDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            lblRentalDashboard.Location = new Point(649, 35);
            lblRentalDashboard.Margin = new Padding(4, 0, 4, 0);
            lblRentalDashboard.Name = "lblRentalDashboard";
            lblRentalDashboard.Size = new Size(369, 62);
            lblRentalDashboard.TabIndex = 17;
            lblRentalDashboard.Text = "Rental Requests";
            lblRentalDashboard.Click += lblRentalDashboard_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(121, 86, 76);
            btnFilter.BackgroundImageLayout = ImageLayout.None;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.FromArgb(241, 240, 234);
            btnFilter.Location = new Point(855, 132);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(319, 65);
            btnFilter.TabIndex = 21;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // RentalRequests
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 763);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(dgvUserRentals);
            Controls.Add(pnlNavigationSideBar);
            Controls.Add(lblRentalDashboard);
            Name = "RentalRequests";
            Text = "RentalRequests";
            ((System.ComponentModel.ISupportInitialize)dgvUserRentals).EndInit();
            pnlNavigationSideBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private DataGridView dgvUserRentals;
        private Panel pnlNavigationSideBar;
        private Button btnEquipmentInformation;
        private Button btnReturnRecords;
        private Button btnRentalTransactions;
        private Button btnUpdateRentalRequest;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnRentalRequests;
        private Button btnEquipmentDashboard;
        private Button btnBack;
        private Label lblRentalDashboard;
        private Button btnFilter;
    }
}