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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalReports));
            lblRentalReport = new Label();
            btnBack = new Button();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbRentalReports = new ComboBox();
            label1 = new Label();
            lblInstruction = new Label();
            btnGenerateRentalReport = new Button();
            dtpPeriodStartDate = new DateTimePicker();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblRentalReport
            // 
            lblRentalReport.AutoSize = true;
            lblRentalReport.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblRentalReport.ForeColor = Color.FromArgb(135, 66, 62);
            lblRentalReport.Location = new Point(378, 28);
            lblRentalReport.Name = "lblRentalReport";
            lblRentalReport.Size = new Size(218, 42);
            lblRentalReport.TabIndex = 9;
            lblRentalReport.Text = "Rental Report";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(42, 28);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 44);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = SystemColors.ControlDarkDark;
            progressBar1.Location = new Point(622, 383);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(281, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 30;
            progressBar1.Visible = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(49, 316);
            label4.Name = "label4";
            label4.Size = new Size(351, 25);
            label4.TabIndex = 29;
            label4.Text = "View previously generated Rental Reports";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(49, 105);
            label3.Name = "label3";
            label3.Size = new Size(230, 25);
            label3.TabIndex = 28;
            label3.Text = "Generate a Rental Report";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(108, 341);
            label2.Name = "label2";
            label2.Size = new Size(357, 25);
            label2.TabIndex = 27;
            label2.Text = "Choose a report that is generated previously to view.";
            // 
            // cmbRentalReports
            // 
            cmbRentalReports.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            cmbRentalReports.FormattingEnabled = true;
            cmbRentalReports.Location = new Point(622, 328);
            cmbRentalReports.Name = "cmbRentalReports";
            cmbRentalReports.Size = new Size(281, 38);
            cmbRentalReports.TabIndex = 26;
            cmbRentalReports.SelectedIndexChanged += cmbRentalReports_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(49, 180);
            label1.Name = "label1";
            label1.Size = new Size(530, 25);
            label1.TabIndex = 25;
            label1.Text = "This report provides a detailed overview of all the rentals, including:\r\n";
            // 
            // lblInstruction
            // 
            lblInstruction.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInstruction.ForeColor = SystemColors.ControlDarkDark;
            lblInstruction.Location = new Point(73, 205);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(523, 98);
            lblInstruction.TabIndex = 24;
            lblInstruction.Text = resources.GetString("lblInstruction.Text");
            // 
            // btnGenerateRentalReport
            // 
            btnGenerateRentalReport.BackColor = Color.FromArgb(121, 86, 76);
            btnGenerateRentalReport.BackgroundImageLayout = ImageLayout.None;
            btnGenerateRentalReport.FlatAppearance.BorderSize = 0;
            btnGenerateRentalReport.FlatStyle = FlatStyle.Flat;
            btnGenerateRentalReport.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateRentalReport.ForeColor = Color.FromArgb(241, 240, 234);
            btnGenerateRentalReport.Location = new Point(622, 197);
            btnGenerateRentalReport.Margin = new Padding(0);
            btnGenerateRentalReport.Name = "btnGenerateRentalReport";
            btnGenerateRentalReport.Size = new Size(281, 61);
            btnGenerateRentalReport.TabIndex = 23;
            btnGenerateRentalReport.Text = "Generate Rental Report";
            btnGenerateRentalReport.UseVisualStyleBackColor = false;
            btnGenerateRentalReport.Click += btnGenerateRentalReport_Click;
            // 
            // dtpPeriodStartDate
            // 
            dtpPeriodStartDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPeriodStartDate.Location = new Point(637, 143);
            dtpPeriodStartDate.Name = "dtpPeriodStartDate";
            dtpPeriodStartDate.ShowCheckBox = true;
            dtpPeriodStartDate.Size = new Size(246, 33);
            dtpPeriodStartDate.TabIndex = 31;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(49, 134);
            label5.Name = "label5";
            label5.Size = new Size(530, 41);
            label5.TabIndex = 32;
            label5.Text = "If you selected a date then records for the following 2 weeks will be generated, else the last 10 rentals in the system will be generated.";
            // 
            // RentalReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(label5);
            Controls.Add(dtpPeriodStartDate);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbRentalReports);
            Controls.Add(label1);
            Controls.Add(lblInstruction);
            Controls.Add(btnGenerateRentalReport);
            Controls.Add(btnBack);
            Controls.Add(lblRentalReport);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RentalReports";
            Text = "RentalReports";
            Load += RentalReports_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRentalReport;
        private Button btnBack;
        private ProgressBar progressBar1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbRentalReports;
        private Label label1;
        private Label lblInstruction;
        private Button btnGenerateRentalReport;
        private DateTimePicker dtpPeriodStartDate;
        private Label label5;
    }
}