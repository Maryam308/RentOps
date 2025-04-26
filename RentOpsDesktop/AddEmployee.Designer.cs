namespace RentOpsDesktop
{
    partial class AddEmployee
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
            Label lblAddEmployee;
            btnBack = new Button();
            btnAddEmployee = new Button();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtFirstName = new TextBox();
            lblEmail = new Label();
            lblPhone = new Label();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblFirstNameError = new Label();
            lblLastNameError = new Label();
            lblPhoneNumberError = new Label();
            lblEmailError = new Label();
            lblPasswordError = new Label();
            lblAddEmployee = new Label();
            SuspendLayout();
            // 
            // lblAddEmployee
            // 
            lblAddEmployee.AutoSize = true;
            lblAddEmployee.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblAddEmployee.ForeColor = Color.FromArgb(135, 66, 62);
            lblAddEmployee.Location = new Point(358, 16);
            lblAddEmployee.Name = "lblAddEmployee";
            lblAddEmployee.Size = new Size(224, 42);
            lblAddEmployee.TabIndex = 3;
            lblAddEmployee.Text = "Add Employee";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(40, 23);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(151, 35);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(121, 86, 76);
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(761, 388);
            btnAddEmployee.Margin = new Padding(3, 2, 3, 2);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(179, 44);
            btnAddEmployee.TabIndex = 9;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(431, 290);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 32);
            txtEmail.TabIndex = 19;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(431, 234);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(323, 32);
            txtPhone.TabIndex = 18;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14F);
            txtFirstName.Location = new Point(431, 124);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(323, 32);
            txtFirstName.TabIndex = 17;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 17.8000011F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(200, 286);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 17.8000011F);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(200, 231);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(177, 32);
            lblPhone.TabIndex = 15;
            lblPhone.Text = "Phone Number";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 17.8000011F);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(200, 119);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(129, 32);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14F);
            txtLastName.Location = new Point(431, 179);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(323, 32);
            txtLastName.TabIndex = 21;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 17.8000011F);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(200, 175);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(126, 32);
            lblLastName.TabIndex = 20;
            lblLastName.Text = "Last Name";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(431, 345);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(323, 32);
            txtPassword.TabIndex = 23;
            txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 17.8000011F);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(200, 342);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(111, 32);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Password";
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFirstNameError.ForeColor = Color.Red;
            lblFirstNameError.Location = new Point(442, 158);
            lblFirstNameError.Margin = new Padding(2, 0, 2, 0);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(10, 13);
            lblFirstNameError.TabIndex = 25;
            lblFirstNameError.Text = " ";
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLastNameError.ForeColor = Color.Red;
            lblLastNameError.Location = new Point(442, 213);
            lblLastNameError.Margin = new Padding(2, 0, 2, 0);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(10, 13);
            lblLastNameError.TabIndex = 26;
            lblLastNameError.Text = " ";
            // 
            // lblPhoneNumberError
            // 
            lblPhoneNumberError.AutoSize = true;
            lblPhoneNumberError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPhoneNumberError.ForeColor = Color.Red;
            lblPhoneNumberError.Location = new Point(442, 268);
            lblPhoneNumberError.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumberError.Name = "lblPhoneNumberError";
            lblPhoneNumberError.Size = new Size(10, 13);
            lblPhoneNumberError.TabIndex = 27;
            lblPhoneNumberError.Text = " ";
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(442, 324);
            lblEmailError.Margin = new Padding(2, 0, 2, 0);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(10, 13);
            lblEmailError.TabIndex = 28;
            lblEmailError.Text = " ";
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(442, 379);
            lblPasswordError.Margin = new Padding(2, 0, 2, 0);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(0, 13);
            lblPasswordError.TabIndex = 29;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 458);
            Controls.Add(lblPasswordError);
            Controls.Add(lblEmailError);
            Controls.Add(lblPhoneNumberError);
            Controls.Add(lblLastNameError);
            Controls.Add(lblFirstNameError);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFirstName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblFirstName);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnBack);
            Controls.Add(lblAddEmployee);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddEmployee";
            Text = "AddEmployee";
            Load += AddEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddEmployee;
        private Button btnBack;
        private Button btnAddEmployee;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtFirstName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblFirstNameError;
        private Label lblLastNameError;
        private Label lblPhoneNumberError;
        private Label lblEmailError;
        private Label lblPasswordError;
    }
}