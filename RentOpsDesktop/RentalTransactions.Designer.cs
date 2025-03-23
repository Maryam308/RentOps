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
            btnFilter = new Button();
            btnSearch = new Button();
            dgvReturnRecords = new DataGridView();
            lblReturnRecords = new Label();
            pnlNavigationSideBar = new Panel();
            btnDeleteRentalTransaction = new Button();
            btnSelectRecord = new Button();
            btnEditRentalTransaction = new Button();
            btnAddnewRentalTransaction = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).BeginInit();
            pnlNavigationSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(121, 86, 76);
            btnFilter.BackgroundImageLayout = ImageLayout.None;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.FromArgb(241, 240, 234);
            btnFilter.Location = new Point(928, 143);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(319, 65);
            btnFilter.TabIndex = 25;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(121, 86, 76);
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(241, 240, 234);
            btnSearch.Location = new Point(456, 145);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(319, 65);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvReturnRecords
            // 
            dgvReturnRecords.BackgroundColor = Color.WhiteSmoke;
            dgvReturnRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnRecords.Location = new Point(374, 250);
            dgvReturnRecords.Margin = new Padding(4, 5, 4, 5);
            dgvReturnRecords.Name = "dgvReturnRecords";
            dgvReturnRecords.RowHeadersWidth = 62;
            dgvReturnRecords.Size = new Size(969, 480);
            dgvReturnRecords.TabIndex = 24;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblReturnRecords.ForeColor = Color.FromArgb(135, 66, 62);
            lblReturnRecords.Location = new Point(671, 35);
            lblReturnRecords.Margin = new Padding(4, 0, 4, 0);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(454, 62);
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
            pnlNavigationSideBar.Size = new Size(341, 763);
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
            btnDeleteRentalTransaction.Location = new Point(13, 452);
            btnDeleteRentalTransaction.Margin = new Padding(4, 3, 4, 3);
            btnDeleteRentalTransaction.Name = "btnDeleteRentalTransaction";
            btnDeleteRentalTransaction.Size = new Size(317, 63);
            btnDeleteRentalTransaction.TabIndex = 18;
            btnDeleteRentalTransaction.Text = "Delete Rental Transaction";
            btnDeleteRentalTransaction.UseVisualStyleBackColor = false;
            // 
            // btnSelectRecord
            // 
            btnSelectRecord.BackColor = Color.FromArgb(187, 178, 169);
            btnSelectRecord.BackgroundImageLayout = ImageLayout.None;
            btnSelectRecord.FlatAppearance.BorderSize = 0;
            btnSelectRecord.FlatStyle = FlatStyle.Flat;
            btnSelectRecord.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btnSelectRecord.ForeColor = Color.White;
            btnSelectRecord.Location = new Point(13, 278);
            btnSelectRecord.Margin = new Padding(4, 3, 4, 3);
            btnSelectRecord.Name = "btnSelectRecord";
            btnSelectRecord.Size = new Size(287, 63);
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
            btnEditRentalTransaction.Location = new Point(24, 371);
            btnEditRentalTransaction.Margin = new Padding(4, 3, 4, 3);
            btnEditRentalTransaction.Name = "btnEditRentalTransaction";
            btnEditRentalTransaction.Size = new Size(293, 63);
            btnEditRentalTransaction.TabIndex = 12;
            btnEditRentalTransaction.Text = "Edit Rental Transaction";
            btnEditRentalTransaction.UseVisualStyleBackColor = false;
            // 
            // btnAddnewRentalTransaction
            // 
            btnAddnewRentalTransaction.BackColor = Color.FromArgb(187, 178, 169);
            btnAddnewRentalTransaction.BackgroundImageLayout = ImageLayout.None;
            btnAddnewRentalTransaction.FlatAppearance.BorderSize = 0;
            btnAddnewRentalTransaction.FlatStyle = FlatStyle.Flat;
            btnAddnewRentalTransaction.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnAddnewRentalTransaction.ForeColor = Color.White;
            btnAddnewRentalTransaction.Location = new Point(4, 145);
            btnAddnewRentalTransaction.Margin = new Padding(4, 3, 4, 3);
            btnAddnewRentalTransaction.Name = "btnAddnewRentalTransaction";
            btnAddnewRentalTransaction.Size = new Size(333, 127);
            btnAddnewRentalTransaction.TabIndex = 10;
            btnAddnewRentalTransaction.Text = "Add new Rental Transaction";
            btnAddnewRentalTransaction.UseVisualStyleBackColor = false;
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
            // RentalTransactions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 763);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(dgvReturnRecords);
            Controls.Add(lblReturnRecords);
            Controls.Add(pnlNavigationSideBar);
            Name = "RentalTransactions";
            Text = "RentalTransactions";
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).EndInit();
            pnlNavigationSideBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFilter;
        private Button btnSearch;
        private DataGridView dgvReturnRecords;
        private Label lblReturnRecords;
        private Panel pnlNavigationSideBar;
        private Button btnDeleteRentalTransaction;
        private Button btnSelectRecord;
        private Button btnEditRentalTransaction;
        private Button btnAddnewRentalTransaction;
        private Button btnBack;
    }
}