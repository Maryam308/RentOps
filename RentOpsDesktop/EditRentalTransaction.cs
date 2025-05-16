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
    public partial class EditRentalTransaction : Form
    {
        RentOpsDBContext dbContext;
        internal RentalTransaction rentalTransactionToEdit;

        Document agreement;
        Document idVerification;

        bool validDeposit = false;
        bool validRentalFee = false;
        bool validPickupDate = false;
        public EditRentalTransaction(RentalTransaction rentalTransactionToEdit)
        {
            InitializeComponent();
            dbContext = new RentOpsDBContext();
            this.rentalTransactionToEdit = rentalTransactionToEdit;

        }

        private void EditRentalTransaction_Load(object sender, EventArgs e)
        {
            //fetch static data 

            try
            {

                var rentalTransaction = dbContext.RentalTransactions
                .Include(rt => rt.Equipment)
                .Include(rt => rt.Employee)
                .Include(rt => rt.Documents)
                .Include(rt => rt.RentalRequest)
                .ThenInclude(rr => rr.User)
                .Where(rt => rt.RentalTransactionId == rentalTransactionToEdit.RentalTransactionId)
                .Select(rt => new
                {
                    rt.RentalTransactionId,
                    rt.PickupDate,
                    rt.ReturnDate,
                    rt.Deposit,
                    rt.RentalFee,
                    rt.RentalTransactionTimestamp,
                    rt.PaymentId,
                    rt.RentalRequestId,
                    rt.EmployeeId,
                    agreement = rt.Documents.Where(rt => rt.FileTypeId == 4),
                    idVerification = rt.Documents.Where(rt => rt.FileTypeId == 5),
                    requesterName = rt.RentalRequest != null ? rt.RentalRequest.User.FirstName + " " + rt.RentalRequest.User.LastName : "N/A",
                    rt.EquipmentId,
                    EquipmentName = rt.Equipment != null ? rt.Equipment.EquipmentName : "N/A",
                    EmployeeName = rt.Employee != null ? rt.Employee.FirstName + " " + rt.Employee.LastName : "N/A"

                })
                .FirstOrDefault();

                //fill in the data in the form
                if (rentalTransaction != null)
                {


                    //set the date time picker values to the rental transaction values
                    dtpPickupDate.Value = rentalTransaction.PickupDate.ToDateTime(new TimeOnly(0, 0));
                    dtpReturnDate.Value = rentalTransaction.ReturnDate.ToDateTime(new TimeOnly(0, 0));


                    txtDeposit.Text = rentalTransaction.Deposit.ToString();
                    txtRentalFee.Text = rentalTransaction.RentalFee.ToString();
                    lblTimestamp.Text = rentalTransaction.RentalTransactionTimestamp.ToString("yyyy-MM-dd HH:mm:ss");
                    txtRentedBy.Text = rentalTransaction.requesterName;
                    txtRentedEquipment.Text = rentalTransaction.EquipmentName;
                    txtManagedBy.Text = rentalTransaction.EmployeeName;


                    //display rental period 
                    DateTime pickupDate = rentalTransaction.PickupDate.ToDateTime(new TimeOnly(0, 0));
                    DateTime returnDate = rentalTransaction.ReturnDate.ToDateTime(new TimeOnly(0, 0));
                    TimeSpan rentalPeriod = returnDate - pickupDate;
                    lblRentalPeriod.Text = rentalPeriod.Days.ToString() + " days";


                    //determine if paid
                    if (rentalTransaction.PaymentId == null)
                    {
                        lblPayment.Text = "Not Paid";
                        lblPayment.ForeColor = Color.Red;
                    }


                    
                    


                }
                else
                {
                    MessageBox.Show("Rental transaction not found.");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }



        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDeposit.Text, out decimal price) || price <= 0)
            {
                lblDepositError.Text = "Late Return Penalty must be a positive number";
                validDeposit = false;
            }
            else
            {
                lblDepositError.Text = string.Empty;
                validDeposit = true;
            }
        }

        private void txtRentalFee_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtRentalFee.Text, out decimal price) || price <= 0)
            {
                lblRentalFeeError.Text = "Late Return Penalty must be a positive number";
                validRentalFee = false;
            }
            else
            {
                lblRentalFeeError.Text = string.Empty;
                validRentalFee = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //close the dialoug and go back 
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnUpdateRentalTransaction_Click(object sender, EventArgs e)
        {
            //check if all the fields are valid
            if (validDeposit && validRentalFee)
            {
                //update the record
                rentalTransactionToEdit.RentalFee = Convert.ToDouble(txtRentalFee.Text);
                rentalTransactionToEdit.Deposit = Convert.ToDouble(txtDeposit.Text);

                //add the date after converting it to date only

                rentalTransactionToEdit.ReturnDate = DateOnly.FromDateTime(dtpReturnDate.Value);
                rentalTransactionToEdit.PickupDate = DateOnly.FromDateTime(dtpPickupDate.Value);


                MessageBox.Show("The rental transaction has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the fields correctly");
            }
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            //if the return date is less than the pickup date, show an error message
            if (dtpReturnDate.Value < dtpPickupDate.Value)
            {
                lblPickupDateError.Text = "Return date cannot be less than pickup date";
                validPickupDate = false;
            }
            else
            {
                lblPickupDateError.Text = string.Empty;
                validPickupDate = true;
            }

            //calculate the rental period
            DateTime pickupDate = dtpPickupDate.Value;
            DateTime returnDate = dtpReturnDate.Value;
            TimeSpan rentalPeriod = returnDate - pickupDate;
            //display the rental period
            lblRentalPeriod.Text = rentalPeriod.Days.ToString() + " days";



        }

        private void dtpPickupDate_ValueChanged(object sender, EventArgs e)
        {
            //calculate the rental period
            DateTime pickupDate = dtpPickupDate.Value;
            DateTime returnDate = dtpReturnDate.Value;
            TimeSpan rentalPeriod = returnDate - pickupDate;
            //display the rental period
            lblRentalPeriod.Text = rentalPeriod.Days.ToString() + " days";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Fetch the rental transactions including their documents
            var rentalTransactions = dbContext.RentalTransactions
                .Include(rt => rt.Documents)
                .Where(rt => rt.RentalTransactionId == rentalTransactionToEdit.RentalTransactionId)
                .ToList();  // Convert IQueryable to a list

            // Loop through the rental transactions
            foreach (var transaction in rentalTransactions)
            {
                foreach (var document in transaction.Documents)
                {
                    if (document != null)
                    {
                        if (document.FileTypeId == 5)
                        {
                            idVerification = document;
                        }
                        if (document.FileTypeId == 4)
                        {
                            agreement = document;
                        }
                    }
                }
            }


            // Show the UploadTransactionDocuments form as a dialog
            UploadTransactionDocuments uploadForm = new UploadTransactionDocuments(agreement, idVerification);
            DialogResult result = uploadForm.ShowDialog();

            if (result == DialogResult.OK)
            {

                if (uploadForm.isAgreementModified == true) {

                    if (agreement != null)
                    {

                        //remove the old agreement 
                        rentalTransactionToEdit.Documents.Remove(agreement);

                        agreement = uploadForm.agreement;

                        if (agreement != null)
                        {
                            rentalTransactionToEdit.Documents.Add(agreement);
                        }

                    }
                    else { 
                    
                        agreement = uploadForm.agreement;

                            if (agreement != null)
                            {
                                rentalTransactionToEdit.Documents.Add(agreement);
                            }

                    
                    }
                    if (idVerification != null)
                    {

                        //remove the old agreement 
                        rentalTransactionToEdit.Documents.Remove(idVerification);

                        idVerification = uploadForm.idVerification;

                        if (idVerification != null)
                        {
                            rentalTransactionToEdit.Documents.Add(idVerification);
                        }

                    }
                    else
                    {

                        agreement = uploadForm.agreement;

                        if (idVerification != null)
                        {
                            rentalTransactionToEdit.Documents.Add(idVerification);
                        }


                    }


                }

                    if (uploadForm.isIDModified == true) { 
                        idVerification = uploadForm.idVerification;



                    }

                
                
            }
        }
    }
}
