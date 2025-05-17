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
            dgvRentalRequests = new DataGridView();
            pnlNavigationSideBar = new Panel();
            btnUpdateRentalRequest = new Button();
            btnBack = new Button();
            lblRentalDashboard = new Label();
            btnFilter = new Button();
            btnReset = new Button();
            cmbEquipmentName = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbRequestStatus = new ComboBox();
            lblRequestId = new Label();
            txtRequestID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequests).BeginInit();
            pnlNavigationSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(121, 86, 76);
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnSearch.ForeColor = Color.FromArgb(241, 240, 234);
            btnSearch.Location = new Point(808, 116);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 39);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvRentalRequests
            // 
            dgvRentalRequests.BackgroundColor = Color.WhiteSmoke;
            dgvRentalRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalRequests.Location = new Point(265, 170);
            dgvRentalRequests.Name = "dgvRentalRequests";
            dgvRentalRequests.RowHeadersWidth = 62;
            dgvRentalRequests.Size = new Size(652, 268);
            dgvRentalRequests.TabIndex = 20;
            // 
            // pnlNavigationSideBar
            // 
            pnlNavigationSideBar.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigationSideBar.Controls.Add(btnUpdateRentalRequest);
            pnlNavigationSideBar.Controls.Add(btnBack);
            pnlNavigationSideBar.Location = new Point(1, 0);
            pnlNavigationSideBar.Margin = new Padding(0);
            pnlNavigationSideBar.Name = "pnlNavigationSideBar";
            pnlNavigationSideBar.Size = new Size(235, 458);
            pnlNavigationSideBar.TabIndex = 19;
            // 
            // btnUpdateRentalRequest
            // 
            btnUpdateRentalRequest.BackColor = Color.FromArgb(187, 178, 169);
            btnUpdateRentalRequest.BackgroundImageLayout = ImageLayout.None;
            btnUpdateRentalRequest.FlatAppearance.BorderSize = 0;
            btnUpdateRentalRequest.FlatStyle = FlatStyle.Flat;
            btnUpdateRentalRequest.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnUpdateRentalRequest.ForeColor = Color.White;
            btnUpdateRentalRequest.Location = new Point(3, 80);
            btnUpdateRentalRequest.Margin = new Padding(3, 2, 3, 2);
            btnUpdateRentalRequest.Name = "btnUpdateRentalRequest";
            btnUpdateRentalRequest.Size = new Size(229, 38);
            btnUpdateRentalRequest.TabIndex = 17;
            btnUpdateRentalRequest.Text = "Update Rental Request";
            btnUpdateRentalRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateRentalRequest.UseVisualStyleBackColor = false;
            btnUpdateRentalRequest.Click += btnUpdateRentalRequest_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(31, 21);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 44);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblRentalDashboard
            // 
            lblRentalDashboard.AutoSize = true;
            lblRentalDashboard.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblRentalDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            lblRentalDashboard.Location = new Point(265, 19);
            lblRentalDashboard.Name = "lblRentalDashboard";
            lblRentalDashboard.Size = new Size(251, 42);
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
            btnFilter.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnFilter.ForeColor = Color.FromArgb(241, 240, 234);
            btnFilter.Location = new Point(808, 68);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(108, 39);
            btnFilter.TabIndex = 21;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(121, 86, 76);
            btnReset.BackgroundImageLayout = ImageLayout.None;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(241, 240, 234);
            btnReset.Location = new Point(808, 21);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(108, 39);
            btnReset.TabIndex = 22;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // cmbEquipmentName
            // 
            cmbEquipmentName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipmentName.Font = new Font("Segoe UI", 12F);
            cmbEquipmentName.FormattingEnabled = true;
            cmbEquipmentName.Location = new Point(374, 127);
            cmbEquipmentName.Margin = new Padding(3, 2, 3, 2);
            cmbEquipmentName.Name = "cmbEquipmentName";
            cmbEquipmentName.Size = new Size(142, 29);
            cmbEquipmentName.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 130);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 28;
            label1.Text = "Equipment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(542, 130);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 29;
            label2.Text = "Request Status";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // cmbRequestStatus
            // 
            cmbRequestStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRequestStatus.Font = new Font("Segoe UI", 12F);
            cmbRequestStatus.FormattingEnabled = true;
            cmbRequestStatus.Location = new Point(632, 127);
            cmbRequestStatus.Margin = new Padding(3, 2, 3, 2);
            cmbRequestStatus.Name = "cmbRequestStatus";
            cmbRequestStatus.Size = new Size(142, 29);
            cmbRequestStatus.TabIndex = 30;
            // 
            // lblRequestId
            // 
            lblRequestId.AutoSize = true;
            lblRequestId.Location = new Point(283, 80);
            lblRequestId.Name = "lblRequestId";
            lblRequestId.Size = new Size(63, 15);
            lblRequestId.TabIndex = 31;
            lblRequestId.Text = "Request ID";
            // 
            // txtRequestID
            // 
            txtRequestID.BorderStyle = BorderStyle.FixedSingle;
            txtRequestID.Location = new Point(374, 78);
            txtRequestID.Margin = new Padding(3, 2, 3, 2);
            txtRequestID.Name = "txtRequestID";
            txtRequestID.Size = new Size(142, 23);
            txtRequestID.TabIndex = 32;
            // 
            // RentalRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(txtRequestID);
            Controls.Add(lblRequestId);
            Controls.Add(cmbRequestStatus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbEquipmentName);
            Controls.Add(btnReset);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(dgvRentalRequests);
            Controls.Add(pnlNavigationSideBar);
            Controls.Add(lblRentalDashboard);
            Margin = new Padding(2);
            Name = "RentalRequests";
            Text = "RentalRequests";
            Load += RentalRequests_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequests).EndInit();
            pnlNavigationSideBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private DataGridView dgvRentalRequests;
        private Panel pnlNavigationSideBar;
        private Button btnEquipmentInformation;
        private Button btnReturnRecords;
        private Button btnRentalTransactions;
        private Button btnUpdateRentalRequest;
        private Button btnRentalRequests;
        private Button btnEquipmentDashboard;
        private Button btnBack;
        private Label lblRentalDashboard;
        private Button btnFilter;
        private Button btnReset;
        private ComboBox cmbEquipmentName;
        private Label label1;
        private Label label2;
        private ComboBox cmbRequestStatus;
        private Label lblRequestId;
        private TextBox txtRequestID;
    }
}