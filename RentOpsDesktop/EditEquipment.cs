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

namespace RentOpsDesktop
{
    public partial class EditEquipmentInformation : Form
    {
        private bool validEquipmentName = false;
        private bool validEquipmentDescription = false;
        private bool validRentalPrice = false;
        private bool validQuantity = false;

        int equipmentId;
        RentOpsDBContext context;

        public EditEquipmentInformation(int equipmentId)
        {
            InitializeComponent();
            this.equipmentId = equipmentId;
            context = new RentOpsDBContext();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EquipmentDashboard equipmentDashboard = new EquipmentDashboard();
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


        private void LoadEquipmentDetails()
        {
            // Fetch the equipment details using LINQ
            var equipment = context.Equipment
                .Where(e => e.EquipmentId == equipmentId)
                .Select(e => new
                {
                    e.EquipmentName,
                    e.EquipmentDescription,
                    e.RentalPrice,
                    e.EquipmentQuantity,
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
                txtQuantity.Text = equipment.EquipmentQuantity.ToString();

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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
              // Check if all fields are valid
            if (validEquipmentName && validEquipmentDescription && validRentalPrice && validQuantity)
            {
                try
                {
                    // Prepare the SQL command for updating the equipment
                    var equipment = context.Equipment.Find(equipmentId);
                    if (equipment != null)
                    {
                        equipment.EquipmentName = txtEquipmentName.Text;
                        equipment.EquipmentDescription = txtEquipmentDescription.Text;
                        equipment.RentalPrice = (double)Convert.ToDecimal(txtRentalPrice.Text);
                        equipment.EquipmentQuantity = Convert.ToInt32(txtQuantity.Text);
                        equipment.ConditionStatusId = Convert.ToInt32(cmbConditionStatus.SelectedValue);
                        equipment.AvailabilityStatusId = Convert.ToInt32(cmbAvailabilityStatus.SelectedValue);
                        equipment.EquipmentCategoryId = Convert.ToInt32(cmbEquipmentCategory.SelectedValue);

                        context.SaveChanges();
                        MessageBox.Show("The equipment has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EquipmentDashboard equipmentDashboard = new EquipmentDashboard();
                        this.Hide();
                        equipmentDashboard.Show();
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
            else
            {
                MessageBox.Show("Please fix the errors before saving the changes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtEquipmentName_TextChanged(object sender, EventArgs e)
        {
            // Check if the field is blank or null
            if (string.IsNullOrWhiteSpace(txtEquipmentName.Text))
            {
                lblEquipmentNameErr.Text = "Cannot be blank.";
                validEquipmentName = false;
                return; // Exit the method early
            }

            // Trim the text to remove leading and trailing spaces
            string inputText = txtEquipmentName.Text.Trim();

            if (inputText.Length < 3) // Check length after trimming leading/trailing spaces
            {
                lblEquipmentNameErr.Text = "Cannot be less than 3 characters.";
                validEquipmentName = false;
            }
            else if (!Regex.IsMatch(inputText, @"^[a-zA-Z ]+$")) // pattern to allow spaces along with letters
            {
                lblEquipmentNameErr.Text = "Only letters and spaces are allowed.";
                validEquipmentName = false;
            }
            else
            {
                lblEquipmentNameErr.Text = ""; // Clear the error message
                validEquipmentName = true;
            }

        }

        private void txtEquipmentDescription_TextChanged(object sender, EventArgs e)
        {
            // Check if the field is blank or null
            if (string.IsNullOrWhiteSpace(txtEquipmentDescription.Text))
            {
                lblEquipmentDescriptionErr.Text = "Cannot be blank.";
                validEquipmentDescription = false;
                return; // Exit the method early
            }

            if (txtEquipmentDescription.Text.Length < 5)
            {
                lblEquipmentDescriptionErr.Text = "Cannot be less than 5 characters.";
                validEquipmentDescription = false;
            }
            else
            {
                lblEquipmentDescriptionErr.Text = ""; // Clear the error message
                validEquipmentDescription = true;
            }

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            // Check if the field is blank or null
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                lblQuantityErr.Text = "Cannot be blank.";
                validQuantity = false;
                return; // Exit the method early
            }

            // Trim the text to remove leading and trailing spaces
            string inputText = txtQuantity.Text.Trim();

            if (!int.TryParse(inputText, out int quantity))
            {
                lblQuantityErr.Text = "Must be a valid number.";
                validQuantity = false;
            }
            else if (quantity < 0)
            {
                lblQuantityErr.Text = "Cannot be negative.";
                validQuantity = false;
            }
            else
            {
                lblQuantityErr.Text = ""; // Clear the error message
                validQuantity = true;
            }

        }

        private void txtRentalPrice_TextChanged(object sender, EventArgs e)
        {
            // Check if the field is blank or null
            if (string.IsNullOrWhiteSpace(txtRentalPrice.Text))
            {
                lblRentalPriceErr.Text = "Cannot be blank.";
                validRentalPrice = false;
                return; // Exit the method early
            }

            // Trim the text to remove leading and trailing spaces
            string inputText = txtRentalPrice.Text.Trim();

            if (!decimal.TryParse(inputText, out decimal rentalPrice))
            {
                lblRentalPriceErr.Text = "Must be a valid number.";
                validRentalPrice = false;
            }
            else if (rentalPrice <= 0)
            {
                lblRentalPriceErr.Text = "Cannot be 0 or negative.";
                validRentalPrice = false;
            }
            else
            {
                lblRentalPriceErr.Text = ""; // Clear the error message
                validRentalPrice = true;
            }

        }
    }
}
