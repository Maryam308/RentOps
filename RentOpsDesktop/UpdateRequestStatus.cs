using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsObjects.Services;

namespace RentOpsDesktop
{
    public partial class UpdateRequestStatus : Form
    {
        internal RentalRequest requestToUpdate;
        int rentalRequestId;
        
        RentOpsDBContext context;
        AuditLogger auditLogger;
        int currentUserId;

        public UpdateRequestStatus(int rentalRequestId)
        {
            InitializeComponent();
            this.rentalRequestId = rentalRequestId;
            context = new RentOpsDBContext();
            currentUserId = Global.user.UserId; ;

            auditLogger = new AuditLogger(context);

        }

        private void LoadRequestData()
        {
            try {

                if (requestToUpdate != null)
                {
                    // Find the enriched item
                    var enrichedRequest = context.RentalRequests
                    .Include(r => r.RentalRequestStatus)
                    .Include(r => r.Equipment)
                    .Include(r => r.User)
                    .FirstOrDefault(r => r.RentalRequestId == rentalRequestId);


                    if (enrichedRequest != null)
                    {
                        StringBuilder details = new StringBuilder();
                        details.AppendLine($"Request ID: {enrichedRequest.RentalRequestId}");
                        details.AppendLine($"Start Date: {enrichedRequest.RentalStartDate:yyyy-MM-dd}");
                        details.AppendLine($"Return Date: {enrichedRequest.RentalReturnDate:yyyy-MM-dd}");
                        details.AppendLine($"Total Cost: {enrichedRequest.RentalTotalCost:C}");
                        details.AppendLine($"Request Status: {enrichedRequest.RentalRequestStatus.RentalRequestStatusTitle}");
                        details.AppendLine($"Equipment Name: {enrichedRequest.Equipment.EquipmentName}");
                        details.AppendLine($"Customer Name: {enrichedRequest.User.FirstName} {enrichedRequest.User.LastName}");

                        lblRequestDetails.Text = details.ToString();
                    }
                    else
                    {
                        lblRequestDetails.Text = "Request details not found.";
                    }
                }
                else
                {
                    lblRequestDetails.Text = "No request selected.";
                }

            } catch(Exception ex) {

                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                //show message indicating the error
                MessageBox.Show("An Error has occured: " + ex.Message);

            }

        }


        private void UpdateRequestStatus_Load(object sender, EventArgs e)
        {
            try
            {
                // Fetch the rental request to update
                requestToUpdate = context.RentalRequests
                    .FirstOrDefault(r => r.RentalRequestId == rentalRequestId);
                LoadRequestData();
                if (requestToUpdate != null)
                {

                    // Load only Approve (2) and Reject (3) statuses into the list box
                    var statuses = context.RentalRequestStatuses
                        .Where(rs => rs.RentalRequestStatusId == 2 || rs.RentalRequestStatusId == 3)
                        .Select(rs => new { rs.RentalRequestStatusId, rs.RentalRequestStatusTitle })
                        .ToList();

                    lstStatus.DataSource = statuses;
                    lstStatus.DisplayMember = "RentalRequestStatusTitle";
                    lstStatus.ValueMember = "RentalRequestStatusId";

                    // Pre-select the current status of the rental request (if it's 2 or 3)
                    if (requestToUpdate.RentalRequestStatusId == 2 || requestToUpdate.RentalRequestStatusId == 3)
                    {
                        lstStatus.SelectedValue = requestToUpdate.RentalRequestStatusId;
                    }
                    else
                    {
                        lstStatus.ClearSelected(); // Otherwise don't preselect
                    }
                }
            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);

                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the rental request status
                requestToUpdate.RentalRequestStatusId = Convert.ToInt32(lstStatus.SelectedValue);

                //log the changes using the audit logger
                auditLogger.TrackChanges(currentUserId, Global.sourceId);

                // Save changes to the database
                context.SaveChanges(); // Ensure you save changes to persist the update

                MessageBox.Show("The rental request status has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                //log the exception using the auditlogger
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId);
                MessageBox.Show("Error updating rental request status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
