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
            txtUsername = new TextBox();
            lblEmail = new Label();
            lblPhone = new Label();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblAddEmployee = new Label();
            SuspendLayout();
            // 
            // lblAddEmployee
            // 
            lblAddEmployee.AutoSize = true;
            lblAddEmployee.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblAddEmployee.ForeColor = Color.FromArgb(135, 66, 62);
            lblAddEmployee.Location = new Point(391, 21);
            lblAddEmployee.Name = "lblAddEmployee";
            lblAddEmployee.Size = new Size(281, 52);
            lblAddEmployee.TabIndex = 3;
            lblAddEmployee.Text = "Add Employee";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(46, 31);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(172, 47);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(139, 128, 116);
            btnAddEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(870, 532);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(172, 47);
            btnAddEmployee.TabIndex = 9;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(492, 369);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(368, 39);
            txtEmail.TabIndex = 19;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(492, 306);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(368, 39);
            txtPhone.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14F);
            txtUsername.Location = new Point(492, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(368, 39);
            txtUsername.TabIndex = 17;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 17.8000011F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(229, 369);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(88, 41);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 17.8000011F);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(229, 301);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(220, 41);
            lblPhone.TabIndex = 15;
            lblPhone.Text = "Phone Number";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 17.8000011F);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(229, 159);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(160, 41);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14F);
            txtLastName.Location = new Point(492, 237);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(368, 39);
            txtLastName.TabIndex = 21;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 17.8000011F);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(229, 231);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(157, 41);
            lblLastName.TabIndex = 20;
            lblLastName.Text = "Last Name";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(492, 431);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(368, 39);
            txtPassword.TabIndex = 23;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 17.8000011F);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(229, 431);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(143, 41);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Password";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtUsername);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblFirstName);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnBack);
            Controls.Add(lblAddEmployee);
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
        private TextBox txtUsername;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtPassword;
        private Label lblPassword;
    }
}