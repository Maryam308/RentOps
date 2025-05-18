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
            btnCustomerReports = new Button();
            btnRentalHistoryReports = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Font = new Font("Segoe UI", 32F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblReport.ForeColor = Color.FromArgb(135, 66, 62);
            lblReport.Location = new Point(377, 51);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(177, 59);
            lblReport.TabIndex = 2;
            lblReport.Text = "Reports";
            // 
            // btnCustomerReports
            // 
            btnCustomerReports.BackColor = Color.FromArgb(121, 86, 76);
            btnCustomerReports.BackgroundImageLayout = ImageLayout.None;
            btnCustomerReports.FlatAppearance.BorderSize = 0;
            btnCustomerReports.FlatStyle = FlatStyle.Flat;
            btnCustomerReports.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic);
            btnCustomerReports.ForeColor = Color.FromArgb(241, 240, 234);
            btnCustomerReports.Location = new Point(99, 159);
            btnCustomerReports.Margin = new Padding(0);
            btnCustomerReports.Name = "btnCustomerReports";
            btnCustomerReports.Size = new Size(325, 225);
            btnCustomerReports.TabIndex = 14;
            btnCustomerReports.Text = "Customer Reports";
            btnCustomerReports.UseVisualStyleBackColor = false;
            btnCustomerReports.Click += btnCustomerReports_Click;
            // 
            // btnRentalHistoryReports
            // 
            btnRentalHistoryReports.BackColor = Color.FromArgb(121, 86, 76);
            btnRentalHistoryReports.BackgroundImageLayout = ImageLayout.None;
            btnRentalHistoryReports.FlatAppearance.BorderSize = 0;
            btnRentalHistoryReports.FlatStyle = FlatStyle.Flat;
            btnRentalHistoryReports.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRentalHistoryReports.ForeColor = Color.FromArgb(241, 240, 234);
            btnRentalHistoryReports.Location = new Point(516, 159);
            btnRentalHistoryReports.Margin = new Padding(0);
            btnRentalHistoryReports.Name = "btnRentalHistoryReports";
            btnRentalHistoryReports.Size = new Size(325, 225);
            btnRentalHistoryReports.TabIndex = 15;
            btnRentalHistoryReports.Text = "Rental History Reports";
            btnRentalHistoryReports.UseVisualStyleBackColor = false;
            btnRentalHistoryReports.Click += btnRentalHistoryReports_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(30, 31);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 44);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(btnBack);
            Controls.Add(btnRentalHistoryReports);
            Controls.Add(btnCustomerReports);
            Controls.Add(lblReport);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reports";
            Text = "Reports";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReport;
        private Button btnCustomerReports;
        private Button btnRentalHistoryReports;
        private Button btnBack;
    }
}