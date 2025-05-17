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
    public partial class ReturnRecords : Form
    {
        RentOpsDBContext dbContext;
        AuditLogger auditLogger;
        int currentUserId;

        public ReturnRecords()
        {
            InitializeComponent();
            
            dbContext = new RentOpsDBContext();//instantiate the db context
            auditLogger = new AuditLogger(dbContext);//instantiate a logger object to track changes 

            //save the current user id
            currentUserId = Global.user.UserId;

        }

        //a function to refresh the data grid view 
        private void RefreshDataGridView()
        {
            try
            {
                //initially fetch all return records
                var returnRecords = dbContext.ReturnRecords.AsQueryable();

                //check for filters


                //check if a condition filter is chosen 
                if (cmbConditionStatus.SelectedValue != null)
                {
                    //get the selected condition
                    int conditionId = Convert.ToInt32(cmbConditionStatus.SelectedValue);
                    //get the return records with the condition
                    returnRecords = returnRecords.Where(r => r.ReturnConditionId == conditionId);
                }

                //check if a specific date is selected to filter
                if (dtpActualReturnDate.Checked == true)
                {
                    //get the selected date
                    DateOnly selectedDate = DateOnly.FromDateTime(dtpActualReturnDate.Value);
                    //get the return records of the selected date
                    returnRecords = returnRecords.Where(r => r.ActualReturnDate == selectedDate);
                }


                //select the full filtered records
                var returnRecordslist = returnRecords.Join(dbContext.ConditionStatuses,
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

                    }).OrderByDescending(d => d.ActualReturnDate).ToList(); //order the records newest to oldest

                //set the data grid view to display the records
                dgvReturnRecords.DataSource = returnRecordslist;

            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                //print the exception message 

                MessageBox.Show("Error: " + ex.Message);
            }




        }

        private void ReturnRecords_Load(object sender, EventArgs e)
        {
            try
            {
                //laod conditions into the combo box
                var conditions = dbContext.ConditionStatuses.ToList();
                cmbConditionStatus.DataSource = conditions;
                cmbConditionStatus.DisplayMember = "ConditionStatusTitle"; //display the condition title
                cmbConditionStatus.ValueMember = "ConditionStatusId"; //set the id of the status as the value
                //set selection to -1 (empty )
                cmbConditionStatus.SelectedIndex = -1;

                //load into the data grid view
                RefreshDataGridView();

            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                //print the exception message 
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void lblReturnID_Click(object sender, EventArgs e)
        {

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
            //validate that not both text fields are empty
            if (txtReturnID.Text == "" && txtTransactionID.Text == "")
            {
                //when searching with empty values ask the user to fill at least one
                MessageBox.Show("Please fill one field");
                return;
            }

            try
            {
                //fetch all the return records
                var returnRecords = dbContext.ReturnRecords.AsQueryable();

                //if the return ID is filled then search for the specified id
                if (txtReturnID.Text != "")
                {
                    //get the return record id from the text field
                    int returnRecordId = Convert.ToInt32(txtReturnID.Text);
                    //get the return records with the condition
                    returnRecords = returnRecords.Where(r => r.ReturnRecordId == returnRecordId);

                }
                else if (txtTransactionID.Text != "")
                {

                    //get the rental transaction id from the text field
                    int rentalTransactionId = Convert.ToInt32(txtTransactionID.Text);
                    //get the return record with the ID
                    returnRecords = returnRecords.Where(r => r.RentalTransactionId == rentalTransactionId);


                }

                //select the full recordds filtered by the search criteria
                var returnRecordslist = returnRecords.Join(dbContext.ConditionStatuses,
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

                    }).OrderByDescending(d => d.ActualReturnDate).ToList();

                //set the data source to display the list in the datagridview
                dgvReturnRecords.DataSource = returnRecordslist;



            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                //print the exception message 
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
                //reset the date to current and the datetimepicker not be active
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
                //instruct the user to use one of filters if clicked on filter without selection
                MessageBox.Show("Please select at least one filter");
                return;
            }

            RefreshDataGridView(); // Refresh the DataGridView
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //show the add record form 
            AddReturnRecord addReturnRecord = new AddReturnRecord();
            addReturnRecord.StartPosition = FormStartPosition.CenterScreen; // Center the form
            addReturnRecord.ShowDialog();

            if (addReturnRecord.DialogResult == DialogResult.OK)
            {
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
                //if a cell is selected select its own row
                int rowIndex = dgvReturnRecords.SelectedCells[0].RowIndex;
                selectedRow = dgvReturnRecords.Rows[rowIndex];
            }

            // Check if the selected row is the empty default row (there is no record id)
            if (selectedRow.IsNewRow || selectedRow.Cells["ReturnRecordID"].Value == null)
            {
                MessageBox.Show("This row is empty. Please select a valid Record to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ID of the selected return record
            int selectedReturnID = Convert.ToInt32(selectedRow.Cells["ReturnRecordID"].Value);

            // Confirm the edit action
            DialogResult result = MessageBox.Show($"Do you want to edit the Return Record with ID {selectedReturnID}?", "Edit Return Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //find the return record object 
                ReturnRecord returnRecordToEdit = dbContext.ReturnRecords.Find(selectedReturnID);

                try
                {
                    // Pass the object to the edit screen constructor and show the form
                    EditReturnRecord editReturnRecord = new EditReturnRecord(returnRecordToEdit);
                    editReturnRecord.StartPosition = FormStartPosition.CenterScreen; // Center the form
                    editReturnRecord.ShowDialog();

                    if (editReturnRecord.DialogResult == DialogResult.OK)
                    {
                        RefreshDataGridView(); // Refresh the DataGridVi
                    }

                }
                catch (Exception ex)
                {
                    //log the exception using the auditlogger
                    auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                    //print the exception message 
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
                //get the selected row
                selectedRow = dgvReturnRecords.SelectedRows[0];
            }
            else
            {
                //if only a cell is selected get its record
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
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the return record with ID {selectedReturnID}?", "Delete Return Record Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //find the object to remove 
                ReturnRecord returnRecordToRemove = dbContext.ReturnRecords.Find(selectedReturnID);

                try
                {
                    dbContext.ReturnRecords.Remove(returnRecordToRemove);
                    dbContext.SaveChanges(); // Save changes to the database
                    RefreshDataGridView(); // Refresh the DataGridVi  
                }
                catch (Exception ex)
                {
                    //log the exception using the auditlogger
                    auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                    //print the exception message 
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go bock to the dashboard
            this.Hide();
            UserEquipmentDashboard userEquipmentDashboard = new UserEquipmentDashboard();
            userEquipmentDashboard.Show();
        }
    }
}
