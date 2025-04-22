namespace RentOpsDesktop
{
    partial class ChooseEquipment
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
            lblTitle = new Label();
            btnBack = new Button();
            dgvReturnRecords = new DataGridView();
            btnAddRentalTransaction = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(365, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(434, 62);
            lblTitle.TabIndex = 86;
            lblTitle.Text = "Choose Equipment";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(56, 33);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(173, 46);
            btnBack.TabIndex = 85;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // dgvReturnRecords
            // 
            dgvReturnRecords.BackgroundColor = Color.WhiteSmoke;
            dgvReturnRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnRecords.Location = new Point(56, 129);
            dgvReturnRecords.Margin = new Padding(3, 4, 3, 4);
            dgvReturnRecords.Name = "dgvReturnRecords";
            dgvReturnRecords.RowHeadersWidth = 62;
            dgvReturnRecords.Size = new Size(966, 384);
            dgvReturnRecords.TabIndex = 87;
            // 
            // btnAddRentalTransaction
            // 
            btnAddRentalTransaction.BackColor = Color.FromArgb(121, 86, 76);
            btnAddRentalTransaction.FlatStyle = FlatStyle.Flat;
            btnAddRentalTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRentalTransaction.ForeColor = Color.White;
            btnAddRentalTransaction.Location = new Point(897, 541);
            btnAddRentalTransaction.Margin = new Padding(3, 2, 3, 2);
            btnAddRentalTransaction.Name = "btnAddRentalTransaction";
            btnAddRentalTransaction.Size = new Size(175, 46);
            btnAddRentalTransaction.TabIndex = 95;
            btnAddRentalTransaction.Text = "Next";
            btnAddRentalTransaction.UseVisualStyleBackColor = false;
            // 
            // ChooseEquipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 610);
            Controls.Add(btnAddRentalTransaction);
            Controls.Add(dgvReturnRecords);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Name = "ChooseEquipment";
            Text = "ChooseEquipment";
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnBack;
        private DataGridView dgvReturnRecords;
        private Button btnAddRentalTransaction;
    }
}