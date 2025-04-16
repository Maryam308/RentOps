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
    public partial class EditReturnRecord : Form
    {
        RentOpsDBContext dbContext;
        internal ReturnRecord returnRecordToEdit;

        //validation variables 
        bool validLateReturnFee = false;
        bool validAdditionalCharge = false;

        public EditReturnRecord(ReturnRecord recordToEdit)
        {
            InitializeComponent();

            dbContext = new RentOpsDBContext();
            //assign the record to edit to the form 
            returnRecordToEdit = recordToEdit;

        }

        private void EditReturnRecord_Load(object sender, EventArgs e)
        {
            //laod conditions into the combo box
            var conditions = dbContext.ReturnConditions.ToList();
            cmbConditionStatus.DataSource = conditions;
            cmbConditionStatus.DisplayMember = "ReturnConditionTitle";
            cmbConditionStatus.ValueMember = "ReturnConditionId";

            //laod the record to edit into the form
            txtAssociatedTransaction.Text = returnRecordToEdit.RentalTransactionId.ToString();

            DateTime dateTime = returnRecordToEdit.ActualReturnDate.ToDateTime(TimeOnly.MinValue); // sets time to 00:00:00

            dtpReturnDate.Value = dateTime;

            txtLateReturnPenalty.Text = returnRecordToEdit.LateReturnFee.ToString();

            txtAdditionalCharge.Text = returnRecordToEdit.AdditionalCharge.ToString();

            cmbConditionStatus.SelectedValue = returnRecordToEdit.ReturnConditionId;



        }

        private void txtLateReturnPenalty_TextChanged(object sender, EventArgs e)
        {

            if (!decimal.TryParse(txtLateReturnPenalty.Text, out decimal price) || price <= 0)
            {
                lblLateReturnPenaltyErr.Text = "Late Return Penalty must be a positive number";
                validLateReturnFee = false;
            }
            else
            {
                lblLateReturnPenaltyErr.Text = string.Empty;
                validLateReturnFee = true;
            }


        }

        private void txtAdditionalCharge_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAdditionalCharge.Text, out decimal price) || price <= 0)
            {
                lblAdditionalChargesErr.Text = "Additional charge must be a positive number";
                validAdditionalCharge = false;
            }
            else
            {
                lblAdditionalChargesErr.Text = string.Empty;
                validAdditionalCharge = true;
            }
        }

        private void cmbConditionStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSaveChages_Click(object sender, EventArgs e)
        {
            //check if all the fields are valid
            if (  validLateReturnFee && validAdditionalCharge)
            {
                //update the record
                returnRecordToEdit.ReturnConditionId = (int)cmbConditionStatus.SelectedValue;

                //convert datetime to date only
                DateOnly dateOnly = DateOnly.FromDateTime(dtpReturnDate.Value);

                returnRecordToEdit.ActualReturnDate = dateOnly;

                //convert the late return fee to double
                double lateReturnFee = Convert.ToDouble(txtLateReturnPenalty.Text);

                returnRecordToEdit.LateReturnFee = lateReturnFee;

                //convert the additional charge to double
                double additionalCharge = Convert.ToDouble(txtAdditionalCharge.Text);
                returnRecordToEdit.AdditionalCharge = additionalCharge;

                MessageBox.Show("The equipment has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the fields correctly");
            }
        }

        private void cmbConditionStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
    }



}
