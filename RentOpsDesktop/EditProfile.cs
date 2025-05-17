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
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsObjects.Services;


namespace RentOpsDesktop
{
    public partial class EditProfile : Form
    {
        bool isFirstNameValid;
        bool isLastNameValid;
        bool isEmailValid;
        bool isPhoneNumberValid;

        int currentUserId;
        RentOpsDBContext dbContext;
        AuditLogger logger;

        public EditProfile()
        {
            InitializeComponent();
            dbContext = new RentOpsDBContext();
            logger = new AuditLogger(dbContext); //create a logger object
            currentUserId = Global.EmployeeID;
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //show login form
            Login loginForm = new Login();
            this.Hide(); //hide the current form
            loginForm.Show(); //show login form
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

            try
            {
                var userId = Global.EmployeeID; // Get the global employee ID
                var employee = dbContext.Users.FirstOrDefault(e => e.UserId == userId);

                if (employee == null)
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Display the employee details in the text boxes
                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtEmail.Text = employee.Email;
                txtPhone.Text = employee.PhoneNumber?.ToString() ?? string.Empty;
            }
            catch (Exception ex)
            {
                //log the exception
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);

                //show the error message
                MessageBox.Show("An error occurred while loading the form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            Profile profileForm = new Profile();
            profileForm.Show(); //show profile form
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateInput())
                {
                    return; // Stop if validation fails
                }

                // Fetch the employee object from the database
                User employee = dbContext.Users.Find(Global.EmployeeID);

                // Check if the data has changed
                bool isFirstNameChanged = employee.FirstName != txtFirstName.Text.Trim();
                bool isLastNameChanged = employee.LastName != txtLastName.Text.Trim();
                bool isEmailChanged = employee.Email != txtEmail.Text.Trim();
                bool isPhoneChanged = (employee.PhoneNumber ?? "") != txtPhone.Text.Trim();

                // If no changes detected
                if (!isFirstNameChanged && !isLastNameChanged && !isEmailChanged && !isPhoneChanged)
                {
                    DialogResult result = MessageBox.Show("You have not made any changes. If you don't want to edit, you can click 'Close' to return to your profile.", "No Changes Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Exit without saving
                }

                // Ask for confirmation before saving
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Update the employee details
                employee.FirstName = txtFirstName.Text.Trim();
                employee.LastName = txtLastName.Text.Trim();
                employee.Email = txtEmail.Text.Trim();
                employee.PhoneNumber = txtPhone.Text.Trim();

                dbContext.Users.Update(employee);
                
                // Track changes 
                logger.TrackChanges(Global.user.UserId, Global.sourceId ?? 2); //call track changes function to insert the logs

                //save the changes
                dbContext.SaveChanges();

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //log the exception
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);

                //show the error message
                MessageBox.Show("An error occurred while saving changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEquipmentDashboard_Click(object sender, EventArgs e)
        {
            //Hide the current form and navigate to the EquipmentDashboard form
            this.Hide(); //hide the current form
            UserEquipmentDashboard equipmentDashboardForm = new UserEquipmentDashboard();
            equipmentDashboardForm.Show(); //show EquipmentDashboard form
        }

        private void btnRentalDashboard_Click(object sender, EventArgs e)
        {
            //Hide the current form and navigate to the rentaldashboard form
            this.Hide(); //hide the current form
            RentalDashboard screen = new RentalDashboard();
            screen.Show();
        }

        private void btnRentalRequests_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            RentalRequests screen = new RentalRequests();
            screen.Show();
        }

        private void btnRentalTransactions_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            RentalTransactions screen = new RentalTransactions();
            screen.Show();
        }

        private void btnReturnRecords_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            ReturnRecords screen = new ReturnRecords();
            screen.Show();
        }

        private void btnEquipmentInformation_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            EquipmentInformation screen = new EquipmentInformation();
            screen.Show();
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

        private void txtEmailError_TextChanged(object sender, EventArgs e)
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


        private bool validateInput()
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if all individual field validations passed
            if (!isFirstNameValid || !isLastNameValid || !isEmailValid || !isPhoneNumberValid)
            {
                MessageBox.Show("Please correct the highlighted errors.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Everything is valid
        }

      
    }
}
