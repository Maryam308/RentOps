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
    public partial class AddReturnRecord : Form
    {

        RentOpsDBContext dbContext;
        internal ReturnRecord newReturnRecord = new ReturnRecord();

        //validation variables 
        bool validLateReturnFee = false;
        bool validAdditionalCharge = false;

        public AddReturnRecord()
        {
            InitializeComponent();
            dbContext = new RentOpsDBContext();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddReturnRecord_Load(object sender, EventArgs e)
        {
            //laod conditions into the combo box
            var conditions = dbContext.ConditionStatuses.ToList();
            cmbReturnCondition.DataSource = conditions;
            cmbReturnCondition.DisplayMember = "ConditionStatusTitle";
            cmbReturnCondition.ValueMember = "ConditionStatusId";
            //select the default
            //cmbReturnCondition.SelectedIndex = 0;


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

        private void cmbReturnCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check if all the fields are valid
            if ( !validLateReturnFee && !validAdditionalCharge)
            {
                MessageBox.Show("Please fill all the fields correctly");
                return;
            }

            //check if the associated rental transaction exist
            var rentalTransaction = dbContext.RentalTransactions.Find(Convert.ToInt32(txtAssociatedTransaction.Text));
                if (rentalTransaction == null)
                {
                    MessageBox.Show("The associated rental transaction does not exist");
                    return;
                }

            //create a new return record
            newReturnRecord.LateReturnFee = Convert.ToDouble(txtLateReturnPenalty.Text);
            newReturnRecord.AdditionalCharge = Convert.ToDouble(txtAdditionalCharge.Text);
            newReturnRecord.ReturnConditionId = (int)cmbReturnCondition.SelectedValue;
            newReturnRecord.RentalTransactionId = Convert.ToInt32(txtAssociatedTransaction.Text);
            //convert datetime to date only
            DateOnly dateOnly = DateOnly.FromDateTime(dtpReturnDate.Value);
            newReturnRecord.ActualReturnDate = dateOnly;

            //set the dialog result to ok
            this.DialogResult = DialogResult.OK;
            //close the form
            this.Close();


        }
    }
}
