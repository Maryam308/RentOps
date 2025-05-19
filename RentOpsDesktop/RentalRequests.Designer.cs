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
            btnSearch.Location = new Point(1501, 142);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(201, 83);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvRentalRequests
            // 
            dgvRentalRequests.BackgroundColor = Color.WhiteSmoke;
            dgvRentalRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalRequests.Location = new Point(492, 363);
            dgvRentalRequests.Margin = new Padding(6, 6, 6, 6);
            dgvRentalRequests.Name = "dgvRentalRequests";
            dgvRentalRequests.RowHeadersWidth = 62;
            dgvRentalRequests.Size = new Size(1211, 572);
            dgvRentalRequests.TabIndex = 20;
            // 
            // pnlNavigationSideBar
            // 
            pnlNavigationSideBar.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigationSideBar.Controls.Add(btnUpdateRentalRequest);
            pnlNavigationSideBar.Controls.Add(btnBack);
            pnlNavigationSideBar.Location = new Point(2, 0);
            pnlNavigationSideBar.Margin = new Padding(0);
            pnlNavigationSideBar.Name = "pnlNavigationSideBar";
            pnlNavigationSideBar.Size = new Size(436, 977);
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
            btnUpdateRentalRequest.Location = new Point(6, 171);
            btnUpdateRentalRequest.Margin = new Padding(6, 4, 6, 4);
            btnUpdateRentalRequest.Name = "btnUpdateRentalRequest";
            btnUpdateRentalRequest.Size = new Size(425, 81);
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
            btnBack.Location = new Point(58, 45);
            btnBack.Margin = new Padding(6, 4, 6, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(288, 94);
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
            lblRentalDashboard.Location = new Point(492, 41);
            lblRentalDashboard.Margin = new Padding(6, 0, 6, 0);
            lblRentalDashboard.Name = "lblRentalDashboard";
            lblRentalDashboard.Size = new Size(489, 82);
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
            btnFilter.Location = new Point(1502, 241);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(201, 83);
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
            btnReset.Location = new Point(1501, 45);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(201, 83);
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
            cmbEquipmentName.Location = new Point(695, 271);
            cmbEquipmentName.Margin = new Padding(6, 4, 6, 4);
            cmbEquipmentName.Name = "cmbEquipmentName";
            cmbEquipmentName.Size = new Size(260, 53);
            cmbEquipmentName.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(498, 277);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 28;
            label1.Text = "Equipment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1007, 277);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 32);
            label2.TabIndex = 29;
            label2.Text = "Request Status";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // cmbRequestStatus
            // 
            cmbRequestStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRequestStatus.Font = new Font("Segoe UI", 12F);
            cmbRequestStatus.FormattingEnabled = true;
            cmbRequestStatus.Location = new Point(1174, 271);
            cmbRequestStatus.Margin = new Padding(6, 4, 6, 4);
            cmbRequestStatus.Name = "cmbRequestStatus";
            cmbRequestStatus.Size = new Size(260, 53);
            cmbRequestStatus.TabIndex = 30;
            // 
            // lblRequestId
            // 
            lblRequestId.AutoSize = true;
            lblRequestId.Location = new Point(526, 171);
            lblRequestId.Margin = new Padding(6, 0, 6, 0);
            lblRequestId.Name = "lblRequestId";
            lblRequestId.Size = new Size(129, 32);
            lblRequestId.TabIndex = 31;
            lblRequestId.Text = "Request ID";
            // 
            // txtRequestID
            // 
            txtRequestID.BorderStyle = BorderStyle.FixedSingle;
            txtRequestID.Location = new Point(695, 166);
            txtRequestID.Margin = new Padding(6, 4, 6, 4);
            txtRequestID.Name = "txtRequestID";
            txtRequestID.Size = new Size(262, 39);
            txtRequestID.TabIndex = 32;
            // 
            // RentalRequests
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 977);
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
            Margin = new Padding(4, 4, 4, 4);
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