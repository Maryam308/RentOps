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

namespace RentOpsDesktop
{
    public partial class AddEquipment : Form
    {
        RentOpsDBContext context;
        bool validEquipmentName = false;
        bool validEquipmentDescription = false;
        bool validEquipmentCategory = false;
        bool validQuantity = false;
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

        private void ValidateForm()
        {
            btnAddEquipment.Enabled = validEquipmentName && validEquipmentDescription && validEquipmentCategory &&
                                      validQuantity && validRentalPrice && validConditionStatus && validAvailabilityStatus;
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

        private void cmbEquipmentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hasInteractedWithCategory)
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
            }
            else
            {
                validEquipmentCategory = cmbEquipmentCategory.SelectedItem != null;
            }

            ValidateForm();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                lblQuantityErr.Text = "Quantity must be a positive integer";
                validQuantity = false;
            }
            else
            {
                lblQuantityErr.Text = string.Empty;
                validQuantity = true;
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

        private void cmbConditionStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hasInteractedWithConditionStatus)
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
            }
            else
            {
                validConditionStatus = cmbConditionStatus.SelectedItem != null;
            }
            ValidateForm();

        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            if (validEquipmentName && validEquipmentDescription && validEquipmentCategory &&
       validQuantity && validRentalPrice && validConditionStatus && validAvailabilityStatus)
            {
                try
                {
                    equipment = new Equipment
                    {
                        EquipmentName = txtEquipmentName.Text,
                        EquipmentDescription = txtEquipmentDescription.Text,
                        EquipmentCategoryId = Convert.ToInt32(cmbEquipmentCategory.SelectedValue),
                        //EquipmentQuantity = Convert.ToInt32(txtQuantity.Text),
                        RentalPrice = Convert.ToDouble(txtRentalPrice.Text),
                        ConditionStatusId = Convert.ToInt32(cmbConditionStatus.SelectedValue),
                        AvailabilityStatusId = Convert.ToInt32(cmbAvailabilityStatus.SelectedValue)
                    };

                    MessageBox.Show("Equipment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the equipment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please ensure all fields are valid before adding equipment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ClearForm()
        {
            txtEquipmentName.Clear();
            txtEquipmentDescription.Clear();
            cmbEquipmentCategory.SelectedItem = null;
            txtQuantity.Clear();
            txtRentalPrice.Clear();
            cmbConditionStatus.SelectedItem = null;
            cmbAvailabilityStatus.SelectedItem = null;

            validEquipmentName = false;
            validEquipmentDescription = false;
            validEquipmentCategory = false;
            validQuantity = false;
            validRentalPrice = false;
            validConditionStatus = false;
            validAvailabilityStatus = false;

            ValidateForm();
        }

        private void cmbAvailabilityStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hasInteractedWithAvailabilityStatus)
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
            }
            else
            {
                validAvailabilityStatus = cmbAvailabilityStatus.SelectedItem != null;
            }
            ValidateForm();

        }

        private void cmbEquipmentCategory_DropDownClosed(object sender, EventArgs e)
        {
            hasInteractedWithCategory = true;
            cmbEquipmentCategory_SelectedIndexChanged(sender, e);
        }

        private void cmbConditionStatus_DropDownClosed(object sender, EventArgs e)
        {
            hasInteractedWithConditionStatus = true;
            cmbConditionStatus_SelectedIndexChanged(sender, e);
        }

        private void cmbAvailabilityStatus_DropDownClosed(object sender, EventArgs e)
        {
            hasInteractedWithAvailabilityStatus = true;
            cmbAvailabilityStatus_SelectedIndexChanged(sender, e);
        }
    }
}
