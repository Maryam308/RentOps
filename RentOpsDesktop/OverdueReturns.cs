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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RentOpsDesktop
{
    public partial class OverdueReturns : Form
    {
        RentOpsDBContext dbContext;
        int currentUserId;
        AuditLogger auditLogger;
        bool isAdmin = false; //to check if the current user is an admin or not

        public OverdueReturns()
        {
            InitializeComponent();
            dbContext = new RentOpsDBContext();
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


        //a function to refresh the data grid view 
        private void RefreshDataGridView()
        {

            try {
                //select the overdue transactions that do not have a return record and its retuned date is less than the current date

                //select as queryable
                IEnumerable<RentalTransaction> rentalTransactions = dbContext.RentalTransactions
                    .Where(x => x.ReturnDate < DateOnly.FromDateTime(DateTime.Now) && (isAdmin ? true : x.EmployeeId == currentUserId))
                    .OrderByDescending(d => d.ReturnDate)
                    .AsQueryable();

                //check if filters apply

                //Filter according to a selected date 
                if (dtpTransctionDate.Checked)
                {
                    //get the date seleceted from the filter dtp
                    DateTime selectedDate = dtpTransctionDate.Value;
                    //filter the transactions to include only the transactions of the selected date
                    rentalTransactions = rentalTransactions.Where(r => r.RentalTransactionTimestamp.Date == selectedDate.Date);
                }

                //Filter according to a selected equipment 
                if (cmbEquipment.SelectedIndex != -1) {

                    //get the selected equipment id
                    int equipmentId = (int)cmbEquipment.SelectedValue;
                    //get the transactions with the specified equipment
                    rentalTransactions = rentalTransactions.Where(r => r.EquipmentId == equipmentId);

                }

                //check if payment status is selected to filter
                if (cmbPaymentStatus.SelectedIndex != -1)
                {
                    //fetch the selected payment status
                    string paymentStatus = cmbPaymentStatus.SelectedItem.ToString();
                    if (paymentStatus == "Paid")
                    {
                        //the paid transactions are the one with a payment id 
                        rentalTransactions = rentalTransactions.Where(r => r.PaymentId != null);
                    }
                    else if (paymentStatus == "Not Paid")
                    {
                        //The transactions without a payment id connected are not paid
                        rentalTransactions = rentalTransactions.Where(r => r.PaymentId == null);
                    }
                }

                //fetch the filtered overdue trnsactions  and include extra data for clarity
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

                //set the data source of the datagridview to the list
                dgvReturnRecords.DataSource = overdueTransactions;

            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                //print the exception message in a message box
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void OverdueReturns_Load(object sender, EventArgs e)
        {
            try {
                //laod filter conditions into the combo boxes

                //load the equipment names 
                cmbEquipment.DataSource = dbContext.Equipment.ToList();
                cmbEquipment.DisplayMember = "EquipmentName"; //display the equipment name
                cmbEquipment.ValueMember = "EquipmentId"; //set the values to hold the equipment ids
                cmbEquipment.SelectedIndex = -1; // set the selected value to display an empty selection

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
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                //print the exception message 
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //validate that not both text fields are filled
            if (txtRequestID.Text != "" && txtTransactionID.Text != "")
            {
                //instruct the user
                MessageBox.Show("Please fill only one field");
                //reset the text fields to empty 
                txtRequestID.Text = "";
                txtTransactionID.Text = "";
                return; //stop the excution
            }

            try
            {
                //select the rental transactions only for the current logged in employee 
                var rentalTransactions = dbContext.RentalTransactions
                .Include(rt => rt.Equipment)
                .Include(rt => rt.Employee)
                .Where(rt => isAdmin ? true : rt.EmployeeId == currentUserId)
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
                });


                //the admin should be able to find all the overdue returns 
                if (Global.RoleName != "Administrator") 
                {
                    //if the role is not administrator filter the transactions to show only the overdue transactions that the currnet employee is responsible of 
                    rentalTransactions = rentalTransactions.Where(rt => rt.EmployeeId == currentUserId);
                }


                //if the request ID is filled (search by the request id)
                if (txtRequestID.Text != "")
                {
                    //get the rental request id from the text field
                    int requestRecordID = Convert.ToInt32(txtRequestID.Text);
                    //fetch the record with the request id
                    var record = rentalTransactions.Where(rt => rt.RentalRequestId == requestRecordID)
                       .ToList();

                    //refresh the data grid view
                    dgvReturnRecords.DataSource = record;
                }
                else if (txtTransactionID.Text != "")
                {
                    //get the transaction id from the text field
                    int transactionID = Convert.ToInt32(txtTransactionID.Text);
                    //fetch the record with the transaction id
                    var record = rentalTransactions.Where(rt => rt.RentalTransactionId == transactionID)
                       .ToList();
                    //refresh the data grid view
                    dgvReturnRecords.DataSource = record;
                }
                else
                {
                    //if the user is trying to search without adding any values to any of the text fields return from the function and instruct the user to fill at leas one  
                    MessageBox.Show("Please fill one of the fields");
                    return;
                }
            }

            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                //print the exception message 
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
            cmbPaymentStatus.Text = "Select Payment Status"; // add the placeholder
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
                //instruct the user to select a criteria to filter if non is chosen
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
            //show the add record form as a dialog
            AddReturnRecord addReturnRecord = new AddReturnRecord();
            addReturnRecord.StartPosition = FormStartPosition.CenterScreen; // Center the form
            addReturnRecord.ShowDialog();

            try { 
                
                //get the dialogresult and add the retutn record to the database if its set to ok
                if (addReturnRecord.DialogResult == DialogResult.OK)
                {
                    dbContext.ReturnRecords.Add(addReturnRecord.newReturnRecord);

                    //track the changes using the audit logger
                    auditLogger.TrackChanges(currentUserId, Global.sourceId);

                    dbContext.SaveChanges(); // Save changes to the database
                    RefreshDataGridView(); // Refresh the DataGridView
                }
            
            
            } catch (Exception ex) {

                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                //print the exception message 
                MessageBox.Show("An error has occured: " + ex.Message) ; return;


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
