namespace RentOpsDesktop
{
    partial class RentalTransactions
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
            dgvRentalTransactions = new DataGridView();
            lblReturnRecords = new Label();
            pnlNavigationSideBar = new Panel();
            btnDeleteRentalTransaction = new Button();
            btnSelectRecord = new Button();
            btnEditRentalTransaction = new Button();
            btnAddnewRentalTransaction = new Button();
            btnBack = new Button();
            btnReset = new Button();
            btnFilter = new Button();
            btnSearch = new Button();
            txtRequestID = new TextBox();
            lblRequestID = new Label();
            txtTransaction = new TextBox();
            lblTransaction = new Label();
            dtpTransctionDate = new DateTimePicker();
            lblPayment = new Label();
            lblTransctionDateFilter = new Label();
            cmbPaymentStatus = new ComboBox();
            lblEquipment = new Label();
            cmbEquipment = new ComboBox();
            gbDataSource = new GroupBox();
            rbAllTransactions = new RadioButton();
            rbDesktopAppTransactions = new RadioButton();
            rbWebsiteAppTransactions = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransactions).BeginInit();
            pnlNavigationSideBar.SuspendLayout();
            gbDataSource.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRentalTransactions
            // 
            dgvRentalTransactions.BackgroundColor = Color.WhiteSmoke;
            dgvRentalTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalTransactions.Location = new Point(470, 439);
            dgvRentalTransactions.Margin = new Padding(6);
            dgvRentalTransactions.Name = "dgvRentalTransactions";
            dgvRentalTransactions.RowHeadersWidth = 62;
            dgvRentalTransactions.Size = new Size(1254, 503);
            dgvRentalTransactions.TabIndex = 24;
            dgvRentalTransactions.CellContentClick += dgvRentalTransactions_CellContentClick;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblReturnRecords.ForeColor = Color.FromArgb(135, 66, 62);
            lblReturnRecords.Location = new Point(770, 20);
            lblReturnRecords.Margin = new Padding(6, 0, 6, 0);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(600, 82);
            lblReturnRecords.TabIndex = 22;
            lblReturnRecords.Text = "Rental Transactions";
            // 
            // pnlNavigationSideBar
            // 
            pnlNavigationSideBar.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigationSideBar.Controls.Add(btnDeleteRentalTransaction);
            pnlNavigationSideBar.Controls.Add(btnSelectRecord);
            pnlNavigationSideBar.Controls.Add(btnEditRentalTransaction);
            pnlNavigationSideBar.Controls.Add(btnAddnewRentalTransaction);
            pnlNavigationSideBar.Controls.Add(btnBack);
            pnlNavigationSideBar.Location = new Point(0, 0);
            pnlNavigationSideBar.Margin = new Padding(0);
            pnlNavigationSideBar.Name = "pnlNavigationSideBar";
            pnlNavigationSideBar.Size = new Size(444, 977);
            pnlNavigationSideBar.TabIndex = 21;
            // 
            // btnDeleteRentalTransaction
            // 
            btnDeleteRentalTransaction.BackColor = Color.FromArgb(187, 178, 169);
            btnDeleteRentalTransaction.BackgroundImageLayout = ImageLayout.None;
            btnDeleteRentalTransaction.FlatAppearance.BorderSize = 0;
            btnDeleteRentalTransaction.FlatStyle = FlatStyle.Flat;
            btnDeleteRentalTransaction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDeleteRentalTransaction.ForeColor = Color.White;
            btnDeleteRentalTransaction.Location = new Point(17, 578);
            btnDeleteRentalTransaction.Margin = new Padding(6, 4, 6, 4);
            btnDeleteRentalTransaction.Name = "btnDeleteRentalTransaction";
            btnDeleteRentalTransaction.Size = new Size(412, 81);
            btnDeleteRentalTransaction.TabIndex = 18;
            btnDeleteRentalTransaction.Text = "Delete Rental Transaction";
            btnDeleteRentalTransaction.UseVisualStyleBackColor = false;
            btnDeleteRentalTransaction.Click += btnDeleteRentalTransaction_Click;
            // 
            // btnSelectRecord
            // 
            btnSelectRecord.BackColor = Color.FromArgb(187, 178, 169);
            btnSelectRecord.BackgroundImageLayout = ImageLayout.None;
            btnSelectRecord.FlatAppearance.BorderSize = 0;
            btnSelectRecord.FlatStyle = FlatStyle.Flat;
            btnSelectRecord.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btnSelectRecord.ForeColor = Color.White;
            btnSelectRecord.Location = new Point(17, 356);
            btnSelectRecord.Margin = new Padding(6, 4, 6, 4);
            btnSelectRecord.Name = "btnSelectRecord";
            btnSelectRecord.Size = new Size(373, 81);
            btnSelectRecord.TabIndex = 17;
            btnSelectRecord.Text = "Select a record to:";
            btnSelectRecord.UseVisualStyleBackColor = false;
            // 
            // btnEditRentalTransaction
            // 
            btnEditRentalTransaction.BackColor = Color.FromArgb(187, 178, 169);
            btnEditRentalTransaction.BackgroundImageLayout = ImageLayout.None;
            btnEditRentalTransaction.FlatAppearance.BorderSize = 0;
            btnEditRentalTransaction.FlatStyle = FlatStyle.Flat;
            btnEditRentalTransaction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEditRentalTransaction.ForeColor = Color.White;
            btnEditRentalTransaction.Location = new Point(32, 476);
            btnEditRentalTransaction.Margin = new Padding(6, 4, 6, 4);
            btnEditRentalTransaction.Name = "btnEditRentalTransaction";
            btnEditRentalTransaction.Size = new Size(381, 81);
            btnEditRentalTransaction.TabIndex = 12;
            btnEditRentalTransaction.Text = "Edit Rental Transaction";
            btnEditRentalTransaction.UseVisualStyleBackColor = false;
            btnEditRentalTransaction.Click += btnEditRentalTransaction_Click;
            // 
            // btnAddnewRentalTransaction
            // 
            btnAddnewRentalTransaction.BackColor = Color.FromArgb(187, 178, 169);
            btnAddnewRentalTransaction.BackgroundImageLayout = ImageLayout.None;
            btnAddnewRentalTransaction.FlatAppearance.BorderSize = 0;
            btnAddnewRentalTransaction.FlatStyle = FlatStyle.Flat;
            btnAddnewRentalTransaction.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnAddnewRentalTransaction.ForeColor = Color.White;
            btnAddnewRentalTransaction.Location = new Point(6, 186);
            btnAddnewRentalTransaction.Margin = new Padding(6, 4, 6, 4);
            btnAddnewRentalTransaction.Name = "btnAddnewRentalTransaction";
            btnAddnewRentalTransaction.Size = new Size(433, 162);
            btnAddnewRentalTransaction.TabIndex = 10;
            btnAddnewRentalTransaction.Text = "Add new Rental Transaction";
            btnAddnewRentalTransaction.UseVisualStyleBackColor = false;
            btnAddnewRentalTransaction.Click += btnAddnewRentalTransaction_Click;
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
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(121, 86, 76);
            btnReset.BackgroundImageLayout = ImageLayout.None;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(241, 240, 234);
            btnReset.Location = new Point(1523, 66);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(201, 83);
            btnReset.TabIndex = 41;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(121, 86, 76);
            btnFilter.BackgroundImageLayout = ImageLayout.None;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.FromArgb(241, 240, 234);
            btnFilter.Location = new Point(1523, 309);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(201, 83);
            btnFilter.TabIndex = 40;
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
            btnSearch.Location = new Point(1523, 192);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(201, 83);
            btnSearch.TabIndex = 39;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtRequestID
            // 
            txtRequestID.BorderStyle = BorderStyle.FixedSingle;
            txtRequestID.Location = new Point(761, 258);
            txtRequestID.Margin = new Padding(6);
            txtRequestID.Name = "txtRequestID";
            txtRequestID.Size = new Size(115, 39);
            txtRequestID.TabIndex = 43;
            // 
            // lblRequestID
            // 
            lblRequestID.AutoSize = true;
            lblRequestID.Location = new Point(468, 260);
            lblRequestID.Margin = new Padding(6, 0, 6, 0);
            lblRequestID.Name = "lblRequestID";
            lblRequestID.Size = new Size(282, 32);
            lblRequestID.TabIndex = 42;
            lblRequestID.Text = "Rental Request Record ID";
            // 
            // txtTransaction
            // 
            txtTransaction.BorderStyle = BorderStyle.FixedSingle;
            txtTransaction.Location = new Point(1369, 254);
            txtTransaction.Margin = new Padding(6);
            txtTransaction.Name = "txtTransaction";
            txtTransaction.Size = new Size(115, 39);
            txtTransaction.TabIndex = 45;
            // 
            // lblTransaction
            // 
            lblTransaction.AutoSize = true;
            lblTransaction.Location = new Point(1041, 256);
            lblTransaction.Margin = new Padding(6, 0, 6, 0);
            lblTransaction.Name = "lblTransaction";
            lblTransaction.Size = new Size(317, 32);
            lblTransaction.TabIndex = 44;
            lblTransaction.Text = "Rental Transaction Record ID";
            // 
            // dtpTransctionDate
            // 
            dtpTransctionDate.Checked = false;
            dtpTransctionDate.Location = new Point(481, 356);
            dtpTransctionDate.Margin = new Padding(6);
            dtpTransctionDate.Name = "dtpTransctionDate";
            dtpTransctionDate.ShowCheckBox = true;
            dtpTransctionDate.Size = new Size(368, 39);
            dtpTransctionDate.TabIndex = 49;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(865, 318);
            lblPayment.Margin = new Padding(6, 0, 6, 0);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(270, 32);
            lblPayment.TabIndex = 48;
            lblPayment.Text = "Filter by Payment Status";
            // 
            // lblTransctionDateFilter
            // 
            lblTransctionDateFilter.AutoSize = true;
            lblTransctionDateFilter.Location = new Point(470, 318);
            lblTransctionDateFilter.Margin = new Padding(6, 0, 6, 0);
            lblTransctionDateFilter.Name = "lblTransctionDateFilter";
            lblTransctionDateFilter.Size = new Size(284, 32);
            lblTransctionDateFilter.TabIndex = 47;
            lblTransctionDateFilter.Text = "Filter by Transaction Date";
            lblTransctionDateFilter.Click += lblReturnDateFilter_Click;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(873, 354);
            cmbPaymentStatus.Margin = new Padding(6, 4, 6, 4);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(309, 40);
            cmbPaymentStatus.TabIndex = 46;
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.Location = new Point(1187, 316);
            lblEquipment.Margin = new Padding(6, 0, 6, 0);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(223, 32);
            lblEquipment.TabIndex = 51;
            lblEquipment.Text = "Filter by Equipment";
            // 
            // cmbEquipment
            // 
            cmbEquipment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipment.FormattingEnabled = true;
            cmbEquipment.Location = new Point(1192, 352);
            cmbEquipment.Margin = new Padding(6, 4, 6, 4);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(292, 40);
            cmbEquipment.TabIndex = 50;
            // 
            // gbDataSource
            // 
            gbDataSource.Controls.Add(rbAllTransactions);
            gbDataSource.Controls.Add(rbDesktopAppTransactions);
            gbDataSource.Controls.Add(rbWebsiteAppTransactions);
            gbDataSource.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbDataSource.Location = new Point(470, 121);
            gbDataSource.Name = "gbDataSource";
            gbDataSource.Size = new Size(1014, 110);
            gbDataSource.TabIndex = 52;
            gbDataSource.TabStop = false;
            gbDataSource.Text = "Selecte The Transaction Source: ";
            // 
            // rbAllTransactions
            // 
            rbAllTransactions.AutoSize = true;
            rbAllTransactions.Font = new Font("Segoe UI", 9F);
            rbAllTransactions.Location = new Point(782, 53);
            rbAllTransactions.Name = "rbAllTransactions";
            rbAllTransactions.Size = new Size(209, 36);
            rbAllTransactions.TabIndex = 2;
            rbAllTransactions.Text = "All Transactions";
            rbAllTransactions.UseVisualStyleBackColor = true;
            rbAllTransactions.CheckedChanged += rbAllTransactions_CheckedChanged;
            // 
            // rbDesktopAppTransactions
            // 
            rbDesktopAppTransactions.AutoSize = true;
            rbDesktopAppTransactions.Font = new Font("Segoe UI", 9F);
            rbDesktopAppTransactions.Location = new Point(342, 53);
            rbDesktopAppTransactions.Name = "rbDesktopAppTransactions";
            rbDesktopAppTransactions.Size = new Size(392, 36);
            rbDesktopAppTransactions.TabIndex = 1;
            rbDesktopAppTransactions.Text = "Desktop Forms App Transactions";
            rbDesktopAppTransactions.TextAlign = ContentAlignment.TopRight;
            rbDesktopAppTransactions.UseVisualStyleBackColor = true;
            rbDesktopAppTransactions.CheckedChanged += rbDesktopAppTransactions_CheckedChanged;
            // 
            // rbWebsiteAppTransactions
            // 
            rbWebsiteAppTransactions.AutoSize = true;
            rbWebsiteAppTransactions.Checked = true;
            rbWebsiteAppTransactions.Font = new Font("Segoe UI", 9F);
            rbWebsiteAppTransactions.Location = new Point(8, 53);
            rbWebsiteAppTransactions.Name = "rbWebsiteAppTransactions";
            rbWebsiteAppTransactions.Size = new Size(305, 36);
            rbWebsiteAppTransactions.TabIndex = 0;
            rbWebsiteAppTransactions.TabStop = true;
            rbWebsiteAppTransactions.Text = "Website App Transctions";
            rbWebsiteAppTransactions.UseVisualStyleBackColor = true;
            rbWebsiteAppTransactions.CheckedChanged += rbWebsiteAppTransactions_CheckedChanged;
            // 
            // RentalTransactions
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 977);
            Controls.Add(gbDataSource);
            Controls.Add(lblEquipment);
            Controls.Add(cmbEquipment);
            Controls.Add(dtpTransctionDate);
            Controls.Add(lblPayment);
            Controls.Add(lblTransctionDateFilter);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(txtTransaction);
            Controls.Add(lblTransaction);
            Controls.Add(txtRequestID);
            Controls.Add(lblRequestID);
            Controls.Add(btnReset);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(dgvRentalTransactions);
            Controls.Add(lblReturnRecords);
            Controls.Add(pnlNavigationSideBar);
            Margin = new Padding(4);
            Name = "RentalTransactions";
            Text = "RentalTransactions";
            Load += RentalTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransactions).EndInit();
            pnlNavigationSideBar.ResumeLayout(false);
            gbDataSource.ResumeLayout(false);
            gbDataSource.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvRentalTransactions;
        private Label lblReturnRecords;
        private Panel pnlNavigationSideBar;
        private Button btnDeleteRentalTransaction;
        private Button btnSelectRecord;
        private Button btnEditRentalTransaction;
        private Button btnAddnewRentalTransaction;
        private Button btnBack;
        private Button btnReset;
        private Button btnFilter;
        private Button btnSearch;
        private TextBox txtRequestID;
        private Label lblRequestID;
        private TextBox txtTransaction;
        private Label lblTransaction;
        private DateTimePicker dtpTransctionDate;
        private Label lblPayment;
        private Label lblTransctionDateFilter;
        private ComboBox cmbPaymentStatus;
        private Label lblEquipment;
        private ComboBox cmbEquipment;
        private GroupBox gbDataSource;
        private RadioButton rbDesktopAppTransactions;
        private RadioButton rbWebsiteAppTransactions;
        private RadioButton rbAllTransactions;
    }
}