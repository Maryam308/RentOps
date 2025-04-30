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
            btnAddRecord = new Button();
            btnBack = new Button();
            pnlNavigationSideBar = new Panel();
            btnReset = new Button();
            txtTransactionID = new TextBox();
            lblRentalTransaction = new Label();
            btnFilter = new Button();
            btnSearch = new Button();
            lblEquipment = new Label();
            cmbEquipment = new ComboBox();
            dtpTransctionDate = new DateTimePicker();
            lblPayment = new Label();
            lblTransctionDateFilter = new Label();
            cmbPaymentStatus = new ComboBox();
            txtRequestID = new TextBox();
            lblRequestID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).BeginInit();
            pnlNavigationSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReturnRecords
            // 
            dgvReturnRecords.BackgroundColor = Color.WhiteSmoke;
            dgvReturnRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnRecords.Location = new Point(286, 248);
            dgvReturnRecords.Margin = new Padding(3, 4, 3, 4);
            dgvReturnRecords.Name = "dgvReturnRecords";
            dgvReturnRecords.RowHeadersWidth = 51;
            dgvReturnRecords.Size = new Size(775, 335);
            dgvReturnRecords.TabIndex = 24;
            // 
            // lblRentalOverdue
            // 
            lblRentalOverdue.AutoSize = true;
            lblRentalOverdue.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblRentalOverdue.ForeColor = Color.FromArgb(135, 66, 62);
            lblRentalOverdue.Location = new Point(464, 21);
            lblRentalOverdue.Name = "lblRentalOverdue";
            lblRentalOverdue.Size = new Size(304, 52);
            lblRentalOverdue.TabIndex = 22;
            lblRentalOverdue.Text = "Rental Overdue";
            // 
            // btnAddRecord
            // 
            btnAddRecord.BackColor = Color.FromArgb(187, 178, 169);
            btnAddRecord.BackgroundImageLayout = ImageLayout.None;
            btnAddRecord.FlatAppearance.BorderSize = 0;
            btnAddRecord.FlatStyle = FlatStyle.Flat;
            btnAddRecord.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnAddRecord.ForeColor = Color.White;
            btnAddRecord.Location = new Point(3, 116);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(253, 51);
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
            btnBack.Location = new Point(35, 28);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(177, 59);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlNavigationSideBar
            // 
            pnlNavigationSideBar.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigationSideBar.Controls.Add(btnAddRecord);
            pnlNavigationSideBar.Controls.Add(btnBack);
            pnlNavigationSideBar.Location = new Point(0, -1);
            pnlNavigationSideBar.Margin = new Padding(0);
            pnlNavigationSideBar.Name = "pnlNavigationSideBar";
            pnlNavigationSideBar.Size = new Size(259, 611);
            pnlNavigationSideBar.TabIndex = 21;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(121, 86, 76);
            btnReset.BackgroundImageLayout = ImageLayout.None;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(241, 240, 234);
            btnReset.Location = new Point(935, 21);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(123, 52);
            btnReset.TabIndex = 50;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtTransactionID
            // 
            txtTransactionID.BorderStyle = BorderStyle.FixedSingle;
            txtTransactionID.Location = new Point(495, 118);
            txtTransactionID.Margin = new Padding(3, 4, 3, 4);
            txtTransactionID.Name = "txtTransactionID";
            txtTransactionID.Size = new Size(72, 27);
            txtTransactionID.TabIndex = 49;
            // 
            // lblRentalTransaction
            // 
            lblRentalTransaction.AutoSize = true;
            lblRentalTransaction.Location = new Point(331, 119);
            lblRentalTransaction.Name = "lblRentalTransaction";
            lblRentalTransaction.Size = new Size(149, 20);
            lblRentalTransaction.TabIndex = 47;
            lblRentalTransaction.Text = "Rental Transaction ID";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(121, 86, 76);
            btnFilter.BackgroundImageLayout = ImageLayout.None;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.FromArgb(241, 240, 234);
            btnFilter.Location = new Point(935, 173);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(123, 52);
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
            btnSearch.Location = new Point(935, 100);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(123, 52);
            btnSearch.TabIndex = 41;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.Location = new Point(738, 158);
            lblEquipment.Margin = new Padding(4, 0, 4, 0);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(138, 20);
            lblEquipment.TabIndex = 59;
            lblEquipment.Text = "Filter by Equipment";
            // 
            // cmbEquipment
            // 
            cmbEquipment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipment.FormattingEnabled = true;
            cmbEquipment.Location = new Point(742, 182);
            cmbEquipment.Margin = new Padding(4, 2, 4, 2);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(181, 28);
            cmbEquipment.TabIndex = 58;
            // 
            // dtpTransctionDate
            // 
            dtpTransctionDate.Checked = false;
            dtpTransctionDate.Location = new Point(304, 184);
            dtpTransctionDate.Margin = new Padding(4);
            dtpTransctionDate.Name = "dtpTransctionDate";
            dtpTransctionDate.ShowCheckBox = true;
            dtpTransctionDate.Size = new Size(228, 27);
            dtpTransctionDate.TabIndex = 57;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(541, 159);
            lblPayment.Margin = new Padding(4, 0, 4, 0);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(166, 20);
            lblPayment.TabIndex = 56;
            lblPayment.Text = "Filter by Payment Status";
            // 
            // lblTransctionDateFilter
            // 
            lblTransctionDateFilter.AutoSize = true;
            lblTransctionDateFilter.Location = new Point(297, 159);
            lblTransctionDateFilter.Margin = new Padding(4, 0, 4, 0);
            lblTransctionDateFilter.Name = "lblTransctionDateFilter";
            lblTransctionDateFilter.Size = new Size(177, 20);
            lblTransctionDateFilter.TabIndex = 55;
            lblTransctionDateFilter.Text = "Filter by Transaction Date";
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(545, 183);
            cmbPaymentStatus.Margin = new Padding(4, 2, 4, 2);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(191, 28);
            cmbPaymentStatus.TabIndex = 54;
            // 
            // txtRequestID
            // 
            txtRequestID.BorderStyle = BorderStyle.FixedSingle;
            txtRequestID.Location = new Point(804, 118);
            txtRequestID.Margin = new Padding(4);
            txtRequestID.Name = "txtRequestID";
            txtRequestID.Size = new Size(72, 27);
            txtRequestID.TabIndex = 53;
            // 
            // lblRequestID
            // 
            lblRequestID.AutoSize = true;
            lblRequestID.Location = new Point(618, 120);
            lblRequestID.Margin = new Padding(4, 0, 4, 0);
            lblRequestID.Name = "lblRequestID";
            lblRequestID.Size = new Size(178, 20);
            lblRequestID.TabIndex = 52;
            lblRequestID.Text = "Rental Request Record ID";
            // 
            // OverdueReturns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(lblEquipment);
            Controls.Add(cmbEquipment);
            Controls.Add(dtpTransctionDate);
            Controls.Add(lblPayment);
            Controls.Add(lblTransctionDateFilter);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(txtRequestID);
            Controls.Add(lblRequestID);
            Controls.Add(btnReset);
            Controls.Add(txtTransactionID);
            Controls.Add(lblRentalTransaction);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(dgvReturnRecords);
            Controls.Add(lblRentalOverdue);
            Controls.Add(pnlNavigationSideBar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OverdueReturns";
            Text = " ";
            Load += OverdueReturns_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).EndInit();
            pnlNavigationSideBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvReturnRecords;
        private Label lblRentalOverdue;
        private Button btnAddRecord;
        private Button btnBack;
        private Panel pnlNavigationSideBar;
        private Button btnReset;
        private TextBox txtTransactionID;
        private Label lblRentalTransaction;
        private Button btnFilter;
        private Button btnSearch;
        private Label lblEquipment;
        private ComboBox cmbEquipment;
        private DateTimePicker dtpTransctionDate;
        private Label lblPayment;
        private Label lblTransctionDateFilter;
        private ComboBox cmbPaymentStatus;
        private TextBox txtRequestID;
        private Label lblRequestID;
    }
}