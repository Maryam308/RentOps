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
                    DateOnly selectedDate = DateOnly.FromDateTime(dtpTransctionDate.Value);
                    rentalTransactions = rentalTransactions.Where(r => r.ReturnDate == selectedDate);
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
            //validate that the search field is not empty
            if (txtTransactionID.Text == "")
            {
                MessageBox.Show("Please fill the field.");
                return;
            }

            try
            {
                if (txtTransactionID.Text != "")
                {

                    //get the rental transaction id from the text field
                    int rentalTransactionId = Convert.ToInt32(txtTransactionID.Text);
                    //get the return record with the ID
                    var returnRecord = dbContext.ReturnRecords.Where(r => r.RentalTransactionId == rentalTransactionId).Join(dbContext.ConditionStatuses,
                        rr => rr.ReturnConditionId,
                        rc => rc.ConditionStatusId,
                        (returnRecord, ReturnCond) =>
                        new
                        {
                            ReturnRecordID = returnRecord.ReturnRecordId,
                            RentalTransactionID = returnRecord.RentalTransactionId,
                            ActualReturnDate = returnRecord.ActualReturnDate,
                            LateReturnFee = returnRecord.LateReturnFee,
                            AdditionalCharge = returnRecord.AdditionalCharge,
                            DocumentID = returnRecord.DocumentId,
                            ReturnCondition = ReturnCond.ConditionStatusTitle

                        }).ToList();

                    //show the return record in the data grid view
                    dgvReturnRecords.DataSource = returnRecord;

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
