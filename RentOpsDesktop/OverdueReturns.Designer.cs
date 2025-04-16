namespace RentOpsDesktop
{
    partial class OverdueReturns
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
            dgvReturnRecords = new DataGridView();
            lblRentalOverdue = new Label();
            btnDeleteReturnRecord = new Button();
            btnSelectRecord = new Button();
            btnEditReturnRecord = new Button();
            btnAddRecord = new Button();
            btnBack = new Button();
            pnlNavigationSideBar = new Panel();
            dtpActualReturnDate = new DateTimePicker();
            btnReset = new Button();
            txtTransactionID = new TextBox();
            txtReturnID = new TextBox();
            lblRentalTransaction = new Label();
            lblReturnID = new Label();
            label2 = new Label();
            lblReturnDateFilter = new Label();
            cmbConditionStatus = new ComboBox();
            btnFilter = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).BeginInit();
            pnlNavigationSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReturnRecords
            // 
            dgvReturnRecords.BackgroundColor = Color.WhiteSmoke;
            dgvReturnRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnRecords.Location = new Point(250, 186);
            dgvReturnRecords.Name = "dgvReturnRecords";
            dgvReturnRecords.Size = new Size(678, 251);
            dgvReturnRecords.TabIndex = 24;
            // 
            // lblRentalOverdue
            // 
            lblRentalOverdue.AutoSize = true;
            lblRentalOverdue.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblRentalOverdue.ForeColor = Color.FromArgb(135, 66, 62);
            lblRentalOverdue.Location = new Point(406, 16);
            lblRentalOverdue.Name = "lblRentalOverdue";
            lblRentalOverdue.Size = new Size(244, 42);
            lblRentalOverdue.TabIndex = 22;
            lblRentalOverdue.Text = "Rental Overdue";
            // 
            // btnDeleteReturnRecord
            // 
            btnDeleteReturnRecord.BackColor = Color.FromArgb(187, 178, 169);
            btnDeleteReturnRecord.BackgroundImageLayout = ImageLayout.None;
            btnDeleteReturnRecord.FlatAppearance.BorderSize = 0;
            btnDeleteReturnRecord.FlatStyle = FlatStyle.Flat;
            btnDeleteReturnRecord.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDeleteReturnRecord.ForeColor = Color.White;
            btnDeleteReturnRecord.Location = new Point(23, 233);
            btnDeleteReturnRecord.Margin = new Padding(3, 2, 3, 2);
            btnDeleteReturnRecord.Name = "btnDeleteReturnRecord";
            btnDeleteReturnRecord.Size = new Size(180, 38);
            btnDeleteReturnRecord.TabIndex = 18;
            btnDeleteReturnRecord.Text = "Delete Return Record";
            btnDeleteReturnRecord.UseVisualStyleBackColor = false;
            btnDeleteReturnRecord.Click += btnDeleteReturnRecord_Click;
            // 
            // btnSelectRecord
            // 
            btnSelectRecord.BackColor = Color.FromArgb(187, 178, 169);
            btnSelectRecord.BackgroundImageLayout = ImageLayout.None;
            btnSelectRecord.FlatAppearance.BorderSize = 0;
            btnSelectRecord.FlatStyle = FlatStyle.Flat;
            btnSelectRecord.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btnSelectRecord.ForeColor = Color.White;
            btnSelectRecord.Location = new Point(2, 144);
            btnSelectRecord.Margin = new Padding(3, 2, 3, 2);
            btnSelectRecord.Name = "btnSelectRecord";
            btnSelectRecord.Size = new Size(201, 38);
            btnSelectRecord.TabIndex = 17;
            btnSelectRecord.Text = "Select a record to:";
            btnSelectRecord.UseVisualStyleBackColor = false;
            // 
            // btnEditReturnRecord
            // 
            btnEditReturnRecord.BackColor = Color.FromArgb(187, 178, 169);
            btnEditReturnRecord.BackgroundImageLayout = ImageLayout.None;
            btnEditReturnRecord.FlatAppearance.BorderSize = 0;
            btnEditReturnRecord.FlatStyle = FlatStyle.Flat;
            btnEditReturnRecord.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEditReturnRecord.ForeColor = Color.White;
            btnEditReturnRecord.Location = new Point(23, 187);
            btnEditReturnRecord.Margin = new Padding(3, 2, 3, 2);
            btnEditReturnRecord.Name = "btnEditReturnRecord";
            btnEditReturnRecord.Size = new Size(180, 38);
            btnEditReturnRecord.TabIndex = 12;
            btnEditReturnRecord.Text = "Edit Return Record";
            btnEditReturnRecord.UseVisualStyleBackColor = false;
            btnEditReturnRecord.Click += btnEditReturnRecord_Click;
            // 
            // btnAddRecord
            // 
            btnAddRecord.BackColor = Color.FromArgb(187, 178, 169);
            btnAddRecord.BackgroundImageLayout = ImageLayout.None;
            btnAddRecord.FlatAppearance.BorderSize = 0;
            btnAddRecord.FlatStyle = FlatStyle.Flat;
            btnAddRecord.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnAddRecord.ForeColor = Color.White;
            btnAddRecord.Location = new Point(3, 87);
            btnAddRecord.Margin = new Padding(3, 2, 3, 2);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(221, 38);
            btnAddRecord.TabIndex = 10;
            btnAddRecord.Text = "Add New Record";
            btnAddRecord.UseVisualStyleBackColor = false;
            btnAddRecord.Click += btnAddRecord_Click;
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
            // 
            // pnlNavigationSideBar
            // 
            pnlNavigationSideBar.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigationSideBar.Controls.Add(btnDeleteReturnRecord);
            pnlNavigationSideBar.Controls.Add(btnSelectRecord);
            pnlNavigationSideBar.Controls.Add(btnEditReturnRecord);
            pnlNavigationSideBar.Controls.Add(btnAddRecord);
            pnlNavigationSideBar.Controls.Add(btnBack);
            pnlNavigationSideBar.Location = new Point(0, -1);
            pnlNavigationSideBar.Margin = new Padding(0);
            pnlNavigationSideBar.Name = "pnlNavigationSideBar";
            pnlNavigationSideBar.Size = new Size(227, 458);
            pnlNavigationSideBar.TabIndex = 21;
            // 
            // dtpActualReturnDate
            // 
            dtpActualReturnDate.Checked = false;
            dtpActualReturnDate.Location = new Point(289, 143);
            dtpActualReturnDate.Name = "dtpActualReturnDate";
            dtpActualReturnDate.ShowCheckBox = true;
            dtpActualReturnDate.Size = new Size(200, 23);
            dtpActualReturnDate.TabIndex = 51;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(121, 86, 76);
            btnReset.BackgroundImageLayout = ImageLayout.None;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(241, 240, 234);
            btnReset.Location = new Point(818, 16);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(108, 39);
            btnReset.TabIndex = 50;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtTransactionID
            // 
            txtTransactionID.BorderStyle = BorderStyle.FixedSingle;
            txtTransactionID.Location = new Point(671, 88);
            txtTransactionID.Name = "txtTransactionID";
            txtTransactionID.Size = new Size(63, 23);
            txtTransactionID.TabIndex = 49;
            // 
            // txtReturnID
            // 
            txtReturnID.BorderStyle = BorderStyle.FixedSingle;
            txtReturnID.Location = new Point(395, 88);
            txtReturnID.Name = "txtReturnID";
            txtReturnID.Size = new Size(63, 23);
            txtReturnID.TabIndex = 48;
            // 
            // lblRentalTransaction
            // 
            lblRentalTransaction.AutoSize = true;
            lblRentalTransaction.Location = new Point(544, 90);
            lblRentalTransaction.Name = "lblRentalTransaction";
            lblRentalTransaction.Size = new Size(118, 15);
            lblRentalTransaction.TabIndex = 47;
            lblRentalTransaction.Text = "Rental Transaction ID";
            // 
            // lblReturnID
            // 
            lblReturnID.AutoSize = true;
            lblReturnID.Location = new Point(295, 90);
            lblReturnID.Name = "lblReturnID";
            lblReturnID.Size = new Size(94, 15);
            lblReturnID.TabIndex = 46;
            lblReturnID.Text = "Rental Record ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(543, 124);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 45;
            label2.Text = "Filter by Condition Status";
            // 
            // lblReturnDateFilter
            // 
            lblReturnDateFilter.AutoSize = true;
            lblReturnDateFilter.Location = new Point(283, 124);
            lblReturnDateFilter.Name = "lblReturnDateFilter";
            lblReturnDateFilter.Size = new Size(114, 15);
            lblReturnDateFilter.TabIndex = 44;
            lblReturnDateFilter.Text = "Filter by Return Date";
            // 
            // cmbConditionStatus
            // 
            cmbConditionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConditionStatus.FormattingEnabled = true;
            cmbConditionStatus.Location = new Point(546, 142);
            cmbConditionStatus.Margin = new Padding(3, 2, 3, 2);
            cmbConditionStatus.Name = "cmbConditionStatus";
            cmbConditionStatus.Size = new Size(190, 23);
            cmbConditionStatus.TabIndex = 43;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(121, 86, 76);
            btnFilter.BackgroundImageLayout = ImageLayout.None;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.FromArgb(241, 240, 234);
            btnFilter.Location = new Point(818, 130);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(108, 39);
            btnFilter.TabIndex = 42;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(121, 86, 76);
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(241, 240, 234);
            btnSearch.Location = new Point(818, 75);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 39);
            btnSearch.TabIndex = 41;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // OverdueReturns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(dtpActualReturnDate);
            Controls.Add(btnReset);
            Controls.Add(txtTransactionID);
            Controls.Add(txtReturnID);
            Controls.Add(lblRentalTransaction);
            Controls.Add(lblReturnID);
            Controls.Add(label2);
            Controls.Add(lblReturnDateFilter);
            Controls.Add(cmbConditionStatus);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(dgvReturnRecords);
            Controls.Add(lblRentalOverdue);
            Controls.Add(pnlNavigationSideBar);
            Name = "OverdueReturns";
            Text = "OverdueReturns";
            Load += OverdueReturns_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).EndInit();
            pnlNavigationSideBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvReturnRecords;
        private Label lblRentalOverdue;
        private Button btnDeleteReturnRecord;
        private Button btnSelectRecord;
        private Button btnEditReturnRecord;
        private Button btnAddRecord;
        private Button btnBack;
        private Panel pnlNavigationSideBar;
        private DateTimePicker dtpActualReturnDate;
        private Button btnReset;
        private TextBox txtTransactionID;
        private TextBox txtReturnID;
        private Label lblRentalTransaction;
        private Label lblReturnID;
        private Label label2;
        private Label lblReturnDateFilter;
        private ComboBox cmbConditionStatus;
        private Button btnFilter;
        private Button btnSearch;
    }
}