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
            dgvRentalReport = new DataGridView();
            lblRentalReport = new Label();
            btnBack = new Button();
            btnGenerateRentalReport = new Button();
            lblInstruction = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRentalReport).BeginInit();
            SuspendLayout();
            // 
            // dgvRentalReport
            // 
            dgvRentalReport.BackgroundColor = Color.WhiteSmoke;
            dgvRentalReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalReport.Location = new Point(466, 105);
            dgvRentalReport.Margin = new Padding(3, 2, 3, 2);
            dgvRentalReport.Name = "dgvRentalReport";
            dgvRentalReport.RowHeadersWidth = 51;
            dgvRentalReport.Size = new Size(421, 320);
            dgvRentalReport.TabIndex = 10;
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
            // 
            // btnGenerateRentalReport
            // 
            btnGenerateRentalReport.BackColor = Color.FromArgb(121, 86, 76);
            btnGenerateRentalReport.BackgroundImageLayout = ImageLayout.None;
            btnGenerateRentalReport.FlatAppearance.BorderSize = 0;
            btnGenerateRentalReport.FlatStyle = FlatStyle.Flat;
            btnGenerateRentalReport.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateRentalReport.ForeColor = Color.FromArgb(241, 240, 234);
            btnGenerateRentalReport.Location = new Point(88, 143);
            btnGenerateRentalReport.Margin = new Padding(0);
            btnGenerateRentalReport.Name = "btnGenerateRentalReport";
            btnGenerateRentalReport.Size = new Size(281, 61);
            btnGenerateRentalReport.TabIndex = 14;
            btnGenerateRentalReport.Text = "Generate Rental Report";
            btnGenerateRentalReport.UseVisualStyleBackColor = false;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lblInstruction.ForeColor = SystemColors.ControlDarkDark;
            lblInstruction.Location = new Point(42, 224);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(303, 19);
            lblInstruction.TabIndex = 17;
            lblInstruction.Text = "The report generated contain data about the ...";
            // 
            // RentalReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(lblInstruction);
            Controls.Add(btnGenerateRentalReport);
            Controls.Add(btnBack);
            Controls.Add(dgvRentalReport);
            Controls.Add(lblRentalReport);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RentalReports";
            Text = "RentalReports";
            ((System.ComponentModel.ISupportInitialize)dgvRentalReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvRentalReport;
        private Label lblRentalReport;
        private Button btnBack;
        private Button btnGenerateRentalReport;
        private Label lblInstruction;
    }
}