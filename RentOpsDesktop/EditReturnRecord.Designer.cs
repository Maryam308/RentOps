namespace RentOpsDesktop
{
    partial class EditReturnRecord
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
            txtAdditionalCharge = new TextBox();
            txtLateReturnPenalty = new TextBox();
            btnUpload = new Button();
            lblDamageReport = new Label();
            lblAdditionalCharge = new Label();
            lblLateReturnPenalty = new Label();
            cmbConditionStatus = new ComboBox();
            lblReturnCondition = new Label();
            dtpReturnDate = new DateTimePicker();
            lblReturnDate = new Label();
            txtAssociatedTransaction = new TextBox();
            lblAssociatedTransaction = new Label();
            btnSaveChages = new Button();
            btnBack = new Button();
            lblEditReturnRecords = new Label();
            lblLateReturnPenaltyErr = new Label();
            lblAdditionalChargesErr = new Label();
            btnDownload = new Button();
            btnRemove = new Button();
            gbDamageReport = new GroupBox();
            lblReturnConditionErr = new Label();
            gbDamageReport.SuspendLayout();
            SuspendLayout();
            // 
            // txtAdditionalCharge
            // 
            txtAdditionalCharge.BorderStyle = BorderStyle.FixedSingle;
            txtAdditionalCharge.Font = new Font("Segoe UI", 14F);
            txtAdditionalCharge.Location = new Point(1357, 452);
            txtAdditionalCharge.Margin = new Padding(6);
            txtAdditionalCharge.Name = "txtAdditionalCharge";
            txtAdditionalCharge.Size = new Size(324, 57);
            txtAdditionalCharge.TabIndex = 40;
            txtAdditionalCharge.TextChanged += txtAdditionalCharge_TextChanged;
            // 
            // txtLateReturnPenalty
            // 
            txtLateReturnPenalty.BorderStyle = BorderStyle.FixedSingle;
            txtLateReturnPenalty.Font = new Font("Segoe UI", 14F);
            txtLateReturnPenalty.Location = new Point(1357, 267);
            txtLateReturnPenalty.Margin = new Padding(6);
            txtLateReturnPenalty.Name = "txtLateReturnPenalty";
            txtLateReturnPenalty.Size = new Size(324, 57);
            txtLateReturnPenalty.TabIndex = 39;
            txtLateReturnPenalty.TextChanged += txtLateReturnPenalty_TextChanged;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(121, 86, 76);
            btnUpload.BackgroundImageLayout = ImageLayout.None;
            btnUpload.FlatAppearance.BorderSize = 2;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnUpload.ForeColor = Color.FromArgb(241, 240, 234);
            btnUpload.Location = new Point(549, 146);
            btnUpload.Margin = new Padding(0);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(255, 57);
            btnUpload.TabIndex = 38;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // lblDamageReport
            // 
            lblDamageReport.AutoSize = true;
            lblDamageReport.Font = new Font("Segoe UI", 14F);
            lblDamageReport.ForeColor = Color.MidnightBlue;
            lblDamageReport.Location = new Point(20, 152);
            lblDamageReport.Margin = new Padding(6, 0, 6, 0);
            lblDamageReport.Name = "lblDamageReport";
            lblDamageReport.Size = new Size(413, 51);
            lblDamageReport.TabIndex = 37;
            lblDamageReport.Text = "Damagae Report Name";
            // 
            // lblAdditionalCharge
            // 
            lblAdditionalCharge.AutoSize = true;
            lblAdditionalCharge.Font = new Font("Segoe UI", 14F);
            lblAdditionalCharge.Location = new Point(993, 449);
            lblAdditionalCharge.Margin = new Padding(6, 0, 6, 0);
            lblAdditionalCharge.Name = "lblAdditionalCharge";
            lblAdditionalCharge.Size = new Size(324, 51);
            lblAdditionalCharge.TabIndex = 36;
            lblAdditionalCharge.Text = "Additional Charge";
            // 
            // lblLateReturnPenalty
            // 
            lblLateReturnPenalty.AutoSize = true;
            lblLateReturnPenalty.Font = new Font("Segoe UI", 14F);
            lblLateReturnPenalty.Location = new Point(993, 267);
            lblLateReturnPenalty.Margin = new Padding(6, 0, 6, 0);
            lblLateReturnPenalty.Name = "lblLateReturnPenalty";
            lblLateReturnPenalty.Size = new Size(345, 51);
            lblLateReturnPenalty.TabIndex = 35;
            lblLateReturnPenalty.Text = "Late Return Penalty";
            // 
            // cmbConditionStatus
            // 
            cmbConditionStatus.Font = new Font("Segoe UI", 14F);
            cmbConditionStatus.FormattingEnabled = true;
            cmbConditionStatus.Location = new Point(1357, 625);
            cmbConditionStatus.Margin = new Padding(6);
            cmbConditionStatus.Name = "cmbConditionStatus";
            cmbConditionStatus.Size = new Size(324, 58);
            cmbConditionStatus.TabIndex = 34;
            cmbConditionStatus.SelectedIndexChanged += cmbConditionStatus_SelectedIndexChanged;
            cmbConditionStatus.SelectionChangeCommitted += cmbConditionStatus_SelectionChangeCommitted;
            // 
            // lblReturnCondition
            // 
            lblReturnCondition.AutoSize = true;
            lblReturnCondition.Font = new Font("Segoe UI", 14F);
            lblReturnCondition.Location = new Point(993, 627);
            lblReturnCondition.Margin = new Padding(6, 0, 6, 0);
            lblReturnCondition.Name = "lblReturnCondition";
            lblReturnCondition.Size = new Size(309, 51);
            lblReturnCondition.TabIndex = 33;
            lblReturnCondition.Text = "Return Condition";
            lblReturnCondition.Click += lblReturnCondition_Click;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.CalendarFont = new Font("Segoe UI", 14F);
            dtpReturnDate.Location = new Point(524, 461);
            dtpReturnDate.Margin = new Padding(6);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(377, 39);
            dtpReturnDate.TabIndex = 32;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Segoe UI", 14F);
            lblReturnDate.Location = new Point(99, 449);
            lblReturnDate.Margin = new Padding(6, 0, 6, 0);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(223, 51);
            lblReturnDate.TabIndex = 31;
            lblReturnDate.Text = "Return Date";
            // 
            // txtAssociatedTransaction
            // 
            txtAssociatedTransaction.BorderStyle = BorderStyle.FixedSingle;
            txtAssociatedTransaction.Enabled = false;
            txtAssociatedTransaction.Font = new Font("Segoe UI", 14F);
            txtAssociatedTransaction.Location = new Point(524, 262);
            txtAssociatedTransaction.Margin = new Padding(6);
            txtAssociatedTransaction.Name = "txtAssociatedTransaction";
            txtAssociatedTransaction.ReadOnly = true;
            txtAssociatedTransaction.Size = new Size(379, 57);
            txtAssociatedTransaction.TabIndex = 30;
            // 
            // lblAssociatedTransaction
            // 
            lblAssociatedTransaction.AutoSize = true;
            lblAssociatedTransaction.Font = new Font("Segoe UI", 14F);
            lblAssociatedTransaction.Location = new Point(99, 267);
            lblAssociatedTransaction.Margin = new Padding(6, 0, 6, 0);
            lblAssociatedTransaction.Name = "lblAssociatedTransaction";
            lblAssociatedTransaction.Size = new Size(402, 51);
            lblAssociatedTransaction.TabIndex = 29;
            lblAssociatedTransaction.Text = "Associated Transaction";
            // 
            // btnSaveChages
            // 
            btnSaveChages.BackColor = Color.FromArgb(121, 86, 76);
            btnSaveChages.BackgroundImageLayout = ImageLayout.None;
            btnSaveChages.FlatAppearance.BorderSize = 0;
            btnSaveChages.FlatStyle = FlatStyle.Flat;
            btnSaveChages.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChages.ForeColor = Color.FromArgb(241, 240, 234);
            btnSaveChages.Location = new Point(1287, 821);
            btnSaveChages.Margin = new Padding(0);
            btnSaveChages.Name = "btnSaveChages";
            btnSaveChages.Size = new Size(414, 102);
            btnSaveChages.TabIndex = 28;
            btnSaveChages.Text = "Save Changes";
            btnSaveChages.UseVisualStyleBackColor = false;
            btnSaveChages.Click += btnSaveChages_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(67, 55);
            btnBack.Margin = new Padding(6, 4, 6, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(288, 94);
            btnBack.TabIndex = 27;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblEditReturnRecords
            // 
            lblEditReturnRecords.AutoSize = true;
            lblEditReturnRecords.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblEditReturnRecords.ForeColor = Color.FromArgb(135, 66, 62);
            lblEditReturnRecords.Location = new Point(656, 83);
            lblEditReturnRecords.Margin = new Padding(6, 0, 6, 0);
            lblEditReturnRecords.Name = "lblEditReturnRecords";
            lblEditReturnRecords.Size = new Size(590, 82);
            lblEditReturnRecords.TabIndex = 26;
            lblEditReturnRecords.Text = "Edit Return Records";
            // 
            // lblLateReturnPenaltyErr
            // 
            lblLateReturnPenaltyErr.AutoSize = true;
            lblLateReturnPenaltyErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLateReturnPenaltyErr.ForeColor = Color.Red;
            lblLateReturnPenaltyErr.Location = new Point(1375, 343);
            lblLateReturnPenaltyErr.Margin = new Padding(6, 0, 6, 0);
            lblLateReturnPenaltyErr.Name = "lblLateReturnPenaltyErr";
            lblLateReturnPenaltyErr.Size = new Size(0, 32);
            lblLateReturnPenaltyErr.TabIndex = 48;
            // 
            // lblAdditionalChargesErr
            // 
            lblAdditionalChargesErr.AutoSize = true;
            lblAdditionalChargesErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAdditionalChargesErr.ForeColor = Color.Red;
            lblAdditionalChargesErr.Location = new Point(1375, 525);
            lblAdditionalChargesErr.Margin = new Padding(6, 0, 6, 0);
            lblAdditionalChargesErr.Name = "lblAdditionalChargesErr";
            lblAdditionalChargesErr.Size = new Size(0, 32);
            lblAdditionalChargesErr.TabIndex = 49;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.FromArgb(121, 86, 76);
            btnDownload.BackgroundImageLayout = ImageLayout.None;
            btnDownload.FlatAppearance.BorderSize = 2;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnDownload.ForeColor = Color.FromArgb(241, 240, 234);
            btnDownload.Location = new Point(547, 63);
            btnDownload.Margin = new Padding(0);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(255, 57);
            btnDownload.TabIndex = 50;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(121, 86, 76);
            btnRemove.BackgroundImageLayout = ImageLayout.None;
            btnRemove.FlatAppearance.BorderSize = 2;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRemove.ForeColor = Color.FromArgb(241, 240, 234);
            btnRemove.Location = new Point(549, 237);
            btnRemove.Margin = new Padding(0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(255, 57);
            btnRemove.TabIndex = 51;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // gbDamageReport
            // 
            gbDamageReport.Controls.Add(lblDamageReport);
            gbDamageReport.Controls.Add(btnDownload);
            gbDamageReport.Controls.Add(btnRemove);
            gbDamageReport.Controls.Add(btnUpload);
            gbDamageReport.Font = new Font("Segoe UI", 14F);
            gbDamageReport.Location = new Point(99, 562);
            gbDamageReport.Name = "gbDamageReport";
            gbDamageReport.Size = new Size(826, 328);
            gbDamageReport.TabIndex = 52;
            gbDamageReport.TabStop = false;
            gbDamageReport.Text = "Edit Damage Report";
            // 
            // lblReturnConditionErr
            // 
            lblReturnConditionErr.AutoSize = true;
            lblReturnConditionErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblReturnConditionErr.ForeColor = Color.Red;
            lblReturnConditionErr.Location = new Point(1375, 708);
            lblReturnConditionErr.Margin = new Padding(6, 0, 6, 0);
            lblReturnConditionErr.Name = "lblReturnConditionErr";
            lblReturnConditionErr.Size = new Size(0, 32);
            lblReturnConditionErr.TabIndex = 53;
            // 
            // EditReturnRecord
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 977);
            Controls.Add(lblReturnConditionErr);
            Controls.Add(gbDamageReport);
            Controls.Add(lblAdditionalChargesErr);
            Controls.Add(lblLateReturnPenaltyErr);
            Controls.Add(txtAdditionalCharge);
            Controls.Add(txtLateReturnPenalty);
            Controls.Add(lblAdditionalCharge);
            Controls.Add(lblLateReturnPenalty);
            Controls.Add(cmbConditionStatus);
            Controls.Add(lblReturnCondition);
            Controls.Add(dtpReturnDate);
            Controls.Add(lblReturnDate);
            Controls.Add(txtAssociatedTransaction);
            Controls.Add(lblAssociatedTransaction);
            Controls.Add(btnSaveChages);
            Controls.Add(btnBack);
            Controls.Add(lblEditReturnRecords);
            Margin = new Padding(6);
            Name = "EditReturnRecord";
            Text = "EditReturnRecord";
            Load += EditReturnRecord_Load;
            gbDamageReport.ResumeLayout(false);
            gbDamageReport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdditionalCharge;
        private TextBox txtLateReturnPenalty;
        private Button btnUpload;
        private Label lblDamageReport;
        private Label lblAdditionalCharge;
        private Label lblLateReturnPenalty;
        private ComboBox cmbConditionStatus;
        private Label lblReturnCondition;
        private DateTimePicker dtpReturnDate;
        private Label lblReturnDate;
        private TextBox txtAssociatedTransaction;
        private Label lblAssociatedTransaction;
        private Button btnSaveChages;
        private Button btnBack;
        private Label lblEditReturnRecords;
        private Label lblLateReturnPenaltyErr;
        private Label lblAdditionalChargesErr;
        private Button btnDownload;
        private Button btnRemove;
        private GroupBox gbDamageReport;
        private Label lblReturnConditionErr;
    }
}