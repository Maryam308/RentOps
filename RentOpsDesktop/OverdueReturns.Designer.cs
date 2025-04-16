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
            btnFilter = new Button();
            btnSearch = new Button();
            dgvReturnRecords = new DataGridView();
            lblRentalOverdue = new Label();
            btnDeleteReturnRecord = new Button();
            btnSelectRecord = new Button();
            btnEditReturnRecord = new Button();
            btnAddRecord = new Button();
            btnBack = new Button();
            pnlNavigationSideBar = new Panel();
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
            btnFilter.Location = new Point(638, 85);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(223, 39);
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
            btnSearch.Location = new Point(307, 86);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(223, 39);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvReturnRecords
            // 
            dgvReturnRecords.BackgroundColor = Color.WhiteSmoke;
            dgvReturnRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnRecords.Location = new Point(250, 149);
            dgvReturnRecords.Name = "dgvReturnRecords";
            dgvReturnRecords.Size = new Size(678, 288);
            dgvReturnRecords.TabIndex = 24;
            // 
            // lblRentalOverdue
            // 
            lblRentalOverdue.AutoSize = true;
            lblRentalOverdue.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblRentalOverdue.ForeColor = Color.FromArgb(135, 66, 62);
            lblRentalOverdue.Location = new Point(458, 20);
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
            // OverdueReturns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(dgvReturnRecords);
            Controls.Add(lblRentalOverdue);
            Controls.Add(pnlNavigationSideBar);
            Name = "OverdueReturns";
            Text = "OverdueReturns";
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).EndInit();
            pnlNavigationSideBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFilter;
        private Button btnSearch;
        private DataGridView dgvReturnRecords;
        private Label lblRentalOverdue;
        private Button btnDeleteReturnRecord;
        private Button btnSelectRecord;
        private Button btnEditReturnRecord;
        private Button btnAddRecord;
        private Button btnBack;
        private Panel pnlNavigationSideBar;
    }
}