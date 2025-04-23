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
            lblRentalDashboard = new Label();
            lstStatus = new ListBox();
            lblRequestDetails = new Label();
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
            btnUpdate.Location = new Point(265, 483);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(212, 52);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblRentalDashboard
            // 
            lblRentalDashboard.AutoSize = true;
            lblRentalDashboard.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblRentalDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            lblRentalDashboard.Location = new Point(122, 30);
            lblRentalDashboard.Name = "lblRentalDashboard";
            lblRentalDashboard.Size = new Size(562, 52);
            lblRentalDashboard.TabIndex = 22;
            lblRentalDashboard.Text = "Update Rental Request Status";
            // 
            // lstStatus
            // 
            lstStatus.FormattingEnabled = true;
            lstStatus.Location = new Point(564, 119);
            lstStatus.Margin = new Padding(2);
            lstStatus.Name = "lstStatus";
            lstStatus.Size = new Size(178, 104);
            lstStatus.TabIndex = 27;
            // 
            // lblRequestDetails
            // 
            lblRequestDetails.AutoSize = true;
            lblRequestDetails.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRequestDetails.Location = new Point(62, 119);
            lblRequestDetails.Name = "lblRequestDetails";
            lblRequestDetails.Size = new Size(181, 31);
            lblRequestDetails.TabIndex = 28;
            lblRequestDetails.Text = "lblRequestDetails";
            // 
            // UpdateRequestStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 560);
            Controls.Add(lblRequestDetails);
            Controls.Add(lstStatus);
            Controls.Add(btnUpdate);
            Controls.Add(lblRentalDashboard);
            Margin = new Padding(2);
            Name = "UpdateRequestStatus";
            Text = "UpdateRequestStatus";
            Load += UpdateRequestStatus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label lblRentalDashboard;
        private ListBox lstStatus;
        private Label lblRequestDetails;
    }
}