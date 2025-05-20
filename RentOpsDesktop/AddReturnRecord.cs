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
using RentOpsObjects.Services;
using Microsoft.EntityFrameworkCore;

namespace RentOpsDesktop
{
    public partial class AddReturnRecord : Form
    {
        int currentUserId;
        RentOpsDBContext dbContext;
        AuditLogger logger;
        internal ReturnRecord newReturnRecord = new ReturnRecord();
        Document uploadedDocument;

        //validation variables 
        bool validLateReturnFee = false;
        bool validAdditionalCharge = false;
        bool validTransctionID = false;

        public AddReturnRecord()
        {
            InitializeComponent();
            dbContext = new RentOpsDBContext();
            logger = new AuditLogger(dbContext); //create a logger object
            currentUserId = Global.user.UserId; //assign the current user id to the global user id
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
            cmbReturnCondition.SelectedIndex = -1;

            
            //save the ids of the rental transactions that has a return record in a list
            List<int> rentalTransactionIds = new List<int>();

            //loop through the return records and add the ids of the transactions to the list
            var returnRecords = dbContext.ReturnRecords.ToList();
            foreach (var returnRecord in returnRecords)
            {
                rentalTransactionIds.Add(returnRecord.RentalTransactionId);
            }

            // Get all rental transactions that are not in the list
            var rentalTransactions = dbContext.RentalTransactions
                .Where(x => !rentalTransactionIds.Contains(x.RentalTransactionId))
                .Select(x => new
                {
                    x.RentalTransactionId,
                    DisplayText = $"{x.RentalTransactionId} | at  {x.RentalTransactionTimestamp}"
                })
                .ToList();

            // Set the data source of the combo box
            cmbAssociatedTransaction.DataSource = rentalTransactions;
            cmbAssociatedTransaction.DisplayMember = "DisplayText";
            cmbAssociatedTransaction.ValueMember = "RentalTransactionId";
            cmbAssociatedTransaction.SelectedIndex = -1; // Select default (none)


        }

        private void txtLateReturnPenalty_TextChanged(object sender, EventArgs e)
        {
            //check if the entered value is empty or null
            if (string.IsNullOrWhiteSpace(txtLateReturnPenalty.Text))
            {
                lblLateReturnPenaltyErr.Text = "";
                validLateReturnFee = true; // if the field is empty, it means no late return fee is applied
            }
            // in case the user entered a value check if it is a valid number greater than 0
            else if (decimal.TryParse(txtLateReturnPenalty.Text, out decimal price))
            {
                if (price < 0)
                {
                    lblLateReturnPenaltyErr.Text = "Late return fee must\n be a positive number";
                    validLateReturnFee = false;
                }
                else
                {
                    lblLateReturnPenaltyErr.Text = "";
                    validLateReturnFee = true;
                }
            }
            else
            {
                lblLateReturnPenaltyErr.Text = "Late return fee must\n be a valid number";
                validLateReturnFee = false;
            }
        }

        private void txtAdditionalCharge_TextChanged(object sender, EventArgs e)
        {
            //check if the entered value is empty or null
            if (string.IsNullOrWhiteSpace(txtAdditionalCharge.Text))
            {
                lblAdditionalChargesErr.Text = "";
                validAdditionalCharge = true; // if the field is empty, it means no additional charge is applied
            }
            // in case the user entered a value check if it is a valid number greater than 0
            else if (decimal.TryParse(txtAdditionalCharge.Text, out decimal price))
            {
                if (price < 0)
                {
                    lblAdditionalChargesErr.Text = "Additional charge must\n be a positive number";
                    validAdditionalCharge = false;
                }
                else
                {
                    lblAdditionalChargesErr.Text = "";
                    validAdditionalCharge = true;
                }
            }
            else
            {
                lblAdditionalChargesErr.Text = "Additional charge must\n be a valid number";
                validAdditionalCharge = false;
            }

        }

        private void cmbReturnCondition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //check if the associated transaction id is empty
                if (string.IsNullOrWhiteSpace(cmbAssociatedTransaction.Text))
                {
                    MessageBox.Show("Please select the associated rental transaction id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //check if the associated rental transaction exist
                var rentalTransaction = dbContext.RentalTransactions.Find(Convert.ToInt32(cmbAssociatedTransaction.SelectedValue));
                if (rentalTransaction == null)
                {
                    MessageBox.Show("Selected rental transaction could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                //check if a return condition is selected
                if (cmbReturnCondition.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a return condition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //check if the inputs are valid
                if (!validLateReturnFee || !validAdditionalCharge)
                {
                    MessageBox.Show("Please ensure that the 'Late Return Penalty'  and the 'Additional Charge' fields are filled correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                //create a new return record
                newReturnRecord.LateReturnFee = string.IsNullOrWhiteSpace(txtLateReturnPenalty.Text)
    ? 0
    : Convert.ToDouble(txtLateReturnPenalty.Text);
                newReturnRecord.AdditionalCharge = string.IsNullOrWhiteSpace(txtAdditionalCharge.Text)
    ? 0
    : Convert.ToDouble(txtAdditionalCharge.Text);
                newReturnRecord.ReturnConditionId = (int)cmbReturnCondition.SelectedValue;
                newReturnRecord.RentalTransactionId = Convert.ToInt32(cmbAssociatedTransaction.SelectedValue);
                //convert datetime to date only
                DateOnly dateOnly = DateOnly.FromDateTime(dtpReturnDate.Value);
                newReturnRecord.ActualReturnDate = dateOnly;


                //set the document id to null if no document is uploaded
                newReturnRecord.DocumentId = null;


                //change the condition of the rented equipment to match the return condition, also change the availability status of the equipment according the return condition
                // Try to get the equipment associated with the transaction
                var equipment = dbContext.Equipment.FirstOrDefault(x => x.EquipmentId == rentalTransaction.EquipmentId);

                // If equipment is found, update its condition and availability
                if (equipment != null)
                {
                    equipment.ConditionStatusId = newReturnRecord.ReturnConditionId;

                    // Check condition status and set availability
                    if (equipment.ConditionStatusId == 4 || equipment.ConditionStatusId == 5)
                    {
                        equipment.AvailabilityStatusId = 3; // Under maintenance
                    }
                    else
                    {
                        equipment.AvailabilityStatusId = 1; // Available
                    }

                    dbContext.Equipment.Update(equipment);
                }
                else
                {
                    logger.LogException(currentUserId, "Associated equipment not found for rentalTransactionId: " + rentalTransaction.RentalTransactionId, "Handled null equipment", Global.sourceId);
                }


                // If a document was uploaded, save it and link it
                if (uploadedDocument != null)
                {
                    dbContext.Documents.Add(uploadedDocument);
                    dbContext.SaveChanges(); // Save the document to get the DocumentId
                    newReturnRecord.DocumentId = uploadedDocument.DocumentId;
                }

        

                //save the changes to the database
                dbContext.ReturnRecords.Add(newReturnRecord);

                //log the changes
                logger.TrackChanges(currentUserId, Global.sourceId);


                dbContext.SaveChanges(); // Save changes to the database

                //call the function to notify the user 
                int? useridnotify = rentalTransaction.UserId ?? rentalTransaction.RentalRequest.UserId;
                if (useridnotify != null)
                {
                    notifyUser((int)useridnotify);
                }


                //set the dialog result to ok
                this.DialogResult = DialogResult.OK;
                //close the form
                this.Close();
            }
            catch (Exception ex)
            {
                // log the error
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);

                // show the error message box to the user
                MessageBox.Show($"An error occurred while saving the return record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void notifyUser(int userId)
        {
            try { 
            //after new return record is added send a notification to the user that made the request
            var notifyUserId = userId;
            var returnMessageContent = dbContext.MessageContents.Include(mc => mc.MessageType)
                 .FirstOrDefault(m => m.MessageType.MessageTypeTitle == "Returned Request Feedback");

            if (returnMessageContent == null)
            {
                //create a new message content
                returnMessageContent = new MessageContent
                {
                    MessageTypeId = dbContext.MessageTypes.Where(mt => mt.MessageTypeTitle == "Returned Request Feedback").Select(mt => mt.MessageTypeId).FirstOrDefault(),
                    MessageContentText = "Your rental request has been returned., please provide us with your feedback through My Return Record Page.",
                };
            }

            if (returnMessageContent != null)
            {
                var notification = new Notification
                {
                    UserId = notifyUserId,
                    MessageContentId = returnMessageContent.MessageContentId,
                    NotificationStatusId = 1,
                    NotificationTimestamp = DateTime.Now
                };

                dbContext.Notifications.Add(notification);
                //track the changes
                logger.TrackChanges(currentUserId, 2);
                dbContext.SaveChanges();
            }
            
            }
            catch (Exception ex)
            {
                // log the error
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                // show the error message box to the user
                MessageBox.Show($"An error occurred while notifying the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                //open the file dialog to select a file
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                openFileDialog.Title = "Select a PDF Document";

                // Set the initial directory to the user's documents folder
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);
                    byte[] fileData = File.ReadAllBytes(filePath);

                    // Validate file extension
                    if (Path.GetExtension(filePath).ToLower() != ".pdf")
                    {
                        MessageBox.Show("Please select a valid PDF file.");
                        return;
                    }


                    int userId = currentUserId;
                    int fileTypeId = 3; //the id of the damage report files 


                    //create a new document object
                    uploadedDocument = new Document
                    {
                        UserId = userId,
                        FileName = fileName,
                        UploadDate = DateTime.Now,
                        FileTypeId = fileTypeId,
                        StoragePath = filePath, // Optional
                        FileData = fileData
                    };

                    //change the label to show the file name
                    lblFilename.Text = fileName + $@"
Uploaded Successfully";

                }
            }
            catch (Exception ex)
            {
                // log the error
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);

                // show the error message box to the user
                MessageBox.Show($"An error occurred while uploading the document: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //back to the return record form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblTransctionIDError_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
