namespace RentOpsDesktop
{
    partial class AuditLog
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
            dgvAuditLog = new DataGridView();
            lblAuditLog = new Label();
            btnBack = new Button();
            dtpTimestamp = new DateTimePicker();
            cmbSource = new ComboBox();
            lblRentalTransaction = new Label();
            label2 = new Label();
            lblReturnDateFilter = new Label();
            cmbLogType = new ComboBox();
            btnReset = new Button();
            btnFilter = new Button();
            btnViewDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLog).BeginInit();
            SuspendLayout();
            // 
            // dgvAuditLog
            // 
            dgvAuditLog.BackgroundColor = Color.WhiteSmoke;
            dgvAuditLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLog.Location = new Point(124, 326);
            dgvAuditLog.Margin = new Padding(6, 4, 6, 4);
            dgvAuditLog.Name = "dgvAuditLog";
            dgvAuditLog.RowHeadersWidth = 51;
            dgvAuditLog.Size = new Size(1510, 495);
            dgvAuditLog.TabIndex = 12;
            // 
            // lblAuditLog
            // 
            lblAuditLog.AutoSize = true;
            lblAuditLog.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblAuditLog.ForeColor = Color.FromArgb(135, 66, 62);
            lblAuditLog.Location = new Point(765, 49);
            lblAuditLog.Margin = new Padding(6, 0, 6, 0);
            lblAuditLog.Name = "lblAuditLog";
            lblAuditLog.Size = new Size(311, 82);
            lblAuditLog.TabIndex = 11;
            lblAuditLog.Text = "Audit Log";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(121, 86, 76);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(22, 23);
            btnBack.Margin = new Padding(6, 4, 6, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(288, 94);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dtpTimestamp
            // 
            dtpTimestamp.Checked = false;
            dtpTimestamp.Location = new Point(223, 235);
            dtpTimestamp.Margin = new Padding(6, 6, 6, 6);
            dtpTimestamp.Name = "dtpTimestamp";
            dtpTimestamp.ShowCheckBox = true;
            dtpTimestamp.Size = new Size(349, 39);
            dtpTimestamp.TabIndex = 14;
            // 
            // cmbSource
            // 
            cmbSource.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSource.FormattingEnabled = true;
            cmbSource.Location = new Point(652, 235);
            cmbSource.Margin = new Padding(6, 6, 6, 6);
            cmbSource.Name = "cmbSource";
            cmbSource.Size = new Size(349, 40);
            cmbSource.TabIndex = 15;
            // 
            // lblRentalTransaction
            // 
            lblRentalTransaction.AutoSize = true;
            lblRentalTransaction.Location = new Point(1073, 190);
            lblRentalTransaction.Margin = new Padding(6, 0, 6, 0);
            lblRentalTransaction.Name = "lblRentalTransaction";
            lblRentalTransaction.Size = new Size(204, 32);
            lblRentalTransaction.TabIndex = 38;
            lblRentalTransaction.Text = "Filter by Log Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(652, 190);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 37;
            label2.Text = "Filter by Source";
            // 
            // lblReturnDateFilter
            // 
            lblReturnDateFilter.AutoSize = true;
            lblReturnDateFilter.Location = new Point(227, 190);
            lblReturnDateFilter.Margin = new Padding(6, 0, 6, 0);
            lblReturnDateFilter.Name = "lblReturnDateFilter";
            lblReturnDateFilter.Size = new Size(203, 32);
            lblReturnDateFilter.TabIndex = 36;
            lblReturnDateFilter.Text = "Filter by Log Date";
            // 
            // cmbLogType
            // 
            cmbLogType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLogType.FormattingEnabled = true;
            cmbLogType.Location = new Point(1068, 235);
            cmbLogType.Margin = new Padding(6, 6, 6, 6);
            cmbLogType.Name = "cmbLogType";
            cmbLogType.Size = new Size(349, 40);
            cmbLogType.TabIndex = 39;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(121, 86, 76);
            btnReset.BackgroundImageLayout = ImageLayout.None;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(241, 240, 234);
            btnReset.Location = new Point(1504, 49);
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
            btnFilter.Location = new Point(1504, 147);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(201, 83);
            btnFilter.TabIndex = 40;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.FromArgb(121, 86, 76);
            btnViewDetails.BackgroundImageLayout = ImageLayout.None;
            btnViewDetails.FlatAppearance.BorderSize = 0;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnViewDetails.ForeColor = Color.White;
            btnViewDetails.Location = new Point(1458, 860);
            btnViewDetails.Margin = new Padding(6, 4, 6, 4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(288, 94);
            btnViewDetails.TabIndex = 42;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // AuditLog
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 977);
            Controls.Add(btnViewDetails);
            Controls.Add(btnReset);
            Controls.Add(btnFilter);
            Controls.Add(cmbLogType);
            Controls.Add(lblRentalTransaction);
            Controls.Add(label2);
            Controls.Add(lblReturnDateFilter);
            Controls.Add(cmbSource);
            Controls.Add(dtpTimestamp);
            Controls.Add(btnBack);
            Controls.Add(dgvAuditLog);
            Controls.Add(lblAuditLog);
            Margin = new Padding(6, 6, 6, 6);
            Name = "AuditLog";
            Text = "AuditLog";
            Load += AuditLog_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuditLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAuditLog;
        private Label lblAuditLog;
        private Button btnBack;
        private DateTimePicker dtpTimestamp;
        private ComboBox cmbSource;
        private Label lblRentalTransaction;
        private Label label2;
        private Label lblReturnDateFilter;
        private ComboBox cmbLogType;
        private Button btnReset;
        private Button btnFilter;
        private Button btnViewDetails;
    }
}