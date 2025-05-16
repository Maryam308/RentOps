using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentOpsObjects.Model;

namespace RentOpsDesktop
{
    public partial class AddRentalTransaction : Form
    {
        RentOpsDBContext context;
        int equipmentId;
        double rentalPrice;
        double totalPrice;
        int rentalTransactionID;
        RentOpsObjects.Model.Document agreement;
        RentOpsObjects.Model.Document idVerification;

        //validation variables 
        bool isValidReturnDate = false;
        bool isValidDeposit = false;
        bool isValidUserId = false;
        bool isValidFirstName = false;
        bool isValidLastName = false;
        bool isValidPhoneNumber = false;
        bool isValidEmail = false;
        bool isPaid = false;
        bool isWebsiteUser = false;
        bool hasDocument = false;

        public AddRentalTransaction(int equipmentId)
        {
            InitializeComponent();

            context = new RentOpsDBContext();

            this.equipmentId = equipmentId;

        }

        private void btnAddRentalTransaction_Click(object sender, EventArgs e)
        {
            //add the rental transaction 

            //the manager will be adding all the following information including the rental transaction details and the user details and as well as the payment details

            //in case of a website user no need to add the user details add the rental transaction and link it with a user id 

            if (isWebsiteUser)
            {
                //check if the user id is valid
                if (!isValidUserId)
                {
                    MessageBox.Show("Please enter a valid User ID");
                    return;
                }

                //check if the rental details are valid
                if (!isValidReturnDate || !isValidDeposit)
                {
                    MessageBox.Show("Please enter valid rental details");
                    return;
                }

                //check if the payment details are valid
                if (isPaid && cmbPaymentMethod.SelectedIndex == -1 && cmbPaymentStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please enter valid payment details");
                    return;
                }

                //add the rental transaction
                RentalTransaction rentalTransaction = new RentalTransaction
                {
                    EquipmentId = equipmentId,
                    EmployeeId = Global.EmployeeID,
                    UserId = Convert.ToInt32(txtUserId.Text),
                    PickupDate = DateOnly.FromDateTime(dtpPickupDate.Value.Date),
                    ReturnDate = DateOnly.FromDateTime(dtpReturnDate.Value.Date),
                    RentalFee = totalPrice,
                    Deposit = (double)Convert.ToDecimal(txtDeposit.Text),
                    RentalTransactionTimestamp = DateTime.Now,
                };

                //add the rental transaction to the database
                context.RentalTransactions.Add(rentalTransaction);

                if (isPaid)
                {
                    //creat a payment object
                    Payment payment = new Payment();
                    payment.PaymentMethodId = cmbPaymentMethod.SelectedIndex;
                    payment.PaymentStatusId = cmbPaymentStatus.SelectedIndex;

                    //add the payment to the database
                    context.Payments.Add(payment);

                    //check if the transaction has document then add them to the database
                    if (hasDocument) {
                        if (agreement != null) {
                            context.Documents.Add(agreement);
                        }
                        if(idVerification != null) {  context.Documents.Add(idVerification); }
                        
                    }

                    //save changes in the db and then link the objects to the transaction
                    context.SaveChanges();

                    if (hasDocument)
                    {

                        rentalTransaction.Documents = new List<RentOpsObjects.Model.Document>();

                        if (agreement != null)
                        {
                            //add the agreement to the list
                            rentalTransaction.Documents.Add(agreement);
                        }
                        if (idVerification != null)
                        {
                            //add the idVerification to the list
                            rentalTransaction.Documents.Add(idVerification);
                        }

                    }

                    //attach the payment to the transaction
                    rentalTransaction.PaymentId = payment.PaymentId;
                    rentalTransaction.Payment = payment;

                    //save changes again
                    context.SaveChanges();

                }
                else
                {
                    if (hasDocument)
                    {
                        if (agreement != null)
                        {
                            context.Documents.Add(agreement);
                        }
                        if (idVerification != null) { context.Documents.Add(idVerification); }

                    }
                    //save changes in the db and then link the objects to the transaction
                    context.SaveChanges();
                    
                    if (hasDocument)
                    {

                        rentalTransaction.Documents = new List<RentOpsObjects.Model.Document>();

                        if (agreement != null)
                        {
                            //add the agreement to the list
                            rentalTransaction.Documents.Add(agreement);
                        }
                        if (idVerification != null)
                        {
                            //add the idVerification to the list
                            rentalTransaction.Documents.Add(idVerification);
                        }

                        context.SaveChanges();

                    }
                }
                //save the rental transaction id
                rentalTransactionID = rentalTransaction.RentalTransactionId;

            }
            else
            {
                //else means the customer is an external customer ]

                //check if the user details are valid
                if (!isValidFirstName || !isValidLastName || !isValidPhoneNumber || !isValidEmail)
                {
                    MessageBox.Show("Please enter valid user details");
                    return;
                }

                //check if the rental details are valid
                if (!isValidReturnDate || !isValidDeposit)
                {
                    MessageBox.Show("Please enter valid rental details");
                    return;
                }

                //check if the payment details are valid
                if (isPaid && cmbPaymentMethod.SelectedIndex == -1 && cmbPaymentStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please enter valid payment details");
                    return;
                }


                //create an external customer object
                ExternalCustomer externalCustomer = new ExternalCustomer
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,

                };
                //add the external customer to the database
                context.ExternalCustomers.Add(externalCustomer);

                //add the rental transaction
                RentalTransaction rentalTransaction = new RentalTransaction
                {
                    EquipmentId = equipmentId,
                    EmployeeId = Global.EmployeeID,
                    PickupDate = DateOnly.FromDateTime(dtpPickupDate.Value.Date),
                    ReturnDate = DateOnly.FromDateTime(dtpReturnDate.Value.Date),
                    RentalFee = totalPrice,
                    Deposit = (double)Convert.ToDecimal(txtDeposit.Text),
                    RentalTransactionTimestamp = DateTime.Now,
                };

                //add the rental transaction to the database
                context.RentalTransactions.Add(rentalTransaction);

                if (isPaid)
                {
                    //creat a payment object
                    Payment payment = new Payment();
                    payment.PaymentMethodId = cmbPaymentMethod.SelectedIndex;
                    payment.PaymentStatusId = cmbPaymentStatus.SelectedIndex;

                    //add the payment to the database
                    context.Payments.Add(payment);

                    if (hasDocument)
                    {
                        if (agreement != null)
                        {
                            context.Documents.Add(agreement);
                        }
                        if (idVerification != null) { context.Documents.Add(idVerification); }

                    }

                    //save changes in the db and then link the objects to the transaction
                    context.SaveChanges();

                    //attach the payment to the transaction
                    rentalTransaction.PaymentId = payment.PaymentId;
                    rentalTransaction.Payment = payment;

                    //attach the customer
                    rentalTransaction.CustomerId = externalCustomer.CustomerId;

                    //save changes again
                    context.SaveChanges();

                }
                else
                {

                    //add a not paid transaction
                    //check if there is documents to add
                    if (hasDocument)
                    {
                        if (agreement != null)
                        {
                            context.Documents.Add(agreement);
                        }
                        if (idVerification != null) { context.Documents.Add(idVerification); }

                    }
                    //save changes in the db and then link the objects to the transaction
                    context.SaveChanges();

                    //attach the customer and the doucuments
                    rentalTransaction.CustomerId = externalCustomer.CustomerId;

                    if (hasDocument) {

                        rentalTransaction.Documents = new List<RentOpsObjects.Model.Document>();

                        if (agreement != null) {
                            //add the agreement to the list
                            rentalTransaction.Documents.Add(agreement);
                        }
                        if (idVerification != null) { 
                            //add the idVerification to the list
                            rentalTransaction.Documents.Add(idVerification);
                        }
                    
                    }

                    //save changes again
                    context.SaveChanges();


                }

                //save the rental transaction id
                rentalTransactionID = rentalTransaction.RentalTransactionId;


            }

            //navigate back to rental transactions
            this.Hide();
            RentalTransactions rentalTransactions = new RentalTransactions();
            rentalTransactions.Show();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
            ChooseEquipment chooseEquipment = new ChooseEquipment();
            chooseEquipment.Show();
        }

        private void AddRentalTransaction_Load(object sender, EventArgs e)
        {
            //load the equipment name
            var equipment = context.Equipment.FirstOrDefault(e => e.EquipmentId == equipmentId);

            txtEquipment.Text = equipment.EquipmentName;

            //save the equipment price 
            rentalPrice = equipment.RentalPrice;


            //assume that the customer is an external customer and the manager will be adding the customer details
            txtUserId.Enabled = false;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtEmail.Enabled = true;

            //load the payment status and payment method
            var paymentStatus = context.PaymentStatuses.ToList();
            var paymentMethod = context.PaymentMethods.ToList();
            cmbPaymentStatus.DataSource = paymentStatus;
            cmbPaymentMethod.DataSource = paymentMethod;
            cmbPaymentStatus.DisplayMember = "PaymentStatusTitle";
            cmbPaymentMethod.DisplayMember = "PaymentMethodTitle";
            cmbPaymentStatus.ValueMember = "PaymentStatusId";
            cmbPaymentMethod.ValueMember = "PaymentMethodId";
            cmbPaymentStatus.SelectedIndex = -1;
            cmbPaymentMethod.SelectedIndex = -1;




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if the checkbox is checked then the manager will just add the id of the user that the user will be able to view from the website 
            if (checkBox1.Checked)
            {
                txtUserId.Enabled = true;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtPhoneNumber.Enabled = false;
                txtEmail.Enabled = false;
            }
            else
            {
                //if the checkbox is unchecked then the manager will be able to add the customer details and that customer will be saved as an external customer
                txtUserId.Enabled = false;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtPhoneNumber.Enabled = true;
                txtEmail.Enabled = true;
            }
        }

        private void txtReturnDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpPickupDate_ValueChanged(object sender, EventArgs e)
        {
            //every time the user changes the pickup date check if the return date is valid if not print an error and set is validReturnDate to false
            if (dtpPickupDate.Value.Date > dtpReturnDate.Value.Date)
            {
                lblReturnDateErr.Text = "Return date cannot be less than PickupDate";
                isValidReturnDate = false;
            }
            else
            {
                isValidReturnDate = true;
                lblReturnDateErr.Text = "";
            }


            if (isValidReturnDate)
            {

                //every time the date change and return date is valid calculate the rental duration and multiply it by the rental price to get the total price 
                //get the rental duration
                TimeSpan rentalDuration = dtpReturnDate.Value.Date - dtpPickupDate.Value.Date;
                //get the total price
                 totalPrice = rentalDuration.TotalDays * rentalPrice;
                //set the total price to the label
                txtRentalFee.Text = totalPrice.ToString("C2");

            }





        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            //every time the user changes the return date check if it is less than the pickup date if it is print an error and set isValidReturnDate to false
            if (dtpReturnDate.Value.Date < dtpPickupDate.Value.Date)
            {
                lblReturnDateErr.Text = "Return date cannot be less than PickupDate";
                isValidReturnDate = false;
            }
            else
            {
                isValidReturnDate = true;
                lblReturnDateErr.Text = "";
            }

            if (isValidReturnDate)
            {

                //every time the date change and return date is valid calculate the rental duration and multiply it by the rental price to get the total price 
                //get the rental duration
                TimeSpan rentalDuration = dtpReturnDate.Value.Date - dtpPickupDate.Value.Date;
                //get the total price
                 totalPrice = rentalDuration.TotalDays * rentalPrice;
                //set the total price to the label
                txtRentalFee.Text = totalPrice.ToString("C2");

            }


        }

        private void gbCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //if the checkbox of the payment is checked then the manager will add the payment method and the payment status
            if (checkBox2.Checked)
            {
                //enable the payment method and payment status
                cmbPaymentMethod.Enabled = true;
                cmbPaymentStatus.Enabled = true;
                //set the transaction as paid
                isPaid = true;
            }
            else
            {
                //if the checkbox is unchecked then the manager will not add the payment method and the payment status
                cmbPaymentMethod.Enabled = false;
                cmbPaymentStatus.Enabled = false;
                //set the transaction as not paid
                isPaid = false;
            }
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            try
            {

                bool isValidUserIdFrmt = false;

                //if the user id is empty then set the user details to empty and stop the retrival of the user details and set the error message to empty
                //if the user id is not empty then check if the user id is a number
                if (txtUserId.Text.Trim() == "" || string.IsNullOrEmpty(txtUserId.Text))
                {
                    //if the user id is empty then set the user details to empty and stop the retrival of the user details
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtPhoneNumber.Text = "";
                    txtEmail.Text = "";
                    lblUserIdErr.Text = "";
                    isValidUserIdFrmt = false;

                    //set the details error message to empty
                    lblFirstNameErr.Text = "";
                    lblLastNameErr.Text = "";
                    lblPhoneNumberErr.Text = "";
                    lblEmailErr.Text = "";


                }
                else
                {
                    //validate that the user id is a number
                    if (!int.TryParse(txtUserId.Text, out int userId))
                    {
                        lblUserIdErr.Text = "User ID must be a number";
                        isValidUserIdFrmt = false;
                        return;
                    }
                    else
                    {
                        lblUserIdErr.Text = "";
                        isValidUserIdFrmt = true;
                    }

                }


                if (!isValidUserIdFrmt)
                {
                    return;
                }
                else
                {

                    //check if the user id exist in the database
                    var user = context.Users.FirstOrDefault(u => u.UserId == Convert.ToInt32(txtUserId.Text));

                    //if the user id exist then set the user details and mark the user as valid
                    if (user != null)
                    {
                        txtFirstName.Text = user.FirstName;
                        txtLastName.Text = user.LastName;
                        txtPhoneNumber.Text = user.PhoneNumber;
                        txtEmail.Text = user.Email;
                        //set the validation to true
                        isValidUserId = true;
                        isValidFirstName = true;
                        isValidLastName = true;
                        isValidPhoneNumber = true;
                        isValidEmail = true;
                        //set the user as a website user
                        isWebsiteUser = true;
                    }
                    else
                    {
                        //if the user id does not exist then set the user details to empty and mark the user as invalid
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtPhoneNumber.Text = "";
                        txtEmail.Text = "";
                        //set the validation to false
                        isValidUserId = false;
                        isValidFirstName = false;
                        isValidLastName = false;
                        isValidPhoneNumber = false;
                        isValidEmail = false;
                        //set the error message to user id does not exist
                        lblUserIdErr.Text = "User ID does not exist";

                        //set iswebsite user to false
                        isWebsiteUser = false;
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDeposit.Text, out decimal price) || price <= 0)
            {
                lblDepositeErr.Text = "Deposit must be a positive number";
                isValidDeposit = false;
            }
            else
            {
                lblDepositeErr.Text = string.Empty;
                isValidDeposit = true;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

            //Validate that the first name input is only letters and at least 3 characters long
            string pattern = @"^[a-zA-Z]{3,}$";
            if (!Regex.IsMatch(txtLastName.Text, pattern))
            {
                lblLastNameErr.Text = "Invalid Name";
                isValidLastName = false;
            }
            else
            {
                lblLastNameErr.Text = "";
                isValidLastName = true;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            //Validate that the first name input is only letters and at least 3 characters long
            string pattern = @"^[a-zA-Z]{3,}$";
            if (!Regex.IsMatch(txtFirstName.Text, pattern))
            {
                lblFirstNameErr.Text = "Invalid Name";
                isValidFirstName = false;
            }
            else
            {
                lblFirstNameErr.Text = "";
                isValidFirstName = true;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            //Validate that the phone number input is exactly 8 digits long
            string pattern = @"^\d+$";

            if (!Regex.IsMatch(txtPhoneNumber.Text.Trim(), pattern))
            {
                lblPhoneNumberErr.Text = "Invalid Phone Number.";
                isValidPhoneNumber = false;
            }
            else
            {
                lblPhoneNumberErr.Text = "";
                isValidPhoneNumber = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //Validate that the email input is in the correct format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(txtEmail.Text.Trim(), pattern))
            {
                lblEmailErr.Text = "Invalid Email Address";
                isValidEmail = false;
            }
            else
            {
                lblEmailErr.Text = "";
                isValidEmail = true;
            }
        }

        private void btnUploadDocuments_Click(object sender, EventArgs e)
        {
            //show dialog the upload form 
            UploadTransactionDocuments uploadForm = new UploadTransactionDocuments();

            DialogResult result = uploadForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                 agreement = uploadForm.agreement;
                 idVerification = uploadForm.idVerfication;

                if (agreement != null || idVerification != null) { 
                
                    hasDocument = true;
                
                }

            }

        }
    }
}
