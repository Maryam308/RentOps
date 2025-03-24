namespace RentOpsDesktop
{
    partial class Reports
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
            lblReport = new Label();
            btnCustomerReport = new Button();
            btnRentalReports = new Button();
            SuspendLayout();
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblReport.ForeColor = Color.FromArgb(135, 66, 62);
            lblReport.Location = new Point(459, 27);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(160, 52);
            lblReport.TabIndex = 2;
            lblReport.Text = "Reports";
            // 
            // btnCustomerReport
            // 
            btnCustomerReport.BackColor = Color.FromArgb(139, 128, 116);
            btnCustomerReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomerReport.ForeColor = Color.White;
            btnCustomerReport.Location = new Point(191, 192);
            btnCustomerReport.Name = "btnCustomerReport";
            btnCustomerReport.Size = new Size(315, 273);
            btnCustomerReport.TabIndex = 8;
            btnCustomerReport.Text = "Customers Report";
            btnCustomerReport.UseVisualStyleBackColor = false;
            // 
            // btnRentalReports
            // 
            btnRentalReports.BackColor = Color.FromArgb(139, 128, 116);
            btnRentalReports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRentalReports.ForeColor = Color.White;
            btnRentalReports.Location = new Point(566, 192);
            btnRentalReports.Name = "btnRentalReports";
            btnRentalReports.Size = new Size(315, 273);
            btnRentalReports.TabIndex = 9;
            btnRentalReports.Text = "Rental Reports";
            btnRentalReports.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(btnRentalReports);
            Controls.Add(btnCustomerReport);
            Controls.Add(lblReport);
            Name = "Reports";
            Text = "Reports";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReport;
        private Button btnCustomerReport;
        private Button btnRentalReports;
    }
}