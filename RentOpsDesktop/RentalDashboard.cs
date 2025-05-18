using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentOpsObjects.Services;

namespace RentOpsDesktop
{
    public partial class RentalDashboard : Form
    {
        RentOpsDBContext dbContext;
        AuditLogger logger;
        public RentalDashboard()
        {
            InitializeComponent();

            //initialize the dbcontext
            dbContext = new RentOpsDBContext();

            //initialize the audit logger object to track changes
            logger = new AuditLogger(dbContext);

        }

        private void RentalDashboard_Load(object sender, EventArgs e)
        {
            //call the method to fetch the statistics from the database
            fetchStatistics();
        }

        //feth statistics from the database 
        private void fetchStatistics()
        {
            //fetch the current user 
            int currentUserId = Global.user.UserId;

            //check if the current user is an admin (if so display the statistics for all the system)
            bool isAdmin;
            if (Global.RoleName == "Administrator")
            {
                isAdmin = true;
            }
            else
            {

                isAdmin = false;

            }



            try
            {
                var today = DateOnly.FromDateTime(DateTime.Today);
                var now = DateTime.Now;

                // all the statics will depend on the current user if the user is not the admin

                // total income from the user equipments
                // sum total cost from rental transaction where the equipment has userid of the current user
                var totalIncome = dbContext.RentalTransactions
                    .Include(i => i.Equipment)
                    .ThenInclude(t => t.RentalRequests)
                    .Include(r => r.RentalRequest)
                    .Where(r => isAdmin || r.Equipment.UserId == currentUserId || r.RentalRequest.Equipment.UserId == currentUserId)
                    .Sum(k => k.RentalFee);


                // average rental period (rental period is checked by the differance between the start and end) 
                // count the days then devide by the number of rentals

                //seperate the fetch from the average to avoid getting an exception
                var rentalPeriodQuery = dbContext.RentalTransactions
                    .Include(r => r.Equipment)
                    .Include(r => r.RentalRequest)
                    .Where(r => isAdmin || (r.RentalRequest != null && r.RentalRequest.Equipment.UserId == currentUserId))
                    .Select(r => EF.Functions.DateDiffDay(r.PickupDate, r.ReturnDate));

                double averageRentalPeriod = 0;

                if (rentalPeriodQuery.Any())
                {
                    averageRentalPeriod = rentalPeriodQuery.Average();
                }




                // fetch the availability id for the available status
                var availableStatus = dbContext.AvailabilityStatuses
                    .FirstOrDefault(s => s.AvailabilityStatusTitle == "Available");

                // available equipments will check the availability status of the equipment that has the user id of the current user
                var availableEquipments = dbContext.Equipment
                    .Include(i => i.AvailabilityStatus)
                    .Where(r => (isAdmin || r.UserId == currentUserId) &&
                                r.AvailabilityStatusId == availableStatus.AvailabilityStatusId)
                    .Count();

                // total rental request of the day
                var totalRentalRequest = dbContext.RentalRequests
                    .Include(i => i.Equipment)
                    .ThenInclude(t => t.RentalRequests)
                    .Where(r => r.RentalRequestTimestamp.Date == now.Date &&
                                (isAdmin || r.Equipment.UserId == currentUserId))
                    .Count();

                // total rentals of the month
                var totalRentalsOfTheMonth = dbContext.RentalTransactions
                    .Include(i => i.Equipment)
                    .ThenInclude(t => t.RentalRequests)
                    .Where(r => r.RentalTransactionTimestamp.Month == now.Month &&
                                r.RentalTransactionTimestamp.Year == now.Year &&
                                (isAdmin || r.Equipment.UserId == currentUserId))
                    .Count();

                // currently rented equipments 

                // fetch the active rentals to a variable
                var activeRentals = dbContext.RentalTransactions
                    .Include(i => i.Equipment)
                    .ThenInclude(t => t.RentalRequests)
                    .Where(r => r.PickupDate <= today &&
                                r.ReturnDate >= today &&
                                (isAdmin || r.Equipment.UserId == currentUserId))
                    .ToList();

                // Fetch the ID of the rented status from the database
                var rentedStatus = dbContext.AvailabilityStatuses
                    .FirstOrDefault(s => s.AvailabilityStatusTitle == "Out for Rent");

                if (rentedStatus != null)
                {
                    // loop through the active rentals and get the equipment id and mark it as rented
                    foreach (var rental in activeRentals)
                    {
                        var equipmentId = rental.EquipmentId;
                        var equipment = dbContext.Equipment.Find(equipmentId);
                        if (equipment != null)
                        {
                            equipment.AvailabilityStatusId = rentedStatus.AvailabilityStatusId; // assign the fetched id as the status of the equipment
                        }
                    }

                    // track changes before saving them to the database
                    logger.TrackChanges(currentUserId, Global.sourceId);

                    // save changes outside the loop and for once to avoid multiple writes to the database
                    dbContext.SaveChanges();
                }

                // count the rented equipments from the database
                var rentedEquipments = dbContext.Equipment
                    .Include(i => i.AvailabilityStatus)
                    .Where(r => (isAdmin || r.UserId == currentUserId) &&
                                r.AvailabilityStatus.AvailabilityStatusId == rentedStatus.AvailabilityStatusId)
                    .Count();

                // set all the labels to the values fetched from the database
                lblTotalIncome.Text = totalIncome.ToString();
                lblAverageRentalPeriod.Text = averageRentalPeriod.ToString();
                lblAvailableEquipments.Text = availableEquipments.ToString();
                lblTodayRentalRequest.Text = totalRentalRequest.ToString();
                lblLastMonthRentals.Text = totalRentalsOfTheMonth.ToString();
                lblCurrentlyRented.Text = rentedEquipments.ToString();
            }

            catch (Exception ex)
            {

                //log the exception using the auditlogger
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                //print the exception message 
                MessageBox.Show("An Error has occured: " + ex.Message);

            }


        }


        //Navigation bar code 

        private void btnRefreshStatistics_Click(object sender, EventArgs e)
        {
            //call the method to fetch the statistics from the database
            fetchStatistics();
        }

        private void btnOverdueReturns_Click(object sender, EventArgs e)
        {
            //navigate to overdue returns form
            OverdueReturns overdueReturns = new OverdueReturns();
            overdueReturns.StartPosition = FormStartPosition.CenterScreen; // Center the form
            overdueReturns.Show();
            this.Hide();
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
            screen.StartPosition = FormStartPosition.CenterScreen;
            screen.Show();
        }

        private void btnEquipmentInformation_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide the current form
            EquipmentInformation screen = new EquipmentInformation();
            screen.StartPosition = FormStartPosition.CenterScreen;
            screen.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.StartPosition = FormStartPosition.CenterScreen;
            reports.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //hide the current form
            this.Hide(); //hide the current form
            //navigate to the user profile form
            Profile profile = new Profile();
            profile.StartPosition = FormStartPosition.CenterScreen; // Center the form
            profile.Show(); //show the profile form
        }
    }
}
