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
        Document uploadedDocument;

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
            if (!validLateReturnFee && !validAdditionalCharge)
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


            //set the document id to null if no document is uploaded
            newReturnRecord.DocumentId = null;


            //change the condition of the rented equipment to match the return condition
            var rentedEquipment = dbContext.Equipment.Where(x => x.EquipmentId == rentalTransaction.EquipmentId).ToList();
            if (rentedEquipment != null)
            {
                rentedEquipment[0].ConditionStatusId = newReturnRecord.ReturnConditionId;
                //update the equipment to set the condition
                dbContext.Equipment.Update(rentedEquipment[0]);

            }

            // If a document was uploaded, save it and link it
            if (uploadedDocument != null)
            {
                dbContext.Documents.Add(uploadedDocument);
                newReturnRecord.DocumentId = uploadedDocument.DocumentId;
            }


            //save the changes to the database
            dbContext.ReturnRecords.Add(newReturnRecord);
            dbContext.SaveChanges(); // Save changes to the database


            //set the dialog result to ok
            this.DialogResult = DialogResult.OK;
            //close the form
            this.Close();


        }

        private void btnUpload_Click(object sender, EventArgs e)
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

                // Example: You will set actual values for UserId and FileTypeId later
                int userId = 1; // Replace with actual logged-in user ID or context
                int fileTypeId = 3; //the id of the damage report files 

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            //back to the return record form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
