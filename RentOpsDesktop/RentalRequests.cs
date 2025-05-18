using System;
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
    public partial class RentalRequests : Form
    {
        RentOpsDBContext context;
        AuditLogger auditLogger;
        int currentUserId;
        public RentalRequests()
        {
            InitializeComponent();

            //initialize the context and the logger object
            context = new RentOpsDBContext();
            auditLogger = new AuditLogger(context);

            //fetch the current user id 
            currentUserId = Global.user.UserId;

        }

        private void RefreshRentalRequestsGridview()
        {

            try
            {
                // Start with all rental requests
                var rentalRequestsToShow = context.RentalRequests.AsQueryable();

                // Apply Equipment Name filter if selected
                if (cmbEquipmentName.SelectedValue != null)
                {
                    rentalRequestsToShow = rentalRequestsToShow.Where(r => r.EquipmentId == (int)cmbEquipmentName.SelectedValue);
                }

                // Apply Request Status filter if selected
                if (cmbRequestStatus.SelectedValue != null)
                {
                    rentalRequestsToShow = rentalRequestsToShow.Where(r => r.RentalRequestStatusId == (int)cmbRequestStatus.SelectedValue);
                }

                // Fetch the filtered rental requests list and select relevant fields
                var rentalRequestsList = rentalRequestsToShow.Select(r => new
                {
                    RequestID = r.RentalRequestId, // Select the rental request ID
                    StartDate = r.RentalStartDate, // Select the rental start date
                    ReturnDate = r.RentalReturnDate, // Select the rental return date
                    TotalCost = r.RentalTotalCost, // Select the rental total cost
                    RequestStatus = context.RentalRequestStatuses
                        .Where(rs => rs.RentalRequestStatusId == r.RentalRequestStatusId)
                        .Select(rs => rs.RentalRequestStatusTitle)
                        .FirstOrDefault(), // Fetch the rental request status title
                    EquipmentName = context.Equipment
                        .Where(e => e.EquipmentId == r.EquipmentId)
                        .Select(e => e.EquipmentName)
                        .FirstOrDefault(), // Fetch the equipment name
                    CustomerName = context.Users
                        .Where(u => u.UserId == r.UserId)
                        .Select(u => u.FirstName + " " + u.LastName)
                        .FirstOrDefault() // Fetch the user's full name
                }).ToList(); // Convert the result to a list

                // Bind the fetched data to the DataGridView
                dgvRentalRequests.DataSource = rentalRequestsList;
            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                // Show error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void lblRentalDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go bock to the dashboard
            this.Hide();
            UserEquipmentDashboard userEquipmentDashboard = new UserEquipmentDashboard();
            userEquipmentDashboard.StartPosition = FormStartPosition.CenterScreen; // Center the form
            userEquipmentDashboard.Show();
        }

        private void btnUpdateRentalRequest_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView is empty
            if (dgvRentalRequests.Rows.Count == 0)
            {
                MessageBox.Show("No requests available to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure a row is selected
            if (dgvRentalRequests.SelectedRows.Count == 0 && dgvRentalRequests.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow;
            if (dgvRentalRequests.SelectedRows.Count > 0)
            {
                selectedRow = dgvRentalRequests.SelectedRows[0];
            }
            else
            {
                int rowIndex = dgvRentalRequests.SelectedCells[0].RowIndex;
                selectedRow = dgvRentalRequests.Rows[rowIndex];
            }

            // Check if the selected row is the empty default row
            if (selectedRow.IsNewRow || selectedRow.Cells["RequestID"].Value == null)
            {
                MessageBox.Show("This row is empty. Please select a valid rental request to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ID of the selected rental request
            int selectedRentalRequestID = Convert.ToInt32(selectedRow.Cells["RequestID"].Value);

            // Confirm the edit action
            DialogResult result = MessageBox.Show($"Are you sure you want to update the rental request with ID {selectedRentalRequestID}?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Pass the ID to the UpdateRequestStatus constructor and show the form
                UpdateRequestStatus updateRequestStatus = new UpdateRequestStatus(selectedRentalRequestID);
                updateRequestStatus.StartPosition = FormStartPosition.CenterScreen; // Center the form
                updateRequestStatus.ShowDialog();

                // refresh the DataGridView 
                RefreshRentalRequestsGridview(); 
            }

        }

        private void RentalRequests_Load(object sender, EventArgs e)
        {

            try
            {
                // Load data to request status combobox
                var requestStatuses = context.RentalRequestStatuses
                    .Select(rs => new { rs.RentalRequestStatusId, rs.RentalRequestStatusTitle })
                    .ToList();
                cmbRequestStatus.DataSource = requestStatuses;
                cmbRequestStatus.DisplayMember = "RentalRequestStatusTitle";
                cmbRequestStatus.ValueMember = "RentalRequestStatusId";
                cmbRequestStatus.SelectedItem = null;

                // Load data to equipment name combobox
                var equipmentNames = context.Equipment
                    .Select(e => new { e.EquipmentId, e.EquipmentName })
                    .ToList();
                cmbEquipmentName.DataSource = equipmentNames;
                cmbEquipmentName.DisplayMember = "EquipmentName";
                cmbEquipmentName.ValueMember = "EquipmentId";
                cmbEquipmentName.SelectedItem = null;

                // Refresh the rental requests gridview
                RefreshRentalRequestsGridview();
            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                // Show error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the search field is empty
                if (string.IsNullOrEmpty(txtRequestID.Text))
                {
                    MessageBox.Show("Please enter a Rental Request ID to search.");
                    return;
                }

                // Start with all rental requests
                var rentalRequestsToShow = context.RentalRequests.AsQueryable();

                // Apply search by Rental Request ID if entered
                int rentalRequestId;
                if (int.TryParse(txtRequestID.Text, out rentalRequestId))
                {
                    rentalRequestsToShow = rentalRequestsToShow.Where(r => r.RentalRequestId == rentalRequestId);
                }
                else
                {
                    MessageBox.Show("Please enter a valid Rental Request ID.");
                    return;
                }

                // Fetch the filtered list based on search criteria and select relevant fields
                var searchedList = rentalRequestsToShow.Select(r => new
                {
                    RentalRequestID = r.RentalRequestId,
                    RentalStartDate = r.RentalStartDate,
                    RentalReturnDate = r.RentalReturnDate,
                    RentalTotalCost = r.RentalTotalCost,
                    RentalRequestStatus = context.RentalRequestStatuses
                        .Where(rs => rs.RentalRequestStatusId == r.RentalRequestStatusId)
                        .Select(rs => rs.RentalRequestStatusTitle)
                        .FirstOrDefault(),
                    EquipmentName = context.Equipment
                        .Where(e => e.EquipmentId == r.EquipmentId)
                        .Select(e => e.EquipmentName)
                        .FirstOrDefault(),
                    UserName = context.Users
                        .Where(u => u.UserId == r.UserId)
                        .Select(u => u.FirstName + " " + u.LastName)
                        .FirstOrDefault()
                }).ToList();

                // Bind the fetched data to the DataGridView
                dgvRentalRequests.DataSource = searchedList;
            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                // Show error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            RefreshRentalRequestsGridview();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset the inputs 
            cmbEquipmentName.SelectedItem = null;
            cmbRequestStatus.SelectedItem = null;
            txtRequestID.Text = "";

            //refresh the data grid view 
            RefreshRentalRequestsGridview();
        }
    }
}
