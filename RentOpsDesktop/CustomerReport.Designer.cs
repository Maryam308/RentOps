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
            lblCustomersReport = new Label();
            dgvCustomersReport = new DataGridView();
            btnBack = new Button();
            btnGenerateCustomerReport = new Button();
            lblInstruction = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersReport).BeginInit();
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
            // dgvCustomersReport
            // 
            dgvCustomersReport.BackgroundColor = Color.WhiteSmoke;
            dgvCustomersReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomersReport.Location = new Point(480, 106);
            dgvCustomersReport.Margin = new Padding(3, 2, 3, 2);
            dgvCustomersReport.Name = "dgvCustomersReport";
            dgvCustomersReport.RowHeadersWidth = 51;
            dgvCustomersReport.Size = new Size(410, 320);
            dgvCustomersReport.TabIndex = 4;
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
            // 
            // btnGenerateCustomerReport
            // 
            btnGenerateCustomerReport.BackColor = Color.FromArgb(121, 86, 76);
            btnGenerateCustomerReport.BackgroundImageLayout = ImageLayout.None;
            btnGenerateCustomerReport.FlatAppearance.BorderSize = 0;
            btnGenerateCustomerReport.FlatStyle = FlatStyle.Flat;
            btnGenerateCustomerReport.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateCustomerReport.ForeColor = Color.FromArgb(241, 240, 234);
            btnGenerateCustomerReport.Location = new Point(97, 137);
            btnGenerateCustomerReport.Margin = new Padding(0);
            btnGenerateCustomerReport.Name = "btnGenerateCustomerReport";
            btnGenerateCustomerReport.Size = new Size(281, 61);
            btnGenerateCustomerReport.TabIndex = 15;
            btnGenerateCustomerReport.Text = "Generate Customers Report";
            btnGenerateCustomerReport.UseVisualStyleBackColor = false;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lblInstruction.ForeColor = SystemColors.ControlDarkDark;
            lblInstruction.Location = new Point(43, 226);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(303, 19);
            lblInstruction.TabIndex = 16;
            lblInstruction.Text = "The report generated contain data about the ...";
            // 
            // CustomerReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(lblInstruction);
            Controls.Add(btnGenerateCustomerReport);
            Controls.Add(btnBack);
            Controls.Add(dgvCustomersReport);
            Controls.Add(lblCustomersReport);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerReport";
            Text = "CustomerReport";
            ((System.ComponentModel.ISupportInitialize)dgvCustomersReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomersReport;
        private DataGridView dgvCustomersReport;
        private Button btnBack;
        private Button btnGenerateCustomerReport;
        private Label lblInstruction;
    }
}