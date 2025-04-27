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

            //select the data filtering the overdue returns that are not yet returned 
            var returnRecords = dbContext.RentalTransactions
                .Where(x => x.ReturnDate < DateOnly.FromDateTime(DateTime.Now) && x.EmployeeId == currentEmployeeId)
                .OrderByDescending(d => d.ReturnDate)
                .Select(r => new
                {
                    r.RentalTransactionId,
                    r.PickupDate,
                    r.ReturnDate,
                    r.PaymentId,
                    r.RentalRequestId,
                    r.Deposit
                })
                .ToList();

            dgvReturnRecords.DataSource = returnRecords;


        }

        private void OverdueReturns_Load(object sender, EventArgs e)
        {
            //laod conditions into the combo box
            var conditions = dbContext.ConditionStatuses.ToList();
            cmbConditionStatus.DataSource = conditions;
            cmbConditionStatus.DisplayMember = "ConditionStatusTitle";
            cmbConditionStatus.ValueMember = "ConditionStatusId";
            //set selection to -1
            cmbConditionStatus.SelectedIndex = -1;

            //load into the data grid view
            RefreshDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //validate that not both text fields are filled
            if (txtReturnID.Text != "" && txtTransactionID.Text != "")
            {
                MessageBox.Show("Please fill only one field");
                //reset the text fields
                txtReturnID.Text = "";
                txtTransactionID.Text = "";
                return;
            }

            try
            {
                //if the return ID is filled
                if (txtReturnID.Text != "")
                {
                    //get the return record id from the text field
                    int returnRecordId = Convert.ToInt32(txtReturnID.Text);

                    //get the return record with the ID
                    var returnRecord = dbContext.ReturnRecords.Where(r => r.ReturnRecordId == returnRecordId).Join(dbContext.ConditionStatuses,
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
                else if (txtTransactionID.Text != "")
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
                else
                {
                    MessageBox.Show("Please fill one field");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset the text fields
            txtReturnID.Text = "";
            txtTransactionID.Text = "";

            //reset the combo boxes
            cmbConditionStatus.SelectedIndex = -1;

            //if the dtp is checked then set the date and then uncheck it 
            if (dtpActualReturnDate.Checked == true)
            {
                dtpActualReturnDate.Value = DateTime.Now;
                dtpActualReturnDate.Checked = false;
            }


            //reset the dgv
            RefreshDataGridView();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //check if one filter at least is choosen
            if (cmbConditionStatus.SelectedIndex == -1 && dtpActualReturnDate.Checked == false)
            {
                MessageBox.Show("Please select at least one filter");
                return;
            }

            //if only the condition is selected
            if (cmbConditionStatus.SelectedIndex != -1 && dtpActualReturnDate.Checked == false)
            {

                //get the selected condition
                int conditionId = Convert.ToInt32(cmbConditionStatus.SelectedValue);
                //get the return records with the condition
                var returnRecords = dbContext.ReturnRecords.Where(r => r.ReturnConditionId == conditionId).Join(dbContext.ConditionStatuses,
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
                dgvReturnRecords.DataSource = returnRecords;
            }
            else if (cmbConditionStatus.SelectedIndex == -1 && dtpActualReturnDate.Checked == true)
            {
                //get the selected date
                DateOnly selectedDate = DateOnly.FromDateTime(dtpActualReturnDate.Value);


                //get the return records of the selected date
                var returnRecords = dbContext.ReturnRecords.Where(r => r.ActualReturnDate == selectedDate).Join(dbContext.ConditionStatuses,
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
                dgvReturnRecords.DataSource = returnRecords;
            }//else if both are selected for the filter
            else if (cmbConditionStatus.SelectedIndex != -1 && dtpActualReturnDate.Checked == true)
            {
                //get the selected condition
                int conditionId = Convert.ToInt32(cmbConditionStatus.SelectedValue);
                //get the selected date
                DateOnly selectedDate = DateOnly.FromDateTime(dtpActualReturnDate.Value);

                //get the return records with the condition and the date
                var returnRecords = dbContext.ReturnRecords.Where(r => r.ReturnConditionId == conditionId && r.ActualReturnDate == selectedDate).Join(dbContext.ConditionStatuses,
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
                dgvReturnRecords.DataSource = returnRecords;


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

        private void btnEditReturnRecord_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView is empty
            if (dgvReturnRecords.Rows.Count == 0)
            {
                MessageBox.Show("No Return Records available to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure a row is selected
            if (dgvReturnRecords.SelectedRows.Count == 0 && dgvReturnRecords.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow;
            if (dgvReturnRecords.SelectedRows.Count > 0)
            {
                selectedRow = dgvReturnRecords.SelectedRows[0];
            }
            else
            {
                int rowIndex = dgvReturnRecords.SelectedCells[0].RowIndex;
                selectedRow = dgvReturnRecords.Rows[rowIndex];
            }

            // Check if the selected row is the empty default row
            if (selectedRow.IsNewRow || selectedRow.Cells["ReturnRecordID"].Value == null)
            {
                MessageBox.Show("This row is empty. Please select a valid Record to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ID of the selected equipment
            int selectedReturnID = Convert.ToInt32(selectedRow.Cells["ReturnRecordID"].Value);

            // Confirm the edit action
            DialogResult result = MessageBox.Show($"Are you sure you want to edit the equipment with ID {selectedReturnID}?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //find the object 
                ReturnRecord returnRecordToEdit = dbContext.ReturnRecords.Find(selectedReturnID);

                try
                {
                    // Pass the object to the edit screen constructor and show the form
                    EditReturnRecord editReturnRecord = new EditReturnRecord(returnRecordToEdit);
                    editReturnRecord.StartPosition = FormStartPosition.CenterScreen; // Center the form
                    editReturnRecord.ShowDialog();

                    if (editReturnRecord.DialogResult == DialogResult.OK)
                    {
                        dbContext.ReturnRecords.Update(editReturnRecord.returnRecordToEdit);
                        dbContext.SaveChanges(); // Save changes to the database
                        RefreshDataGridView(); // Refresh the DataGridVi
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }

        }

        private void btnDeleteReturnRecord_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView is empty
            if (dgvReturnRecords.Rows.Count == 0)
            {
                MessageBox.Show("No Return Records available to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure a row is selected
            if (dgvReturnRecords.SelectedRows.Count == 0 && dgvReturnRecords.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow;
            if (dgvReturnRecords.SelectedRows.Count > 0)
            {
                selectedRow = dgvReturnRecords.SelectedRows[0];
            }
            else
            {
                int rowIndex = dgvReturnRecords.SelectedCells[0].RowIndex;
                selectedRow = dgvReturnRecords.Rows[rowIndex];
            }

            // Check if the selected row is the empty default row
            if (selectedRow.IsNewRow || selectedRow.Cells["ReturnRecordID"].Value == null)
            {
                MessageBox.Show("This row is empty. Please select a valid Record to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ID of the selected equipment
            int selectedReturnID = Convert.ToInt32(selectedRow.Cells["ReturnRecordID"].Value);

            // Confirm the edit action
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the return record with ID {selectedReturnID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //find the object 
                ReturnRecord returnRecordToRemove = dbContext.ReturnRecords.Find(selectedReturnID);

                try
                {
                    dbContext.ReturnRecords.Remove(returnRecordToRemove);
                    dbContext.SaveChanges(); // Save changes to the database
                    RefreshDataGridView(); // Refresh the DataGridVi  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
        }
    }
}
