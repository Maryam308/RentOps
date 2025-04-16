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
            btnReturnReports = new Button();
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
            // 
            // btnReturnReports
            // 
            btnReturnReports.BackColor = Color.FromArgb(121, 86, 76);
            btnReturnReports.BackgroundImageLayout = ImageLayout.None;
            btnReturnReports.FlatAppearance.BorderSize = 0;
            btnReturnReports.FlatStyle = FlatStyle.Flat;
            btnReturnReports.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReturnReports.ForeColor = Color.FromArgb(241, 240, 234);
            btnReturnReports.Location = new Point(516, 159);
            btnReturnReports.Margin = new Padding(0);
            btnReturnReports.Name = "btnReturnReports";
            btnReturnReports.Size = new Size(325, 225);
            btnReturnReports.TabIndex = 15;
            btnReturnReports.Text = "Return Reports";
            btnReturnReports.UseVisualStyleBackColor = false;
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
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(btnBack);
            Controls.Add(btnReturnReports);
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
        private Button btnReturnReports;
        private Button btnBack;
    }
}