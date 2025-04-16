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
            lblAdditionalDocument = new Label();
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
            SuspendLayout();
            // 
            // txtAdditionalCharge
            // 
            txtAdditionalCharge.BorderStyle = BorderStyle.FixedSingle;
            txtAdditionalCharge.Font = new Font("Segoe UI", 14F);
            txtAdditionalCharge.Location = new Point(741, 212);
            txtAdditionalCharge.Name = "txtAdditionalCharge";
            txtAdditionalCharge.Size = new Size(165, 32);
            txtAdditionalCharge.TabIndex = 40;
            txtAdditionalCharge.TextChanged += txtAdditionalCharge_TextChanged;
            // 
            // txtLateReturnPenalty
            // 
            txtLateReturnPenalty.BorderStyle = BorderStyle.FixedSingle;
            txtLateReturnPenalty.Font = new Font("Segoe UI", 14F);
            txtLateReturnPenalty.Location = new Point(741, 125);
            txtLateReturnPenalty.Name = "txtLateReturnPenalty";
            txtLateReturnPenalty.Size = new Size(165, 32);
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
            btnUpload.Location = new Point(761, 295);
            btnUpload.Margin = new Padding(0);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(125, 37);
            btnUpload.TabIndex = 38;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            // 
            // lblAdditionalDocument
            // 
            lblAdditionalDocument.AutoSize = true;
            lblAdditionalDocument.Font = new Font("Segoe UI", 14F);
            lblAdditionalDocument.Location = new Point(533, 300);
            lblAdditionalDocument.Name = "lblAdditionalDocument";
            lblAdditionalDocument.Size = new Size(191, 25);
            lblAdditionalDocument.TabIndex = 37;
            lblAdditionalDocument.Text = "Additional Document";
            // 
            // lblAdditionalCharge
            // 
            lblAdditionalCharge.AutoSize = true;
            lblAdditionalCharge.Font = new Font("Segoe UI", 14F);
            lblAdditionalCharge.Location = new Point(546, 216);
            lblAdditionalCharge.Name = "lblAdditionalCharge";
            lblAdditionalCharge.Size = new Size(165, 25);
            lblAdditionalCharge.TabIndex = 36;
            lblAdditionalCharge.Text = "Additional Charge";
            // 
            // lblLateReturnPenalty
            // 
            lblLateReturnPenalty.AutoSize = true;
            lblLateReturnPenalty.Font = new Font("Segoe UI", 14F);
            lblLateReturnPenalty.Location = new Point(542, 125);
            lblLateReturnPenalty.Name = "lblLateReturnPenalty";
            lblLateReturnPenalty.Size = new Size(173, 25);
            lblLateReturnPenalty.TabIndex = 35;
            lblLateReturnPenalty.Text = "Late Return Penalty";
            // 
            // cmbConditionStatus
            // 
            cmbConditionStatus.Font = new Font("Segoe UI", 14F);
            cmbConditionStatus.FormattingEnabled = true;
            cmbConditionStatus.Location = new Point(282, 300);
            cmbConditionStatus.Name = "cmbConditionStatus";
            cmbConditionStatus.Size = new Size(205, 33);
            cmbConditionStatus.TabIndex = 34;
            cmbConditionStatus.SelectedIndexChanged += cmbConditionStatus_SelectedIndexChanged;
            cmbConditionStatus.SelectionChangeCommitted += cmbConditionStatus_SelectionChangeCommitted;
            // 
            // lblReturnCondition
            // 
            lblReturnCondition.AutoSize = true;
            lblReturnCondition.Font = new Font("Segoe UI", 14F);
            lblReturnCondition.Location = new Point(82, 303);
            lblReturnCondition.Name = "lblReturnCondition";
            lblReturnCondition.Size = new Size(155, 25);
            lblReturnCondition.TabIndex = 33;
            lblReturnCondition.Text = "Return Condition";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.CalendarFont = new Font("Segoe UI", 14F);
            dtpReturnDate.Location = new Point(282, 216);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(205, 23);
            dtpReturnDate.TabIndex = 32;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Segoe UI", 14F);
            lblReturnDate.Location = new Point(104, 214);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(111, 25);
            lblReturnDate.TabIndex = 31;
            lblReturnDate.Text = "Return Date";
            // 
            // txtAssociatedTransaction
            // 
            txtAssociatedTransaction.BorderStyle = BorderStyle.FixedSingle;
            txtAssociatedTransaction.Font = new Font("Segoe UI", 14F);
            txtAssociatedTransaction.Location = new Point(282, 123);
            txtAssociatedTransaction.Name = "txtAssociatedTransaction";
            txtAssociatedTransaction.ReadOnly = true;
            txtAssociatedTransaction.Size = new Size(205, 32);
            txtAssociatedTransaction.TabIndex = 30;
            // 
            // lblAssociatedTransaction
            // 
            lblAssociatedTransaction.AutoSize = true;
            lblAssociatedTransaction.Font = new Font("Segoe UI", 14F);
            lblAssociatedTransaction.Location = new Point(58, 127);
            lblAssociatedTransaction.Name = "lblAssociatedTransaction";
            lblAssociatedTransaction.Size = new Size(203, 25);
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
            btnSaveChages.Location = new Point(693, 385);
            btnSaveChages.Margin = new Padding(0);
            btnSaveChages.Name = "btnSaveChages";
            btnSaveChages.Size = new Size(223, 48);
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
            btnBack.Location = new Point(36, 26);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 44);
            btnBack.TabIndex = 27;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblEditReturnRecords
            // 
            lblEditReturnRecords.AutoSize = true;
            lblEditReturnRecords.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblEditReturnRecords.ForeColor = Color.FromArgb(135, 66, 62);
            lblEditReturnRecords.Location = new Point(353, 39);
            lblEditReturnRecords.Name = "lblEditReturnRecords";
            lblEditReturnRecords.Size = new Size(302, 42);
            lblEditReturnRecords.TabIndex = 26;
            lblEditReturnRecords.Text = "Edit Return Records";
            // 
            // lblLateReturnPenaltyErr
            // 
            lblLateReturnPenaltyErr.AutoSize = true;
            lblLateReturnPenaltyErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLateReturnPenaltyErr.ForeColor = Color.Red;
            lblLateReturnPenaltyErr.Location = new Point(752, 160);
            lblLateReturnPenaltyErr.Name = "lblLateReturnPenaltyErr";
            lblLateReturnPenaltyErr.Size = new Size(0, 15);
            lblLateReturnPenaltyErr.TabIndex = 48;
            // 
            // lblAdditionalChargesErr
            // 
            lblAdditionalChargesErr.AutoSize = true;
            lblAdditionalChargesErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAdditionalChargesErr.ForeColor = Color.Red;
            lblAdditionalChargesErr.Location = new Point(752, 247);
            lblAdditionalChargesErr.Name = "lblAdditionalChargesErr";
            lblAdditionalChargesErr.Size = new Size(0, 15);
            lblAdditionalChargesErr.TabIndex = 49;
            // 
            // EditReturnRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(lblAdditionalChargesErr);
            Controls.Add(lblLateReturnPenaltyErr);
            Controls.Add(txtAdditionalCharge);
            Controls.Add(txtLateReturnPenalty);
            Controls.Add(btnUpload);
            Controls.Add(lblAdditionalDocument);
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
            Name = "EditReturnRecord";
            Text = "EditReturnRecord";
            Load += EditReturnRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdditionalCharge;
        private TextBox txtLateReturnPenalty;
        private Button btnUpload;
        private Label lblAdditionalDocument;
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
    }
}