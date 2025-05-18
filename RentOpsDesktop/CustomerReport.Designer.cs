namespace RentOpsDesktop
{
    partial class CustomerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReport));
            lblCustomersReport = new Label();
            btnBack = new Button();
            btnGenerateCustomerReport = new Button();
            lblInstruction = new Label();
            label1 = new Label();
            cmbCustomerReports = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // lblCustomersReport
            // 
            lblCustomersReport.AutoSize = true;
            lblCustomersReport.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblCustomersReport.ForeColor = Color.FromArgb(135, 66, 62);
            lblCustomersReport.Location = new Point(357, 23);
            lblCustomersReport.Name = "lblCustomersReport";
            lblCustomersReport.Size = new Size(276, 42);
            lblCustomersReport.TabIndex = 3;
            lblCustomersReport.Text = "Customers Report";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(23, 21);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 44);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnGenerateCustomerReport
            // 
            btnGenerateCustomerReport.BackColor = Color.FromArgb(121, 86, 76);
            btnGenerateCustomerReport.BackgroundImageLayout = ImageLayout.None;
            btnGenerateCustomerReport.FlatAppearance.BorderSize = 0;
            btnGenerateCustomerReport.FlatStyle = FlatStyle.Flat;
            btnGenerateCustomerReport.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateCustomerReport.ForeColor = Color.FromArgb(241, 240, 234);
            btnGenerateCustomerReport.Location = new Point(609, 171);
            btnGenerateCustomerReport.Margin = new Padding(0);
            btnGenerateCustomerReport.Name = "btnGenerateCustomerReport";
            btnGenerateCustomerReport.Size = new Size(281, 61);
            btnGenerateCustomerReport.TabIndex = 15;
            btnGenerateCustomerReport.Text = "Generate Customers Report";
            btnGenerateCustomerReport.UseVisualStyleBackColor = false;
            btnGenerateCustomerReport.Click += btnGenerateCustomerReport_Click;
            // 
            // lblInstruction
            // 
            lblInstruction.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInstruction.ForeColor = SystemColors.ControlDarkDark;
            lblInstruction.Location = new Point(60, 181);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(539, 98);
            lblInstruction.TabIndex = 16;
            lblInstruction.Text = resources.GetString("lblInstruction.Text");
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(36, 147);
            label1.Name = "label1";
            label1.Size = new Size(530, 25);
            label1.TabIndex = 17;
            label1.Text = " This report provides a detailed overview of all registered customers, including:\r\n";
            // 
            // cmbCustomerReports
            // 
            cmbCustomerReports.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomerReports.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            cmbCustomerReports.FormattingEnabled = true;
            cmbCustomerReports.Location = new Point(560, 332);
            cmbCustomerReports.Name = "cmbCustomerReports";
            cmbCustomerReports.Size = new Size(330, 33);
            cmbCustomerReports.TabIndex = 18;
            cmbCustomerReports.SelectedIndexChanged += cmbCustomerReports_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(118, 345);
            label2.Name = "label2";
            label2.Size = new Size(357, 25);
            label2.TabIndex = 19;
            label2.Text = "Choose a report that is generated previously to view.";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 111);
            label3.Name = "label3";
            label3.Size = new Size(230, 25);
            label3.TabIndex = 20;
            label3.Text = "Generate a Customer Report";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 320);
            label4.Name = "label4";
            label4.Size = new Size(351, 25);
            label4.TabIndex = 21;
            label4.Text = "View previously generated Customer Reports";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = SystemColors.ControlDarkDark;
            progressBar1.Location = new Point(560, 387);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(330, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 22;
            progressBar1.Visible = false;
            // 
            // CustomerReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCustomerReports);
            Controls.Add(label1);
            Controls.Add(lblInstruction);
            Controls.Add(btnGenerateCustomerReport);
            Controls.Add(btnBack);
            Controls.Add(lblCustomersReport);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerReport";
            Text = "CustomerReport";
            Load += CustomerReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomersReport;
        private Button btnBack;
        private Button btnGenerateCustomerReport;
        private Label lblInstruction;
        private Label label1;
        private ComboBox cmbCustomerReports;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
    }
}