using Microsoft.EntityFrameworkCore;
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
    public partial class EditRentalTransaction : Form
    {
        RentOpsDBContext dbContext;
        int currentUserId;
        AuditLogger logger;
        internal RentalTransaction rentalTransactionToEdit;
        UploadTransactionDocuments theUploadForm;

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
            logger = new AuditLogger(dbContext);
            currentUserId = Global.user.UserId;

        }

        private void EditRentalTransaction_Load(object sender, EventArgs e)
        {
            //fetch static data 

            try
            {
                // fetch the selected rental transction
                var rentalTransaction = dbContext.RentalTransactions
                .Include(rt => rt.Equipment)
                .Include(rt => rt.Employee)
                .Include(rt => rt.Documents)
                .Include(rt => rt.RentalRequest)
                .ThenInclude(rr => rr.User)
                .Include(rt => rt.Payment)
                .ThenInclude(p => p.PaymentStatus)
                .Include(rt => rt.Payment)
                .ThenInclude(p => p.PaymentMethod)
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
                    EmployeeName = rt.Employee != null ? rt.Employee.FirstName + " " + rt.Employee.LastName : "N/A",
                    paymentStatusId = rt.Payment != null ? rt.Payment.PaymentStatusId : (int?)null,
                    paymentMethodId = rt.Payment != null ? rt.Payment.PaymentMethodId : (int?)null

                })
                .FirstOrDefault();

                //fill in the data in the form
                if (rentalTransaction != null)
                {
                    //set the date time picker values to the rental transaction values
                    dtpPickupDate.Value = rentalTransaction.PickupDate.ToDateTime(new TimeOnly(0, 0));
                    dtpReturnDate.Value = rentalTransaction.ReturnDate.ToDateTime(new TimeOnly(0, 0));

                    //set the text boxes to the rental transaction values
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

                    // Fetch payment statuses and methods (like AddRentalTransaction form)
                    var paymentStatus = dbContext.PaymentStatuses.ToList();
                    var paymentMethod = dbContext.PaymentMethods.ToList();

                    cmbPaymentStatus.DataSource = paymentStatus;
                    cmbPaymentMethod.DataSource = paymentMethod;

                    cmbPaymentStatus.DisplayMember = "PaymentStatusTitle";
                    cmbPaymentMethod.DisplayMember = "PaymentMethodTitle";

                    cmbPaymentStatus.ValueMember = "PaymentStatusId";
                    cmbPaymentMethod.ValueMember = "PaymentMethodId";

                    cmbPaymentStatus.SelectedIndex = -1;
                    cmbPaymentMethod.SelectedIndex = -1;

                    if (rentalTransaction.PaymentId == null)
                    {
                        lblPayment.Text = "Not Paid";
                        lblPayment.ForeColor = Color.Red;


                        cmbPaymentStatus.Enabled = true;
                        cmbPaymentMethod.Enabled = true;

                        cmbPaymentStatus.SelectedIndexChanged += CmbPayment_SelectedIndexChanged;
                        cmbPaymentMethod.SelectedIndexChanged += CmbPayment_SelectedIndexChanged;
                    }
                    else
                    {
                        // Set payment label to Paid in green
                        lblPayment.Text = "Paid";
                        lblPayment.ForeColor = Color.Green;

                        // Pre-select the existing payment method and status from the projection result
                        cmbPaymentStatus.SelectedValue = rentalTransaction.paymentStatusId ?? -1;
                        cmbPaymentMethod.SelectedValue = rentalTransaction.paymentMethodId ?? -1;

                        // Disable changing them
                        cmbPaymentStatus.Enabled = false;
                        cmbPaymentMethod.Enabled = false;


                    }
                }
                else
                {
                    //show an error message if the rental transaction is not found
                    MessageBox.Show("Rental transaction not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                //log the exception
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);

                //show the error message
                MessageBox.Show("An error occurred while loading the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {
            //check if the deposit in a non negative number
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
            //check if the rental fee is a non negative number
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
            if (validDeposit && validRentalFee && validPickupDate)
            {
                if (rentalTransactionToEdit.PaymentId == null &&
                    cmbPaymentStatus.Enabled && cmbPaymentMethod.Enabled &&
                    (cmbPaymentStatus.SelectedIndex == -1 || cmbPaymentMethod.SelectedIndex == -1))
                {
                    MessageBox.Show("Please select both Payment Status and Payment Method before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Get a fresh, tracked instance
                    var rentalTransaction = dbContext.RentalTransactions
                        .Include(rt => rt.Documents)
                        .FirstOrDefault(rt => rt.RentalTransactionId == rentalTransactionToEdit.RentalTransactionId);

                    if (rentalTransaction == null)
                    {
                        MessageBox.Show("Rental transaction not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update basic fields
                    rentalTransaction.RentalFee = Convert.ToDouble(txtRentalFee.Text);
                    rentalTransaction.Deposit = Convert.ToDouble(txtDeposit.Text);
                    rentalTransaction.ReturnDate = DateOnly.FromDateTime(dtpReturnDate.Value);
                    rentalTransaction.PickupDate = DateOnly.FromDateTime(dtpPickupDate.Value);

                    // Add new Payment if needed
                    if (rentalTransaction.PaymentId == null &&
                        cmbPaymentStatus.Enabled && cmbPaymentMethod.Enabled)
                    {
                        var newPayment = new Payment
                        {
                            PaymentMethodId = (int)cmbPaymentMethod.SelectedValue,
                            PaymentStatusId = (int)cmbPaymentStatus.SelectedValue
                        };

                        dbContext.Payments.Add(newPayment);
                        dbContext.SaveChanges();

                        rentalTransaction.PaymentId = newPayment.PaymentId;
                    }

                    // Update documents
                    UpdateDocument(rentalTransaction, agreement, 4, theUploadForm?.isAgreementModified == true);
                    UpdateDocument(rentalTransaction, idVerification, 5, theUploadForm?.isIDModified == true);

                    dbContext.SaveChanges();

                    MessageBox.Show("The rental transaction has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDocument(RentalTransaction rentalTransaction, Document newDoc, int fileTypeId, bool isModified)
        {
            if (!isModified) return;

            var existing = rentalTransaction.Documents.FirstOrDefault(d => d.FileTypeId == fileTypeId);

            if (newDoc == null)
            {
                if (existing != null)
                {
                    rentalTransaction.Documents.Remove(existing);
                }
            }
            else
            {
                if (existing != null && existing.DocumentId == newDoc.DocumentId)
                    return;

                // Avoid tracking multiple instances
                var trackedDoc = dbContext.Documents.Local.FirstOrDefault(d => d.DocumentId == newDoc.DocumentId);
                if (trackedDoc == null)
                {
                    dbContext.Documents.Attach(newDoc);
                    trackedDoc = newDoc;
                }

                rentalTransaction.Documents.Remove(existing);
                rentalTransaction.Documents.Add(trackedDoc);
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
            try
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

                    // Only update local variables, do not touch dbContext or rentalTransactionToEdit.Documents here
                    if (uploadForm.isAgreementModified)
                        agreement = uploadForm.agreement;

                    if (uploadForm.isIDModified)
                        idVerification = uploadForm.idVerification;
                    
                    theUploadForm = uploadForm;

                }
            }
            catch (Exception ex)
            {
                // log the exception
                logger.LogException(currentUserId, ex.Message, ex.StackTrace, Global.sourceId);
              
                // show a the error message
                MessageBox.Show("An error occurred while updating the transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
