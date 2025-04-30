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
            txtEquipmentDescription = new TextBox();
            txtEquipmentName = new TextBox();
            lblConditionStatus = new Label();
            lblRentalPrice = new Label();
            lblEquipmentCategory = new Label();
            lblEquipmentDescription = new Label();
            lblEquipmentName = new Label();
            lblTitle = new Label();
            cmbAvailabilityStatus = new ComboBox();
            lblAvailabilityStatus = new Label();
            lblEquipmentNameErr = new Label();
            lblEquipmentDescriptionErr = new Label();
            lblRentalPriceErr = new Label();
            lblEquipmentCategoryErr = new Label();
            lblConditionStatusErr = new Label();
            lblAvailabilityStatusErr = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(121, 86, 76);
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(760, 403);
            btnSaveChanges.Margin = new Padding(3, 2, 3, 2);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(180, 44);
            btnSaveChanges.TabIndex = 37;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // cmbConditionStatus
            // 
            cmbConditionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConditionStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbConditionStatus.FormattingEnabled = true;
            cmbConditionStatus.Location = new Point(414, 303);
            cmbConditionStatus.Margin = new Padding(2, 1, 2, 1);
            cmbConditionStatus.Name = "cmbConditionStatus";
            cmbConditionStatus.Size = new Size(327, 29);
            cmbConditionStatus.TabIndex = 36;
            cmbConditionStatus.SelectedIndexChanged += cmbConditionStatus_SelectedIndexChanged;
            // 
            // cmbEquipmentCategory
            // 
            cmbEquipmentCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipmentCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEquipmentCategory.FormattingEnabled = true;
            cmbEquipmentCategory.Location = new Point(416, 203);
            cmbEquipmentCategory.Margin = new Padding(2, 1, 2, 1);
            cmbEquipmentCategory.Name = "cmbEquipmentCategory";
            cmbEquipmentCategory.Size = new Size(327, 29);
            cmbEquipmentCategory.TabIndex = 35;
            cmbEquipmentCategory.SelectedIndexChanged += cmbEquipmentCategory_SelectedIndexChanged;
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.BorderStyle = BorderStyle.FixedSingle;
            txtRentalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalPrice.Location = new Point(416, 252);
            txtRentalPrice.Margin = new Padding(2, 1, 2, 1);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.Size = new Size(327, 29);
            txtRentalPrice.TabIndex = 34;
            txtRentalPrice.TextChanged += txtRentalPrice_TextChanged;
            // 
            // txtEquipmentDescription
            // 
            txtEquipmentDescription.BorderStyle = BorderStyle.FixedSingle;
            txtEquipmentDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentDescription.Location = new Point(416, 156);
            txtEquipmentDescription.Margin = new Padding(2, 1, 2, 1);
            txtEquipmentDescription.Name = "txtEquipmentDescription";
            txtEquipmentDescription.Size = new Size(327, 29);
            txtEquipmentDescription.TabIndex = 32;
            txtEquipmentDescription.TextChanged += txtEquipmentDescription_TextChanged;
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.BorderStyle = BorderStyle.FixedSingle;
            txtEquipmentName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentName.Location = new Point(416, 109);
            txtEquipmentName.Margin = new Padding(2, 1, 2, 1);
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.Size = new Size(327, 29);
            txtEquipmentName.TabIndex = 31;
            txtEquipmentName.TextChanged += txtEquipmentName_TextChanged;
            // 
            // lblConditionStatus
            // 
            lblConditionStatus.AutoSize = true;
            lblConditionStatus.Font = new Font("Segoe UI", 14F);
            lblConditionStatus.Location = new Point(175, 304);
            lblConditionStatus.Margin = new Padding(2, 0, 2, 0);
            lblConditionStatus.Name = "lblConditionStatus";
            lblConditionStatus.Size = new Size(154, 25);
            lblConditionStatus.TabIndex = 30;
            lblConditionStatus.Text = "Condition Status:";
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 14F);
            lblRentalPrice.Location = new Point(175, 252);
            lblRentalPrice.Margin = new Padding(2, 0, 2, 0);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(115, 25);
            lblRentalPrice.TabIndex = 29;
            lblRentalPrice.Text = "Rental Price:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 14F);
            lblEquipmentCategory.Location = new Point(175, 203);
            lblEquipmentCategory.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(188, 25);
            lblEquipmentCategory.TabIndex = 27;
            lblEquipmentCategory.Text = "Equipment Category:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 14F);
            lblEquipmentDescription.Location = new Point(175, 157);
            lblEquipmentDescription.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(208, 25);
            lblEquipmentDescription.TabIndex = 26;
            lblEquipmentDescription.Text = "Equipment Description:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 14F);
            lblEquipmentName.Location = new Point(175, 110);
            lblEquipmentName.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(162, 25);
            lblEquipmentName.TabIndex = 25;
            lblEquipmentName.Text = "Equipment Name:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24.125F, FontStyle.Bold | FontStyle.Italic);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(285, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(371, 45);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Edit Equipment Details";
            // 
            // cmbAvailabilityStatus
            // 
            cmbAvailabilityStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailabilityStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAvailabilityStatus.FormattingEnabled = true;
            cmbAvailabilityStatus.Location = new Point(414, 349);
            cmbAvailabilityStatus.Margin = new Padding(2, 1, 2, 1);
            cmbAvailabilityStatus.Name = "cmbAvailabilityStatus";
            cmbAvailabilityStatus.Size = new Size(327, 29);
            cmbAvailabilityStatus.TabIndex = 38;
            cmbAvailabilityStatus.SelectedIndexChanged += cmbAvailabilityStatus_SelectedIndexChanged;
            // 
            // lblAvailabilityStatus
            // 
            lblAvailabilityStatus.AutoSize = true;
            lblAvailabilityStatus.Font = new Font("Segoe UI", 14F);
            lblAvailabilityStatus.Location = new Point(175, 349);
            lblAvailabilityStatus.Margin = new Padding(2, 0, 2, 0);
            lblAvailabilityStatus.Name = "lblAvailabilityStatus";
            lblAvailabilityStatus.Size = new Size(163, 25);
            lblAvailabilityStatus.TabIndex = 39;
            lblAvailabilityStatus.Text = "Availability Status:";
            // 
            // lblEquipmentNameErr
            // 
            lblEquipmentNameErr.AutoSize = true;
            lblEquipmentNameErr.ForeColor = Color.Red;
            lblEquipmentNameErr.Location = new Point(416, 137);
            lblEquipmentNameErr.Name = "lblEquipmentNameErr";
            lblEquipmentNameErr.Size = new Size(0, 15);
            lblEquipmentNameErr.TabIndex = 40;
            // 
            // lblEquipmentDescriptionErr
            // 
            lblEquipmentDescriptionErr.AutoSize = true;
            lblEquipmentDescriptionErr.ForeColor = Color.Red;
            lblEquipmentDescriptionErr.Location = new Point(416, 182);
            lblEquipmentDescriptionErr.Name = "lblEquipmentDescriptionErr";
            lblEquipmentDescriptionErr.Size = new Size(0, 15);
            lblEquipmentDescriptionErr.TabIndex = 41;
            // 
            // lblRentalPriceErr
            // 
            lblRentalPriceErr.AutoSize = true;
            lblRentalPriceErr.ForeColor = Color.Red;
            lblRentalPriceErr.Location = new Point(416, 278);
            lblRentalPriceErr.Name = "lblRentalPriceErr";
            lblRentalPriceErr.Size = new Size(0, 15);
            lblRentalPriceErr.TabIndex = 43;
            // 
            // lblEquipmentCategoryErr
            // 
            lblEquipmentCategoryErr.AutoSize = true;
            lblEquipmentCategoryErr.ForeColor = Color.Red;
            lblEquipmentCategoryErr.Location = new Point(416, 230);
            lblEquipmentCategoryErr.Name = "lblEquipmentCategoryErr";
            lblEquipmentCategoryErr.Size = new Size(0, 15);
            lblEquipmentCategoryErr.TabIndex = 44;
            // 
            // lblConditionStatusErr
            // 
            lblConditionStatusErr.AutoSize = true;
            lblConditionStatusErr.ForeColor = Color.Red;
            lblConditionStatusErr.Location = new Point(414, 331);
            lblConditionStatusErr.Name = "lblConditionStatusErr";
            lblConditionStatusErr.Size = new Size(0, 15);
            lblConditionStatusErr.TabIndex = 45;
            // 
            // lblAvailabilityStatusErr
            // 
            lblAvailabilityStatusErr.AutoSize = true;
            lblAvailabilityStatusErr.ForeColor = Color.Red;
            lblAvailabilityStatusErr.Location = new Point(414, 377);
            lblAvailabilityStatusErr.Name = "lblAvailabilityStatusErr";
            lblAvailabilityStatusErr.Size = new Size(0, 15);
            lblAvailabilityStatusErr.TabIndex = 46;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(21, 22);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 44);
            btnBack.TabIndex = 47;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // EditEquipmentInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(btnBack);
            Controls.Add(lblAvailabilityStatusErr);
            Controls.Add(lblConditionStatusErr);
            Controls.Add(lblEquipmentCategoryErr);
            Controls.Add(lblRentalPriceErr);
            Controls.Add(lblEquipmentDescriptionErr);
            Controls.Add(lblEquipmentNameErr);
            Controls.Add(lblAvailabilityStatus);
            Controls.Add(cmbAvailabilityStatus);
            Controls.Add(btnSaveChanges);
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
        private TextBox txtEquipmentDescription;
        private TextBox txtEquipmentName;
        private Label lblConditionStatus;
        private Label lblRentalPrice;
        private Label lblEquipmentCategory;
        private Label lblEquipmentDescription;
        private Label lblEquipmentName;
        private Label lblTitle;
        private ComboBox cmbAvailabilityStatus;
        private Label lblAvailabilityStatus;
        private Label lblEquipmentNameErr;
        private Label lblEquipmentDescriptionErr;
        private Label lblRentalPriceErr;
        private Label lblEquipmentCategoryErr;
        private Label lblConditionStatusErr;
        private Label lblAvailabilityStatusErr;
        private Button btnBack;
    }
}