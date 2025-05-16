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
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransactions).BeginInit();
            pnlNavigationSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRentalTransactions
            // 
            dgvRentalTransactions.BackgroundColor = Color.WhiteSmoke;
            dgvRentalTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalTransactions.Location = new Point(253, 206);
            dgvRentalTransactions.Name = "dgvRentalTransactions";
            dgvRentalTransactions.RowHeadersWidth = 62;
            dgvRentalTransactions.Size = new Size(675, 236);
            dgvRentalTransactions.TabIndex = 24;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblReturnRecords.ForeColor = Color.FromArgb(135, 66, 62);
            lblReturnRecords.Location = new Point(415, 18);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(308, 42);
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
            pnlNavigationSideBar.Size = new Size(239, 458);
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
            btnDeleteRentalTransaction.Location = new Point(9, 271);
            btnDeleteRentalTransaction.Margin = new Padding(3, 2, 3, 2);
            btnDeleteRentalTransaction.Name = "btnDeleteRentalTransaction";
            btnDeleteRentalTransaction.Size = new Size(222, 38);
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
            btnSelectRecord.Location = new Point(9, 167);
            btnSelectRecord.Margin = new Padding(3, 2, 3, 2);
            btnSelectRecord.Name = "btnSelectRecord";
            btnSelectRecord.Size = new Size(201, 38);
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
            btnEditRentalTransaction.Location = new Point(17, 223);
            btnEditRentalTransaction.Margin = new Padding(3, 2, 3, 2);
            btnEditRentalTransaction.Name = "btnEditRentalTransaction";
            btnEditRentalTransaction.Size = new Size(205, 38);
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
            btnAddnewRentalTransaction.Location = new Point(3, 87);
            btnAddnewRentalTransaction.Margin = new Padding(3, 2, 3, 2);
            btnAddnewRentalTransaction.Name = "btnAddnewRentalTransaction";
            btnAddnewRentalTransaction.Size = new Size(233, 76);
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
            btnBack.Location = new Point(31, 21);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 44);
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
            btnReset.Location = new Point(820, 31);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(108, 39);
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
            btnFilter.Location = new Point(820, 145);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(108, 39);
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
            btnSearch.Location = new Point(820, 90);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 39);
            btnSearch.TabIndex = 39;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtRequestID
            // 
            txtRequestID.BorderStyle = BorderStyle.FixedSingle;
            txtRequestID.Location = new Point(410, 104);
            txtRequestID.Name = "txtRequestID";
            txtRequestID.Size = new Size(63, 23);
            txtRequestID.TabIndex = 43;
            // 
            // lblRequestID
            // 
            lblRequestID.AutoSize = true;
            lblRequestID.Location = new Point(252, 105);
            lblRequestID.Name = "lblRequestID";
            lblRequestID.Size = new Size(139, 15);
            lblRequestID.TabIndex = 42;
            lblRequestID.Text = "Rental Request Record ID";
            // 
            // txtTransaction
            // 
            txtTransaction.BorderStyle = BorderStyle.FixedSingle;
            txtTransaction.Location = new Point(704, 102);
            txtTransaction.Name = "txtTransaction";
            txtTransaction.Size = new Size(63, 23);
            txtTransaction.TabIndex = 45;
            // 
            // lblTransaction
            // 
            lblTransaction.AutoSize = true;
            lblTransaction.Location = new Point(527, 103);
            lblTransaction.Name = "lblTransaction";
            lblTransaction.Size = new Size(158, 15);
            lblTransaction.TabIndex = 44;
            lblTransaction.Text = "Rental Transaction Record ID";
            // 
            // dtpTransctionDate
            // 
            dtpTransctionDate.Checked = false;
            dtpTransctionDate.Location = new Point(259, 167);
            dtpTransctionDate.Name = "dtpTransctionDate";
            dtpTransctionDate.ShowCheckBox = true;
            dtpTransctionDate.Size = new Size(200, 23);
            dtpTransctionDate.TabIndex = 49;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(466, 149);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(134, 15);
            lblPayment.TabIndex = 48;
            lblPayment.Text = "Filter by Payment Status";
            // 
            // lblTransctionDateFilter
            // 
            lblTransctionDateFilter.AutoSize = true;
            lblTransctionDateFilter.Location = new Point(253, 149);
            lblTransctionDateFilter.Name = "lblTransctionDateFilter";
            lblTransctionDateFilter.Size = new Size(140, 15);
            lblTransctionDateFilter.TabIndex = 47;
            lblTransctionDateFilter.Text = "Filter by Transaction Date";
            lblTransctionDateFilter.Click += lblReturnDateFilter_Click;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(470, 166);
            cmbPaymentStatus.Margin = new Padding(3, 2, 3, 2);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(168, 23);
            cmbPaymentStatus.TabIndex = 46;
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.Location = new Point(639, 148);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(110, 15);
            lblEquipment.TabIndex = 51;
            lblEquipment.Text = "Filter by Equipment";
            // 
            // cmbEquipment
            // 
            cmbEquipment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipment.FormattingEnabled = true;
            cmbEquipment.Location = new Point(642, 165);
            cmbEquipment.Margin = new Padding(3, 2, 3, 2);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(159, 23);
            cmbEquipment.TabIndex = 50;
            // 
            // RentalTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
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
            Margin = new Padding(2);
            Name = "RentalTransactions";
            Text = "RentalTransactions";
            Load += RentalTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransactions).EndInit();
            pnlNavigationSideBar.ResumeLayout(false);
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
    }
}