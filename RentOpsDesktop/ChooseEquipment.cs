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
using RentOpsObjects.Services;


namespace RentOpsDesktop
{
    public partial class ChooseEquipment : Form
    {
        int currentUserId;
        RentOpsDBContext context;
        AuditLogger logger;
        public ChooseEquipment()
        {
            InitializeComponent();
            context = new RentOpsDBContext();
            logger = new AuditLogger(context); //create a logger object
            currentUserId = Global.EmployeeID;
            RefreshEquipmentGridview();

        }

        private void RefreshEquipmentGridview()
        {
            try
            {
                // Start with all equipment
                var equipmentToShow = context.Equipment.AsQueryable();

                // Fetch the filtered equipment list and select relevant fields
                var equipmentList = equipmentToShow.Select(e => new
                {
                    EquipmentID = e.EquipmentId, // Select the equipment ID
                    EquipmentName = e.EquipmentName, // Select the equipment name
                    EquipmentDescription = e.EquipmentDescription, // Select the equipment description
                    RentalPrice = e.RentalPrice, // Select the rental price
                    ConditionStatus = context.ConditionStatuses
                        .Where(cs => cs.ConditionStatusId == e.ConditionStatusId)
                        .Select(cs => cs.ConditionStatusTitle)
                        .FirstOrDefault(), // Fetch the condition status title
                    AvailabilityStatus = context.AvailabilityStatuses
                        .Where(a => a.AvailabilityStatusId == e.AvailabilityStatusId)
                        .Select(a => a.AvailabilityStatusTitle)
                        .FirstOrDefault(), // Fetch the availability status title
                    EquipmentCategory = context.EquipmentCategories
                        .Where(ec => ec.EquipmentCategoryId == e.EquipmentCategoryId)
                        .Select(ec => ec.EquipmentCategoryTitle)
                        .FirstOrDefault(), // Fetch the equipment category title
                    AddedBy = context.Users
                        .Where(u => u.UserId == e.UserId)
                        .Select(u => u.FirstName)
                        .FirstOrDefault() // Fetch the user's full name
                }).ToList(); // Convert the result to a list

                // Bind the fetched data to the DataGridView
                dgvEquipment.DataSource = equipmentList;
            }
            catch (Exception ex)
            {
                // log the error
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);

                // Show an error message
                MessageBox.Show("An error occurred while loading the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back button
            this.Hide();
            RentalTransactions rentalTransaction = new RentalTransactions();
            rentalTransaction.Show();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try 
            {

                // Check if the DataGridView is empty
                if (dgvEquipment.Rows.Count == 0)
                {
                    MessageBox.Show("No Equipment available to view.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Ensure a row is selected
                if (dgvEquipment.SelectedRows.Count == 0 && dgvEquipment.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Please select a record to view.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Get the selected row
                DataGridViewRow selectedRow;
                if (dgvEquipment.SelectedRows.Count > 0)
                {
                    selectedRow = dgvEquipment.SelectedRows[0];
                }
                else
                {
                    int rowIndex = dgvEquipment.SelectedCells[0].RowIndex;
                    selectedRow = dgvEquipment.Rows[rowIndex];
                }

                // Check if the selected row is the empty default row
                if (selectedRow.IsNewRow || selectedRow.Cells["EquipmentID"].Value == null)
                {
                    MessageBox.Show("This row is empty. Please select a valid Record to view.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the ID of the selected equipment
                int selectedEquipmentID = Convert.ToInt32(selectedRow.Cells["EquipmentID"].Value);

                // Confirm the edit action
                DialogResult result = MessageBox.Show($"Are you sure you want to view the Log with ID {selectedEquipmentID}?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        //hide the current form
                        this.Hide();
                        // Pass the object to the edit screen constructor and show the form
                        AddRentalTransaction addRentalTransactionScreen = new AddRentalTransaction(selectedEquipmentID);
                        addRentalTransactionScreen.StartPosition = FormStartPosition.CenterScreen; // Center the form
                        addRentalTransactionScreen.Show();

                    }
                    catch (Exception ex)
                    {
                        // log the error
                        logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                        
                        // Show an error message
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                // log the error
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                
                // Show an error message
                MessageBox.Show("An error occurred while loading the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChooseEquipment_Load(object sender, EventArgs e)
        {

        }
    }
}
