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
            comboBoxConditionStatus = new ComboBox();
            comboBoxEquipmentCategory = new ComboBox();
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
            SuspendLayout();
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.BackColor = Color.FromArgb(121, 86, 76);
            btnAddEquipment.FlatStyle = FlatStyle.Flat;
            btnAddEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEquipment.ForeColor = Color.White;
            btnAddEquipment.Location = new Point(398, 848);
            btnAddEquipment.Margin = new Padding(5);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(1033, 75);
            btnAddEquipment.TabIndex = 52;
            btnAddEquipment.Text = "Add Equipment";
            btnAddEquipment.UseVisualStyleBackColor = false;
            // 
            // comboBoxConditionStatus
            // 
            comboBoxConditionStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxConditionStatus.FormattingEnabled = true;
            comboBoxConditionStatus.Location = new Point(828, 749);
            comboBoxConditionStatus.Name = "comboBoxConditionStatus";
            comboBoxConditionStatus.Size = new Size(603, 53);
            comboBoxConditionStatus.TabIndex = 51;
            comboBoxConditionStatus.Text = "Select Condition Status";
            // 
            // comboBoxEquipmentCategory
            // 
            comboBoxEquipmentCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxEquipmentCategory.FormattingEnabled = true;
            comboBoxEquipmentCategory.Location = new Point(828, 432);
            comboBoxEquipmentCategory.Name = "comboBoxEquipmentCategory";
            comboBoxEquipmentCategory.Size = new Size(603, 53);
            comboBoxEquipmentCategory.TabIndex = 50;
            comboBoxEquipmentCategory.Text = "Select Equipment Category";
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalPrice.Location = new Point(828, 645);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.PlaceholderText = "Enter Rental Price";
            txtRentalPrice.Size = new Size(603, 50);
            txtRentalPrice.TabIndex = 49;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(828, 538);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Enter Quantity";
            txtQuantity.Size = new Size(603, 50);
            txtQuantity.TabIndex = 48;
            // 
            // txtEquipmentDescription
            // 
            txtEquipmentDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentDescription.Location = new Point(828, 325);
            txtEquipmentDescription.Name = "txtEquipmentDescription";
            txtEquipmentDescription.PlaceholderText = "Enter Equipment Description";
            txtEquipmentDescription.Size = new Size(603, 50);
            txtEquipmentDescription.TabIndex = 47;
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentName.Location = new Point(828, 218);
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.PlaceholderText = "Enter Equipment Name";
            txtEquipmentName.Size = new Size(603, 50);
            txtEquipmentName.TabIndex = 46;
            // 
            // lblConditionStatus
            // 
            lblConditionStatus.AutoSize = true;
            lblConditionStatus.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConditionStatus.Location = new Point(412, 752);
            lblConditionStatus.Name = "lblConditionStatus";
            lblConditionStatus.Size = new Size(320, 50);
            lblConditionStatus.TabIndex = 45;
            lblConditionStatus.Text = "Condition Status:";
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalPrice.Location = new Point(493, 645);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(239, 50);
            lblRentalPrice.TabIndex = 44;
            lblRentalPrice.Text = "Rental Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(549, 538);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(183, 50);
            lblQuantity.TabIndex = 43;
            lblQuantity.Text = "Quantity:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentCategory.Location = new Point(342, 431);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(390, 50);
            lblEquipmentCategory.TabIndex = 42;
            lblEquipmentCategory.Text = "Equipment Category:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentDescription.Location = new Point(301, 324);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(431, 50);
            lblEquipmentDescription.TabIndex = 41;
            lblEquipmentDescription.Text = "Equipment Description:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentName.Location = new Point(398, 217);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(334, 50);
            lblEquipmentName.TabIndex = 40;
            lblEquipmentName.Text = "Equipment Name:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(537, 49);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(761, 100);
            lblTitle.TabIndex = 39;
            lblTitle.Text = "Add New Equipment";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(33, 49);
            btnBack.Margin = new Padding(5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(280, 75);
            btnBack.TabIndex = 38;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // AddEquipment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 978);
            Controls.Add(btnAddEquipment);
            Controls.Add(comboBoxConditionStatus);
            Controls.Add(comboBoxEquipmentCategory);
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
            Name = "AddEquipment";
            Text = "AddEquipment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddEquipment;
        private ComboBox comboBoxConditionStatus;
        private ComboBox comboBoxEquipmentCategory;
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
    }
}