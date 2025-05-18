namespace RentOpsDesktop
{
    partial class AddReturnRecord
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
            btnAdd = new Button();
            btnBack = new Button();
            lblAddReturnRecords = new Label();
            lblAssociatedTransaction = new Label();
            lblReturnDate = new Label();
            dtpReturnDate = new DateTimePicker();
            lblReturnCondition = new Label();
            cmbReturnCondition = new ComboBox();
            lblLateReturnPenalty = new Label();
            lblAdditionalCharge = new Label();
            lblAdditionalDocument = new Label();
            btnUpload = new Button();
            txtLateReturnPenalty = new TextBox();
            txtAdditionalCharge = new TextBox();
            lblAdditionalChargesErr = new Label();
            lblLateReturnPenaltyErr = new Label();
            lblFilename = new Label();
            lblTransctionIDError = new Label();
            cmbAssociatedTransaction = new ComboBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(121, 86, 76);
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(241, 240, 234);
            btnAdd.Location = new Point(677, 376);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(223, 48);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add Record";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(20, 17);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 44);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblAddReturnRecords
            // 
            lblAddReturnRecords.AutoSize = true;
            lblAddReturnRecords.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblAddReturnRecords.ForeColor = Color.FromArgb(135, 66, 62);
            lblAddReturnRecords.Location = new Point(337, 30);
            lblAddReturnRecords.Name = "lblAddReturnRecords";
            lblAddReturnRecords.Size = new Size(304, 42);
            lblAddReturnRecords.TabIndex = 11;
            lblAddReturnRecords.Text = "Add Return Records";
            // 
            // lblAssociatedTransaction
            // 
            lblAssociatedTransaction.AutoSize = true;
            lblAssociatedTransaction.Font = new Font("Segoe UI", 14F);
            lblAssociatedTransaction.Location = new Point(20, 133);
            lblAssociatedTransaction.Name = "lblAssociatedTransaction";
            lblAssociatedTransaction.Size = new Size(203, 25);
            lblAssociatedTransaction.TabIndex = 14;
            lblAssociatedTransaction.Text = "Associated Transaction";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Segoe UI", 14F);
            lblReturnDate.Location = new Point(45, 205);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(111, 25);
            lblReturnDate.TabIndex = 16;
            lblReturnDate.Text = "Return Date";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.CalendarFont = new Font("Segoe UI", 14F);
            dtpReturnDate.Font = new Font("Segoe UI", 12F);
            dtpReturnDate.Location = new Point(266, 207);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(199, 29);
            dtpReturnDate.TabIndex = 17;
            // 
            // lblReturnCondition
            // 
            lblReturnCondition.AutoSize = true;
            lblReturnCondition.Font = new Font("Segoe UI", 14F);
            lblReturnCondition.Location = new Point(510, 288);
            lblReturnCondition.Name = "lblReturnCondition";
            lblReturnCondition.Size = new Size(155, 25);
            lblReturnCondition.TabIndex = 18;
            lblReturnCondition.Text = "Return Condition";
            // 
            // cmbReturnCondition
            // 
            cmbReturnCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReturnCondition.Font = new Font("Segoe UI", 14F);
            cmbReturnCondition.FormattingEnabled = true;
            cmbReturnCondition.Location = new Point(705, 285);
            cmbReturnCondition.Name = "cmbReturnCondition";
            cmbReturnCondition.Size = new Size(199, 33);
            cmbReturnCondition.TabIndex = 19;
            cmbReturnCondition.SelectedIndexChanged += cmbReturnCondition_SelectedIndexChanged;
            // 
            // lblLateReturnPenalty
            // 
            lblLateReturnPenalty.AutoSize = true;
            lblLateReturnPenalty.Font = new Font("Segoe UI", 14F);
            lblLateReturnPenalty.Location = new Point(506, 133);
            lblLateReturnPenalty.Name = "lblLateReturnPenalty";
            lblLateReturnPenalty.Size = new Size(173, 25);
            lblLateReturnPenalty.TabIndex = 20;
            lblLateReturnPenalty.Text = "Late Return Penalty";
            // 
            // lblAdditionalCharge
            // 
            lblAdditionalCharge.AutoSize = true;
            lblAdditionalCharge.Font = new Font("Segoe UI", 14F);
            lblAdditionalCharge.Location = new Point(510, 207);
            lblAdditionalCharge.Name = "lblAdditionalCharge";
            lblAdditionalCharge.Size = new Size(165, 25);
            lblAdditionalCharge.TabIndex = 21;
            lblAdditionalCharge.Text = "Additional Charge";
            lblAdditionalCharge.Click += label2_Click;
            // 
            // lblAdditionalDocument
            // 
            lblAdditionalDocument.AutoSize = true;
            lblAdditionalDocument.Font = new Font("Segoe UI", 14F);
            lblAdditionalDocument.Location = new Point(44, 293);
            lblAdditionalDocument.Name = "lblAdditionalDocument";
            lblAdditionalDocument.Size = new Size(142, 25);
            lblAdditionalDocument.TabIndex = 22;
            lblAdditionalDocument.Text = "Damage Report";
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(121, 86, 76);
            btnUpload.BackgroundImageLayout = ImageLayout.None;
            btnUpload.FlatAppearance.BorderSize = 2;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnUpload.ForeColor = Color.FromArgb(241, 240, 234);
            btnUpload.Location = new Point(266, 288);
            btnUpload.Margin = new Padding(0);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(178, 37);
            btnUpload.TabIndex = 23;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtLateReturnPenalty
            // 
            txtLateReturnPenalty.BorderStyle = BorderStyle.FixedSingle;
            txtLateReturnPenalty.Font = new Font("Segoe UI", 14F);
            txtLateReturnPenalty.Location = new Point(705, 133);
            txtLateReturnPenalty.Name = "txtLateReturnPenalty";
            txtLateReturnPenalty.Size = new Size(199, 32);
            txtLateReturnPenalty.TabIndex = 24;
            txtLateReturnPenalty.TextChanged += txtLateReturnPenalty_TextChanged;
            // 
            // txtAdditionalCharge
            // 
            txtAdditionalCharge.BorderStyle = BorderStyle.FixedSingle;
            txtAdditionalCharge.Font = new Font("Segoe UI", 14F);
            txtAdditionalCharge.Location = new Point(705, 203);
            txtAdditionalCharge.Name = "txtAdditionalCharge";
            txtAdditionalCharge.Size = new Size(199, 32);
            txtAdditionalCharge.TabIndex = 25;
            txtAdditionalCharge.TextChanged += txtAdditionalCharge_TextChanged;
            // 
            // lblAdditionalChargesErr
            // 
            lblAdditionalChargesErr.AutoSize = true;
            lblAdditionalChargesErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAdditionalChargesErr.ForeColor = Color.Red;
            lblAdditionalChargesErr.Location = new Point(713, 232);
            lblAdditionalChargesErr.Name = "lblAdditionalChargesErr";
            lblAdditionalChargesErr.Size = new Size(0, 15);
            lblAdditionalChargesErr.TabIndex = 52;
            // 
            // lblLateReturnPenaltyErr
            // 
            lblLateReturnPenaltyErr.AutoSize = true;
            lblLateReturnPenaltyErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLateReturnPenaltyErr.ForeColor = Color.Red;
            lblLateReturnPenaltyErr.Location = new Point(713, 163);
            lblLateReturnPenaltyErr.Name = "lblLateReturnPenaltyErr";
            lblLateReturnPenaltyErr.Size = new Size(0, 15);
            lblLateReturnPenaltyErr.TabIndex = 51;
            // 
            // lblFilename
            // 
            lblFilename.AutoSize = true;
            lblFilename.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFilename.ForeColor = Color.Green;
            lblFilename.Location = new Point(266, 336);
            lblFilename.Name = "lblFilename";
            lblFilename.Size = new Size(74, 60);
            lblFilename.TabIndex = 53;
            lblFilename.Text = "filename\r\nuploaded\r\n\r\n";
            // 
            // lblTransctionIDError
            // 
            lblTransctionIDError.AutoSize = true;
            lblTransctionIDError.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTransctionIDError.ForeColor = Color.Red;
            lblTransctionIDError.Location = new Point(273, 163);
            lblTransctionIDError.Name = "lblTransctionIDError";
            lblTransctionIDError.Size = new Size(0, 15);
            lblTransctionIDError.TabIndex = 54;
            lblTransctionIDError.TextChanged += lblTransctionIDError_TextChanged;
            // 
            // cmbAssociatedTransaction
            // 
            cmbAssociatedTransaction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssociatedTransaction.Font = new Font("Segoe UI", 12F);
            cmbAssociatedTransaction.FormattingEnabled = true;
            cmbAssociatedTransaction.Location = new Point(241, 131);
            cmbAssociatedTransaction.Name = "cmbAssociatedTransaction";
            cmbAssociatedTransaction.Size = new Size(236, 29);
            cmbAssociatedTransaction.TabIndex = 55;
            // 
            // AddReturnRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(cmbAssociatedTransaction);
            Controls.Add(lblTransctionIDError);
            Controls.Add(lblFilename);
            Controls.Add(lblAdditionalChargesErr);
            Controls.Add(lblLateReturnPenaltyErr);
            Controls.Add(txtAdditionalCharge);
            Controls.Add(txtLateReturnPenalty);
            Controls.Add(btnUpload);
            Controls.Add(lblAdditionalDocument);
            Controls.Add(lblAdditionalCharge);
            Controls.Add(lblLateReturnPenalty);
            Controls.Add(cmbReturnCondition);
            Controls.Add(lblReturnCondition);
            Controls.Add(dtpReturnDate);
            Controls.Add(lblReturnDate);
            Controls.Add(lblAssociatedTransaction);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(lblAddReturnRecords);
            Name = "AddReturnRecord";
            Text = "AddReturnRecord";
            Load += AddReturnRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnBack;
        private Label lblAddReturnRecords;
        private Label lblAssociatedTransaction;
        private Label lblReturnDate;
        private DateTimePicker dtpReturnDate;
        private Label lblReturnCondition;
        private ComboBox cmbReturnCondition;
        private Label lblLateReturnPenalty;
        private Label lblAdditionalCharge;
        private Label lblAdditionalDocument;
        private Button btnUpload;
        private TextBox txtLateReturnPenalty;
        private TextBox txtAdditionalCharge;
        private Label lblAdditionalChargesErr;
        private Label lblLateReturnPenaltyErr;
        private Label lblFilename;
        private Label lblTransctionIDError;
        private ComboBox cmbAssociatedTransaction;
    }
}