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

namespace RentOpsDesktop
{
    public partial class EquipmentDashboard : Form
    {
        RentOpsDBContext context;
        public EquipmentDashboard()
        {
            InitializeComponent();
            context = new RentOpsDBContext();
        }

        private void lblRentalDashboard_Click(object sender, EventArgs e)
        {

        }

        private void EquipmentDashboard_Load(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        private void LoadEquipment()
        {
            // Fetch the equipment list with related titles using LINQ
            var equipmentList = context.Equipment
                .Where(e => e.ConditionStatusId != null && e.AvailabilityStatusId != null && e.EquipmentCategoryId != null)
                .Select(e => new
                {
                    EquipmentID = e.EquipmentId, // Select the equipment ID
                    EquipmentName = e.EquipmentName, // Select the equipment name
                    EquipmentDescription = e.EquipmentDescription, // Select the equipment description
                    RentalPrice = e.RentalPrice, // Select the rental price
                    EquipmentQuantity = e.EquipmentQuantity, // Select the equipment quantity
                    ConditionStatusTitle = context.ConditionStatuses
                        .Where(cs => cs.ConditionStatusId == e.ConditionStatusId)
                        .Select(cs => cs.ConditionStatusTitle)
                        .FirstOrDefault(), // Fetch the condition status title
                    AvailabilityStatusTitle = context.AvailabilityStatuses
                        .Where(a => a.AvailabilityStatusId == e.AvailabilityStatusId)
                        .Select(a => a.AvailabilityStatusTitle)
                        .FirstOrDefault(), // Fetch the availability status title
                    EquipmentCategoryTitle = context.EquipmentCategories
                        .Where(ec => ec.EquipmentCategoryId == e.EquipmentCategoryId)
                        .Select(ec => ec.EquipmentCategoryTitle)
                        .FirstOrDefault() // Fetch the equipment category title
                })
                .ToList(); // Convert the result to a list

            // Bind the fetched data to the DataGridView
            dgvEquipment.DataSource = equipmentList;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide(); //hide the current form
            login.Show(); //show the main menu
        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView is empty
            if (dgvEquipment.Rows.Count == 0)
            {
                MessageBox.Show("No equipment available to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure a row is selected
            if (dgvEquipment.SelectedRows.Count == 0 && dgvEquipment.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("This row is empty. Please select a valid equipment to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ID of the selected equipment
            int selectedEquipmentID = Convert.ToInt32(selectedRow.Cells["EquipmentID"].Value);

            // Confirm the edit action
            DialogResult result = MessageBox.Show($"Are you sure you want to edit the equipment with ID {selectedEquipmentID}?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Pass the ID to the EditEquipmentInformation constructor and show the form
                EditEquipmentInformation editEquipmentInformation = new EditEquipmentInformation(selectedEquipmentID);
                this.Hide();
                editEquipmentInformation.Show();
            }
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView is empty
            if (dgvEquipment.Rows.Count == 0)
            {
                MessageBox.Show("No equipment available to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure a row is selected
            if (dgvEquipment.SelectedRows.Count == 0 && dgvEquipment.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("This row is empty. Please select a valid equipment to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ID of the selected equipment
            int selectedEquipmentID = Convert.ToInt32(selectedRow.Cells["EquipmentID"].Value);

            // Confirm the delete action
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the equipment with ID {selectedEquipmentID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Find the equipment in the context and remove it
                    var equipment = context.Equipment.Find(selectedEquipmentID);
                    if (equipment != null)
                    {
                        context.Equipment.Remove(equipment);
                        context.SaveChanges();
                        MessageBox.Show("The equipment has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload the equipment list to reflect the changes
                        LoadEquipment();
                    }
                    else
                    {
                        MessageBox.Show("Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions by showing a message box
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            AddEquipment addEquipment = new AddEquipment();
            this.Hide(); //hide the current form
            addEquipment.Show(); //show the add equipment form
        }
    }
}
