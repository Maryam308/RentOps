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
            ((System.ComponentModel.ISupportInitialize)dgvCustomersReport).BeginInit();
            SuspendLayout();
            // 
            // lblCustomersReport
            // 
            lblCustomersReport.AutoSize = true;
            lblCustomersReport.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblCustomersReport.ForeColor = Color.FromArgb(135, 66, 62);
            lblCustomersReport.Location = new Point(366, 31);
            lblCustomersReport.Name = "lblCustomersReport";
            lblCustomersReport.Size = new Size(345, 52);
            lblCustomersReport.TabIndex = 3;
            lblCustomersReport.Text = "Customers Report";
            // 
            // dgvCustomersReport
            // 
            dgvCustomersReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomersReport.Location = new Point(77, 139);
            dgvCustomersReport.Name = "dgvCustomersReport";
            dgvCustomersReport.RowHeadersWidth = 51;
            dgvCustomersReport.Size = new Size(929, 426);
            dgvCustomersReport.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(42, 31);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(172, 47);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // CustomerReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(btnBack);
            Controls.Add(dgvCustomersReport);
            Controls.Add(lblCustomersReport);
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
    }
}