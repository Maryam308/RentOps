using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentOpsObjects.Model;

namespace RentOpsDesktop
{
    public partial class Profile : Form
    {

        //Declaring database context object
        private RentOpsDBContext dBContext;

        User employee;
        public Profile()
        {
            InitializeComponent();
            //Initializing database context object
            dBContext = new RentOpsDBContext();
        }

        private void Profile_Load(object sender, EventArgs e)
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

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            this.Hide(); //hide the curent form 
            editProfile.Show(); //show edit profile form

        }

        private void btnEditProfile_Click_1(object sender, EventArgs e)
        {
            EditProfile editProfileForm = new EditProfile();
            this.Hide(); //hide the current form
            editProfileForm.Show(); //show edit profile form
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try 
            {
                Login loginForm = new Login();
                this.Hide(); //hide the current form
                loginForm.Show(); //show login form

                // Clear the global employee ID 
                Global.EmployeeID = 0; // Reset the global employee ID

                //Display a message box to confirm logout
                MessageBox.Show("You have been logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging out: " + ex.Message);
            }
       

        }
    }
}
