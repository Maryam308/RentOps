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
            txtQuantity = new TextBox();
            txtEquipmentDescription = new TextBox();
            txtEquipmentName = new TextBox();
            lblConditionStatus = new Label();
            lblRentalPrice = new Label();
            lblQuantity = new Label();
            lblEquipmentCategory = new Label();
            lblEquipmentDescription = new Label();
            lblEquipmentName = new Label();
            lblTitle = new Label();
            lblEquipmentNameErr = new Label();
            lblEquipmentDescriptionErr = new Label();
            lblEquipmentCategoryErr = new Label();
            lblQuantityErr = new Label();
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
            btnAddEquipment.Location = new Point(271, 547);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(203, 41);
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
            cmbConditionStatus.Location = new Point(346, 415);
            cmbConditionStatus.Margin = new Padding(2, 1, 2, 1);
            cmbConditionStatus.Name = "cmbConditionStatus";
            cmbConditionStatus.Size = new Size(373, 36);
            cmbConditionStatus.TabIndex = 51;
            cmbConditionStatus.SelectedIndexChanged += cmbConditionStatus_SelectedIndexChanged;
            cmbConditionStatus.DropDownClosed += cmbConditionStatus_DropDownClosed;
            // 
            // cmbEquipmentCategory
            // 
            cmbEquipmentCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipmentCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEquipmentCategory.FormattingEnabled = true;
            cmbEquipmentCategory.Location = new Point(346, 216);
            cmbEquipmentCategory.Margin = new Padding(2, 1, 2, 1);
            cmbEquipmentCategory.Name = "cmbEquipmentCategory";
            cmbEquipmentCategory.Size = new Size(373, 36);
            cmbEquipmentCategory.TabIndex = 50;
            cmbEquipmentCategory.SelectedIndexChanged += cmbEquipmentCategory_SelectedIndexChanged;
            cmbEquipmentCategory.DropDownClosed += cmbEquipmentCategory_DropDownClosed;
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalPrice.Location = new Point(346, 350);
            txtRentalPrice.Margin = new Padding(2, 1, 2, 1);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.PlaceholderText = "Enter Rental Price";
            txtRentalPrice.Size = new Size(373, 34);
            txtRentalPrice.TabIndex = 49;
            txtRentalPrice.TextChanged += txtRentalPrice_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(346, 283);
            txtQuantity.Margin = new Padding(2, 1, 2, 1);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Enter Quantity";
            txtQuantity.Size = new Size(373, 34);
            txtQuantity.TabIndex = 48;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtEquipmentDescription
            // 
            txtEquipmentDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentDescription.Location = new Point(346, 150);
            txtEquipmentDescription.Margin = new Padding(2, 1, 2, 1);
            txtEquipmentDescription.Name = "txtEquipmentDescription";
            txtEquipmentDescription.PlaceholderText = "Enter Equipment Description";
            txtEquipmentDescription.Size = new Size(373, 34);
            txtEquipmentDescription.TabIndex = 47;
            txtEquipmentDescription.TextChanged += txtEquipmentDescription_TextChanged;
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentName.Location = new Point(346, 83);
            txtEquipmentName.Margin = new Padding(2, 1, 2, 1);
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.PlaceholderText = "Enter Equipment Name";
            txtEquipmentName.Size = new Size(373, 34);
            txtEquipmentName.TabIndex = 46;
            txtEquipmentName.TextChanged += txtEquipmentName_TextChanged;
            // 
            // lblConditionStatus
            // 
            lblConditionStatus.AutoSize = true;
            lblConditionStatus.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConditionStatus.Location = new Point(90, 416);
            lblConditionStatus.Margin = new Padding(2, 0, 2, 0);
            lblConditionStatus.Name = "lblConditionStatus";
            lblConditionStatus.Size = new Size(210, 32);
            lblConditionStatus.TabIndex = 45;
            lblConditionStatus.Text = "Condition Status:";
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalPrice.Location = new Point(139, 350);
            lblRentalPrice.Margin = new Padding(2, 0, 2, 0);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(157, 32);
            lblRentalPrice.TabIndex = 44;
            lblRentalPrice.Text = "Rental Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(174, 283);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(120, 32);
            lblQuantity.TabIndex = 43;
            lblQuantity.Text = "Quantity:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentCategory.Location = new Point(46, 216);
            lblEquipmentCategory.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(256, 32);
            lblEquipmentCategory.TabIndex = 42;
            lblEquipmentCategory.Text = "Equipment Category:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentDescription.Location = new Point(21, 150);
            lblEquipmentDescription.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(284, 32);
            lblEquipmentDescription.TabIndex = 41;
            lblEquipmentDescription.Text = "Equipment Description:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentName.Location = new Point(81, 83);
            lblEquipmentName.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(219, 32);
            lblEquipmentName.TabIndex = 40;
            lblEquipmentName.Text = "Equipment Name:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24.125F, FontStyle.Bold | FontStyle.Italic);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(174, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(416, 55);
            lblTitle.TabIndex = 39;
            lblTitle.Text = "Add New Equipment";
            // 
            // lblEquipmentNameErr
            // 
            lblEquipmentNameErr.AutoSize = true;
            lblEquipmentNameErr.ForeColor = Color.Red;
            lblEquipmentNameErr.Location = new Point(349, 122);
            lblEquipmentNameErr.Name = "lblEquipmentNameErr";
            lblEquipmentNameErr.Size = new Size(0, 20);
            lblEquipmentNameErr.TabIndex = 53;
            // 
            // lblEquipmentDescriptionErr
            // 
            lblEquipmentDescriptionErr.AutoSize = true;
            lblEquipmentDescriptionErr.ForeColor = Color.Red;
            lblEquipmentDescriptionErr.Location = new Point(346, 185);
            lblEquipmentDescriptionErr.Name = "lblEquipmentDescriptionErr";
            lblEquipmentDescriptionErr.Size = new Size(0, 20);
            lblEquipmentDescriptionErr.TabIndex = 54;
            // 
            // lblEquipmentCategoryErr
            // 
            lblEquipmentCategoryErr.AutoSize = true;
            lblEquipmentCategoryErr.ForeColor = Color.Red;
            lblEquipmentCategoryErr.Location = new Point(346, 253);
            lblEquipmentCategoryErr.Name = "lblEquipmentCategoryErr";
            lblEquipmentCategoryErr.Size = new Size(0, 20);
            lblEquipmentCategoryErr.TabIndex = 55;
            // 
            // lblQuantityErr
            // 
            lblQuantityErr.AutoSize = true;
            lblQuantityErr.ForeColor = Color.Red;
            lblQuantityErr.Location = new Point(346, 318);
            lblQuantityErr.Name = "lblQuantityErr";
            lblQuantityErr.Size = new Size(0, 20);
            lblQuantityErr.TabIndex = 56;
            // 
            // lblRentalPriceErr
            // 
            lblRentalPriceErr.AutoSize = true;
            lblRentalPriceErr.ForeColor = Color.Red;
            lblRentalPriceErr.Location = new Point(346, 385);
            lblRentalPriceErr.Name = "lblRentalPriceErr";
            lblRentalPriceErr.Size = new Size(0, 20);
            lblRentalPriceErr.TabIndex = 57;
            // 
            // lblConditionStatusErr
            // 
            lblConditionStatusErr.AutoSize = true;
            lblConditionStatusErr.ForeColor = Color.Red;
            lblConditionStatusErr.Location = new Point(346, 452);
            lblConditionStatusErr.Name = "lblConditionStatusErr";
            lblConditionStatusErr.RightToLeft = RightToLeft.No;
            lblConditionStatusErr.Size = new Size(0, 20);
            lblConditionStatusErr.TabIndex = 58;
            // 
            // lblAvailabilityStatus
            // 
            lblAvailabilityStatus.AutoSize = true;
            lblAvailabilityStatus.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailabilityStatus.Location = new Point(81, 473);
            lblAvailabilityStatus.Margin = new Padding(2, 0, 2, 0);
            lblAvailabilityStatus.Name = "lblAvailabilityStatus";
            lblAvailabilityStatus.Size = new Size(217, 32);
            lblAvailabilityStatus.TabIndex = 59;
            lblAvailabilityStatus.Text = "Availability Status";
            // 
            // cmbAvailabilityStatus
            // 
            cmbAvailabilityStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailabilityStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAvailabilityStatus.FormattingEnabled = true;
            cmbAvailabilityStatus.Location = new Point(346, 484);
            cmbAvailabilityStatus.Margin = new Padding(2, 1, 2, 1);
            cmbAvailabilityStatus.Name = "cmbAvailabilityStatus";
            cmbAvailabilityStatus.Size = new Size(373, 36);
            cmbAvailabilityStatus.TabIndex = 60;
            cmbAvailabilityStatus.SelectedIndexChanged += cmbAvailabilityStatus_SelectedIndexChanged;
            cmbAvailabilityStatus.DropDownClosed += cmbAvailabilityStatus_DropDownClosed;
            // 
            // lblAvailabilityStatusErr
            // 
            lblAvailabilityStatusErr.AutoSize = true;
            lblAvailabilityStatusErr.ForeColor = Color.Red;
            lblAvailabilityStatusErr.Location = new Point(346, 521);
            lblAvailabilityStatusErr.Name = "lblAvailabilityStatusErr";
            lblAvailabilityStatusErr.Size = new Size(0, 20);
            lblAvailabilityStatusErr.TabIndex = 61;
            // 
            // AddEquipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 600);
            Controls.Add(lblAvailabilityStatusErr);
            Controls.Add(cmbAvailabilityStatus);
            Controls.Add(lblAvailabilityStatus);
            Controls.Add(lblConditionStatusErr);
            Controls.Add(lblRentalPriceErr);
            Controls.Add(lblQuantityErr);
            Controls.Add(lblEquipmentCategoryErr);
            Controls.Add(lblEquipmentDescriptionErr);
            Controls.Add(lblEquipmentNameErr);
            Controls.Add(btnAddEquipment);
            Controls.Add(cmbConditionStatus);
            Controls.Add(cmbEquipmentCategory);
            Controls.Add(txtRentalPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtEquipmentDescription);
            Controls.Add(txtEquipmentName);
            Controls.Add(lblConditionStatus);
            Controls.Add(lblRentalPrice);
            Controls.Add(lblQuantity);
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
        private TextBox txtQuantity;
        private TextBox txtEquipmentDescription;
        private TextBox txtEquipmentName;
        private Label lblConditionStatus;
        private Label lblRentalPrice;
        private Label lblQuantity;
        private Label lblEquipmentCategory;
        private Label lblEquipmentDescription;
        private Label lblEquipmentName;
        private Label lblTitle;
        private Label lblEquipmentNameErr;
        private Label lblEquipmentDescriptionErr;
        private Label lblEquipmentCategoryErr;
        private Label lblQuantityErr;
        private Label lblRentalPriceErr;
        private Label lblConditionStatusErr;
        private Label lblAvailabilityStatus;
        private ComboBox cmbAvailabilityStatus;
        private Label lblAvailabilityStatusErr;
    }
}