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
            txtRentalPeriod = new Label();
            btnAddRentalTransaction = new Button();
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
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRentalPeriod
            // 
            txtRentalPeriod.AutoSize = true;
            txtRentalPeriod.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalPeriod.Location = new Point(285, 227);
            txtRentalPeriod.Margin = new Padding(2, 0, 2, 0);
            txtRentalPeriod.Name = "txtRentalPeriod";
            txtRentalPeriod.Size = new Size(196, 25);
            txtRentalPeriod.TabIndex = 95;
            txtRentalPeriod.Text = "fetch the equipment ";
            // 
            // btnAddRentalTransaction
            // 
            btnAddRentalTransaction.BackColor = Color.FromArgb(121, 86, 76);
            btnAddRentalTransaction.FlatStyle = FlatStyle.Flat;
            btnAddRentalTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRentalTransaction.ForeColor = Color.White;
            btnAddRentalTransaction.Location = new Point(249, 408);
            btnAddRentalTransaction.Margin = new Padding(3, 2, 3, 2);
            btnAddRentalTransaction.Name = "btnAddRentalTransaction";
            btnAddRentalTransaction.Size = new Size(556, 34);
            btnAddRentalTransaction.TabIndex = 94;
            btnAddRentalTransaction.Text = "Add Rental Transaction";
            btnAddRentalTransaction.UseVisualStyleBackColor = false;
            btnAddRentalTransaction.Click += btnAddRentalTransaction_Click;
            // 
            // txtRentalFee
            // 
            txtRentalFee.BorderStyle = BorderStyle.FixedSingle;
            txtRentalFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalFee.Location = new Point(263, 327);
            txtRentalFee.Margin = new Padding(2);
            txtRentalFee.Name = "txtRentalFee";
            txtRentalFee.PlaceholderText = "Enter Rental Fee";
            txtRentalFee.Size = new Size(248, 29);
            txtRentalFee.TabIndex = 93;
            // 
            // txtDeposit
            // 
            txtDeposit.BorderStyle = BorderStyle.FixedSingle;
            txtDeposit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDeposit.Location = new Point(263, 278);
            txtDeposit.Margin = new Padding(2);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.PlaceholderText = "Enter Deposit";
            txtDeposit.Size = new Size(248, 29);
            txtDeposit.TabIndex = 92;
            // 
            // txtReturnDate
            // 
            txtReturnDate.BorderStyle = BorderStyle.FixedSingle;
            txtReturnDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReturnDate.Location = new Point(263, 177);
            txtReturnDate.Margin = new Padding(2);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.PlaceholderText = "Enter Return Date";
            txtReturnDate.Size = new Size(248, 29);
            txtReturnDate.TabIndex = 91;
            // 
            // txtPickupDate
            // 
            txtPickupDate.BorderStyle = BorderStyle.FixedSingle;
            txtPickupDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPickupDate.Location = new Point(263, 128);
            txtPickupDate.Margin = new Padding(2);
            txtPickupDate.Name = "txtPickupDate";
            txtPickupDate.PlaceholderText = "Enter Pickup Date";
            txtPickupDate.Size = new Size(248, 29);
            txtPickupDate.TabIndex = 90;
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalPrice.Location = new Point(32, 326);
            lblRentalPrice.Margin = new Padding(2, 0, 2, 0);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(108, 25);
            lblRentalPrice.TabIndex = 89;
            lblRentalPrice.Text = "Rental Fee:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(32, 277);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(85, 25);
            lblQuantity.TabIndex = 88;
            lblQuantity.Text = "Deposit:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentCategory.Location = new Point(32, 227);
            lblEquipmentCategory.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(193, 25);
            lblEquipmentCategory.TabIndex = 87;
            lblEquipmentCategory.Text = "Equipment Selected:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentDescription.Location = new Point(32, 176);
            lblEquipmentDescription.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(124, 25);
            lblEquipmentDescription.TabIndex = 86;
            lblEquipmentDescription.Text = "Return Date:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentName.Location = new Point(32, 128);
            lblEquipmentName.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(124, 25);
            lblEquipmentName.TabIndex = 85;
            lblEquipmentName.Text = "Pickup Date:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(324, 33);
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
            btnBack.Location = new Point(53, 33);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(151, 34);
            btnBack.TabIndex = 83;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(536, 100);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(411, 268);
            groupBox1.TabIndex = 96;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 15F);
            checkBox1.Location = new Point(219, 35);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 108;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(46, 24);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(149, 25);
            label8.TabIndex = 107;
            label8.Text = "Is website User:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 56);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 105;
            label7.Text = "User ID:";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(209, 55);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Enter First Name";
            textBox5.Size = new Size(182, 29);
            textBox5.TabIndex = 106;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 239);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 102;
            label5.Text = "Phone Number:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(209, 239);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter Last Name";
            textBox3.Size = new Size(182, 29);
            textBox3.TabIndex = 104;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 191);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 101;
            label6.Text = "Email:";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(209, 190);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter First Name";
            textBox4.Size = new Size(182, 29);
            textBox4.TabIndex = 103;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 146);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 98;
            label3.Text = "Last Name:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(209, 146);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Last Name";
            textBox1.Size = new Size(182, 29);
            textBox1.TabIndex = 100;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 98);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 97;
            label4.Text = "First Name:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(209, 97);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter First Name";
            textBox2.Size = new Size(182, 29);
            textBox2.TabIndex = 99;
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
            // AddRentalTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 458);
            Controls.Add(groupBox1);
            Controls.Add(txtRentalPeriod);
            Controls.Add(btnAddRentalTransaction);
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
            Margin = new Padding(2);
            Name = "AddRentalTransaction";
            Text = "AddRentalTransaction";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtRentalPeriod;
        private Button btnAddRentalTransaction;
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
        private GroupBox groupBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private Label label8;
        private Label label7;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
    }
}