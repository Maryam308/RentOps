namespace RentOpsDesktop
{
    partial class UpdateRequestStatus
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
            btnUpdate = new Button();
            dgvRentalRequestDetails = new DataGridView();
            lblRentalDashboard = new Label();
            btnBack = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequestDetails).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(121, 86, 76);
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(241, 240, 234);
            btnUpdate.Location = new Point(1009, 619);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(319, 65);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // dgvRentalRequestDetails
            // 
            dgvRentalRequestDetails.BackgroundColor = Color.WhiteSmoke;
            dgvRentalRequestDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalRequestDetails.Location = new Point(88, 204);
            dgvRentalRequestDetails.Margin = new Padding(4, 5, 4, 5);
            dgvRentalRequestDetails.Name = "dgvRentalRequestDetails";
            dgvRentalRequestDetails.RowHeadersWidth = 62;
            dgvRentalRequestDetails.Size = new Size(886, 480);
            dgvRentalRequestDetails.TabIndex = 25;
            // 
            // lblRentalDashboard
            // 
            lblRentalDashboard.AutoSize = true;
            lblRentalDashboard.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblRentalDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            lblRentalDashboard.Location = new Point(471, 40);
            lblRentalDashboard.Margin = new Padding(4, 0, 4, 0);
            lblRentalDashboard.Name = "lblRentalDashboard";
            lblRentalDashboard.Size = new Size(664, 62);
            lblRentalDashboard.TabIndex = 22;
            lblRentalDashboard.Text = "Update Rental Request Status";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(35, 40);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(221, 73);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(1009, 204);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(319, 129);
            listBox1.TabIndex = 27;
            // 
            // UpdateRequestStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 763);
            Controls.Add(listBox1);
            Controls.Add(btnUpdate);
            Controls.Add(dgvRentalRequestDetails);
            Controls.Add(btnBack);
            Controls.Add(lblRentalDashboard);
            Name = "UpdateRequestStatus";
            Text = "UpdateRequestStatus";
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequestDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private DataGridView dgvRentalRequestDetails;
        private Label lblRentalDashboard;
        private Button btnBack;
        private ListBox listBox1;
    }
}