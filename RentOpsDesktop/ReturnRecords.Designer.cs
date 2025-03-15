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
            this.btnDeleteReturnRecord = new Button();
            btnSelectRecord = new Button();
            this.btnEditReturnRecord = new Button();
            btnAddRecord = new Button();
            btnBack = new Button();
            btnSearch = new Button();
            dgvReturnRecords = new DataGridView();
            lblReturnRecords = new Label();
            btnFilter = new Button();
            pnlNavigationSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).BeginInit();
            SuspendLayout();
            // 
            // pnlNavigationSideBar
            // 
            pnlNavigationSideBar.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigationSideBar.Controls.Add(this.btnDeleteReturnRecord);
            pnlNavigationSideBar.Controls.Add(btnSelectRecord);
            pnlNavigationSideBar.Controls.Add(this.btnEditReturnRecord);
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
            this.btnDeleteReturnRecord.BackColor = Color.FromArgb(187, 178, 169);
            this.btnDeleteReturnRecord.BackgroundImageLayout = ImageLayout.None;
            this.btnDeleteReturnRecord.FlatAppearance.BorderSize = 0;
            this.btnDeleteReturnRecord.FlatStyle = FlatStyle.Flat;
            this.btnDeleteReturnRecord.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            this.btnDeleteReturnRecord.ForeColor = Color.White;
            this.btnDeleteReturnRecord.Location = new Point(23, 233);
            this.btnDeleteReturnRecord.Margin = new Padding(3, 2, 3, 2);
            this.btnDeleteReturnRecord.Name = "btnDeleteReturnRecord";
            this.btnDeleteReturnRecord.Size = new Size(180, 38);
            this.btnDeleteReturnRecord.TabIndex = 18;
            this.btnDeleteReturnRecord.Text = "Delete Return Record";
            this.btnDeleteReturnRecord.UseVisualStyleBackColor = false;
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
            this.btnEditReturnRecord.BackColor = Color.FromArgb(187, 178, 169);
            this.btnEditReturnRecord.BackgroundImageLayout = ImageLayout.None;
            this.btnEditReturnRecord.FlatAppearance.BorderSize = 0;
            this.btnEditReturnRecord.FlatStyle = FlatStyle.Flat;
            this.btnEditReturnRecord.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            this.btnEditReturnRecord.ForeColor = Color.White;
            this.btnEditReturnRecord.Location = new Point(23, 187);
            this.btnEditReturnRecord.Margin = new Padding(3, 2, 3, 2);
            this.btnEditReturnRecord.Name = "btnEditReturnRecord";
            this.btnEditReturnRecord.Size = new Size(180, 38);
            this.btnEditReturnRecord.TabIndex = 12;
            this.btnEditReturnRecord.Text = "Edit Return Record";
            this.btnEditReturnRecord.UseVisualStyleBackColor = false;
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
            btnSearch.Location = new Point(307, 87);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(223, 39);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvReturnRecords
            // 
            dgvReturnRecords.BackgroundColor = Color.WhiteSmoke;
            dgvReturnRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnRecords.Location = new Point(250, 150);
            dgvReturnRecords.Name = "dgvReturnRecords";
            dgvReturnRecords.Size = new Size(678, 288);
            dgvReturnRecords.TabIndex = 19;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblReturnRecords.ForeColor = Color.FromArgb(135, 66, 62);
            lblReturnRecords.Location = new Point(458, 21);
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
            btnFilter.Location = new Point(638, 86);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(223, 39);
            btnFilter.TabIndex = 20;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // ReturnRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(dgvReturnRecords);
            Controls.Add(lblReturnRecords);
            Controls.Add(pnlNavigationSideBar);
            Name = "ReturnRecords";
            Text = "ReturnRecords";
            pnlNavigationSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavigationSideBar;
        private Button btnEquipmentInformation;
        private Button btnReturnRecords;
        private Button btnRentalTransactions;
        private Button btnSelectRecord;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnRentalRequests;
        private Button btnAddRecord;
        private Button btnBack;
        private Button btnSearch;
        private DataGridView dgvReturnRecords;
        private Label lblReturnRecords;
        private Button btnFilter;
    }
}