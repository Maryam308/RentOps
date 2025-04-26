namespace RentOpsDesktop
{
    partial class EditRentalTransaction
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
            txtRentalPeriod = new Label();
            btnUpdateRentalTransaction = new Button();
            txtRentalFee = new TextBox();
            txtDeposit = new TextBox();
            txtReturnDate = new TextBox();
            txtPickupDate = new TextBox();
            lblRentalPrice = new Label();
            lblQuantity = new Label();
            lblEquipmentCategory = new Label();
            lblEquipmentDescription = new Label();
            lblEquipmentName = new Label();
            lblTitle = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtRentalPeriod
            // 
            txtRentalPeriod.AutoSize = true;
            txtRentalPeriod.Font = new Font("Segoe UI", 14F);
            txtRentalPeriod.Location = new Point(297, 210);
            txtRentalPeriod.Margin = new Padding(2, 0, 2, 0);
            txtRentalPeriod.Name = "txtRentalPeriod";
            txtRentalPeriod.Size = new Size(123, 25);
            txtRentalPeriod.TabIndex = 82;
            txtRentalPeriod.Text = "Rental Period";
            // 
            // btnUpdateRentalTransaction
            // 
            btnUpdateRentalTransaction.BackColor = Color.FromArgb(121, 86, 76);
            btnUpdateRentalTransaction.FlatStyle = FlatStyle.Flat;
            btnUpdateRentalTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateRentalTransaction.ForeColor = Color.White;
            btnUpdateRentalTransaction.Location = new Point(249, 403);
            btnUpdateRentalTransaction.Margin = new Padding(3, 2, 3, 2);
            btnUpdateRentalTransaction.Name = "btnUpdateRentalTransaction";
            btnUpdateRentalTransaction.Size = new Size(556, 35);
            btnUpdateRentalTransaction.TabIndex = 81;
            btnUpdateRentalTransaction.Text = "Update Rental Transaction";
            btnUpdateRentalTransaction.UseVisualStyleBackColor = false;
            // 
            // txtRentalFee
            // 
            txtRentalFee.BorderStyle = BorderStyle.FixedSingle;
            txtRentalFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalFee.Location = new Point(222, 311);
            txtRentalFee.Margin = new Padding(2, 1, 2, 1);
            txtRentalFee.Name = "txtRentalFee";
            txtRentalFee.PlaceholderText = " ";
            txtRentalFee.Size = new Size(272, 29);
            txtRentalFee.TabIndex = 80;
            // 
            // txtDeposit
            // 
            txtDeposit.BorderStyle = BorderStyle.FixedSingle;
            txtDeposit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDeposit.Location = new Point(222, 261);
            txtDeposit.Margin = new Padding(2, 1, 2, 1);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.PlaceholderText = " ";
            txtDeposit.Size = new Size(272, 29);
            txtDeposit.TabIndex = 79;
            // 
            // txtReturnDate
            // 
            txtReturnDate.BorderStyle = BorderStyle.FixedSingle;
            txtReturnDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReturnDate.Location = new Point(222, 157);
            txtReturnDate.Margin = new Padding(2, 1, 2, 1);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.PlaceholderText = " ";
            txtReturnDate.Size = new Size(272, 29);
            txtReturnDate.TabIndex = 78;
            // 
            // txtPickupDate
            // 
            txtPickupDate.BorderStyle = BorderStyle.FixedSingle;
            txtPickupDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPickupDate.Location = new Point(222, 107);
            txtPickupDate.Margin = new Padding(2, 1, 2, 1);
            txtPickupDate.Name = "txtPickupDate";
            txtPickupDate.PlaceholderText = " ";
            txtPickupDate.Size = new Size(272, 29);
            txtPickupDate.TabIndex = 77;
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 14F);
            lblRentalPrice.Location = new Point(66, 310);
            lblRentalPrice.Margin = new Padding(2, 0, 2, 0);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(102, 25);
            lblRentalPrice.TabIndex = 76;
            lblRentalPrice.Text = "Rental Fee:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14F);
            lblQuantity.Location = new Point(66, 260);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(80, 25);
            lblQuantity.TabIndex = 75;
            lblQuantity.Text = "Deposit:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 14F);
            lblEquipmentCategory.Location = new Point(66, 210);
            lblEquipmentCategory.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(127, 25);
            lblEquipmentCategory.TabIndex = 74;
            lblEquipmentCategory.Text = "Rental Period:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 14F);
            lblEquipmentDescription.Location = new Point(66, 160);
            lblEquipmentDescription.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(115, 25);
            lblEquipmentDescription.TabIndex = 73;
            lblEquipmentDescription.Text = "Return Date:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 14F);
            lblEquipmentName.Location = new Point(66, 111);
            lblEquipmentName.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(116, 25);
            lblEquipmentName.TabIndex = 72;
            lblEquipmentName.Text = "Pickup Date:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(324, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(439, 51);
            lblTitle.TabIndex = 71;
            lblTitle.Text = "Edit Rental Transaction";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(53, 28);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(151, 35);
            btnBack.TabIndex = 70;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // EditRentalTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 458);
            Controls.Add(txtRentalPeriod);
            Controls.Add(btnUpdateRentalTransaction);
            Controls.Add(txtRentalFee);
            Controls.Add(txtDeposit);
            Controls.Add(txtReturnDate);
            Controls.Add(txtPickupDate);
            Controls.Add(lblRentalPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblEquipmentCategory);
            Controls.Add(lblEquipmentDescription);
            Controls.Add(lblEquipmentName);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EditRentalTransaction";
            Text = "EditRentalTransaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtRentalPeriod;
        private Button btnUpdateRentalTransaction;
        private TextBox txtRentalFee;
        private TextBox txtDeposit;
        private TextBox txtReturnDate;
        private TextBox txtPickupDate;
        private Label lblRentalPrice;
        private Label lblQuantity;
        private Label lblEquipmentCategory;
        private Label lblEquipmentDescription;
        private Label lblEquipmentName;
        private Label lblTitle;
        private Button btnBack;
    }
}