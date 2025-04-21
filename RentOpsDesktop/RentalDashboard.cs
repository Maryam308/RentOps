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

namespace RentOpsDesktop
{
    public partial class RentalDashboard : Form
    {
        RentOpsDBContext dbContext;
        public RentalDashboard()
        {
            InitializeComponent();
            dbContext = new RentOpsDBContext();
        }

        private void RentalDashboard_Load(object sender, EventArgs e)
        {
            //call the method to fetch the statistics from the database
            fetchStatistics();
        }

        //feth statistics from the database 
        private void fetchStatistics()
        {

            //fetch the current user from the database
            int currentUserId = Global.EmployeeID;

            //all the statics will depend on the current user


            //total income from the user equipments
            //sum total cost from rental transaction where the equipment has userid of the current user
            var totalIncome = dbContext.RentalTransactions
                .Include(i => i.Equipment)
                .ThenInclude(t => t.RentalRequests)
                .Where(r => r.Equipment.UserId == currentUserId || r.RentalRequest.Equipment.UserId == currentUserId).Sum(k => k.RentalFee);



            //average rental period (rental period is checked by the differance between the start and end) count the days then devide by the number of rentals
            var averageRentalPeriod = dbContext.RentalTransactions
                .Include(i => i.Equipment)
                .ThenInclude(t => t.RentalRequests)
                .Where(r => r.Equipment.UserId == currentUserId || r.RentalRequest.Equipment.UserId == currentUserId)
                .Select(r => (r.ReturnDate.ToDateTime(TimeOnly.MinValue) - r.PickupDate.ToDateTime(TimeOnly.MinValue)).TotalDays)
                .Average();

            //available equipments will check the availability status of the equipment that has the user id of the current user
            var availableEquipments = dbContext.Equipment
                .Include(i => i.AvailabilityStatus)
                .Where(r => r.UserId == currentUserId && r.AvailabilityStatus.AvailabilityStatusTitle == "Available")
                .Count();


            //total rental request of the day
            var totalRentalRequest = dbContext.RentalRequests
                .Include(i => i.Equipment)
                .ThenInclude(t => t.RentalRequests)
                .Where(r => r.Equipment.UserId == currentUserId && r.RentalRequestTimestamp == DateTime.Now.Date)
                .Count();

            //total rentals of the month
            var totalRentalsOfTheMonth = dbContext.RentalTransactions
                .Include(i => i.Equipment)
                .ThenInclude(t => t.RentalRequests)
                .Where(r => r.Equipment.UserId == currentUserId && r.RentalTransactionTimestamp.Month == DateTime.Now.Month)
                .Count();

            //currently rented equipments 

            //fetch the active rentals to a variable
            var activeRentals = dbContext.RentalTransactions
                .Include(i => i.Equipment)
                .ThenInclude(t => t.RentalRequests)
                .Where(r => r.Equipment.UserId == currentUserId && r.PickupDate <= DateOnly.FromDateTime(DateTime.Today.Date) && r.ReturnDate >= DateOnly.FromDateTime(DateTime.Today.Date))
                .ToList();

            //loop through the active rentals and get the equipment id and mark it as rented
            foreach (var rental in activeRentals)
            {
                //get the equipment id
                var equipmentId = rental.EquipmentId;
                //mark the equipment as rented
                var equipment = dbContext.Equipment.Find(equipmentId);
                if (equipment != null)
                {
                    equipment.AvailabilityStatusId = 2; // 2 is the id for rented
                    dbContext.SaveChanges();
                }
            }

            //count the rented equipments from the database
            var rentedEquipments = dbContext.Equipment
                .Include(i => i.AvailabilityStatus)
                .Where(r => r.UserId == currentUserId && r.AvailabilityStatus.AvailabilityStatusTitle == "Rented")
                .Count();


            //set all the labels to the values fetched from the database
            lblTotalIncome.Text = totalIncome.ToString();
            lblAverageRentalPeriod.Text = averageRentalPeriod.ToString();
            lblAvailableEquipments.Text = availableEquipments.ToString();
            lblTodayRentalRequest.Text = totalRentalRequest.ToString();
            lblLastMonthRentals.Text = totalRentalsOfTheMonth.ToString();
            lblCurrentlyRented.Text = rentedEquipments.ToString();


        }

        private void btnRefreshStatistics_Click(object sender, EventArgs e)
        {
            //call the method to fetch the statistics from the database
            fetchStatistics();
        }

        private void btnOverdueReturns_Click(object sender, EventArgs e)
        {
            //navigate to overdue returns form
            OverdueReturns overdueReturns = new OverdueReturns();
            overdueReturns.Show();
            this.Hide();
        }
    }
}
