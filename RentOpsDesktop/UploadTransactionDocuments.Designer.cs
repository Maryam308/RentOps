namespace RentOpsDesktop
{
    partial class UploadTransactionDocuments
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
            btnBack = new Button();
            lblTitle = new Label();
            gbIdentityVerification = new GroupBox();
            btnRemoveIDDecument = new Button();
            btnDownloadIDDocument = new Button();
            lblIDFilename = new Label();
            btnUploadIDVerificationDocuments = new Button();
            label1 = new Label();
            gbRentalAgreement = new GroupBox();
            btnRemoveAgreementDocument = new Button();
            lblAgreementFilename = new Label();
            btnDownloadAgreementDocument = new Button();
            btnUploadREntalAgreement = new Button();
            label3 = new Label();
            btnAdd = new Button();
            gbIdentityVerification.SuspendLayout();
            gbRentalAgreement.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(24, 24);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(177, 59);
            btnBack.TabIndex = 84;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(274, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(689, 50);
            lblTitle.TabIndex = 85;
            lblTitle.Text = "Upload Rental Transaction Documents";
            // 
            // gbIdentityVerification
            // 
            gbIdentityVerification.Controls.Add(btnRemoveIDDecument);
            gbIdentityVerification.Controls.Add(btnDownloadIDDocument);
            gbIdentityVerification.Controls.Add(lblIDFilename);
            gbIdentityVerification.Controls.Add(btnUploadIDVerificationDocuments);
            gbIdentityVerification.Controls.Add(label1);
            gbIdentityVerification.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbIdentityVerification.Location = new Point(130, 145);
            gbIdentityVerification.Margin = new Padding(2, 1, 2, 1);
            gbIdentityVerification.Name = "gbIdentityVerification";
            gbIdentityVerification.Padding = new Padding(2, 1, 2, 1);
            gbIdentityVerification.Size = new Size(874, 167);
            gbIdentityVerification.TabIndex = 86;
            gbIdentityVerification.TabStop = false;
            gbIdentityVerification.Text = "Upload Identity Verificaton Document";
            // 
            // btnRemoveIDDecument
            // 
            btnRemoveIDDecument.BackColor = Color.FromArgb(121, 86, 76);
            btnRemoveIDDecument.FlatStyle = FlatStyle.Flat;
            btnRemoveIDDecument.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveIDDecument.ForeColor = Color.White;
            btnRemoveIDDecument.Location = new Point(610, 96);
            btnRemoveIDDecument.Name = "btnRemoveIDDecument";
            btnRemoveIDDecument.Size = new Size(113, 51);
            btnRemoveIDDecument.TabIndex = 114;
            btnRemoveIDDecument.Text = "Remove";
            btnRemoveIDDecument.UseVisualStyleBackColor = false;
            btnRemoveIDDecument.Click += btnRemoveIDDecument_Click;
            // 
            // btnDownloadIDDocument
            // 
            btnDownloadIDDocument.BackColor = Color.FromArgb(121, 86, 76);
            btnDownloadIDDocument.FlatStyle = FlatStyle.Flat;
            btnDownloadIDDocument.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownloadIDDocument.ForeColor = Color.White;
            btnDownloadIDDocument.Location = new Point(741, 96);
            btnDownloadIDDocument.Name = "btnDownloadIDDocument";
            btnDownloadIDDocument.Size = new Size(113, 51);
            btnDownloadIDDocument.TabIndex = 113;
            btnDownloadIDDocument.Text = "Download";
            btnDownloadIDDocument.UseVisualStyleBackColor = false;
            btnDownloadIDDocument.Click += btnDownloadIDDocument_Click;
            // 
            // lblIDFilename
            // 
            lblIDFilename.AutoSize = true;
            lblIDFilename.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            lblIDFilename.ForeColor = Color.Green;
            lblIDFilename.Location = new Point(288, 67);
            lblIDFilename.Name = "lblIDFilename";
            lblIDFilename.Size = new Size(0, 23);
            lblIDFilename.TabIndex = 112;
            // 
            // btnUploadIDVerificationDocuments
            // 
            btnUploadIDVerificationDocuments.BackColor = Color.FromArgb(121, 86, 76);
            btnUploadIDVerificationDocuments.FlatStyle = FlatStyle.Flat;
            btnUploadIDVerificationDocuments.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadIDVerificationDocuments.ForeColor = Color.White;
            btnUploadIDVerificationDocuments.Location = new Point(610, 33);
            btnUploadIDVerificationDocuments.Name = "btnUploadIDVerificationDocuments";
            btnUploadIDVerificationDocuments.Size = new Size(243, 51);
            btnUploadIDVerificationDocuments.TabIndex = 111;
            btnUploadIDVerificationDocuments.Text = "Upload";
            btnUploadIDVerificationDocuments.UseVisualStyleBackColor = false;
            btnUploadIDVerificationDocuments.Click += btnUploadIDVerificationDocuments_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 57);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 41);
            label1.TabIndex = 0;
            label1.Text = "Identity Verification: ";
            // 
            // gbRentalAgreement
            // 
            gbRentalAgreement.Controls.Add(btnRemoveAgreementDocument);
            gbRentalAgreement.Controls.Add(lblAgreementFilename);
            gbRentalAgreement.Controls.Add(btnDownloadAgreementDocument);
            gbRentalAgreement.Controls.Add(btnUploadREntalAgreement);
            gbRentalAgreement.Controls.Add(label3);
            gbRentalAgreement.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbRentalAgreement.Location = new Point(130, 344);
            gbRentalAgreement.Margin = new Padding(2, 1, 2, 1);
            gbRentalAgreement.Name = "gbRentalAgreement";
            gbRentalAgreement.Padding = new Padding(2, 1, 2, 1);
            gbRentalAgreement.Size = new Size(874, 167);
            gbRentalAgreement.TabIndex = 113;
            gbRentalAgreement.TabStop = false;
            gbRentalAgreement.Text = "Upload Rental Agreement Document";
            // 
            // btnRemoveAgreementDocument
            // 
            btnRemoveAgreementDocument.BackColor = Color.FromArgb(121, 86, 76);
            btnRemoveAgreementDocument.FlatStyle = FlatStyle.Flat;
            btnRemoveAgreementDocument.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveAgreementDocument.ForeColor = Color.White;
            btnRemoveAgreementDocument.Location = new Point(610, 92);
            btnRemoveAgreementDocument.Name = "btnRemoveAgreementDocument";
            btnRemoveAgreementDocument.Size = new Size(113, 51);
            btnRemoveAgreementDocument.TabIndex = 116;
            btnRemoveAgreementDocument.Text = "Remove";
            btnRemoveAgreementDocument.UseVisualStyleBackColor = false;
            btnRemoveAgreementDocument.Click += btnRemoveAgreementDocument_Click;
            // 
            // lblAgreementFilename
            // 
            lblAgreementFilename.AutoSize = true;
            lblAgreementFilename.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgreementFilename.ForeColor = Color.Green;
            lblAgreementFilename.Location = new Point(274, 67);
            lblAgreementFilename.Name = "lblAgreementFilename";
            lblAgreementFilename.Size = new Size(0, 23);
            lblAgreementFilename.TabIndex = 112;
            // 
            // btnDownloadAgreementDocument
            // 
            btnDownloadAgreementDocument.BackColor = Color.FromArgb(121, 86, 76);
            btnDownloadAgreementDocument.FlatStyle = FlatStyle.Flat;
            btnDownloadAgreementDocument.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownloadAgreementDocument.ForeColor = Color.White;
            btnDownloadAgreementDocument.Location = new Point(741, 92);
            btnDownloadAgreementDocument.Name = "btnDownloadAgreementDocument";
            btnDownloadAgreementDocument.Size = new Size(113, 51);
            btnDownloadAgreementDocument.TabIndex = 115;
            btnDownloadAgreementDocument.Text = "Download";
            btnDownloadAgreementDocument.UseVisualStyleBackColor = false;
            btnDownloadAgreementDocument.Click += btnDownloadAgreementDocument_Click;
            // 
            // btnUploadREntalAgreement
            // 
            btnUploadREntalAgreement.BackColor = Color.FromArgb(121, 86, 76);
            btnUploadREntalAgreement.FlatStyle = FlatStyle.Flat;
            btnUploadREntalAgreement.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadREntalAgreement.ForeColor = Color.White;
            btnUploadREntalAgreement.Location = new Point(610, 36);
            btnUploadREntalAgreement.Name = "btnUploadREntalAgreement";
            btnUploadREntalAgreement.Size = new Size(243, 51);
            btnUploadREntalAgreement.TabIndex = 111;
            btnUploadREntalAgreement.Text = "Upload";
            btnUploadREntalAgreement.UseVisualStyleBackColor = false;
            btnUploadREntalAgreement.Click += btnUploadREntalAgreement_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 57);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(263, 41);
            label3.TabIndex = 0;
            label3.Text = "Rental Agreement:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(121, 86, 76);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(883, 532);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(183, 55);
            btnAdd.TabIndex = 113;
            btnAdd.Text = "Done";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // UploadTransactionDocuments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 611);
            Controls.Add(btnAdd);
            Controls.Add(gbRentalAgreement);
            Controls.Add(gbIdentityVerification);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Margin = new Padding(2, 1, 2, 1);
            Name = "UploadTransactionDocuments";
            Text = "UploadTransactionDocuments";
            gbIdentityVerification.ResumeLayout(false);
            gbIdentityVerification.PerformLayout();
            gbRentalAgreement.ResumeLayout(false);
            gbRentalAgreement.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblTitle;
        private GroupBox gbIdentityVerification;
        private Label label1;
        private Button btnUploadIDVerificationDocuments;
        private Label lblIDFilename;
        private GroupBox gbRentalAgreement;
        private Label lblAgreementFilename;
        private Button btnUploadREntalAgreement;
        private Label label3;
        private Button btnAdd;
        private Button btnDownloadIDDocument;
        private Button btnRemoveIDDecument;
        private Button btnRemoveAgreementDocument;
        private Button btnDownloadAgreementDocument;
    }
}