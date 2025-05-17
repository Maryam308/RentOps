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
using RentOpsObjects.Model;
using RentOpsObjects.Services;

namespace RentOpsDesktop
{
    public partial class EditEquipmentInformation : Form
    {
        private bool validEquipmentName = false;
        private bool validEquipmentDescription = false;
        private bool validRentalPrice = false;

        bool validConditionStatus = false;
        bool validAvailabilityStatus = false;
        bool validEquipmentCategory = false;
        internal Equipment equipmentToEdit;
        int equipmentId;
        RentOpsDBContext context;
        AuditLogger logger;
        int currentUserId;

        public EditEquipmentInformation(int equipmentId)
        {
            InitializeComponent();
            this.equipmentId = equipmentId;
            context = new RentOpsDBContext();
            logger = new AuditLogger(context); //create a logger object
            currentUserId = Global.EmployeeID;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EquipmentInformation equipmentDashboard = new EquipmentInformation();
            this.Hide(); //hide the current form
            equipmentDashboard.Show(); //show the equipment dashboard
        }

        private void EditEquipmentInformation_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadEquipmentDetails();
        }

        private void LoadComboBoxData()
        {
            try 
            {
                // Load data for ConditionStatus combobox
                var conditionStatuses = context.ConditionStatuses
                    .Select(cs => new { cs.ConditionStatusId, cs.ConditionStatusTitle })
                    .ToList();
                cmbConditionStatus.DataSource = conditionStatuses;
                cmbConditionStatus.DisplayMember = "ConditionStatusTitle";
                cmbConditionStatus.ValueMember = "ConditionStatusId";

                // Load data for AvailabilityStatus combobox
                var availabilityStatuses = context.AvailabilityStatuses
                    .Select(a => new { a.AvailabilityStatusId, a.AvailabilityStatusTitle })
                    .ToList();
                cmbAvailabilityStatus.DataSource = availabilityStatuses;
                cmbAvailabilityStatus.DisplayMember = "AvailabilityStatusTitle";
                cmbAvailabilityStatus.ValueMember = "AvailabilityStatusId";

                // Load data for EquipmentCategory combobox
                var equipmentCategories = context.EquipmentCategories
                    .Select(ec => new { ec.EquipmentCategoryId, ec.EquipmentCategoryTitle })
                    .ToList();
                cmbEquipmentCategory.DataSource = equipmentCategories;
                cmbEquipmentCategory.DisplayMember = "EquipmentCategoryTitle";
                cmbEquipmentCategory.ValueMember = "EquipmentCategoryId";
            }
            catch (Exception ex)
            {
                // log the error
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);

                // show the error message
                MessageBox.Show("An error occurred while loading the data. Please try again or contact support if the issue persists.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ValidateForm()
        {
            btnSaveChanges.Enabled = validEquipmentName && validEquipmentDescription && validEquipmentCategory &&
                                       validRentalPrice && validConditionStatus && validAvailabilityStatus;
        }


        private void LoadEquipmentDetails()
        {
            try 
            {

                // Fetch the equipment details using LINQ
                var equipment = context.Equipment
                    .Where(e => e.EquipmentId == equipmentId)
                    .Select(e => new
                    {
                        e.EquipmentName,
                        e.EquipmentDescription,
                        e.RentalPrice,
                        //e.EquipmentQuantity,
                        ConditionStatusId = e.ConditionStatusId,
                        AvailabilityStatusId = e.AvailabilityStatusId,
                        EquipmentCategoryId = e.EquipmentCategoryId
                    })
                    .FirstOrDefault();

                if (equipment != null)
                {
                    // Populate the text boxes with the equipment details
                    txtEquipmentName.Text = equipment.EquipmentName;
                    txtEquipmentDescription.Text = equipment.EquipmentDescription;
                    txtRentalPrice.Text = equipment.RentalPrice.ToString();
                    //txtQuantity.Text = equipment.EquipmentQuantity.ToString();

                    // Set the selected values for the comboboxes
                    cmbConditionStatus.SelectedValue = equipment.ConditionStatusId;
                    cmbAvailabilityStatus.SelectedValue = equipment.AvailabilityStatusId;
                    cmbEquipmentCategory.SelectedValue = equipment.EquipmentCategoryId;
                }
                else
                {
                    MessageBox.Show("Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // log the error
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);

                // shw the error message
                MessageBox.Show("An error occurred while loading the equipment details. Please try again or contact support if the issue persists.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Check if all fields are valid
            if (validEquipmentName && validEquipmentDescription && validRentalPrice)
            {
                try
                {
                    // Prepare the SQL command for updating the equipment
                    equipmentToEdit = context.Equipment.Find(equipmentId);
                    if (equipmentToEdit != null)
                    {
                        equipmentToEdit.EquipmentName = txtEquipmentName.Text;
                        equipmentToEdit.EquipmentDescription = txtEquipmentDescription.Text;
                        equipmentToEdit.RentalPrice = (double)Convert.ToDecimal(txtRentalPrice.Text);
                        //equipmentToEdit.EquipmentQuantity = Convert.ToInt32(txtQuantity.Text);
                        equipmentToEdit.ConditionStatusId = Convert.ToInt32(cmbConditionStatus.SelectedValue);
                        equipmentToEdit.AvailabilityStatusId = Convert.ToInt32(cmbAvailabilityStatus.SelectedValue);
                        equipmentToEdit.EquipmentCategoryId = Convert.ToInt32(cmbEquipmentCategory.SelectedValue);

                        MessageBox.Show("The equipment has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Log the error
                    logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);

                    // show the error message
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fix the errors before saving the changes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtEquipmentName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipmentName.Text))
            {
                lblEquipmentNameErr.Text = "Equipment name cannot be empty";
                validEquipmentName = false;
            }
            else if (txtEquipmentName.Text.Length < 3)
            {
                lblEquipmentNameErr.Text = "Equipment name must be at least 3 characters long";
                validEquipmentName = false;
            }
            else
            {
                lblEquipmentNameErr.Text = string.Empty;
                validEquipmentName = true;
            }
            ValidateForm();

        }

        private void txtEquipmentDescription_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipmentDescription.Text))
            {
                lblEquipmentDescriptionErr.Text = "Equipment description cannot be empty";
                validEquipmentDescription = false;
            }
            else if (txtEquipmentDescription.Text.Length < 10)
            {
                lblEquipmentDescriptionErr.Text = "Equipment description must be at least 10 characters long";
                validEquipmentDescription = false;
            }
            else
            {
                lblEquipmentDescriptionErr.Text = string.Empty;
                validEquipmentDescription = true;
            }
            ValidateForm();

        }


        private void txtRentalPrice_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtRentalPrice.Text, out decimal price) || price <= 0)
            {
                lblRentalPriceErr.Text = "Rental price must be a positive number";
                validRentalPrice = false;
            }
            else
            {
                lblRentalPriceErr.Text = string.Empty;
                validRentalPrice = true;
            }
            ValidateForm();
        }


        private void cmbEquipmentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquipmentCategory.SelectedItem == null)
            {
                lblEquipmentCategoryErr.Text = "Please select an equipment category";
                validEquipmentCategory = false;
            }
            else
            {
                lblEquipmentCategoryErr.Text = string.Empty;
                validEquipmentCategory = true;
            }
            ValidateForm();
        }

        private void cmbConditionStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConditionStatus.SelectedItem == null)
            {
                lblConditionStatusErr.Text = "Please select a condition status";
                validConditionStatus = false;
            }
            else
            {
                lblConditionStatusErr.Text = string.Empty;
                validConditionStatus = true;
            }

            ValidateForm();
        }

        private void cmbAvailabilityStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAvailabilityStatus.SelectedItem == null)
            {
                lblAvailabilityStatusErr.Text = "Please select availability status";
                validAvailabilityStatus = false;
            }
            else
            {
                lblAvailabilityStatusErr.Text = string.Empty;
                validAvailabilityStatus = true;
            }
            ValidateForm();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            //close the current form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
