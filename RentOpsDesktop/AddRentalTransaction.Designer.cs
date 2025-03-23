namespace RentOpsDesktop
{
    partial class AddRentalTransaction
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
            this.btnCreateRentalTransaction = new Button();
            this.txtRentalFee = new TextBox();
            this.txtDeposit = new TextBox();
            this.txtReturnDate = new TextBox();
            txtPickupDate = new TextBox();
            lblRentalPrice = new Label();
            lblQuantity = new Label();
            lblEquipmentCategory = new Label();
            lblEquipmentDescription = new Label();
            lblEquipmentName = new Label();
            lblTitle = new Label();
            btnBack = new Button();
            txtRentalPeriod = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // btnCreateRentalTransaction
            // 
            this.btnCreateRentalTransaction.BackColor = Color.FromArgb(121, 86, 76);
            this.btnCreateRentalTransaction.FlatStyle = FlatStyle.Flat;
            this.btnCreateRentalTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCreateRentalTransaction.ForeColor = Color.White;
            this.btnCreateRentalTransaction.Location = new Point(315, 657);
            this.btnCreateRentalTransaction.Margin = new Padding(4, 3, 4, 3);
            this.btnCreateRentalTransaction.Name = "btnCreateRentalTransaction";
            this.btnCreateRentalTransaction.Size = new Size(794, 58);
            this.btnCreateRentalTransaction.TabIndex = 67;
            this.btnCreateRentalTransaction.Text = "Create Rental Transaction";
            this.btnCreateRentalTransaction.UseVisualStyleBackColor = false;
            // 
            // txtRentalFee
            // 
            this.txtRentalFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtRentalFee.Location = new Point(646, 497);
            this.txtRentalFee.Margin = new Padding(3, 2, 3, 2);
            this.txtRentalFee.Name = "txtRentalFee";
            this.txtRentalFee.PlaceholderText = "Enter Rental Fee";
            this.txtRentalFee.Size = new Size(465, 39);
            this.txtRentalFee.TabIndex = 64;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtDeposit.Location = new Point(646, 414);
            this.txtDeposit.Margin = new Padding(3, 2, 3, 2);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.PlaceholderText = "Enter Deposit";
            this.txtDeposit.Size = new Size(465, 39);
            this.txtDeposit.TabIndex = 63;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtReturnDate.Location = new Point(646, 247);
            this.txtReturnDate.Margin = new Padding(3, 2, 3, 2);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.PlaceholderText = "Enter Return Date";
            this.txtReturnDate.Size = new Size(465, 39);
            this.txtReturnDate.TabIndex = 62;
            // 
            // txtPickupDate
            // 
            txtPickupDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPickupDate.Location = new Point(646, 164);
            txtPickupDate.Margin = new Padding(3, 2, 3, 2);
            txtPickupDate.Name = "txtPickupDate";
            txtPickupDate.PlaceholderText = "Enter Pickup Date";
            txtPickupDate.Size = new Size(465, 39);
            txtPickupDate.TabIndex = 61;
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalPrice.Location = new Point(315, 495);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(161, 38);
            lblRentalPrice.TabIndex = 59;
            lblRentalPrice.Text = "Rental Fee:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(315, 412);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(126, 38);
            lblQuantity.TabIndex = 58;
            lblQuantity.Text = "Deposit:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentCategory.Location = new Point(315, 329);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(200, 38);
            lblEquipmentCategory.TabIndex = 57;
            lblEquipmentCategory.Text = "Rental Period:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentDescription.Location = new Point(315, 245);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(183, 38);
            lblEquipmentDescription.TabIndex = 56;
            lblEquipmentDescription.Text = "Return Date:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentName.Location = new Point(315, 164);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(183, 38);
            lblEquipmentName.TabIndex = 55;
            lblEquipmentName.Text = "Pickup Date:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(422, 32);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(660, 76);
            lblTitle.TabIndex = 54;
            lblTitle.Text = "Add Rental Transaction";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(35, 32);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(216, 58);
            btnBack.TabIndex = 53;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // txtRentalPeriod
            // 
            txtRentalPeriod.AutoSize = true;
            txtRentalPeriod.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalPeriod.Location = new Point(646, 329);
            txtRentalPeriod.Name = "txtRentalPeriod";
            txtRentalPeriod.Size = new Size(192, 38);
            txtRentalPeriod.TabIndex = 69;
            txtRentalPeriod.Text = "Rental Period";
            // 
            // AddRentalTransaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 763);
            Controls.Add(txtRentalPeriod);
            Controls.Add(this.btnCreateRentalTransaction);
            Controls.Add(this.txtRentalFee);
            Controls.Add(this.txtDeposit);
            Controls.Add(this.txtReturnDate);
            Controls.Add(txtPickupDate);
            Controls.Add(lblRentalPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblEquipmentCategory);
            Controls.Add(lblEquipmentDescription);
            Controls.Add(lblEquipmentName);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Name = "AddRentalTransaction";
            Text = "AddRentalTransaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddEquipment;
        private ComboBox comboBoxEquipmentCategory;
        private TextBox txtRentalPrice;
        private TextBox txtQuantity;
        private TextBox txtEquipmentDescription;
        private TextBox txtPickupDate;
        private Label lblRentalPrice;
        private Label lblQuantity;
        private Label lblEquipmentCategory;
        private Label lblEquipmentDescription;
        private Label lblEquipmentName;
        private Label lblTitle;
        private Button btnBack;
        private Label txtRentalPeriod;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}