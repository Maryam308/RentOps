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
            btnAddEquipment.Location = new Point(214, 398);
            btnAddEquipment.Margin = new Padding(3, 2, 3, 2);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(556, 35);
            btnAddEquipment.TabIndex = 52;
            btnAddEquipment.Text = "Add Equipment";
            btnAddEquipment.UseVisualStyleBackColor = false;
            // 
            // comboBoxConditionStatus
            // 
            comboBoxConditionStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxConditionStatus.FormattingEnabled = true;
            comboBoxConditionStatus.Location = new Point(446, 351);
            comboBoxConditionStatus.Margin = new Padding(2, 1, 2, 1);
            comboBoxConditionStatus.Name = "comboBoxConditionStatus";
            comboBoxConditionStatus.Size = new Size(327, 29);
            comboBoxConditionStatus.TabIndex = 51;
            comboBoxConditionStatus.Text = "Select Condition Status";
            // 
            // comboBoxEquipmentCategory
            // 
            comboBoxEquipmentCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxEquipmentCategory.FormattingEnabled = true;
            comboBoxEquipmentCategory.Location = new Point(446, 202);
            comboBoxEquipmentCategory.Margin = new Padding(2, 1, 2, 1);
            comboBoxEquipmentCategory.Name = "comboBoxEquipmentCategory";
            comboBoxEquipmentCategory.Size = new Size(327, 29);
            comboBoxEquipmentCategory.TabIndex = 50;
            comboBoxEquipmentCategory.Text = "Select Equipment Category";
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalPrice.Location = new Point(446, 302);
            txtRentalPrice.Margin = new Padding(2, 1, 2, 1);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.PlaceholderText = "Enter Rental Price";
            txtRentalPrice.Size = new Size(327, 29);
            txtRentalPrice.TabIndex = 49;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(446, 252);
            txtQuantity.Margin = new Padding(2, 1, 2, 1);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Enter Quantity";
            txtQuantity.Size = new Size(327, 29);
            txtQuantity.TabIndex = 48;
            // 
            // txtEquipmentDescription
            // 
            txtEquipmentDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentDescription.Location = new Point(446, 152);
            txtEquipmentDescription.Margin = new Padding(2, 1, 2, 1);
            txtEquipmentDescription.Name = "txtEquipmentDescription";
            txtEquipmentDescription.PlaceholderText = "Enter Equipment Description";
            txtEquipmentDescription.Size = new Size(327, 29);
            txtEquipmentDescription.TabIndex = 47;
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEquipmentName.Location = new Point(446, 102);
            txtEquipmentName.Margin = new Padding(2, 1, 2, 1);
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.PlaceholderText = "Enter Equipment Name";
            txtEquipmentName.Size = new Size(327, 29);
            txtEquipmentName.TabIndex = 46;
            // 
            // lblConditionStatus
            // 
            lblConditionStatus.AutoSize = true;
            lblConditionStatus.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConditionStatus.Location = new Point(222, 352);
            lblConditionStatus.Margin = new Padding(2, 0, 2, 0);
            lblConditionStatus.Name = "lblConditionStatus";
            lblConditionStatus.Size = new Size(166, 25);
            lblConditionStatus.TabIndex = 45;
            lblConditionStatus.Text = "Condition Status:";
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalPrice.Location = new Point(265, 302);
            lblRentalPrice.Margin = new Padding(2, 0, 2, 0);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(122, 25);
            lblRentalPrice.TabIndex = 44;
            lblRentalPrice.Text = "Rental Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(296, 252);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(94, 25);
            lblQuantity.TabIndex = 43;
            lblQuantity.Text = "Quantity:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentCategory.Location = new Point(184, 202);
            lblEquipmentCategory.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(201, 25);
            lblEquipmentCategory.TabIndex = 42;
            lblEquipmentCategory.Text = "Equipment Category:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentDescription.Location = new Point(162, 152);
            lblEquipmentDescription.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(221, 25);
            lblEquipmentDescription.TabIndex = 41;
            lblEquipmentDescription.Text = "Equipment Description:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentName.Location = new Point(214, 102);
            lblEquipmentName.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(171, 25);
            lblEquipmentName.TabIndex = 40;
            lblEquipmentName.Text = "Equipment Name:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(289, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(388, 51);
            lblTitle.TabIndex = 39;
            lblTitle.Text = "Add New Equipment";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(18, 23);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(151, 35);
            btnBack.TabIndex = 38;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // AddEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
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
            Margin = new Padding(2, 1, 2, 1);
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