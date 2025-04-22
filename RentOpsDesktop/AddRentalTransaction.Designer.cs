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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRentalPeriod
            // 
            txtRentalPeriod.AutoSize = true;
            txtRentalPeriod.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalPeriod.Location = new Point(301, 296);
            txtRentalPeriod.Margin = new Padding(2, 0, 2, 0);
            txtRentalPeriod.Name = "txtRentalPeriod";
            txtRentalPeriod.Size = new Size(167, 32);
            txtRentalPeriod.TabIndex = 95;
            txtRentalPeriod.Text = "Rental Period";
            // 
            // btnAddRentalTransaction
            // 
            btnAddRentalTransaction.BackColor = Color.FromArgb(121, 86, 76);
            btnAddRentalTransaction.FlatStyle = FlatStyle.Flat;
            btnAddRentalTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRentalTransaction.ForeColor = Color.White;
            btnAddRentalTransaction.Location = new Point(285, 544);
            btnAddRentalTransaction.Margin = new Padding(3, 2, 3, 2);
            btnAddRentalTransaction.Name = "btnAddRentalTransaction";
            btnAddRentalTransaction.Size = new Size(635, 46);
            btnAddRentalTransaction.TabIndex = 94;
            btnAddRentalTransaction.Text = "Add Rental Transaction";
            btnAddRentalTransaction.UseVisualStyleBackColor = false;
            btnAddRentalTransaction.Click += btnAddRentalTransaction_Click;
            // 
            // txtRentalFee
            // 
            txtRentalFee.BorderStyle = BorderStyle.FixedSingle;
            txtRentalFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalFee.Location = new Point(301, 430);
            txtRentalFee.Margin = new Padding(2, 2, 2, 2);
            txtRentalFee.Name = "txtRentalFee";
            txtRentalFee.PlaceholderText = "Enter Rental Fee";
            txtRentalFee.Size = new Size(283, 34);
            txtRentalFee.TabIndex = 93;
            // 
            // txtDeposit
            // 
            txtDeposit.BorderStyle = BorderStyle.FixedSingle;
            txtDeposit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDeposit.Location = new Point(301, 364);
            txtDeposit.Margin = new Padding(2, 2, 2, 2);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.PlaceholderText = "Enter Deposit";
            txtDeposit.Size = new Size(283, 34);
            txtDeposit.TabIndex = 92;
            // 
            // txtReturnDate
            // 
            txtReturnDate.BorderStyle = BorderStyle.FixedSingle;
            txtReturnDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReturnDate.Location = new Point(301, 230);
            txtReturnDate.Margin = new Padding(2, 2, 2, 2);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.PlaceholderText = "Enter Return Date";
            txtReturnDate.Size = new Size(283, 34);
            txtReturnDate.TabIndex = 91;
            // 
            // txtPickupDate
            // 
            txtPickupDate.BorderStyle = BorderStyle.FixedSingle;
            txtPickupDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPickupDate.Location = new Point(301, 164);
            txtPickupDate.Margin = new Padding(2, 2, 2, 2);
            txtPickupDate.Name = "txtPickupDate";
            txtPickupDate.PlaceholderText = "Enter Pickup Date";
            txtPickupDate.Size = new Size(283, 34);
            txtPickupDate.TabIndex = 90;
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalPrice.Location = new Point(36, 428);
            lblRentalPrice.Margin = new Padding(2, 0, 2, 0);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(138, 32);
            lblRentalPrice.TabIndex = 89;
            lblRentalPrice.Text = "Rental Fee:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(36, 362);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(109, 32);
            lblQuantity.TabIndex = 88;
            lblQuantity.Text = "Deposit:";
            // 
            // lblEquipmentCategory
            // 
            lblEquipmentCategory.AutoSize = true;
            lblEquipmentCategory.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentCategory.Location = new Point(36, 296);
            lblEquipmentCategory.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentCategory.Name = "lblEquipmentCategory";
            lblEquipmentCategory.Size = new Size(174, 32);
            lblEquipmentCategory.TabIndex = 87;
            lblEquipmentCategory.Text = "Rental Period:";
            // 
            // lblEquipmentDescription
            // 
            lblEquipmentDescription.AutoSize = true;
            lblEquipmentDescription.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentDescription.Location = new Point(36, 228);
            lblEquipmentDescription.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentDescription.Name = "lblEquipmentDescription";
            lblEquipmentDescription.Size = new Size(158, 32);
            lblEquipmentDescription.TabIndex = 86;
            lblEquipmentDescription.Text = "Return Date:";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentName.Location = new Point(36, 164);
            lblEquipmentName.Margin = new Padding(2, 0, 2, 0);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(158, 32);
            lblEquipmentName.TabIndex = 85;
            lblEquipmentName.Text = "Pickup Date:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(370, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(547, 62);
            lblTitle.TabIndex = 84;
            lblTitle.Text = "Add Rental Transaction";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(61, 44);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(173, 46);
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
            groupBox1.Location = new Point(612, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 358);
            groupBox1.TabIndex = 96;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(239, 195);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Last Name";
            textBox1.Size = new Size(208, 34);
            textBox1.TabIndex = 100;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(239, 129);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter First Name";
            textBox2.Size = new Size(208, 34);
            textBox2.TabIndex = 99;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-168, 125);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 98;
            label1.Text = "Return Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-168, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 97;
            label2.Text = "Pickup Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 195);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 32);
            label3.TabIndex = 98;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 131);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 97;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 319);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(195, 32);
            label5.TabIndex = 102;
            label5.Text = "Phone Number:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(239, 319);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter Last Name";
            textBox3.Size = new Size(208, 34);
            textBox3.TabIndex = 104;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 255);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 32);
            label6.TabIndex = 101;
            label6.Text = "Email:";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(239, 253);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter First Name";
            textBox4.Size = new Size(208, 34);
            textBox4.TabIndex = 103;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 75);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 32);
            label7.TabIndex = 105;
            label7.Text = "User ID:";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(239, 73);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Enter First Name";
            textBox5.Size = new Size(208, 34);
            textBox5.TabIndex = 106;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(52, 32);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(193, 32);
            label8.TabIndex = 107;
            label8.Text = "Is website User:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 15F);
            checkBox1.Location = new Point(250, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 108;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // AddRentalTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 610);
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
            Margin = new Padding(2, 2, 2, 2);
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