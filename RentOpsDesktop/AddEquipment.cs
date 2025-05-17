using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentOpsObjects;
using RentOpsObjects.Model;
using RentOpsObjects.Services;


namespace RentOpsDesktop
{

    public partial class AddEquipment : Form
    {
        int currentUserId;
        RentOpsDBContext context;
        AuditLogger logger;
        bool validEquipmentName = false;
        bool validEquipmentDescription = false;
        bool validEquipmentCategory = false;

        bool validRentalPrice = false;
        bool validConditionStatus = false;
        bool validAvailabilityStatus = false;
        internal Equipment equipment;
        private bool hasInteractedWithCategory = false;
        private bool hasInteractedWithConditionStatus = false;
        private bool hasInteractedWithAvailabilityStatus = false;


        public AddEquipment()
        {
            InitializeComponent();
            context = new RentOpsDBContext();
            logger = new AuditLogger(context); //create a logger object
            currentUserId = Global.EmployeeID;
        }

        private void AddEquipment_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            try 
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
            }
            catch (Exception ex)
            {
                // log the error
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);

                // show a message to the user
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void ValidateForm()
        {
            btnAddEquipment.Enabled = validEquipmentName && validEquipmentDescription && validEquipmentCategory &&
                                       validRentalPrice && validConditionStatus && validAvailabilityStatus;
        }


        private void txtEquipmentName_TextChanged(object sender, EventArgs e)
        {
            //validate the equipment name
            //check if the equipment name is empty
            if (string.IsNullOrWhiteSpace(txtEquipmentName.Text))
            {
                lblEquipmentNameErr.Text = "Equipment name cannot be empty";
                validEquipmentName = false;
            }
            //check if the equipment name is less than 3 characters
            else if (txtEquipmentName.Text.Length < 3)
            {
                lblEquipmentNameErr.Text = "Equipment name must be at least 3 characters long";
                validEquipmentName = false;
            }
            //else the name is valid
            else
            {
                lblEquipmentNameErr.Text = string.Empty;
                validEquipmentName = true;
            }
            ValidateForm();

        }

        private void txtEquipmentDescription_TextChanged(object sender, EventArgs e)
        {
            //validate the equipment description
            //check if the equipment description is empty
            if (string.IsNullOrWhiteSpace(txtEquipmentDescription.Text))
            {
                lblEquipmentDescriptionErr.Text = "Equipment description cannot be empty";
                validEquipmentDescription = false;
            }
            //check if the equipment description is less than 10 characters
            else if (txtEquipmentDescription.Text.Length < 10)
            {
                lblEquipmentDescriptionErr.Text = "Equipment description must be at least 10 characters long";
                validEquipmentDescription = false;
            }
            //else the description is valid
            else
            {
                lblEquipmentDescriptionErr.Text = string.Empty;
                validEquipmentDescription = true;
            }
            ValidateForm();

        }

        private void cmbEquipmentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validate the equipment category
            //check if the equipment category is empty
            if (hasInteractedWithCategory)
            {
                //check if the equipment category is selected
                if (cmbEquipmentCategory.SelectedItem == null)
                {
                    lblEquipmentCategoryErr.Text = "Please select an equipment category";
                    validEquipmentCategory = false;
                }
                //else the category is valid
                else
                {
                    lblEquipmentCategoryErr.Text = string.Empty;
                    validEquipmentCategory = true;
                }
            }
            else
            {
                validEquipmentCategory = cmbEquipmentCategory.SelectedItem != null;
            }

            ValidateForm();
        }


        private void txtRentalPrice_TextChanged(object sender, EventArgs e)
        {
            //validate the rental price
            //check if the rental price is empty, grater than 0, and a number
            if (!decimal.TryParse(txtRentalPrice.Text, out decimal price) || price <= 0)
            {
                lblRentalPriceErr.Text = "Rental price must be a positive number";
                validRentalPrice = false;
            }
            //if not empty, and grater than 0, then the rental price is valid
            else
            {
                lblRentalPriceErr.Text = string.Empty;
                validRentalPrice = true;
            }
            ValidateForm();

        }

        private void cmbConditionStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validate the condition status
            if (hasInteractedWithConditionStatus)
            {
                //check if the condition status is selected
                if (cmbConditionStatus.SelectedItem == null)
                {
                    lblConditionStatusErr.Text = "Please select a condition status";
                    validConditionStatus = false;
                }
                //else the condition status is valid
                else
                {
                    lblConditionStatusErr.Text = string.Empty;
                    validConditionStatus = true;
                }
            }
            else
            {
                validConditionStatus = cmbConditionStatus.SelectedItem != null;
            }
            ValidateForm();

        }

        // function to check if the equipment already exists in the database
        private bool EquipmentAlreadyExists()
        {
            //fetching an equipment with the same entered values from the database
            var existingEquipment = context.Equipment.FirstOrDefault(e =>
                e.EquipmentName == txtEquipmentName.Text &&
                e.EquipmentDescription == txtEquipmentDescription.Text &&
                e.EquipmentCategoryId == Convert.ToInt32(cmbEquipmentCategory.SelectedValue) &&
                e.RentalPrice == Convert.ToDouble(txtRentalPrice.Text) &&
                e.ConditionStatusId == Convert.ToInt32(cmbConditionStatus.SelectedValue) &&
                e.AvailabilityStatusId == Convert.ToInt32(cmbAvailabilityStatus.SelectedValue));

            //if the equipment already exists, show a message and return true
            if (existingEquipment != null)
            {
                MessageBox.Show("An equipment with identical details already exists and cannot be added again.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }


        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            if (validEquipmentName && validEquipmentDescription && validEquipmentCategory &&
        validRentalPrice && validConditionStatus && validAvailabilityStatus)
            {
                try
                {
                    //check if the equipment already exists
                    if (EquipmentAlreadyExists())
                    {
                        return;
                    }

                    // create a new equipment object
                    equipment = new Equipment
                    {
                        EquipmentName = txtEquipmentName.Text,
                        EquipmentDescription = txtEquipmentDescription.Text,
                        EquipmentCategoryId = Convert.ToInt32(cmbEquipmentCategory.SelectedValue),
                        RentalPrice = Convert.ToDouble(txtRentalPrice.Text),
                        ConditionStatusId = Convert.ToInt32(cmbConditionStatus.SelectedValue),
                        AvailabilityStatusId = Convert.ToInt32(cmbAvailabilityStatus.SelectedValue),
                        UserId = currentUserId
                    };

                    //show a success message to the user
                    MessageBox.Show("Equipment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {
                    // log the error
                    logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);

                    // show a message to the user
                    MessageBox.Show($"An error occurred while adding the equipment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // show a message to the user to indicate that the form is not valid or not filled out
                MessageBox.Show("Please ensure all fields are valid before adding equipment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //this function clears the form inputs
        private void ClearForm()
        {
            txtEquipmentName.Clear();
            txtEquipmentDescription.Clear();
            cmbEquipmentCategory.SelectedItem = null;
            //txtQuantity.Clear();
            txtRentalPrice.Clear();
            cmbConditionStatus.SelectedItem = null;
            cmbAvailabilityStatus.SelectedItem = null;

            validEquipmentName = false;
            validEquipmentDescription = false;
            validEquipmentCategory = false;
            //validQuantity = false;
            validRentalPrice = false;
            validConditionStatus = false;
            validAvailabilityStatus = false;

            ValidateForm();
        }

        private void cmbAvailabilityStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validate the availability status
            if (hasInteractedWithAvailabilityStatus)
            {
                //check if the availability status is selected
                if (cmbAvailabilityStatus.SelectedItem == null)
                {
                    lblAvailabilityStatusErr.Text = "Please select availability status";
                    validAvailabilityStatus = false;
                }
                //else the availability status is valid
                else
                {
                    lblAvailabilityStatusErr.Text = string.Empty;
                    validAvailabilityStatus = true;
                }
            }
            else
            {
                validAvailabilityStatus = cmbAvailabilityStatus.SelectedItem != null;
            }
            ValidateForm();

        }

        private void cmbEquipmentCategory_DropDownClosed(object sender, EventArgs e)
        {
            //check if the equipment category is selected
            hasInteractedWithCategory = true;
            cmbEquipmentCategory_SelectedIndexChanged(sender, e);
        }

        private void cmbConditionStatus_DropDownClosed(object sender, EventArgs e)
        {
            //check if the condition status is selected
            hasInteractedWithConditionStatus = true;
            cmbConditionStatus_SelectedIndexChanged(sender, e);
        }

        private void cmbAvailabilityStatus_DropDownClosed(object sender, EventArgs e)
        {
            //check if the availability status is selected
            hasInteractedWithAvailabilityStatus = true;
            cmbAvailabilityStatus_SelectedIndexChanged(sender, e);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            //close the form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
