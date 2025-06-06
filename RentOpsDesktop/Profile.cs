﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentOpsObjects.Model;
using RentOpsObjects.Services;

namespace RentOpsDesktop
{
    public partial class Profile : Form
    {

        //Declaring database context object
        private RentOpsDBContext dBContext;
        AuditLogger auditLogger;
        User currentUser;


        public Profile()
        {
            InitializeComponent();
            
            //Initializing database context object
            dBContext = new RentOpsDBContext();

            //initialze a logger object for change tracking
            auditLogger = new AuditLogger(dBContext);

            //fetch the current user object 
            currentUser = Global.user;

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {

                //Display the employee details in the text boxes
                txtFirstName.Text = currentUser.FirstName;
                txtLastName.Text = currentUser.LastName;
                txtEmail.Text = currentUser.Email;
                txtPhone.Text = currentUser.PhoneNumber.ToString() ?? "";

                //if the role is not admin hide and disable the auditlog button  
                if (Global.RoleName != "Administrator")
                {
                    
                    btnViewAuditLog.Enabled = false;
                    btnViewAuditLog.Visible = false;

                }               

            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUser.UserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                //print the exception message 
                MessageBox.Show("An error occurred while loading the form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            this.Hide(); //hide the curent form 
            editProfile.StartPosition = FormStartPosition.CenterScreen; // Center the form
            editProfile.Show(); //show edit profile form

        }

        private void btnEditProfile_Click_1(object sender, EventArgs e)
        {
            EditProfile editProfileForm = new EditProfile();
            this.Hide(); //hide the current form
            editProfileForm.StartPosition = FormStartPosition.CenterScreen; // Center the form
            editProfileForm.Show(); //show edit profile form
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                Login loginForm = new Login();
                this.Hide(); //hide the current form
                loginForm.StartPosition = FormStartPosition.CenterScreen; // Center the form
                loginForm.Show(); //show login form

                // Clear the global user and roleName objects
                Global.user = new User();

                //Display a message box to confirm logout
                MessageBox.Show("You have been logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUser.UserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                //print the exception message 
                MessageBox.Show("Error logging out: " + ex.Message);
            }


        }

        private void btnEquipmentInformation_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            EquipmentInformation screen = new EquipmentInformation();
            screen.StartPosition = FormStartPosition.CenterScreen; // Center the form
            screen.Show();
        }

        private void btnEquipmentDashboard_Click(object sender, EventArgs e)
        {
            //Hide the current form and navigate to the EquipmentDashboard form
            this.Hide(); //hide the current form
            UserEquipmentDashboard equipmentDashboardForm = new UserEquipmentDashboard();
            equipmentDashboardForm.StartPosition = FormStartPosition.CenterScreen; // Center the form
            equipmentDashboardForm.Show(); //show EquipmentDashboard form
        }

        private void btnRentalDashboard_Click(object sender, EventArgs e)
        {
            //Hide the current form and navigate to the rentaldashboard form
            this.Hide(); //hide the current form
            RentalDashboard screen = new RentalDashboard();
            screen.StartPosition = FormStartPosition.CenterScreen; // Center the form
            screen.Show();
        }

        private void btnRentalRequests_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            RentalRequests screen = new RentalRequests();
            screen.StartPosition = FormStartPosition.CenterScreen; // Center the form
            screen.Show();
        }

        private void btnRentalTransactions_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            RentalTransactions screen = new RentalTransactions();
            screen.StartPosition = FormStartPosition.CenterScreen; // Center the form
            screen.Show();
        }

        private void btnReturnRecords_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            ReturnRecords screen = new ReturnRecords();
            screen.StartPosition = FormStartPosition.CenterScreen; // Center the form
            screen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            AuditLog screen = new AuditLog();
            screen.StartPosition = FormStartPosition.CenterScreen; // Center the form
            screen.Show();
        
        }
    }
}
