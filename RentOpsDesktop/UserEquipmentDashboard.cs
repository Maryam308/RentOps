using RentOpsObjects.Model;
using RentOpsObjects.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentOpsDesktop
{
    public partial class UserEquipmentDashboard : Form
    {
        RentOpsDBContext dbContext;
        AuditLogger auditLogger;
        int currentUserId;
        bool isAdmin = false;

        public UserEquipmentDashboard()
        {
            InitializeComponent();
            dbContext = new RentOpsDBContext();
            auditLogger = new AuditLogger(dbContext);

            //fetch the user id from global
            currentUserId = Global.user.UserId;


            //check if the current user is an admin (if so display the statistics for all the system)

            if (Global.RoleName == "Administrator")
            {
                isAdmin = true;
            }
            else
            {

                isAdmin = false;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void UserEquipmentDashboard_Load(object sender, EventArgs e)
        {
            //load the data into the datagridview when the form loads
            RefreshDataGridView();

            //load the statistics when the form loads
            LoadStatistics();


        }

        //a function to load the data into the datagridview
        private void RefreshDataGridView()
        {

            try
            {

                // Fetch the filtered equipment list and select relevant fields
                var equipmentQuery = dbContext.Equipment.AsQueryable();

                if (!isAdmin)
                {
                    equipmentQuery = equipmentQuery.Where(e => e.UserId == currentUserId);
                }

                var equipmentList = equipmentQuery.Select(e => new
                {
                    EquipmentID = e.EquipmentId, // Select the equipment ID
                    EquipmentName = e.EquipmentName, // Select the equipment name
                    EquipmentDescription = e.EquipmentDescription, // Select the equipment description
                    RentalPrice = e.RentalPrice, // Select the rental price
                    ConditionStatus = dbContext.ConditionStatuses
                        .Where(cs => cs.ConditionStatusId == e.ConditionStatusId)
                        .Select(cs => cs.ConditionStatusTitle)
                        .FirstOrDefault(), // Fetch the condition status title
                    AvailabilityStatus = dbContext.AvailabilityStatuses
                        .Where(a => a.AvailabilityStatusId == e.AvailabilityStatusId)
                        .Select(a => a.AvailabilityStatusTitle)
                        .FirstOrDefault(), // Fetch the availability status title
                    EquipmentCategory = dbContext.EquipmentCategories
                        .Where(ec => ec.EquipmentCategoryId == e.EquipmentCategoryId)
                        .Select(ec => ec.EquipmentCategoryTitle)
                        .FirstOrDefault() // Fetch the equipment category title
                }).ToList(); // Convert the result to a list

                // Bind the fetched data to the DataGridView
                dgvEquipment.DataSource = equipmentList;



            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                MessageBox.Show("Error: " + ex.Message);
            }



        }


        //function to load statistics 
        private void LoadStatistics()
        {

            try
            {

                // Fetch the total number of current user equipment 
                var totalEquipment = dbContext.Equipment.Where(e => isAdmin ? true : e.UserId == currentUserId).Count();


                //fetch frequently rented equipment object
                var frequentlyRentedEquipment = dbContext.RentalTransactions
                    .Where(rt => isAdmin ? true : rt.EmployeeId == currentUserId
                    && rt.EquipmentId != null)
                    .GroupBy(rt => rt.EquipmentId)
                    .Select(g => new
                    {
                        EquipmentId = g.Key,
                        EquipmentName = dbContext.Equipment
                            .Where(e => e.EquipmentId == g.Key)
                            .Select(e => e.EquipmentName)
                            .FirstOrDefault(),
                        RentalCount = g.Count()
                    })
                    .OrderByDescending(g => g.RentalCount)
                    .FirstOrDefault();

                //fetch the frequently rented equipment name
                var frequentlyRentedEquipmentName = frequentlyRentedEquipment != null ? frequentlyRentedEquipment.EquipmentName : "";

                //fetch the condition status 
                ConditionStatus damaged = dbContext.ConditionStatuses.Where(cs => cs.ConditionStatusTitle == "Requires Maintenance").FirstOrDefault();

               ConditionStatus outOfOrder = dbContext.ConditionStatuses.Where(cs => cs.ConditionStatusTitle == "Out of Order").FirstOrDefault();


                //fech the number of the damaged equipment
                var damagedEquipment = dbContext.Equipment.Where(e => isAdmin ? true : e.UserId == currentUserId)
                    .Count(e => e.ConditionStatusId == damaged.ConditionStatusId ||e.ConditionStatusId == outOfOrder.ConditionStatusId); // under maintainance or out of order


                //fetch the condition status id
                AvailabilityStatus availableStatusId = dbContext.AvailabilityStatuses.Where(a => a.AvailabilityStatusTitle == "Available").FirstOrDefault();

                // Fetch the total number of available equipment
                var availableEquipment = dbContext.Equipment.Where(e => isAdmin ? true : e.UserId == currentUserId)
                    .Count(e => e.AvailabilityStatusId == availableStatusId.AvailabilityStatusId);

                //display the statistics in the labels
                lblEquipmentCount.Text = totalEquipment.ToString();
                lblDamagedEquipment.Text = damagedEquipment.ToString();
                lblAvailableForRental.Text = availableEquipment.ToString();
                lblFrequentlyRented.Text = frequentlyRentedEquipmentName;



            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                MessageBox.Show("Error: " + ex.Message);
            }


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

        private void btnEquipmentInformation_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            EquipmentInformation screen = new EquipmentInformation();
            screen.StartPosition = FormStartPosition.CenterScreen; // Center the form
            screen.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //navigate to the profile form
            this.Hide();
            Profile screen = new Profile();
            screen.StartPosition = FormStartPosition.CenterScreen; // Center the form
            screen.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //log out the user and navigate to the login form
            this.Hide();
            Login loginForm = new Login();
            loginForm.StartPosition = FormStartPosition.CenterScreen; // Center the form
            loginForm.Show(); //show login form
            // Clear the global user and roleName objects
            Global.user = new User();
            Global.RoleName = "";
        }
    }
}
