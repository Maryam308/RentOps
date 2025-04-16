namespace RentOpsDesktop
{
    partial class ReturnRecords
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
            btnDeleteReturnRecord = new Button();
            btnSelectRecord = new Button();
            btnEditReturnRecord = new Button();
            btnAddRecord = new Button();
            btnBack = new Button();
            btnSearch = new Button();
            dgvReturnRecords = new DataGridView();
            lblReturnRecords = new Label();
            btnFilter = new Button();
            label2 = new Label();
            lblReturnDateFilter = new Label();
            cmbConditionStatus = new ComboBox();
            lblReturnID = new Label();
            lblRentalTransaction = new Label();
            txtReturnID = new TextBox();
            txtTransactionID = new TextBox();
            btnReset = new Button();
            dtpActualReturnDate = new DateTimePicker();
            pnlNavigationSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).BeginInit();
            SuspendLayout();
            // 
            // pnlNavigationSideBar
            // 
            pnlNavigationSideBar.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigationSideBar.Controls.Add(btnDeleteReturnRecord);
            pnlNavigationSideBar.Controls.Add(btnSelectRecord);
            pnlNavigationSideBar.Controls.Add(btnEditReturnRecord);
            pnlNavigationSideBar.Controls.Add(btnAddRecord);
            pnlNavigationSideBar.Controls.Add(btnBack);
            pnlNavigationSideBar.Location = new Point(0, 0);
            pnlNavigationSideBar.Margin = new Padding(0);
            pnlNavigationSideBar.Name = "pnlNavigationSideBar";
            pnlNavigationSideBar.Size = new Size(227, 458);
            pnlNavigationSideBar.TabIndex = 16;
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
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(121, 86, 76);
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(241, 240, 234);
            btnSearch.Location = new Point(807, 76);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 39);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvReturnRecords
            // 
            dgvReturnRecords.BackgroundColor = Color.WhiteSmoke;
            dgvReturnRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnRecords.Location = new Point(250, 193);
            dgvReturnRecords.Name = "dgvReturnRecords";
            dgvReturnRecords.Size = new Size(678, 251);
            dgvReturnRecords.TabIndex = 19;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblReturnRecords.ForeColor = Color.FromArgb(135, 66, 62);
            lblReturnRecords.Location = new Point(449, 17);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(237, 42);
            lblReturnRecords.TabIndex = 17;
            lblReturnRecords.Text = "Return Records";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(121, 86, 76);
            btnFilter.BackgroundImageLayout = ImageLayout.None;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.FromArgb(241, 240, 234);
            btnFilter.Location = new Point(807, 131);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(108, 39);
            btnFilter.TabIndex = 20;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 125);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 32;
            label2.Text = "Filter by Condition Status";
            // 
            // lblReturnDateFilter
            // 
            lblReturnDateFilter.AutoSize = true;
            lblReturnDateFilter.Location = new Point(272, 125);
            lblReturnDateFilter.Name = "lblReturnDateFilter";
            lblReturnDateFilter.Size = new Size(114, 15);
            lblReturnDateFilter.TabIndex = 31;
            lblReturnDateFilter.Text = "Filter by Return Date";
            // 
            // cmbConditionStatus
            // 
            cmbConditionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConditionStatus.FormattingEnabled = true;
            cmbConditionStatus.Location = new Point(535, 143);
            cmbConditionStatus.Margin = new Padding(3, 2, 3, 2);
            cmbConditionStatus.Name = "cmbConditionStatus";
            cmbConditionStatus.Size = new Size(190, 23);
            cmbConditionStatus.TabIndex = 29;
            // 
            // lblReturnID
            // 
            lblReturnID.AutoSize = true;
            lblReturnID.Location = new Point(284, 91);
            lblReturnID.Name = "lblReturnID";
            lblReturnID.Size = new Size(94, 15);
            lblReturnID.TabIndex = 34;
            lblReturnID.Text = "Rental Record ID";
            lblReturnID.Click += lblReturnID_Click;
            // 
            // lblRentalTransaction
            // 
            lblRentalTransaction.AutoSize = true;
            lblRentalTransaction.Location = new Point(533, 91);
            lblRentalTransaction.Name = "lblRentalTransaction";
            lblRentalTransaction.Size = new Size(118, 15);
            lblRentalTransaction.TabIndex = 35;
            lblRentalTransaction.Text = "Rental Transaction ID";
            // 
            // txtReturnID
            // 
            txtReturnID.BorderStyle = BorderStyle.FixedSingle;
            txtReturnID.Location = new Point(384, 89);
            txtReturnID.Name = "txtReturnID";
            txtReturnID.Size = new Size(63, 23);
            txtReturnID.TabIndex = 36;
            // 
            // txtTransactionID
            // 
            txtTransactionID.BorderStyle = BorderStyle.FixedSingle;
            txtTransactionID.Location = new Point(660, 89);
            txtTransactionID.Name = "txtTransactionID";
            txtTransactionID.Size = new Size(63, 23);
            txtTransactionID.TabIndex = 37;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(121, 86, 76);
            btnReset.BackgroundImageLayout = ImageLayout.None;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(241, 240, 234);
            btnReset.Location = new Point(807, 17);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(108, 39);
            btnReset.TabIndex = 38;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dtpActualReturnDate
            // 
            dtpActualReturnDate.Checked = false;
            dtpActualReturnDate.Location = new Point(278, 144);
            dtpActualReturnDate.Name = "dtpActualReturnDate";
            dtpActualReturnDate.ShowCheckBox = true;
            dtpActualReturnDate.Size = new Size(200, 23);
            dtpActualReturnDate.TabIndex = 39;
            // 
            // ReturnRecords
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
            Controls.Add(lblReturnRecords);
            Controls.Add(pnlNavigationSideBar);
            Name = "ReturnRecords";
            Text = "ReturnRecords";
            Load += ReturnRecords_Load;
            pnlNavigationSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel pnlNavigationSideBar;
        private Button btnDeleteReturnRecord;
        private Button btnSelectRecord;
        private Button btnEditReturnRecord;
        private Button btnAddRecord;
        private Button btnBack;
        private Button btnSearch;
        private Button btnFilter;
        private DataGridView dgvReturnRecords;
        private Label lblReturnRecords;
        private Label label2;
        private Label lblReturnDateFilter;
        private ComboBox cmbConditionStatus;
        private DateTimePicker dtpReturnDate;
        private Label lblReturnID;
        private Label lblRentalTransaction;
        private TextBox txtReturnID;
        private TextBox txtTransactionID;
        private Button btnReset;
        private DateTimePicker dtpActualReturnDate;
    }
}