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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace RentOpsDesktop
{
    public partial class RentalTransactions : Form
    {
        RentOpsDBContext dbContext;
        AuditLogger auditLogger;
        int currentUserId;


        public RentalTransactions()
        {
            InitializeComponent();
            dbContext = new RentOpsDBContext();
            auditLogger = new AuditLogger(dbContext);
            currentUserId = Global.user.UserId;
        }

        //a function to refresh the data grid view 
        private void RefreshDataGridView()
        {

            try
            {
                // based on the selected radio button, filter the data
                IQueryable<RentalTransaction> baseQuery = dbContext.RentalTransactions;

                // Apply filters if selected
                //check the transaction date
                if (dtpTransctionDate.Checked)
                {
                    DateTime selectedDate = dtpTransctionDate.Value.Date;
                    baseQuery = baseQuery.Where(r => r.RentalTransactionTimestamp.Date == selectedDate);
                }

                //checks the equipment combo box
                if (cmbEquipment.SelectedIndex != -1)
                {
                    int equipmentId = (int)cmbEquipment.SelectedValue;
                    baseQuery = baseQuery.Where(r => r.EquipmentId == equipmentId);
                }

                //checks the payment status combo box
                if (cmbPaymentStatus.SelectedIndex != -1)
                {
                    string paymentStatus = cmbPaymentStatus.SelectedItem.ToString();
                    if (paymentStatus == "Paid")
                        baseQuery = baseQuery.Where(r => r.PaymentId != null);
                    else if (paymentStatus == "Not Paid")
                        baseQuery = baseQuery.Where(r => r.PaymentId == null);
                }

                // fetch the rental transactions based on the selected radio button
                // fetching the website app transactions
                if (this.rbWebsiteAppTransactions.Checked)
                {
                    var websiteTransactions = baseQuery
                        .Where(r => r.RentalRequestId != null)
                        .Select(rt => new
                        {
                            rt.RentalTransactionId,
                            rt.PickupDate,
                            rt.ReturnDate,
                            rt.PaymentId,
                            rt.RentalRequestId,
                            rt.Deposit,
                            rt.EmployeeId,
                            rt.RentalFee,
                            rt.EquipmentId,
                            rt.RentalTransactionTimestamp
                        })
                        .OrderByDescending(r => r.RentalTransactionTimestamp)
                        .ToList();

                    dgvRentalTransactions.DataSource = websiteTransactions;
                }
                // fetching the desktop app transactions
                else if (rbDesktopAppTransactions.Checked)
                {
                    var desktopTransactions = baseQuery
                        .Where(r => r.RentalRequestId == null)
                        .Select(rt => new
                        {
                            rt.RentalTransactionId,
                            rt.PickupDate,
                            rt.ReturnDate,
                            rt.PaymentId,
                            rt.Deposit,
                            rt.EmployeeId,
                            rt.RentalFee,
                            rt.CustomerId,
                            rt.UserId,
                            rt.EquipmentId,
                            rt.RentalTransactionTimestamp
                        })
                        .OrderByDescending(r => r.RentalTransactionTimestamp)
                        .ToList();

                    dgvRentalTransactions.DataSource = desktopTransactions;
                }
                // fetching all transactions
                else if (rbAllTransactions.Checked)
                {
                    var allTransactions = baseQuery
                        .Select(rt => new
                        {
                            rt.RentalTransactionId,
                            rt.PickupDate,
                            rt.ReturnDate,
                            rt.PaymentId,
                            rt.RentalRequestId,
                            rt.Deposit,
                            rt.EmployeeId,
                            rt.RentalFee,
                            rt.CustomerId,
                            rt.UserId,
                            rt.EquipmentId,
                            rt.RentalTransactionTimestamp
                        })
                        .OrderByDescending(r => r.RentalTransactionTimestamp)
                        .ToList();

                    dgvRentalTransactions.DataSource = allTransactions;
                }

            }
            catch (Exception ex)
            {
                //log error
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);

                //show error message 
                MessageBox.Show("Error occoured while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void RentalTransactions_Load(object sender, EventArgs e)
        {
            bool websiteAppTransactionsChecked = rbWebsiteAppTransactions.Checked;
            bool desktopAppTransactionsChecked = rbDesktopAppTransactions.Checked;
            bool allTransactionsChecked = rbAllTransactions.Checked;
            try
            {
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
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblReturnDateFilter_Click(object sender, EventArgs e)
        {

        }

        private void cmbConditionStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the text fields
            txtRequestID.Text = "";
            txtTransaction.Text = "";

            //reset the combo boxes
            cmbEquipment.SelectedIndex = -1;

            //reset the combo boxes
            cmbPaymentStatus.SelectedIndex = -1;

            //if the dtp is checked then set the date and then uncheck it 
            if (dtpTransctionDate.Checked == true)
            {
                dtpTransctionDate.Value = DateTime.Now;
                dtpTransctionDate.Checked = false;
            }


            //reset the dgv
            RefreshDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            //validate that not both text fields are filled
            if (txtRequestID.Text != "" && txtTransaction.Text != "")
            {
                MessageBox.Show("Please fill only one field");
                //reset the text fields
                txtRequestID.Text = "";
                txtTransaction.Text = "";
                return;
            }

            try
            {
                var rentalTransactions = dbContext.RentalTransactions
                .Include(rt => rt.Equipment)
                .Include(rt => rt.Employee)
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
                    dgvRentalTransactions.DataSource = record;
                }
                else if (txtTransaction.Text != "")
                {
                    //get the transaction id from the text field
                    int transactionID = Convert.ToInt32(txtTransaction.Text);
                    var record = rentalTransactions.Where(rt => rt.RentalTransactionId == transactionID)
                       .ToList();
                    //refresh the data grid view
                    dgvRentalTransactions.DataSource = record;
                }
                else
                {
                    MessageBox.Show("Please fill one of the fields");
                    return;
                }
            }

            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //check if one filter at least is choosen
            if (cmbEquipment.SelectedIndex == -1 && dtpTransctionDate.Checked == false && cmbPaymentStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select at least one filter");
                return;
            }
            else
            {
                //refresh the data grid view
                RefreshDataGridView();
            }

        }

        private void btnEditRentalTransaction_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView is empty
            if (dgvRentalTransactions.Rows.Count == 0)
            {
                MessageBox.Show("No Rental Transaction available to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure a row is selected
            if (dgvRentalTransactions.SelectedRows.Count == 0 && dgvRentalTransactions.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a Transaction record to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow;
            if (dgvRentalTransactions.SelectedRows.Count > 0)
            {
                selectedRow = dgvRentalTransactions.SelectedRows[0];
            }
            else
            {
                int rowIndex = dgvRentalTransactions.SelectedCells[0].RowIndex;
                selectedRow = dgvRentalTransactions.Rows[rowIndex];
            }

            // Check if the selected row is the empty default row
            if (selectedRow.IsNewRow || selectedRow.Cells["RentalTransactionId"].Value == null)
            {
                MessageBox.Show("This row is empty. Please select a valid Record to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ID of the selected equipment
            int selectedTransactionID = Convert.ToInt32(selectedRow.Cells["RentalTransactionId"].Value);

            // Confirm the edit action
            DialogResult result = MessageBox.Show($"Do you want to edit the transaction with ID {selectedTransactionID}?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //find the object 
                RentalTransaction returnTransactionToEdit = dbContext.RentalTransactions.Find(selectedTransactionID);

                try
                {
                    // Pass the object to the edit screen constructor and show the form
                    EditRentalTransaction editRentalTransaction = new EditRentalTransaction(returnTransactionToEdit);
                    editRentalTransaction.StartPosition = FormStartPosition.CenterScreen; // Center the form
                    editRentalTransaction.ShowDialog();

                    if (editRentalTransaction.DialogResult == DialogResult.OK)
                    {
                        //dbContext.RentalTransactions.Update(editRentalTransaction.rentalTransactionToEdit);

                        //track changes 
                        //auditLogger.TrackChanges(currentUserId, Global.sourceId ?? 2);

                        //dbContext.SaveChanges(); // Save changes to the database
                        RefreshDataGridView(); // Refresh the DataGridVi
                    }

            }
                catch (Exception ex)
                {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        }

        private void btnDeleteRentalTransaction_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView is empty
            if (dgvRentalTransactions.Rows.Count == 0)
            {
                MessageBox.Show("No Rental Transction Records available to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure a row is selected
            if (dgvRentalTransactions.SelectedRows.Count == 0 && dgvRentalTransactions.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow;
            if (dgvRentalTransactions.SelectedRows.Count > 0)
            {
                selectedRow = dgvRentalTransactions.SelectedRows[0];
            }
            else
            {
                int rowIndex = dgvRentalTransactions.SelectedCells[0].RowIndex;
                selectedRow = dgvRentalTransactions.Rows[rowIndex];
            }

            // Check if the selected row is the empty default row
            if (selectedRow.IsNewRow || selectedRow.Cells["RentalTransactionId"].Value == null)
            {
                MessageBox.Show("This row is empty. Please select a valid Record to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the RentalTransactionId from the selected row
            int rentalTransactionId = Convert.ToInt32(selectedRow.Cells["RentalTransactionId"].Value);

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Rental Transaction?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // find the object 
                RentalTransaction rentalTransaction = dbContext.RentalTransactions.Find(rentalTransactionId);

                try
                {
                    // Check and delete associated payment if it exists
                    if (rentalTransaction.PaymentId != null)
                    {
                        var payment = dbContext.Payments.Find(rentalTransaction.PaymentId);
                        if (payment != null)
                        {
                            dbContext.Payments.Remove(payment);
                        }
                    }

                    dbContext.RentalTransactions.Remove(rentalTransaction);

                    //track changes using the logger
                    auditLogger.TrackChanges(currentUserId, Global.sourceId);

                    dbContext.SaveChanges(); // Save changes to the database
                    RefreshDataGridView(); // Refresh the DataGridView
                    MessageBox.Show("Rental Transaction deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message


                }
                catch (Exception ex)
                {
                    //log the exception using the auditlogger
                    auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                    MessageBox.Show("An error occurred while deleting the Rental Transaction: " + ex.Message);
                }
            }
        }

        private void btnAddnewRentalTransaction_Click(object sender, EventArgs e)
        {
            //show choose equipment form
            this.Hide();
            ChooseEquipment chooseEquipment = new ChooseEquipment();
            chooseEquipment.StartPosition = FormStartPosition.CenterScreen; // Center the form
            chooseEquipment.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go bock to the dashboard
            this.Hide();
            UserEquipmentDashboard userEquipmentDashboard = new UserEquipmentDashboard();
            userEquipmentDashboard.StartPosition = FormStartPosition.CenterScreen; // Center the form
            userEquipmentDashboard.Show();
        }

        private void dgvRentalTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void rbWebsiteAppTransactions_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RefreshDataGridView();
            }
        }

        private void rbDesktopAppTransactions_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RefreshDataGridView();
            }
        }

        private void rbAllTransactions_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RefreshDataGridView();
            }
        }
    }

}
