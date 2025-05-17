using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentOpsObjects.Model;
using RentOpsObjects.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RentOpsDesktop
{
    public partial class UploadTransactionDocuments : Form
    {
        public Document agreement;
        public Document idVerification;

        private bool isEditMode = false;
        public bool isIDModified = false;
        public bool isAgreementModified = false;

        AuditLogger auditLogger;
        RentOpsDBContext dbContext;
        int currentUserId = Global.user.UserId;


        public UploadTransactionDocuments()
        {
            InitializeComponent();

            dbContext = new RentOpsDBContext();

            //initialize the logger
            auditLogger = new AuditLogger(dbContext);

        }

        //overloaded constructor
        public UploadTransactionDocuments(Document rentalAgreement, Document IDVerification)
        {
            InitializeComponent();

            dbContext = new RentOpsDBContext();

            //initialize the logger
            auditLogger = new AuditLogger(dbContext);

            //flag the form for edit mode
            isEditMode = true;

            //get the passed documents variable from the rentaltransaction being editted and save them to class level
            agreement = rentalAgreement;
            idVerification = IDVerification;

            // Show document filenames if available
            if (idVerification != null)
                lblIDFilename.Text = idVerification.FileName + "\n(Already Uploaded)";

            if (agreement != null)
                lblAgreementFilename.Text = agreement.FileName + "\n(Already Uploaded)";

            // Show download/remove if documents exist
            btnDownloadIDDocument.Visible = idVerification != null;
            btnRemoveIDDecument.Visible = idVerification != null;
            btnDownloadIDDocument.Enabled = idVerification != null;
            btnRemoveIDDecument.Enabled = idVerification != null;

            btnDownloadAgreementDocument.Visible = agreement != null;
            btnRemoveAgreementDocument.Visible = agreement != null;
            btnDownloadAgreementDocument.Enabled = agreement != null;
            btnRemoveAgreementDocument.Enabled = agreement != null;


        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            //return to the addd transaction form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnUploadIDVerificationDocuments_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                openFileDialog.Title = "Select a PDF Document";

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

                    //fetch the file type id for the idverification
                    FileType? fileTypeIdVerification = (FileType)dbContext.FileTypes.Where(ft => ft.FileTypeTitle == "ID Verification");        
                    int fileTypeId = fileTypeIdVerification.FileTypeId ; 

                    idVerification = new Document
                    {
                        UserId = currentUserId,
                        FileName = fileName,
                        UploadDate = DateTime.Now,
                        FileTypeId = fileTypeId,
                        StoragePath = filePath, // Optional
                        FileData = fileData
                    };

                    // change the modification boolean to true
                    isIDModified = true;

                    //change the label to show the file name
                    lblIDFilename.Text = fileName + $@"
Uploaded Successfully";

                    //enable the buttons
                    btnDownloadIDDocument.Visible = true;
                    btnRemoveIDDecument.Visible = true;


                }
            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                //print the exception message 
                MessageBox.Show("An error occurred while uploading the file:\n" + ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnUploadREntalAgreement_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                openFileDialog.Title = "Select a PDF Document";

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

                    //fetch the file type id for the idverification
                    FileType? fileTypeIdVerification = (FileType)dbContext.FileTypes.Where(ft => ft.FileTypeTitle == "Rental Agreement");
                    int fileTypeId = fileTypeIdVerification.FileTypeId;

                    //create a new document for the agreement
                    agreement = new Document
                    {
                        UserId = currentUserId,
                        FileName = fileName,
                        UploadDate = DateTime.Now,
                        FileTypeId = fileTypeId,
                        StoragePath = filePath, // Optional
                        FileData = fileData
                    };

                    //change the modification boolean to true'
                    isAgreementModified = true;

                    //change the label to show the file name
                    lblAgreementFilename.Text = fileName + $@"
Uploaded Successfully";

                    //show the buttons
                    btnDownloadAgreementDocument.Visible = true;
                    btnRemoveAgreementDocument.Visible = true;


                }
            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                //print the exception message 
                MessageBox.Show("An error occurred while uploading the file:\n" + ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDownloadIDDocument_Click(object sender, EventArgs e)
        {
            try 
            {
                if (idVerification == null)
                {
                    MessageBox.Show("No file to download.");
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = idVerification.FileName;
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveDialog.FileName, idVerification.FileData);
                    MessageBox.Show("File downloaded successfully.", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                //print the exception message 
                MessageBox.Show("An error occurred while downloading the file:\n" + ex.Message, "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveIDDecument_Click(object sender, EventArgs e)
        {
            idVerification = null;
            isIDModified = true; 
            lblIDFilename.Text = "(No file selected)";
            btnDownloadIDDocument.Visible = false;
            btnRemoveIDDecument.Visible = false;
        }

        private void btnRemoveAgreementDocument_Click(object sender, EventArgs e)
        {
            agreement = null;
            isAgreementModified = true; 
            lblAgreementFilename.Text = "(No file selected)";
            btnDownloadAgreementDocument.Visible = false;
            btnRemoveAgreementDocument.Visible = false;
        }

        private void btnDownloadAgreementDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (agreement == null)
                {
                    MessageBox.Show("No file to download.");
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = agreement.FileName;
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveDialog.FileName, agreement.FileData);
                    MessageBox.Show("File downloaded successfully.", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                //print the exception message 
                MessageBox.Show("An error occurred while downloading the file:\n" + ex.Message, "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
