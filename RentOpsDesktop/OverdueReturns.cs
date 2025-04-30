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
    public partial class OverdueReturns : Form
    {
        RentOpsDBContext dbContext;
        int currentEmployeeId;
        public OverdueReturns()
        {
            InitializeComponent();
            dbContext = new RentOpsDBContext();
            currentEmployeeId = Global.EmployeeID; // Get the global employee ID
        }


        //a function to refresh the data grid view 
        private void RefreshDataGridView()
        {

            try {


                //select the overdue transactions that do not have a return record and its retuned date is less than the current date

                //select as queryable
                IEnumerable<RentalTransaction> rentalTransactions = dbContext.RentalTransactions
                    .Where(x => x.ReturnDate < DateOnly.FromDateTime(DateTime.Now) && x.EmployeeId == currentEmployeeId)
                    .OrderByDescending(d => d.ReturnDate)
                    .AsQueryable();

                //check if filters apply

                //check the return date
                if (dtpTransctionDate.Checked)
                {
                    DateTime selectedDate = dtpTransctionDate.Value;
                    rentalTransactions = rentalTransactions.Where(r => r.RentalTransactionTimestamp.Date == selectedDate.Date);
                }

                //check if equipment is selected to filter
                if (cmbEquipment.SelectedIndex != -1) {

                    //filter the rental transactions by equipment id
                    int equipmentId = (int)cmbEquipment.SelectedValue;
                    rentalTransactions = rentalTransactions.Where(r => r.EquipmentId == equipmentId);

                }

                //check if payment status is selected to filter
                if (cmbPaymentStatus.SelectedIndex != -1)
                {
                    //filter the rental transactions by payment status
                    string paymentStatus = cmbPaymentStatus.SelectedItem.ToString();
                    if (paymentStatus == "Paid")
                    {
                        rentalTransactions = rentalTransactions.Where(r => r.PaymentId != null);
                    }
                    else if (paymentStatus == "Not Paid")
                    {
                        rentalTransactions = rentalTransactions.Where(r => r.PaymentId == null);
                    }
                }

                //check if the equipment is selected to filter
                var overdueTransactions = rentalTransactions.Select(rt => new
                {
                    RentalTransactionId = rt.RentalTransactionId,
                    PickupDate = rt.PickupDate,
                    ReturnDate = rt.ReturnDate,
                    Deposit = rt.Deposit,
                    RentalFee = rt.RentalFee,
                    RentalTransactionTimestamp = rt.RentalTransactionTimestamp,
                    PaymentId = rt.PaymentId,
                    RentalRequestId = rt.RentalRequestId,
                    EmployeeId = rt.EmployeeId,
                    EquipmentId = rt.EquipmentId,
                    EquipmentName = dbContext.Equipment
                        .Where(e => e.EquipmentId == rt.EquipmentId)
                        .Select(e => e.EquipmentName)
                        .FirstOrDefault(), // Fetch Equipment Name
                    EmployeeName = dbContext.Users
                        .Where(emp => emp.UserId == rt.EmployeeId)
                        .Select(emp => emp.FirstName + " " + emp.LastName)
                        .FirstOrDefault() // Fetch Employee Full Name
                                }).ToList(); // Convert the result to a list

                dgvReturnRecords.DataSource = overdueTransactions;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void OverdueReturns_Load(object sender, EventArgs e)
        {
            try {
                //laod conditions into the combo box

                //load the equipment names 
                cmbEquipment.DataSource = dbContext.Equipment.ToList();
                cmbEquipment.DisplayMember = "EquipmentName";
                cmbEquipment.ValueMember = "EquipmentId";
                cmbEquipment.SelectedIndex = -1;

                //load into the payment cmbo box a paid and not paid options
                cmbPaymentStatus.Items.Add("Paid");
                cmbPaymentStatus.Items.Add("Not Paid");
                cmbPaymentStatus.SelectedIndex = -1;
                //set the -1 index to placeholder
                cmbPaymentStatus.Text = "Select Payment Status";

                //load into the data grid view
                RefreshDataGridView();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //validate that not both text fields are filled
            if (txtRequestID.Text != "" && txtTransactionID.Text != "")
            {
                MessageBox.Show("Please fill only one field");
                //reset the text fields
                txtRequestID.Text = "";
                txtTransactionID.Text = "";
                return;
            }

            try
            {
                var rentalTransactions = dbContext.RentalTransactions
                .Include(rt => rt.Equipment)
                .Include(rt => rt.Employee)
                .Where(rt => rt.EmployeeId == currentEmployeeId)
                .OrderByDescending(rt => rt.RentalTransactionTimestamp)
                .Select(rt => new
                {
                    rt.RentalTransactionId,
                    rt.PickupDate,
                    rt.ReturnDate,
                    rt.Deposit,
                    rt.RentalFee,
                    rt.RentalTransactionTimestamp,
                    rt.PaymentId,
                    rt.RentalRequestId,
                    rt.EmployeeId,
                    rt.EquipmentId,
                    EquipmentName = rt.Equipment != null ? rt.Equipment.EquipmentName : "N/A",
                    EmployeeName = rt.Employee != null ? rt.Employee.FirstName + " " + rt.Employee.LastName : "N/A"
                })
                .ToList();

                //if the request ID is filled
                if (txtRequestID.Text != "")
                {
                    //get the return record id from the text field
                    int requestRecordID = Convert.ToInt32(txtRequestID.Text);

                    var record = rentalTransactions.Where(rt => rt.RentalRequestId == requestRecordID)
                       .ToList();

                    //refresh the data grid view
                    dgvReturnRecords.DataSource = record;
                }
                else if (txtTransactionID.Text != "")
                {
                    //get the transaction id from the text field
                    int transactionID = Convert.ToInt32(txtTransactionID.Text);
                    var record = rentalTransactions.Where(rt => rt.RentalTransactionId == transactionID)
                       .ToList();
                    //refresh the data grid view
                    dgvReturnRecords.DataSource = record;
                }
                else
                {
                    MessageBox.Show("Please fill one of the fields");
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset the text field
            txtTransactionID.Text = "";

            //reset the combo boxes
            cmbEquipment.SelectedIndex = -1;
            cmbPaymentStatus.SelectedIndex = -1;
            cmbPaymentStatus.Text = "Select Payment Status";
            dtpTransctionDate.Value = DateTime.Now; // Reset to current date
            dtpTransctionDate.Checked = false; // Uncheck the date picker

            //reset the dgv
            RefreshDataGridView();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //if no filters are selected, show message 
            if (cmbEquipment.SelectedIndex == -1 && cmbPaymentStatus.SelectedIndex == -1 && dtpTransctionDate.Checked == false)
            {
                MessageBox.Show("Please select at least one filter.");
                return;
            }
            else {

                //call the refresh method to filter the data grid view
                RefreshDataGridView();

            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //show the add record form 
            AddReturnRecord addReturnRecord = new AddReturnRecord();
            addReturnRecord.StartPosition = FormStartPosition.CenterScreen; // Center the form
            addReturnRecord.ShowDialog();

            if (addReturnRecord.DialogResult == DialogResult.OK)
            {
                dbContext.ReturnRecords.Add(addReturnRecord.newReturnRecord);
                dbContext.SaveChanges(); // Save changes to the database
                RefreshDataGridView(); // Refresh the DataGridView
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go back to the rental dashboard
            RentalDashboard rentalDashboard = new RentalDashboard();
            rentalDashboard.StartPosition = FormStartPosition.CenterScreen; // Center the form
            rentalDashboard.Show();
            this.Hide(); // Hide the current form
        }
    }
}
