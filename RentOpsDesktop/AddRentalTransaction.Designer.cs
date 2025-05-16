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
            txtEquipment = new Label();
            btnAddRentalTransaction = new Button();
            txtRentalFee = new TextBox();
            txtDeposit = new TextBox();
            lblRentalPrice = new Label();
            lblQuantity = new Label();
            lblEquipmentCategory = new Label();
            lblEquipmentDescription = new Label();
            lblEquipmentName = new Label();
            lblTitle = new Label();
            btnBack = new Button();
            gbCustomer = new GroupBox();
            lblUserIdErr = new Label();
            lblPhoneNumberErr = new Label();
            lblEmailErr = new Label();
            lblLastNameErr = new Label();
            lblFirstNameErr = new Label();
            checkBox1 = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            txtUserId = new TextBox();
            label5 = new Label();
            txtPhoneNumber = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            cmbPaymentStatus = new ComboBox();
            lblReturnDateErr = new Label();
            lblDepositeErr = new Label();
            dtpReturnDate = new DateTimePicker();
            dtpPickupDate = new DateTimePicker();
            gbPayment = new GroupBox();
            cmbPaymentMethod = new ComboBox();
            label11 = new Label();
            checkBox2 = new CheckBox();
            label10 = new Label();
            label16 = new Label();
            label17 = new Label();
            gbRental = new GroupBox();
            label20 = new Label();
            label21 = new Label();
            btnUploadDocuments = new Button();
            gbCustomer.SuspendLayout();
            gbPayment.SuspendLayout();
            gbRental.SuspendLayout();
            SuspendLayout();
            // 
            // txtEquipment
            // 
            txtEquipment.AutoSize = true;
            txtEquipment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtEquipment.Location = new Point(197, 30);
            txtEquipment.Margin = new Padding(2, 0, 2, 0);
            txtEquipment.Name = "txtEquipment";
            txtEquipment.Size = new Size(164, 21);
            txtEquipment.TabIndex = 95;
            txtEquipment.Text = "fetch the equipment ";
            // 
            // btnAddRentalTransaction
            // 
            btnAddRentalTransaction.BackColor = Color.FromArgb(121, 86, 76);
            btnAddRentalTransaction.FlatStyle = FlatStyle.Flat;
            btnAddRentalTransaction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRentalTransaction.ForeColor = Color.White;
            btnAddRentalTransaction.Location = new Point(685, 394);
            btnAddRentalTransaction.Margin = new Padding(3, 2, 3, 2);
            btnAddRentalTransaction.Name = "btnAddRentalTransaction";
            btnAddRentalTransaction.Size = new Size(223, 44);
            btnAddRentalTransaction.TabIndex = 94;
            btnAddRentalTransaction.Text = "Add Rental Transaction";
            btnAddRentalTransaction.UseVisualStyleBackColor = false;
            btnAddRentalTransaction.Click += btnAddRentalTransaction_Click;
            // 
            // txtRentalFee
            // 
            txtRentalFee.BorderStyle = BorderStyle.FixedSingle;
            txtRentalFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalFee.Location = new Point(139, 164);
            txtRentalFee.Margin = new Padding(2);
            txtRentalFee.Name = "txtRentalFee";
            txtRentalFee.ReadOnly = true;
            txtRentalFee.Size = new Size(220, 29);
            txtRentalFee.TabIndex = 93;
            // 
            // txtDeposit
            // 
            txtDeposit.BorderStyle = BorderStyle.FixedSingle;
            txtDeposit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDeposit.Location = new Point(139, 210);
            txtDeposit.Margin = new Padding(2);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(220, 29);
            txtDeposit.TabIndex = 92;
            txtDeposit.TextChanged += txtDeposit_TextChanged;
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 12F);
            lblRentalPrice.Location = new Point(19, 166);
            lblRentalPrice.Margin = new Padding(2, 0, 2, 0);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(85, 21);
            lblRentalPrice.TabIndex = 89;
            lblRentalPrice.Text = "Rental Fee:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F);
            lblQuantity.Location = new Point(19, 212);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(66, 21);
            lblQuantity.TabIndex = 88;
            lblQuantity.Text = "Deposit:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 12F);
            lblEquipmentCategory.Location = new Point(18, 30);
            lblEquipmentCategory.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(150, 21);
            lblEquipmentCategory.TabIndex = 87;
            lblEquipmentCategory.Text = "Equipment Selected:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 12F);
            lblEquipmentDescription.Location = new Point(19, 116);
            lblEquipmentDescription.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(96, 21);
            lblEquipmentDescription.TabIndex = 86;
            lblEquipmentDescription.Text = "Return Date:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 12F);
            lblEquipmentName.Location = new Point(19, 75);
            lblEquipmentName.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(95, 21);
            lblEquipmentName.TabIndex = 85;
            lblEquipmentName.Text = "Pickup Date:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(292, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(443, 51);
            lblTitle.TabIndex = 84;
            lblTitle.Text = "Add Rental Transaction";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 11);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 44);
            btnBack.TabIndex = 83;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // gbCustomer
            // 
            gbCustomer.Controls.Add(lblUserIdErr);
            gbCustomer.Controls.Add(lblPhoneNumberErr);
            gbCustomer.Controls.Add(lblEmailErr);
            gbCustomer.Controls.Add(lblLastNameErr);
            gbCustomer.Controls.Add(lblFirstNameErr);
            gbCustomer.Controls.Add(checkBox1);
            gbCustomer.Controls.Add(label8);
            gbCustomer.Controls.Add(label7);
            gbCustomer.Controls.Add(txtUserId);
            gbCustomer.Controls.Add(label5);
            gbCustomer.Controls.Add(txtPhoneNumber);
            gbCustomer.Controls.Add(label6);
            gbCustomer.Controls.Add(txtEmail);
            gbCustomer.Controls.Add(label3);
            gbCustomer.Controls.Add(txtLastName);
            gbCustomer.Controls.Add(label4);
            gbCustomer.Controls.Add(txtFirstName);
            gbCustomer.Controls.Add(label2);
            gbCustomer.Controls.Add(label1);
            gbCustomer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbCustomer.Location = new Point(511, 64);
            gbCustomer.Margin = new Padding(3, 2, 3, 2);
            gbCustomer.Name = "gbCustomer";
            gbCustomer.Padding = new Padding(3, 2, 3, 2);
            gbCustomer.Size = new Size(411, 270);
            gbCustomer.TabIndex = 96;
            gbCustomer.TabStop = false;
            gbCustomer.Text = "Customer Details";
            gbCustomer.Enter += gbCustomer_Enter;
            // 
            // lblUserIdErr
            // 
            lblUserIdErr.AutoSize = true;
            lblUserIdErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUserIdErr.ForeColor = Color.Red;
            lblUserIdErr.Location = new Point(217, 64);
            lblUserIdErr.Name = "lblUserIdErr";
            lblUserIdErr.Size = new Size(0, 15);
            lblUserIdErr.TabIndex = 113;
            // 
            // lblPhoneNumberErr
            // 
            lblPhoneNumberErr.AutoSize = true;
            lblPhoneNumberErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPhoneNumberErr.ForeColor = Color.Red;
            lblPhoneNumberErr.Location = new Point(174, 243);
            lblPhoneNumberErr.Name = "lblPhoneNumberErr";
            lblPhoneNumberErr.Size = new Size(0, 15);
            lblPhoneNumberErr.TabIndex = 112;
            // 
            // lblEmailErr
            // 
            lblEmailErr.AutoSize = true;
            lblEmailErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmailErr.ForeColor = Color.Red;
            lblEmailErr.Location = new Point(174, 191);
            lblEmailErr.Name = "lblEmailErr";
            lblEmailErr.Size = new Size(0, 15);
            lblEmailErr.TabIndex = 111;
            // 
            // lblLastNameErr
            // 
            lblLastNameErr.AutoSize = true;
            lblLastNameErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLastNameErr.ForeColor = Color.Red;
            lblLastNameErr.Location = new Point(242, 139);
            lblLastNameErr.Name = "lblLastNameErr";
            lblLastNameErr.Size = new Size(0, 15);
            lblLastNameErr.TabIndex = 110;
            // 
            // lblFirstNameErr
            // 
            lblFirstNameErr.AutoSize = true;
            lblFirstNameErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFirstNameErr.ForeColor = Color.Red;
            lblFirstNameErr.Location = new Point(66, 137);
            lblFirstNameErr.Name = "lblFirstNameErr";
            lblFirstNameErr.Size = new Size(0, 15);
            lblFirstNameErr.TabIndex = 109;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 15F);
            checkBox1.Location = new Point(169, 44);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 108;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(27, 37);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(117, 21);
            label8.TabIndex = 107;
            label8.Text = "Is website User:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(210, 37);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 21);
            label7.TabIndex = 105;
            label7.Text = "User ID:";
            // 
            // txtUserId
            // 
            txtUserId.BorderStyle = BorderStyle.FixedSingle;
            txtUserId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserId.Location = new Point(278, 35);
            txtUserId.Margin = new Padding(2);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(105, 29);
            txtUserId.TabIndex = 106;
            txtUserId.TextChanged += txtUserId_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(19, 210);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 102;
            label5.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(160, 210);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(223, 29);
            txtPhoneNumber.TabIndex = 104;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(19, 159);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 101;
            label6.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(160, 158);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 29);
            txtEmail.TabIndex = 103;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(210, 84);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 98;
            label3.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(233, 108);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 29);
            txtLastName.TabIndex = 100;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(27, 84);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 97;
            label4.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(43, 108);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 29);
            txtFirstName.TabIndex = 99;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-147, 46);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 97;
            label2.Text = "Pickup Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-147, 94);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 98;
            label1.Text = "Return Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(364, 28);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(119, 21);
            label9.TabIndex = 97;
            label9.Text = "Payment Status:";
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.Font = new Font("Segoe UI", 12F);
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(365, 52);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(185, 29);
            cmbPaymentStatus.TabIndex = 98;
            // 
            // lblReturnDateErr
            // 
            lblReturnDateErr.AutoSize = true;
            lblReturnDateErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblReturnDateErr.ForeColor = Color.Red;
            lblReturnDateErr.Location = new Point(154, 147);
            lblReturnDateErr.Name = "lblReturnDateErr";
            lblReturnDateErr.Size = new Size(0, 15);
            lblReturnDateErr.TabIndex = 99;
            // 
            // lblDepositeErr
            // 
            lblDepositeErr.AutoSize = true;
            lblDepositeErr.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDepositeErr.ForeColor = Color.Red;
            lblDepositeErr.Location = new Point(154, 245);
            lblDepositeErr.Name = "lblDepositeErr";
            lblDepositeErr.Size = new Size(0, 15);
            lblDepositeErr.TabIndex = 100;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.CalendarFont = new Font("Segoe UI", 12F);
            dtpReturnDate.Font = new Font("Segoe UI", 12F);
            dtpReturnDate.Location = new Point(139, 111);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(220, 29);
            dtpReturnDate.TabIndex = 102;
            dtpReturnDate.ValueChanged += dtpReturnDate_ValueChanged;
            // 
            // dtpPickupDate
            // 
            dtpPickupDate.CalendarFont = new Font("Segoe UI", 12F);
            dtpPickupDate.Font = new Font("Segoe UI", 12F);
            dtpPickupDate.Location = new Point(139, 69);
            dtpPickupDate.Name = "dtpPickupDate";
            dtpPickupDate.Size = new Size(220, 29);
            dtpPickupDate.TabIndex = 103;
            dtpPickupDate.ValueChanged += dtpPickupDate_ValueChanged;
            // 
            // gbPayment
            // 
            gbPayment.Controls.Add(cmbPaymentMethod);
            gbPayment.Controls.Add(label11);
            gbPayment.Controls.Add(checkBox2);
            gbPayment.Controls.Add(label10);
            gbPayment.Controls.Add(label16);
            gbPayment.Controls.Add(label17);
            gbPayment.Controls.Add(cmbPaymentStatus);
            gbPayment.Controls.Add(label9);
            gbPayment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            gbPayment.Location = new Point(54, 342);
            gbPayment.Margin = new Padding(3, 2, 3, 2);
            gbPayment.Name = "gbPayment";
            gbPayment.Padding = new Padding(3, 2, 3, 2);
            gbPayment.Size = new Size(601, 98);
            gbPayment.TabIndex = 104;
            gbPayment.TabStop = false;
            gbPayment.Text = "Total Payment Details";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Font = new Font("Segoe UI", 12F);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(159, 52);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(185, 29);
            cmbPaymentMethod.TabIndex = 110;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(159, 28);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(131, 21);
            label11.TabIndex = 109;
            label11.Text = "Payment Method:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 15F);
            checkBox2.Location = new Point(96, 41);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 108;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(34, 34);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(57, 21);
            label10.TabIndex = 107;
            label10.Text = "Is Paid:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(-147, 45);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(124, 25);
            label16.TabIndex = 97;
            label16.Text = "Pickup Date:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(-147, 93);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(124, 25);
            label17.TabIndex = 98;
            label17.Text = "Return Date:";
            // 
            // gbRental
            // 
            gbRental.Controls.Add(label20);
            gbRental.Controls.Add(label21);
            gbRental.Controls.Add(dtpPickupDate);
            gbRental.Controls.Add(txtEquipment);
            gbRental.Controls.Add(dtpReturnDate);
            gbRental.Controls.Add(lblEquipmentName);
            gbRental.Controls.Add(lblDepositeErr);
            gbRental.Controls.Add(lblEquipmentDescription);
            gbRental.Controls.Add(lblReturnDateErr);
            gbRental.Controls.Add(lblEquipmentCategory);
            gbRental.Controls.Add(lblRentalPrice);
            gbRental.Controls.Add(txtDeposit);
            gbRental.Controls.Add(txtRentalFee);
            gbRental.Controls.Add(lblQuantity);
            gbRental.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            gbRental.Location = new Point(54, 64);
            gbRental.Margin = new Padding(3, 2, 3, 2);
            gbRental.Name = "gbRental";
            gbRental.Padding = new Padding(3, 2, 3, 2);
            gbRental.Size = new Size(411, 270);
            gbRental.TabIndex = 109;
            gbRental.TabStop = false;
            gbRental.Text = "Rental Details";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(-147, 45);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(124, 25);
            label20.TabIndex = 97;
            label20.Text = "Pickup Date:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(-147, 93);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(124, 25);
            label21.TabIndex = 98;
            label21.Text = "Return Date:";
            // 
            // btnUploadDocuments
            // 
            btnUploadDocuments.BackColor = Color.FromArgb(121, 86, 76);
            btnUploadDocuments.FlatStyle = FlatStyle.Flat;
            btnUploadDocuments.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadDocuments.ForeColor = Color.White;
            btnUploadDocuments.Location = new Point(685, 346);
            btnUploadDocuments.Margin = new Padding(3, 2, 3, 2);
            btnUploadDocuments.Name = "btnUploadDocuments";
            btnUploadDocuments.Size = new Size(223, 44);
            btnUploadDocuments.TabIndex = 110;
            btnUploadDocuments.Text = "Upload Documents";
            btnUploadDocuments.UseVisualStyleBackColor = false;
            btnUploadDocuments.Click += btnUploadDocuments_Click;
            // 
            // AddRentalTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 458);
            Controls.Add(btnUploadDocuments);
            Controls.Add(gbRental);
            Controls.Add(gbPayment);
            Controls.Add(gbCustomer);
            Controls.Add(btnAddRentalTransaction);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Margin = new Padding(2);
            Name = "AddRentalTransaction";
            Text = "AddRentalTransaction";
            Load += AddRentalTransaction_Load;
            gbCustomer.ResumeLayout(false);
            gbCustomer.PerformLayout();
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            gbRental.ResumeLayout(false);
            gbRental.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtEquipment;
        private Button btnAddRentalTransaction;
        private TextBox txtRentalFee;
        private TextBox txtDeposit;
        private Label lblRentalPrice;
        private Label lblQuantity;
        private Label lblEquipmentCategory;
        private Label lblEquipmentDescription;
        private Label lblEquipmentName;
        private Label lblTitle;
        private Button btnBack;
        private GroupBox gbCustomer;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private Label label8;
        private Label label7;
        private TextBox txtUserId;
        private Label label5;
        private TextBox txtPhoneNumber;
        private Label label6;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private Label label9;
        private ComboBox cmbPaymentStatus;
        private Label lblReturnDateErr;
        private Label lblDepositeErr;
        private DateTimePicker dtpReturnDate;
        private DateTimePicker dtpPickupDate;
        private GroupBox gbPayment;
        private CheckBox checkBox2;
        private Label label10;
        private Label label16;
        private Label label17;
        private ComboBox cmbPaymentMethod;
        private Label label11;
        private Label lblFirstNameErr;
        private GroupBox gbRental;
        private Label label20;
        private Label label21;
        private Label lblPhoneNumberErr;
        private Label lblEmailErr;
        private Label lblLastNameErr;
        private Label lblUserIdErr;
        private Button btnUploadDocuments;
    }
}