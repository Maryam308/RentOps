using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;

namespace RentOpsDesktop
{
    public partial class EditProfile : Form
    {

        //Declaring database context object
        private RentOpsDBContext dBContext;
        public EditProfile()
        {
            InitializeComponent();
            //Initializing database context object
            dBContext = new RentOpsDBContext();
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

                //Fetch the employee object from the database
                var employee = dBContext.Users
                    .Where(e => e.UserId == userId)
                    .FirstOrDefault();

                //Display the employee details in the text boxes
                //txtFirstName.Text = employee.FirstName;
                //txtLastName.Text = employee.LastName;
                txtEmail.Text = employee.Email;
                //txtPhone.Text = employee.PhoneNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            Profile profileForm = new Profile();
            profileForm.Show(); //show profile form

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                //Fetch the employee object from the database
                User employee = dBContext.Users.Find(Global.EmployeeID);

                //Update the employee details
                //employee.FirstName = txtFirstName.Text.Trim();
                //employee.LastName = txtLastName.Text.Trim();
                employee.Email = txtEmail.Text.Trim();
                //employee.PhoneNumber = txtPhone.Text.Trim();

                //Display message asking for user confirmation before edit
                DialogResult result = MessageBox.Show("Are you sure you want to save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return; // Exit the method if the user clicks "No"
                }

                //Update and save the changes to the database
                dBContext.Users.Update(employee);
                dBContext.SaveChanges();

                //Display a success message
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
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
    }
}
