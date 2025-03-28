namespace RentOpsDesktop
{
    partial class EditEquipmentInformation
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
            btnSaveChanges = new Button();
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
            btnBack = new Button();
            cmbAvailabilityStatus = new ComboBox();
            lblAvailabilityStatus = new Label();
            lblEquipmentNameErr = new Label();
            lblEquipmentDescriptionErr = new Label();
            lblQuantityErr = new Label();
            lblRentalPriceErr = new Label();
            SuspendLayout();
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(121, 86, 76);
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(248, 552);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(635, 47);
            btnSaveChanges.TabIndex = 37;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // cmbConditionStatus
            // 
            cmbConditionStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbConditionStatus.FormattingEnabled = true;
            cmbConditionStatus.Location = new Point(513, 487);
            cmbConditionStatus.Margin = new Padding(2, 1, 2, 1);
            cmbConditionStatus.Name = "cmbConditionStatus";
            cmbConditionStatus.Size = new Size(373, 36);
            cmbConditionStatus.TabIndex = 36;
            cmbConditionStatus.Text = "Select Condition Status";
            // 
            // cmbEquipmentCategory
            // 
            cmbEquipmentCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEquipmentCategory.FormattingEnabled = true;
            cmbEquipmentCategory.Location = new Point(513, 244);
            cmbEquipmentCategory.Margin = new Padding(2, 1, 2, 1);
            cmbEquipmentCategory.Name = "cmbEquipmentCategory";
            cmbEquipmentCategory.Size = new Size(373, 36);
            cmbEquipmentCategory.TabIndex = 35;
            cmbEquipmentCategory.Text = "Select Equipment Category";
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalPrice.Location = new Point(513, 366);
            txtRentalPrice.Margin = new Padding(2, 1, 2, 1);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.PlaceholderText = "Enter Rental Price";
            txtRentalPrice.Size = new Size(373, 34);
            txtRentalPrice.TabIndex = 34;
            txtRentalPrice.TextChanged += txtRentalPrice_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(510, 302);
            txtQuantity.Margin = new Padding(2, 1, 2, 1);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Enter Quantity";
            txtQuantity.Size = new Size(373, 34);
            txtQuantity.TabIndex = 33;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtEquipmentDescription
            // 
            txtEquipmentDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentDescription.Location = new Point(513, 182);
            txtEquipmentDescription.Margin = new Padding(2, 1, 2, 1);
            txtEquipmentDescription.Name = "txtEquipmentDescription";
            txtEquipmentDescription.PlaceholderText = "Enter Equipment Description";
            txtEquipmentDescription.Size = new Size(373, 34);
            txtEquipmentDescription.TabIndex = 32;
            txtEquipmentDescription.TextChanged += txtEquipmentDescription_TextChanged;
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentName.Location = new Point(513, 119);
            txtEquipmentName.Margin = new Padding(2, 1, 2, 1);
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.PlaceholderText = "Enter Equipment Name";
            txtEquipmentName.Size = new Size(373, 34);
            txtEquipmentName.TabIndex = 31;
            txtEquipmentName.TextChanged += txtEquipmentName_TextChanged;
            // 
            // lblConditionStatus
            // 
            lblConditionStatus.AutoSize = true;
            lblConditionStatus.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConditionStatus.Location = new Point(257, 488);
            lblConditionStatus.Margin = new Padding(2, 0, 2, 0);
            lblConditionStatus.Name = "lblConditionStatus";
            lblConditionStatus.Size = new Size(210, 32);
            lblConditionStatus.TabIndex = 30;
            lblConditionStatus.Text = "Condition Status:";
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalPrice.Location = new Point(304, 366);
            lblRentalPrice.Margin = new Padding(2, 0, 2, 0);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(157, 32);
            lblRentalPrice.TabIndex = 29;
            lblRentalPrice.Text = "Rental Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(341, 302);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(120, 32);
            lblQuantity.TabIndex = 28;
            lblQuantity.Text = "Quantity:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentCategory.Location = new Point(214, 244);
            lblEquipmentCategory.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(256, 32);
            lblEquipmentCategory.TabIndex = 27;
            lblEquipmentCategory.Text = "Equipment Category:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentDescription.Location = new Point(186, 184);
            lblEquipmentDescription.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(284, 32);
            lblEquipmentDescription.TabIndex = 26;
            lblEquipmentDescription.Text = "Equipment Description:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentName.Location = new Point(248, 121);
            lblEquipmentName.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(219, 32);
            lblEquipmentName.TabIndex = 25;
            lblEquipmentName.Text = "Equipment Name:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(341, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(532, 62);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Edit Equipment Details";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(23, 29);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(173, 47);
            btnBack.TabIndex = 23;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // cmbAvailabilityStatus
            // 
            cmbAvailabilityStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAvailabilityStatus.FormattingEnabled = true;
            cmbAvailabilityStatus.Location = new Point(513, 437);
            cmbAvailabilityStatus.Margin = new Padding(2, 1, 2, 1);
            cmbAvailabilityStatus.Name = "cmbAvailabilityStatus";
            cmbAvailabilityStatus.Size = new Size(373, 36);
            cmbAvailabilityStatus.TabIndex = 38;
            cmbAvailabilityStatus.Text = "Select Availability Status";
            // 
            // lblAvailabilityStatus
            // 
            lblAvailabilityStatus.AutoSize = true;
            lblAvailabilityStatus.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailabilityStatus.Location = new Point(257, 438);
            lblAvailabilityStatus.Margin = new Padding(2, 0, 2, 0);
            lblAvailabilityStatus.Name = "lblAvailabilityStatus";
            lblAvailabilityStatus.Size = new Size(224, 32);
            lblAvailabilityStatus.TabIndex = 39;
            lblAvailabilityStatus.Text = "Availability Status:";
            // 
            // lblEquipmentNameErr
            // 
            lblEquipmentNameErr.AutoSize = true;
            lblEquipmentNameErr.ForeColor = Color.Red;
            lblEquipmentNameErr.Location = new Point(513, 156);
            lblEquipmentNameErr.Name = "lblEquipmentNameErr";
            lblEquipmentNameErr.Size = new Size(156, 20);
            lblEquipmentNameErr.TabIndex = 40;
            lblEquipmentNameErr.Text = "lblEquipmentNameErr";
            // 
            // lblEquipmentDescriptionErr
            // 
            lblEquipmentDescriptionErr.AutoSize = true;
            lblEquipmentDescriptionErr.ForeColor = Color.Red;
            lblEquipmentDescriptionErr.Location = new Point(513, 217);
            lblEquipmentDescriptionErr.Name = "lblEquipmentDescriptionErr";
            lblEquipmentDescriptionErr.Size = new Size(192, 20);
            lblEquipmentDescriptionErr.TabIndex = 41;
            lblEquipmentDescriptionErr.Text = "lblEquipmentDescriptionErr";
            // 
            // lblQuantityErr
            // 
            lblQuantityErr.AutoSize = true;
            lblQuantityErr.ForeColor = Color.Red;
            lblQuantityErr.Location = new Point(510, 337);
            lblQuantityErr.Name = "lblQuantityErr";
            lblQuantityErr.Size = new Size(100, 20);
            lblQuantityErr.TabIndex = 42;
            lblQuantityErr.Text = "lblQuantityErr";
            // 
            // lblRentalPriceErr
            // 
            lblRentalPriceErr.AutoSize = true;
            lblRentalPriceErr.ForeColor = Color.Red;
            lblRentalPriceErr.Location = new Point(513, 401);
            lblRentalPriceErr.Name = "lblRentalPriceErr";
            lblRentalPriceErr.Size = new Size(118, 20);
            lblRentalPriceErr.TabIndex = 43;
            lblRentalPriceErr.Text = "lblRentalPriceErr";
            // 
            // EditEquipmentInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(lblRentalPriceErr);
            Controls.Add(lblQuantityErr);
            Controls.Add(lblEquipmentDescriptionErr);
            Controls.Add(lblEquipmentNameErr);
            Controls.Add(lblAvailabilityStatus);
            Controls.Add(cmbAvailabilityStatus);
            Controls.Add(btnSaveChanges);
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
            Controls.Add(btnBack);
            Margin = new Padding(2, 1, 2, 1);
            Name = "EditEquipmentInformation";
            Text = "EditEquipment";
            Load += EditEquipmentInformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveChanges;
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
        private Button btnBack;
        private ComboBox cmbAvailabilityStatus;
        private Label lblAvailabilityStatus;
        private Label lblEquipmentNameErr;
        private Label lblEquipmentDescriptionErr;
        private Label lblQuantityErr;
        private Label lblRentalPriceErr;
    }
}