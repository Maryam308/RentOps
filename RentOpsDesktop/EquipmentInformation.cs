using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;

namespace RentOpsDesktop
{
    public partial class EquipmentInformation : Form
    {
        RentOpsDBContext context;
        public EquipmentInformation()
        {
            InitializeComponent();
            context = new RentOpsDBContext();
        }

        private void lblRentalDashboard_Click(object sender, EventArgs e)
        {

        }

        private void EquipmentDashboard_Load(object sender, EventArgs e)
        {
            //load data to the equipment cateogry combobox
            cmbEquipmentCategory.DataSource = context.EquipmentCategories.ToList();
            cmbEquipmentCategory.DisplayMember = "EquipmentCategoryTitle";
            cmbEquipmentCategory.ValueMember = "EquipmentCategoryId";
            cmbEquipmentCategory.SelectedItem = null;

            //load data to the condition status combobox
            cmbConditionStatus.DataSource = context.ConditionStatuses.ToList();
            cmbConditionStatus.DisplayMember = "ConditionStatusTitle";
            cmbConditionStatus.ValueMember = "ConditionStatusId";
            cmbConditionStatus.SelectedItem = null;


            //load data to the availability status combobox
            cmbAvailabilityStatus.DataSource = context.AvailabilityStatuses.ToList();
            cmbAvailabilityStatus.DisplayMember = "AvailabilityStatusTitle";
            cmbAvailabilityStatus.ValueMember = "AvailabilityStatusId";
            cmbAvailabilityStatus.SelectedItem = null;

            // Load data to the user combobox
            cmbUser.DataSource = context.Users.ToList();
            cmbUser.DisplayMember = "FullName"; // Displaying full name
            cmbUser.ValueMember = "UserId";
            cmbUser.SelectedItem = null;

            RefreshEquipmentGridview();
        }
        private void RefreshEquipmentGridview()
        {
            try
            {
                // Start with all equipment
                var equipmentToShow = context.Equipment.AsQueryable();

                // Apply Equipment Category filter if selected
                if (cmbEquipmentCategory.SelectedValue != null)
                {
                    equipmentToShow = equipmentToShow.Where(e => e.EquipmentCategoryId == (int)cmbEquipmentCategory.SelectedValue);
                }

                // Apply Condition Status filter if selected
                if (cmbConditionStatus.SelectedValue != null)
                {
                    equipmentToShow = equipmentToShow.Where(e => e.ConditionStatusId == (int)cmbConditionStatus.SelectedValue);
                }

                // Apply Availability Status filter if selected
                if (cmbAvailabilityStatus.SelectedValue != null)
                {
                    equipmentToShow = equipmentToShow.Where(e => e.AvailabilityStatusId == (int)cmbAvailabilityStatus.SelectedValue);
                }

                // Apply User filter if selected
                if (cmbUser.SelectedValue != null)
                {
                    equipmentToShow = equipmentToShow.Where(e => e.UserId == (int)cmbUser.SelectedValue);
                }

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
                // Show error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide(); //hide the current form
            login.Show(); //show the main menu
        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {


        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {

        }

        private void EquipmentDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //exit the application
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            RefreshEquipmentGridview();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbAvailabilityStatus.SelectedItem = null;
            cmbEquipmentCategory.SelectedItem = null;
            cmbConditionStatus.SelectedItem = null;
            cmbUser.SelectedItem = null;
            txtEquipID.Text = "";
            txtEquipName.Text = "";
            RefreshEquipmentGridview();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            EquipmentInformation equipmentDashboard = new EquipmentInformation();
            this.Hide();
            equipmentDashboard.Show();
        }

        private void pnlNavigation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNewEquipment_Click(object sender, EventArgs e)
        {

            AddEquipment addEquipment = new AddEquipment();
            addEquipment.StartPosition = FormStartPosition.CenterScreen; // Center the form
            addEquipment.ShowDialog(); // Show the add equipment form

            if (addEquipment.DialogResult == DialogResult.OK)
            {
                // Detach any existing entity with the same key value
                var existingEntity = context.Equipment.Local.FirstOrDefault(e => e.EquipmentId == addEquipment.equipment.EquipmentId);
                if (existingEntity != null)
                {
                    context.Entry(existingEntity).State = EntityState.Detached;
                }

                context.Equipment.Add(addEquipment.equipment);
                context.SaveChanges(); // Save changes to the database
                RefreshEquipmentGridview(); // Refresh the DataGridView
            }

        }

        private void btnEditEquipmentInformation_Click(object sender, EventArgs e)
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
                editEquipmentInformation.StartPosition = FormStartPosition.CenterScreen; // Center the form
                editEquipmentInformation.ShowDialog();

                if (editEquipmentInformation.DialogResult == DialogResult.OK)
                {
                    // Detach any existing entity with the same key value
                    var existingEntity = context.Equipment.Local.FirstOrDefault(e => e.EquipmentId == editEquipmentInformation.equipmentToEdit.EquipmentId);
                    if (existingEntity != null)
                    {
                        context.Entry(existingEntity).State = EntityState.Detached;
                    }

                    context.Equipment.Update(editEquipmentInformation.equipmentToEdit);
                    context.SaveChanges(); // Save changes to the database
                    RefreshEquipmentGridview(); // Refresh the DataGridView
                }
            }
        }

        private void btnDeleteEquipmentInformation_Click(object sender, EventArgs e)
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
                        RefreshEquipmentGridview();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if both fields are empty
                if (string.IsNullOrEmpty(txtEquipID.Text) && string.IsNullOrEmpty(txtEquipName.Text))
                {
                    MessageBox.Show("Please enter either an Equipment ID or Equipment Name to search.");
                    return;
                }

                // Check if both fields are filled
                if (!string.IsNullOrEmpty(txtEquipID.Text) && !string.IsNullOrEmpty(txtEquipName.Text))
                {
                    MessageBox.Show("Please enter either an Equipment ID or Equipment Name, not both.");
                    return;
                }

                // Start with all equipment
                var equipmentToShow = context.Equipment.AsQueryable();

                // Apply search by Equipment ID if entered
                if (!string.IsNullOrEmpty(txtEquipID.Text))
                {
                    int equipmentId;
                    if (int.TryParse(txtEquipID.Text, out equipmentId))
                    {
                        equipmentToShow = equipmentToShow.Where(e => e.EquipmentId == equipmentId);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Equipment ID.");
                        return;
                    }
                }
                // Apply search by Equipment Name if entered
                else if (!string.IsNullOrEmpty(txtEquipName.Text))
                {
                    string equipmentName = txtEquipName.Text.Trim();
                    equipmentToShow = equipmentToShow.Where(e => e.EquipmentName.Contains(equipmentName));
                }

                // Fetch the filtered list based on search criteria and select relevant fields
                var searchedList = equipmentToShow.Select(e => new
                {
                    EquipmentID = e.EquipmentId,
                    EquipmentName = e.EquipmentName,
                    EquipmentDescription = e.EquipmentDescription,
                    RentalPrice = e.RentalPrice,
                    ConditionStatus = context.ConditionStatuses
                        .Where(cs => cs.ConditionStatusId == e.ConditionStatusId)
                        .Select(cs => cs.ConditionStatusTitle)
                        .FirstOrDefault(),
                    AvailabilityStatus = context.AvailabilityStatuses
                        .Where(a => a.AvailabilityStatusId == e.AvailabilityStatusId)
                        .Select(a => a.AvailabilityStatusTitle)
                        .FirstOrDefault(),
                    EquipmentCategory = context.EquipmentCategories
                        .Where(ec => ec.EquipmentCategoryId == e.EquipmentCategoryId)
                        .Select(ec => ec.EquipmentCategoryTitle)
                        .FirstOrDefault(),
                    AddedBy = context.Users
                        .Where(u => u.UserId == e.UserId)
                        .Select(u => u.FirstName)
                        .FirstOrDefault()
                }).ToList();

                // Bind the fetched data to the DataGridView
                dgvEquipment.DataSource = searchedList;
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        }
    }
