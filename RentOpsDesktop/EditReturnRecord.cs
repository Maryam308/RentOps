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
    public partial class EditReturnRecord : Form
    {
        private Document? uploadedDocument;
        private RentOpsDBContext dbContext;
        private AuditLogger logger;
        private int currentUserId;

        internal ReturnRecord returnRecordToEdit;

        //validation variables 
        bool validLateReturnFee = false;
        bool validAdditionalCharge = false;
        bool validConditionStatus = false;


        public EditReturnRecord(ReturnRecord recordToEdit)
        {
            InitializeComponent();

            dbContext = new RentOpsDBContext();
            logger = new AuditLogger(dbContext);
            currentUserId = Global.user.UserId;

            //assign the record to edit to the form 
            returnRecordToEdit = recordToEdit;
            
        }

        private void EditReturnRecord_Load(object sender, EventArgs e)
        {
            try
            {
                //laod conditions into the combo box
                var conditions = dbContext.ConditionStatuses.ToList();
                cmbConditionStatus.DataSource = conditions;
                cmbConditionStatus.DisplayMember = "ConditionStatusTitle";
                cmbConditionStatus.ValueMember = "ConditionStatusId";

                //laod the record to edit into the form
                txtAssociatedTransaction.Text = returnRecordToEdit.RentalTransactionId.ToString();

                DateTime dateTime = returnRecordToEdit.ActualReturnDate.ToDateTime(TimeOnly.MinValue); // sets time to 00:00:00

                dtpReturnDate.Value = dateTime;

                txtLateReturnPenalty.Text = returnRecordToEdit.LateReturnFee.ToString();

                txtAdditionalCharge.Text = returnRecordToEdit.AdditionalCharge.ToString();

                cmbConditionStatus.SelectedValue = returnRecordToEdit.ReturnConditionId;

                //load the damage report if it exists
                LoadDamageReport();
            }
            catch (Exception ex)
            {
                //log the exception
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);

                //show the error message
                MessageBox.Show("An error occurred while loading the form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLateReturnPenalty_TextChanged(object sender, EventArgs e)
        {

            if (!decimal.TryParse(txtLateReturnPenalty.Text, out decimal price) || price < 0)
            {
                lblLateReturnPenaltyErr.Text = "Late Return Penalty must\n be a positive number";
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
            if (!decimal.TryParse(txtAdditionalCharge.Text, out decimal price) || price < 0)
            {
                lblAdditionalChargesErr.Text = "Additional charge must\n be a positive number";
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
            try
            {
                // check if the entered values are valid
                if (validLateReturnFee && validAdditionalCharge)

                {
                    // Update the main record fields
                    returnRecordToEdit.ReturnConditionId = (int)cmbConditionStatus.SelectedValue;
                    returnRecordToEdit.ReturnCondition = null;
                    DateOnly dateOnly = DateOnly.FromDateTime(dtpReturnDate.Value);
                    returnRecordToEdit.ActualReturnDate = dateOnly;
                    returnRecordToEdit.LateReturnFee = Convert.ToDouble(txtLateReturnPenalty.Text);
                    returnRecordToEdit.AdditionalCharge = Convert.ToDouble(txtAdditionalCharge.Text);


                    // If a new damage report was uploaded
                    if (uploadedDocument != null)
                    {
                        // Add the document to the context so EF can track it (if not already tracked)
                        dbContext.Documents.Add(uploadedDocument);

                        // update the th return record with the new document
                        dbContext.Entry(returnRecordToEdit).State = EntityState.Modified;

                        //log the changes
                        //logger.TrackChanges(currentUserId, Global.sourceId ?? 2);

                        // Save all changes to the database
                        dbContext.SaveChanges();

                        // Assign the new document to the return record
                        returnRecordToEdit.Document = uploadedDocument;
                    }
                    else
                    {
                        // If document was removed, clear the link
                        returnRecordToEdit.Document = null;
                    }

                    // Update the return record in the context
                    dbContext.Entry(returnRecordToEdit).State = EntityState.Modified;

                    //log the changes
                    logger.TrackChanges(currentUserId, Global.sourceId);

                    // Save all changes to the database
                    dbContext.SaveChanges();

                    //show success message
                    MessageBox.Show("The return record has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Please fill all the fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                logger.LogException(currentUserId, ex.Message, ex.StackTrace, Global.sourceId);
                MessageBox.Show("An error occurred while updating the return record. Please try again.\n\nDetails: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void LoadDamageReport()
        {
            try
            {
                // fetch the existing damage report from the database
                var existingDamageReport = dbContext.Documents
                    .Where(d => d.FileTypeId == 3 && d.DocumentId == returnRecordToEdit.DocumentId)
                    .FirstOrDefault();

                // If a damage report is found
                if (existingDamageReport != null)
                {
                    // Set the uploaded document to the existing damage report
                    uploadedDocument = existingDamageReport;

                    // Display the file name in the label
                    lblDamageReport.Text = uploadedDocument.FileName + "\n(Already Uploaded)";

                    // Show download and remove buttons if the document exists
                    btnDownload.Visible = true;
                    btnRemove.Visible = true;
                }
                else
                {
                    // If no document is found, show "None" and hide the edit buttons, only show the upload button
                    lblDamageReport.Text = "None";
                    btnDownload.Visible = false;
                    btnRemove.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Log the error 
                logger.LogException(currentUserId, ex.Message, ex.StackTrace, Global.sourceId);

                // show the error message
                MessageBox.Show("An error occurred while loading the damage report.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbConditionStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void lblReturnCondition_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                // Open a file dialog to select a PDF document
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                openFileDialog.Title = "Select a PDF Document";

                // Set the initial directory to the user's documents folder
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);
                    byte[] fileData = File.ReadAllBytes(filePath);

                    if (Path.GetExtension(filePath).ToLower() != ".pdf")
                    {
                        MessageBox.Show("Please select a valid PDF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // create a new document object
                    uploadedDocument = new Document
                    {
                        UserId = currentUserId,
                        FileName = fileName,
                        UploadDate = DateTime.Now,
                        FileTypeId = 3, // Damage Report
                        StoragePath = filePath,
                        FileData = fileData
                    };


                    // show success message
                    lblDamageReport.Text = fileName + "\nUploaded Successfully";
                    btnDownload.Visible = true;
                    btnRemove.Visible = true;
                }
            }
            catch (Exception ex)
            {
                // log the error
                logger.LogException(currentUserId, ex.Message, ex.StackTrace, Global.sourceId);

                // show the error message
                MessageBox.Show("An error occurred while uploading the document:\n" + ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (uploadedDocument == null)
                {
                    MessageBox.Show("No file to download.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = uploadedDocument.FileName;
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveDialog.FileName, uploadedDocument.FileData);
                    MessageBox.Show("File downloaded successfully.", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // log the error
                logger.LogException(currentUserId, ex.Message, ex.StackTrace, Global.sourceId );
                // show the error message
                MessageBox.Show("An error occurred while downloading the document:\n" + ex.Message, "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                uploadedDocument = null;
                returnRecordToEdit.DocumentId = null;
                lblDamageReport.Text = "(No file selected)";
                btnDownload.Visible = false;
                btnRemove.Visible = false;
            }
            catch (Exception ex)
            {
                // log the error
                logger.LogException(currentUserId, ex.Message, ex.StackTrace, Global.sourceId );

                // show the error message
                MessageBox.Show("An error occurred while removing the document:\n" + ex.Message, "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //create a new instance of the ReturnRecords form
            ReturnRecords returnRecordsForm = new ReturnRecords();
            returnRecordsForm.StartPosition = FormStartPosition.CenterScreen; // Center the form
            returnRecordsForm.Show();
           
            //close the current form
            this.Close();
        }
    }



}
