namespace RentOpsDesktop
{
    partial class AddEquipment
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
            btnAddEquipment = new Button();
            cmbConditionStatus = new ComboBox();
            cmbEquipmentCategory = new ComboBox();
            txtRentalPrice = new TextBox();
            txtEquipmentDescription = new TextBox();
            txtEquipmentName = new TextBox();
            lblConditionStatus = new Label();
            lblRentalPrice = new Label();
            lblEquipmentCategory = new Label();
            lblEquipmentDescription = new Label();
            lblEquipmentName = new Label();
            lblTitle = new Label();
            lblEquipmentNameErr = new Label();
            lblEquipmentDescriptionErr = new Label();
            lblEquipmentCategoryErr = new Label();
            lblRentalPriceErr = new Label();
            lblConditionStatusErr = new Label();
            lblAvailabilityStatus = new Label();
            cmbAvailabilityStatus = new ComboBox();
            lblAvailabilityStatusErr = new Label();
            SuspendLayout();
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.BackColor = Color.FromArgb(121, 86, 76);
            btnAddEquipment.FlatStyle = FlatStyle.Flat;
            btnAddEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEquipment.ForeColor = Color.White;
            btnAddEquipment.Location = new Point(761, 384);
            btnAddEquipment.Margin = new Padding(3, 2, 3, 2);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(163, 44);
            btnAddEquipment.TabIndex = 52;
            btnAddEquipment.Text = "Add Equipment";
            btnAddEquipment.UseVisualStyleBackColor = false;
            btnAddEquipment.Click += btnAddEquipment_Click;
            // 
            // cmbConditionStatus
            // 
            cmbConditionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConditionStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbConditionStatus.FormattingEnabled = true;
            cmbConditionStatus.Location = new Point(393, 305);
            cmbConditionStatus.Margin = new Padding(2, 1, 2, 1);
            cmbConditionStatus.Name = "cmbConditionStatus";
            cmbConditionStatus.Size = new Size(327, 29);
            cmbConditionStatus.TabIndex = 51;
            cmbConditionStatus.SelectedIndexChanged += cmbConditionStatus_SelectedIndexChanged;
            cmbConditionStatus.DropDownClosed += cmbConditionStatus_DropDownClosed;
            // 
            // cmbEquipmentCategory
            // 
            cmbEquipmentCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipmentCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEquipmentCategory.FormattingEnabled = true;
            cmbEquipmentCategory.Location = new Point(393, 194);
            cmbEquipmentCategory.Margin = new Padding(2, 1, 2, 1);
            cmbEquipmentCategory.Name = "cmbEquipmentCategory";
            cmbEquipmentCategory.Size = new Size(327, 29);
            cmbEquipmentCategory.TabIndex = 50;
            cmbEquipmentCategory.SelectedIndexChanged += cmbEquipmentCategory_SelectedIndexChanged;
            cmbEquipmentCategory.DropDownClosed += cmbEquipmentCategory_DropDownClosed;
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.BorderStyle = BorderStyle.FixedSingle;
            txtRentalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalPrice.Location = new Point(393, 256);
            txtRentalPrice.Margin = new Padding(2, 1, 2, 1);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.Size = new Size(327, 29);
            txtRentalPrice.TabIndex = 49;
            txtRentalPrice.TextChanged += txtRentalPrice_TextChanged;
            // 
            // txtEquipmentDescription
            // 
            txtEquipmentDescription.BorderStyle = BorderStyle.FixedSingle;
            txtEquipmentDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentDescription.Location = new Point(393, 144);
            txtEquipmentDescription.Margin = new Padding(2, 1, 2, 1);
            txtEquipmentDescription.Name = "txtEquipmentDescription";
            txtEquipmentDescription.Size = new Size(327, 29);
            txtEquipmentDescription.TabIndex = 47;
            txtEquipmentDescription.TextChanged += txtEquipmentDescription_TextChanged;
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.BorderStyle = BorderStyle.FixedSingle;
            txtEquipmentName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentName.Location = new Point(393, 94);
            txtEquipmentName.Margin = new Padding(2, 1, 2, 1);
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.Size = new Size(327, 29);
            txtEquipmentName.TabIndex = 46;
            txtEquipmentName.TextChanged += txtEquipmentName_TextChanged;
            // 
            // lblConditionStatus
            // 
            lblConditionStatus.AutoSize = true;
            lblConditionStatus.Font = new Font("Segoe UI", 14F);
            lblConditionStatus.Location = new Point(169, 306);
            lblConditionStatus.Margin = new Padding(2, 0, 2, 0);
            lblConditionStatus.Name = "lblConditionStatus";
            lblConditionStatus.Size = new Size(154, 25);
            lblConditionStatus.TabIndex = 45;
            lblConditionStatus.Text = "Condition Status:";
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 14F);
            lblRentalPrice.Location = new Point(212, 256);
            lblRentalPrice.Margin = new Padding(2, 0, 2, 0);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(115, 25);
            lblRentalPrice.TabIndex = 44;
            lblRentalPrice.Text = "Rental Price:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 14F);
            lblEquipmentCategory.Location = new Point(130, 194);
            lblEquipmentCategory.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(188, 25);
            lblEquipmentCategory.TabIndex = 42;
            lblEquipmentCategory.Text = "Equipment Category:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 14F);
            lblEquipmentDescription.Location = new Point(108, 144);
            lblEquipmentDescription.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(208, 25);
            lblEquipmentDescription.TabIndex = 41;
            lblEquipmentDescription.Text = "Equipment Description:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 14F);
            lblEquipmentName.Location = new Point(161, 94);
            lblEquipmentName.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(162, 25);
            lblEquipmentName.TabIndex = 40;
            lblEquipmentName.Text = "Equipment Name:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24.125F, FontStyle.Bold | FontStyle.Italic);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(325, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(336, 45);
            lblTitle.TabIndex = 39;
            lblTitle.Text = "Add New Equipment";
            // 
            // lblEquipmentNameErr
            // 
            lblEquipmentNameErr.AutoSize = true;
            lblEquipmentNameErr.ForeColor = Color.Red;
            lblEquipmentNameErr.Location = new Point(395, 124);
            lblEquipmentNameErr.Name = "lblEquipmentNameErr";
            lblEquipmentNameErr.Size = new Size(0, 15);
            lblEquipmentNameErr.TabIndex = 53;
            // 
            // lblEquipmentDescriptionErr
            // 
            lblEquipmentDescriptionErr.AutoSize = true;
            lblEquipmentDescriptionErr.ForeColor = Color.Red;
            lblEquipmentDescriptionErr.Location = new Point(393, 171);
            lblEquipmentDescriptionErr.Name = "lblEquipmentDescriptionErr";
            lblEquipmentDescriptionErr.Size = new Size(0, 15);
            lblEquipmentDescriptionErr.TabIndex = 54;
            // 
            // lblEquipmentCategoryErr
            // 
            lblEquipmentCategoryErr.AutoSize = true;
            lblEquipmentCategoryErr.ForeColor = Color.Red;
            lblEquipmentCategoryErr.Location = new Point(393, 222);
            lblEquipmentCategoryErr.Name = "lblEquipmentCategoryErr";
            lblEquipmentCategoryErr.Size = new Size(0, 15);
            lblEquipmentCategoryErr.TabIndex = 55;
            // 
            // lblRentalPriceErr
            // 
            lblRentalPriceErr.AutoSize = true;
            lblRentalPriceErr.ForeColor = Color.Red;
            lblRentalPriceErr.Location = new Point(393, 282);
            lblRentalPriceErr.Name = "lblRentalPriceErr";
            lblRentalPriceErr.Size = new Size(0, 15);
            lblRentalPriceErr.TabIndex = 57;
            // 
            // lblConditionStatusErr
            // 
            lblConditionStatusErr.AutoSize = true;
            lblConditionStatusErr.ForeColor = Color.Red;
            lblConditionStatusErr.Location = new Point(393, 333);
            lblConditionStatusErr.Name = "lblConditionStatusErr";
            lblConditionStatusErr.RightToLeft = RightToLeft.No;
            lblConditionStatusErr.Size = new Size(0, 15);
            lblConditionStatusErr.TabIndex = 58;
            // 
            // lblAvailabilityStatus
            // 
            lblAvailabilityStatus.AutoSize = true;
            lblAvailabilityStatus.Font = new Font("Segoe UI", 14F);
            lblAvailabilityStatus.Location = new Point(161, 348);
            lblAvailabilityStatus.Margin = new Padding(2, 0, 2, 0);
            lblAvailabilityStatus.Name = "lblAvailabilityStatus";
            lblAvailabilityStatus.Size = new Size(159, 25);
            lblAvailabilityStatus.TabIndex = 59;
            lblAvailabilityStatus.Text = "Availability Status";
            // 
            // cmbAvailabilityStatus
            // 
            cmbAvailabilityStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailabilityStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAvailabilityStatus.FormattingEnabled = true;
            cmbAvailabilityStatus.Location = new Point(393, 357);
            cmbAvailabilityStatus.Margin = new Padding(2, 1, 2, 1);
            cmbAvailabilityStatus.Name = "cmbAvailabilityStatus";
            cmbAvailabilityStatus.Size = new Size(327, 29);
            cmbAvailabilityStatus.TabIndex = 60;
            cmbAvailabilityStatus.SelectedIndexChanged += cmbAvailabilityStatus_SelectedIndexChanged;
            cmbAvailabilityStatus.DropDownClosed += cmbAvailabilityStatus_DropDownClosed;
            // 
            // lblAvailabilityStatusErr
            // 
            lblAvailabilityStatusErr.AutoSize = true;
            lblAvailabilityStatusErr.ForeColor = Color.Red;
            lblAvailabilityStatusErr.Location = new Point(393, 384);
            lblAvailabilityStatusErr.Name = "lblAvailabilityStatusErr";
            lblAvailabilityStatusErr.Size = new Size(0, 15);
            lblAvailabilityStatusErr.TabIndex = 61;
            // 
            // AddEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(lblAvailabilityStatusErr);
            Controls.Add(cmbAvailabilityStatus);
            Controls.Add(lblAvailabilityStatus);
            Controls.Add(lblConditionStatusErr);
            Controls.Add(lblRentalPriceErr);
            Controls.Add(lblEquipmentCategoryErr);
            Controls.Add(lblEquipmentDescriptionErr);
            Controls.Add(lblEquipmentNameErr);
            Controls.Add(btnAddEquipment);
            Controls.Add(cmbConditionStatus);
            Controls.Add(cmbEquipmentCategory);
            Controls.Add(txtRentalPrice);
            Controls.Add(txtEquipmentDescription);
            Controls.Add(txtEquipmentName);
            Controls.Add(lblConditionStatus);
            Controls.Add(lblRentalPrice);
            Controls.Add(lblEquipmentCategory);
            Controls.Add(lblEquipmentDescription);
            Controls.Add(lblEquipmentName);
            Controls.Add(lblTitle);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AddEquipment";
            Text = "AddEquipment";
            Load += AddEquipment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddEquipment;
        private ComboBox cmbConditionStatus;
        private ComboBox cmbEquipmentCategory;
        private TextBox txtRentalPrice;
        private TextBox txtEquipmentDescription;
        private TextBox txtEquipmentName;
        private Label lblConditionStatus;
        private Label lblRentalPrice;
        private Label lblEquipmentCategory;
        private Label lblEquipmentDescription;
        private Label lblEquipmentName;
        private Label lblTitle;
        private Label lblEquipmentNameErr;
        private Label lblEquipmentDescriptionErr;
        private Label lblEquipmentCategoryErr;
        private Label lblRentalPriceErr;
        private Label lblConditionStatusErr;
        private Label lblAvailabilityStatus;
        private ComboBox cmbAvailabilityStatus;
        private Label lblAvailabilityStatusErr;
    }
}