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
            txtRentalPeriod.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalPeriod.Location = new Point(687, 344);
            txtRentalPeriod.Name = "txtRentalPeriod";
            txtRentalPeriod.Size = new Size(192, 38);
            txtRentalPeriod.TabIndex = 82;
            txtRentalPeriod.Text = "Rental Period";
            // 
            // btnUpdateRentalTransaction
            // 
            btnUpdateRentalTransaction.BackColor = Color.FromArgb(121, 86, 76);
            btnUpdateRentalTransaction.FlatStyle = FlatStyle.Flat;
            btnUpdateRentalTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateRentalTransaction.ForeColor = Color.White;
            btnUpdateRentalTransaction.Location = new Point(356, 672);
            btnUpdateRentalTransaction.Margin = new Padding(4, 3, 4, 3);
            btnUpdateRentalTransaction.Name = "btnUpdateRentalTransaction";
            btnUpdateRentalTransaction.Size = new Size(794, 58);
            btnUpdateRentalTransaction.TabIndex = 81;
            btnUpdateRentalTransaction.Text = "Update Rental Transaction";
            btnUpdateRentalTransaction.UseVisualStyleBackColor = false;
            // 
            // txtRentalFee
            // 
            txtRentalFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalFee.Location = new Point(687, 512);
            txtRentalFee.Margin = new Padding(3, 2, 3, 2);
            txtRentalFee.Name = "txtRentalFee";
            txtRentalFee.PlaceholderText = "Enter Rental Fee";
            txtRentalFee.Size = new Size(465, 39);
            txtRentalFee.TabIndex = 80;
            // 
            // txtDeposit
            // 
            txtDeposit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDeposit.Location = new Point(687, 429);
            txtDeposit.Margin = new Padding(3, 2, 3, 2);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.PlaceholderText = "Enter Deposit";
            txtDeposit.Size = new Size(465, 39);
            txtDeposit.TabIndex = 79;
            // 
            // txtReturnDate
            // 
            txtReturnDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReturnDate.Location = new Point(687, 262);
            txtReturnDate.Margin = new Padding(3, 2, 3, 2);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.PlaceholderText = "Enter Return Date";
            txtReturnDate.Size = new Size(465, 39);
            txtReturnDate.TabIndex = 78;
            // 
            // txtPickupDate
            // 
            txtPickupDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPickupDate.Location = new Point(687, 179);
            txtPickupDate.Margin = new Padding(3, 2, 3, 2);
            txtPickupDate.Name = "txtPickupDate";
            txtPickupDate.PlaceholderText = "Enter Pickup Date";
            txtPickupDate.Size = new Size(465, 39);
            txtPickupDate.TabIndex = 77;
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalPrice.Location = new Point(356, 510);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(161, 38);
            lblRentalPrice.TabIndex = 76;
            lblRentalPrice.Text = "Rental Fee:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(356, 427);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(126, 38);
            lblQuantity.TabIndex = 75;
            lblQuantity.Text = "Deposit:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentCategory.Location = new Point(356, 344);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(200, 38);
            lblEquipmentCategory.TabIndex = 74;
            lblEquipmentCategory.Text = "Rental Period:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentDescription.Location = new Point(356, 260);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(183, 38);
            lblEquipmentDescription.TabIndex = 73;
            lblEquipmentDescription.Text = "Return Date:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentName.Location = new Point(356, 179);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(183, 38);
            lblEquipmentName.TabIndex = 72;
            lblEquipmentName.Text = "Pickup Date:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(463, 47);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(655, 76);
            lblTitle.TabIndex = 71;
            lblTitle.Text = "Edit Rental Transaction";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(76, 47);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(216, 58);
            btnBack.TabIndex = 70;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // EditRentalTransaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 763);
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