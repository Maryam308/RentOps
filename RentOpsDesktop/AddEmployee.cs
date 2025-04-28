using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentOpsObjects.Model;

namespace RentOpsDesktop
{
    public partial class AddEmployee : Form
    {
        //Declaring database context object
        private RentOpsDBContext dbContext;


        bool isFirstNameValid;
        bool isLastNameValid;
        bool isEmailValid;
        bool isPhoneNumberValid;
        bool isPasswordValid;
        public AddEmployee()
        {
            InitializeComponent();

            //Initializing database context object
            dbContext = new RentOpsDBContext();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            validatePassword();

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                validateInput();

                // Stop further execution if validation failed
                if (!isFirstNameValid || !isLastNameValid || !isEmailValid || !isPhoneNumberValid || !isPasswordValid)
                {
                    return;
                }

                // Check if user already exists in the database
                var existingUser = dbContext.Users.FirstOrDefault(u =>
                    u.FirstName == txtFirstName.Text.Trim() &&
                    u.LastName == txtLastName.Text.Trim() &&
                    u.Email == txtEmail.Text.Trim() &&
                    u.PhoneNumber == txtPhone.Text.Trim() &&
                    u.RoleId == 2 // Employee role ID
                );

                if (existingUser != null)
                {
                    MessageBox.Show($"User already exists in the system with ID: {existingUser.UserId}", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Creating a new employee object
                User employee = new User
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    PhoneNumber = txtPhone.Text.Trim(),
                    RoleId = 2, // Assuming 2 is the role ID for employees
                };

                //Adding the employee to the database and saving the changes
                dbContext.Users.Add(employee);
                dbContext.SaveChanges();

                //Displaying a success message
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validateInput()
        {
            // Validate that all fields are filled
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password is not empty
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblPasswordError.Text = "Password cannot be empty.";
                isPasswordValid = false;
            }
            else
            {
                lblPasswordError.Text = "";
                isPasswordValid = true;
            }

            // Validate the input is correct
            if (!isFirstNameValid || !isLastNameValid || !isEmailValid || !isPhoneNumberValid || !isPasswordValid)
            {
                MessageBox.Show("Please correct the highlighted errors.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            //Validate that the first name input is only letters and at least 3 characters long
            string pattern = @"^[a-zA-Z]{3,}$";
            if (!Regex.IsMatch(txtFirstName.Text, pattern))
            {
                lblFirstNameError.Text = "Invalid Name";
                isFirstNameValid = false;
            }
            else
            {
                lblFirstNameError.Text = "";
                isFirstNameValid = true;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            //Validate that the last name input is only letters and at least 3 characters long
            string pattern = @"^[a-zA-Z]{3,}$";
            if (!Regex.IsMatch(txtLastName.Text, pattern))
            {
                lblLastNameError.Text = "Invalid Name";
                isLastNameValid = false;
            }
            else
            {
                lblLastNameError.Text = "";
                isLastNameValid = true;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            //Validate that the phone number input is exactly 8 digits long
            string pattern = @"^\d{8}$";

            if (!Regex.IsMatch(txtPhone.Text.Trim(), pattern))
            {
                lblPhoneNumberError.Text = "Invalid Phone Number. Must be exactly 8 digits.";
                isPhoneNumberValid = false;
            }
            else
            {
                lblPhoneNumberError.Text = "";
                isPhoneNumberValid = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //Validate that the email input is in the correct format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(txtEmail.Text.Trim(), pattern))
            {
                lblEmailError.Text = "Invalid Email Address";
                isEmailValid = false;
            }
            else
            {
                lblEmailError.Text = "";
                isEmailValid = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void validatePassword()
        {
            if (txtPassword.Text.Trim() == "")
            {
                lblPasswordError.Text = "Password cannot be empty!";
                isPasswordValid = false;
            }
            else
            {
                lblPasswordError.Text = "";
                isPasswordValid = true;
            }

        }
    }
}
