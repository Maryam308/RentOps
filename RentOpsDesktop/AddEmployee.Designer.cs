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
            lblAddEmployee.Location = new Point(664, 34);
            lblAddEmployee.Margin = new Padding(5, 0, 5, 0);
            lblAddEmployee.Name = "lblAddEmployee";
            lblAddEmployee.Size = new Size(442, 82);
            lblAddEmployee.TabIndex = 3;
            lblAddEmployee.Text = "Add Employee";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(75, 50);
            btnBack.Margin = new Padding(5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(280, 75);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(139, 128, 116);
            btnAddEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(1414, 851);
            btnAddEmployee.Margin = new Padding(5);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(280, 75);
            btnAddEmployee.TabIndex = 9;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(800, 618);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(596, 57);
            txtEmail.TabIndex = 19;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(800, 500);
            txtPhone.Margin = new Padding(5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(596, 57);
            txtPhone.TabIndex = 18;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14F);
            txtFirstName.Location = new Point(800, 264);
            txtFirstName.Margin = new Padding(5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(596, 57);
            txtFirstName.TabIndex = 17;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 17.8000011F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(372, 611);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(141, 65);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 17.8000011F);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(372, 492);
            lblPhone.Margin = new Padding(5, 0, 5, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(349, 65);
            lblPhone.TabIndex = 15;
            lblPhone.Text = "Phone Number";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 17.8000011F);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(372, 254);
            lblFirstName.Margin = new Padding(5, 0, 5, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(255, 65);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14F);
            txtLastName.Location = new Point(800, 382);
            txtLastName.Margin = new Padding(5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(596, 57);
            txtLastName.TabIndex = 21;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 17.8000011F);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(372, 373);
            lblLastName.Margin = new Padding(5, 0, 5, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(250, 65);
            lblLastName.TabIndex = 20;
            lblLastName.Text = "Last Name";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(800, 736);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(596, 57);
            txtPassword.TabIndex = 23;
            txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 17.8000011F);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(372, 730);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(225, 65);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Password";
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFirstNameError.ForeColor = Color.Red;
            lblFirstNameError.Location = new Point(800, 326);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(60, 30);
            lblFirstNameError.TabIndex = 25;
            lblFirstNameError.Text = "Error";
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLastNameError.ForeColor = Color.Red;
            lblLastNameError.Location = new Point(800, 444);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(60, 30);
            lblLastNameError.TabIndex = 26;
            lblLastNameError.Text = "Error";
            // 
            // lblPhoneNumberError
            // 
            lblPhoneNumberError.AutoSize = true;
            lblPhoneNumberError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPhoneNumberError.ForeColor = Color.Red;
            lblPhoneNumberError.Location = new Point(800, 562);
            lblPhoneNumberError.Name = "lblPhoneNumberError";
            lblPhoneNumberError.Size = new Size(60, 30);
            lblPhoneNumberError.TabIndex = 27;
            lblPhoneNumberError.Text = "Error";
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(800, 680);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(60, 30);
            lblEmailError.TabIndex = 28;
            lblEmailError.Text = "Error";
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(800, 798);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(0, 30);
            lblPasswordError.TabIndex = 29;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 978);
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
            Margin = new Padding(5);
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