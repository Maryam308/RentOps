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
            lblRentalPeriod = new Label();
            btnUpdateRentalTransaction = new Button();
            txtRentalFee = new TextBox();
            txtDeposit = new TextBox();
            lblRentalPrice = new Label();
            lblQuantity = new Label();
            lblEquipmentCategory = new Label();
            lblEquipmentDescription = new Label();
            lblEquipmentName = new Label();
            lblTitle = new Label();
            btnBack = new Button();
            dtpPickupDate = new DateTimePicker();
            dtpReturnDate = new DateTimePicker();
            txtManagedBy = new TextBox();
            txtRentedEquipment = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblPayment = new Label();
            label4 = new Label();
            lblTimestamp = new Label();
            txtRentedBy = new TextBox();
            label6 = new Label();
            lblPickupDateError = new Label();
            lblDepositError = new Label();
            lblRentalFeeError = new Label();
            button1 = new Button();
            gbPaymentDetails = new GroupBox();
            lblPaymentMethod = new Label();
            lblPaymentStatus = new Label();
            cmbPaymentMethod = new ComboBox();
            cmbPaymentStatus = new ComboBox();
            gbPaymentDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblRentalPeriod
            // 
            lblRentalPeriod.AutoSize = true;
            lblRentalPeriod.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalPeriod.Location = new Point(268, 274);
            lblRentalPeriod.Margin = new Padding(2, 0, 2, 0);
            lblRentalPeriod.Name = "lblRentalPeriod";
            lblRentalPeriod.Size = new Size(125, 25);
            lblRentalPeriod.TabIndex = 82;
            lblRentalPeriod.Text = "Rental Period";
            // 
            // btnUpdateRentalTransaction
            // 
            btnUpdateRentalTransaction.BackColor = Color.FromArgb(121, 86, 76);
            btnUpdateRentalTransaction.FlatStyle = FlatStyle.Flat;
            btnUpdateRentalTransaction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateRentalTransaction.ForeColor = Color.White;
            btnUpdateRentalTransaction.Location = new Point(714, 412);
            btnUpdateRentalTransaction.Margin = new Padding(3, 2, 3, 2);
            btnUpdateRentalTransaction.Name = "btnUpdateRentalTransaction";
            btnUpdateRentalTransaction.Size = new Size(177, 33);
            btnUpdateRentalTransaction.TabIndex = 81;
            btnUpdateRentalTransaction.Text = "Save Changes";
            btnUpdateRentalTransaction.UseVisualStyleBackColor = false;
            btnUpdateRentalTransaction.Click += btnUpdateRentalTransaction_Click;
            // 
            // txtRentalFee
            // 
            txtRentalFee.BorderStyle = BorderStyle.FixedSingle;
            txtRentalFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalFee.Location = new Point(222, 375);
            txtRentalFee.Margin = new Padding(2, 1, 2, 1);
            txtRentalFee.Name = "txtRentalFee";
            txtRentalFee.PlaceholderText = " ";
            txtRentalFee.Size = new Size(226, 29);
            txtRentalFee.TabIndex = 80;
            txtRentalFee.TextChanged += txtRentalFee_TextChanged;
            // 
            // txtDeposit
            // 
            txtDeposit.BorderStyle = BorderStyle.FixedSingle;
            txtDeposit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDeposit.Location = new Point(222, 325);
            txtDeposit.Margin = new Padding(2, 1, 2, 1);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.PlaceholderText = " ";
            txtDeposit.Size = new Size(226, 29);
            txtDeposit.TabIndex = 79;
            txtDeposit.TextChanged += txtDeposit_TextChanged;
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 14F);
            lblRentalPrice.Location = new Point(66, 374);
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
            lblQuantity.Location = new Point(66, 324);
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
            lblEquipmentCategory.Location = new Point(66, 274);
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
            lblEquipmentDescription.Location = new Point(66, 224);
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
            lblEquipmentName.Location = new Point(66, 175);
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
            btnBack.Click += btnBack_Click;
            // 
            // dtpPickupDate
            // 
            dtpPickupDate.CalendarFont = new Font("Segoe UI", 12F);
            dtpPickupDate.Location = new Point(222, 177);
            dtpPickupDate.Name = "dtpPickupDate";
            dtpPickupDate.Size = new Size(226, 23);
            dtpPickupDate.TabIndex = 83;
            dtpPickupDate.ValueChanged += dtpPickupDate_ValueChanged;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.CalendarFont = new Font("Segoe UI", 12F);
            dtpReturnDate.Location = new Point(222, 226);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(226, 23);
            dtpReturnDate.TabIndex = 84;
            dtpReturnDate.ValueChanged += dtpReturnDate_ValueChanged;
            // 
            // txtManagedBy
            // 
            txtManagedBy.BorderStyle = BorderStyle.FixedSingle;
            txtManagedBy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtManagedBy.Location = new Point(666, 181);
            txtManagedBy.Margin = new Padding(2, 1, 2, 1);
            txtManagedBy.Name = "txtManagedBy";
            txtManagedBy.PlaceholderText = " ";
            txtManagedBy.ReadOnly = true;
            txtManagedBy.Size = new Size(226, 29);
            txtManagedBy.TabIndex = 88;
            // 
            // txtRentedEquipment
            // 
            txtRentedEquipment.BorderStyle = BorderStyle.FixedSingle;
            txtRentedEquipment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentedEquipment.Location = new Point(666, 123);
            txtRentedEquipment.Margin = new Padding(2, 1, 2, 1);
            txtRentedEquipment.Name = "txtRentedEquipment";
            txtRentedEquipment.PlaceholderText = " ";
            txtRentedEquipment.ReadOnly = true;
            txtRentedEquipment.Size = new Size(226, 29);
            txtRentedEquipment.TabIndex = 87;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(510, 175);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 86;
            label1.Text = "Managed By:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(485, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 85;
            label2.Text = "Rented Equipment:";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblPayment.ForeColor = Color.Green;
            lblPayment.Location = new Point(5, 55);
            lblPayment.Margin = new Padding(2, 0, 2, 0);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(57, 30);
            lblPayment.TabIndex = 89;
            lblPayment.Text = "Paid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(66, 122);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(209, 25);
            label4.TabIndex = 90;
            label4.Text = "Transaction Created at: ";
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimestamp.Location = new Point(279, 122);
            lblTimestamp.Margin = new Padding(2, 0, 2, 0);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(97, 25);
            lblTimestamp.TabIndex = 91;
            lblTimestamp.Text = "print time";
            // 
            // txtRentedBy
            // 
            txtRentedBy.BorderStyle = BorderStyle.FixedSingle;
            txtRentedBy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentedBy.Location = new Point(666, 233);
            txtRentedBy.Margin = new Padding(2, 1, 2, 1);
            txtRentedBy.Name = "txtRentedBy";
            txtRentedBy.PlaceholderText = " ";
            txtRentedBy.ReadOnly = true;
            txtRentedBy.Size = new Size(226, 29);
            txtRentedBy.TabIndex = 93;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(518, 232);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 92;
            label6.Text = "Rented By:";
            // 
            // lblPickupDateError
            // 
            lblPickupDateError.AutoSize = true;
            lblPickupDateError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPickupDateError.ForeColor = Color.Red;
            lblPickupDateError.Location = new Point(233, 252);
            lblPickupDateError.Margin = new Padding(2, 0, 2, 0);
            lblPickupDateError.Name = "lblPickupDateError";
            lblPickupDateError.Size = new Size(10, 13);
            lblPickupDateError.TabIndex = 94;
            lblPickupDateError.Text = " ";
            // 
            // lblDepositError
            // 
            lblDepositError.AutoSize = true;
            lblDepositError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDepositError.ForeColor = Color.Red;
            lblDepositError.Location = new Point(233, 358);
            lblDepositError.Margin = new Padding(2, 0, 2, 0);
            lblDepositError.Name = "lblDepositError";
            lblDepositError.Size = new Size(10, 13);
            lblDepositError.TabIndex = 95;
            lblDepositError.Text = " ";
            // 
            // lblRentalFeeError
            // 
            lblRentalFeeError.AutoSize = true;
            lblRentalFeeError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRentalFeeError.ForeColor = Color.Red;
            lblRentalFeeError.Location = new Point(233, 412);
            lblRentalFeeError.Margin = new Padding(2, 0, 2, 0);
            lblRentalFeeError.Name = "lblRentalFeeError";
            lblRentalFeeError.Size = new Size(10, 13);
            lblRentalFeeError.TabIndex = 96;
            lblRentalFeeError.Text = " ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(121, 86, 76);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(522, 412);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(177, 33);
            button1.TabIndex = 97;
            button1.Text = "View Documents";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // gbPaymentDetails
            // 
            gbPaymentDetails.Controls.Add(lblPaymentMethod);
            gbPaymentDetails.Controls.Add(lblPaymentStatus);
            gbPaymentDetails.Controls.Add(cmbPaymentMethod);
            gbPaymentDetails.Controls.Add(cmbPaymentStatus);
            gbPaymentDetails.Controls.Add(lblPayment);
            gbPaymentDetails.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPaymentDetails.Location = new Point(505, 281);
            gbPaymentDetails.Margin = new Padding(2, 1, 2, 1);
            gbPaymentDetails.Name = "gbPaymentDetails";
            gbPaymentDetails.Padding = new Padding(2, 1, 2, 1);
            gbPaymentDetails.Size = new Size(399, 117);
            gbPaymentDetails.TabIndex = 98;
            gbPaymentDetails.TabStop = false;
            gbPaymentDetails.Text = "Payment Details";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(109, 81);
            lblPaymentMethod.Margin = new Padding(2, 0, 2, 0);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(67, 20);
            lblPaymentMethod.TabIndex = 93;
            lblPaymentMethod.Text = "Method:";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Location = new Point(109, 40);
            lblPaymentStatus.Margin = new Padding(2, 0, 2, 0);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(54, 20);
            lblPaymentStatus.TabIndex = 92;
            lblPaymentStatus.Text = "Status:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(184, 77);
            cmbPaymentMethod.Margin = new Padding(2, 1, 2, 1);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(201, 27);
            cmbPaymentMethod.TabIndex = 91;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(184, 37);
            cmbPaymentStatus.Margin = new Padding(2, 1, 2, 1);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(201, 27);
            cmbPaymentStatus.TabIndex = 90;
            // 
            // EditRentalTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 458);
            Controls.Add(gbPaymentDetails);
            Controls.Add(button1);
            Controls.Add(lblRentalFeeError);
            Controls.Add(lblDepositError);
            Controls.Add(lblPickupDateError);
            Controls.Add(txtRentedBy);
            Controls.Add(label6);
            Controls.Add(lblTimestamp);
            Controls.Add(label4);
            Controls.Add(txtManagedBy);
            Controls.Add(txtRentedEquipment);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dtpReturnDate);
            Controls.Add(dtpPickupDate);
            Controls.Add(lblRentalPeriod);
            Controls.Add(btnUpdateRentalTransaction);
            Controls.Add(txtRentalFee);
            Controls.Add(txtDeposit);
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
            Load += EditRentalTransaction_Load;
            gbPaymentDetails.ResumeLayout(false);
            gbPaymentDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRentalPeriod;
        private Button btnUpdateRentalTransaction;
        private TextBox txtRentalFee;
        private TextBox txtDeposit;
        private Label lblRentalPrice;
        private Label lblQuantity;
        private Label lblEquipmentCategory;
        private Label lblEquipmentDescription;
        private Label lblEquipmentName;
        private Label lblTitle;
        private Button btnBack;
        private DateTimePicker dtpPickupDate;
        private DateTimePicker dtpReturnDate;
        private TextBox txtManagedBy;
        private TextBox txtRentedEquipment;
        private Label label1;
        private Label label2;
        private Label lblPayment;
        private Label label4;
        private Label lblTimestamp;
        private TextBox txtRentedBy;
        private Label label6;
        private Label lblPickupDateError;
        private Label lblDepositError;
        private Label lblRentalFeeError;
        private Button button1;
        private GroupBox gbPaymentDetails;
        private ComboBox cmbPaymentMethod;
        private ComboBox cmbPaymentStatus;
        private Label lblPaymentMethod;
        private Label lblPaymentStatus;
    }
}