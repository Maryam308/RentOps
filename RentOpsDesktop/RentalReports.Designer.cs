namespace RentOpsDesktop
{
    partial class RentalReports
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
            dgvRentalReport = new DataGridView();
            lblRentalReport = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRentalReport).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(62, 38);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(172, 47);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // dgvRentalReport
            // 
            dgvRentalReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalReport.Location = new Point(97, 146);
            dgvRentalReport.Name = "dgvRentalReport";
            dgvRentalReport.RowHeadersWidth = 51;
            dgvRentalReport.Size = new Size(929, 426);
            dgvRentalReport.TabIndex = 10;
            // 
            // lblRentalReport
            // 
            lblRentalReport.AutoSize = true;
            lblRentalReport.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblRentalReport.ForeColor = Color.FromArgb(135, 66, 62);
            lblRentalReport.Location = new Point(432, 38);
            lblRentalReport.Name = "lblRentalReport";
            lblRentalReport.Size = new Size(272, 52);
            lblRentalReport.TabIndex = 9;
            lblRentalReport.Text = "Rental Report";
            // 
            // RentalReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(btnBack);
            Controls.Add(dgvRentalReport);
            Controls.Add(lblRentalReport);
            Name = "RentalReports";
            Text = "RentalReports";
            ((System.ComponentModel.ISupportInitialize)dgvRentalReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private DataGridView dgvRentalReport;
        private Label lblRentalReport;
    }
}