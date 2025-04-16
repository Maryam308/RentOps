namespace RentOpsDesktop
{
    partial class AuditLog
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
            dgvAuditLog = new DataGridView();
            lblAuditLog = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLog).BeginInit();
            SuspendLayout();
            // 
            // dgvAuditLog
            // 
            dgvAuditLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLog.Location = new Point(64, 100);
            dgvAuditLog.Margin = new Padding(3, 2, 3, 2);
            dgvAuditLog.Name = "dgvAuditLog";
            dgvAuditLog.RowHeadersWidth = 51;
            dgvAuditLog.Size = new Size(813, 320);
            dgvAuditLog.TabIndex = 12;
            // 
            // lblAuditLog
            // 
            lblAuditLog.AutoSize = true;
            lblAuditLog.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblAuditLog.ForeColor = Color.FromArgb(135, 66, 62);
            lblAuditLog.Location = new Point(412, 23);
            lblAuditLog.Name = "lblAuditLog";
            lblAuditLog.Size = new Size(160, 42);
            lblAuditLog.TabIndex = 11;
            lblAuditLog.Text = "Audit Log";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(121, 86, 76);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(46, 21);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 44);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // AuditLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(btnBack);
            Controls.Add(dgvAuditLog);
            Controls.Add(lblAuditLog);
            Name = "AuditLog";
            Text = "AuditLog";
            ((System.ComponentModel.ISupportInitialize)dgvAuditLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAuditLog;
        private Label lblAuditLog;
        private Button btnBack;
    }
}