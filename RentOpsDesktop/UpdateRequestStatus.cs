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


                // Notify the user based on the selected status
                if (requestToUpdate.RentalRequestStatusId == 2) // Approved
                {
                    notifyApprove(requestToUpdate.UserId);
                }
                else if (requestToUpdate.RentalRequestStatusId == 3) // Rejected
                {
                    notifyReject(requestToUpdate.UserId);
                }

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


        //function to notify the user when rejecting a request
        private void notifyReject(int userid)
        {
            //after rejecting the rental request send a notification to the user that made the request
            var notifyUserId = userid;
            var rejectedRentalRequestMessageContent = context.MessageContents.Include(mc => mc.MessageType)
                .FirstOrDefault(m => m.MessageType.MessageTypeTitle == "Rental Request Rejected");

            if (rejectedRentalRequestMessageContent == null)
            {
                //create a new message content
                rejectedRentalRequestMessageContent = new MessageContent
                {
                    MessageTypeId = context.MessageTypes.Where(mt => mt.MessageTypeTitle == "Rental Request Approved").Select(mt => mt.MessageTypeId).FirstOrDefault(),
                    MessageContentText = "Your rental request has been rejected.",
                };
            }

            if (rejectedRentalRequestMessageContent != null)
            {
                var notification = new Notification
                {
                    UserId = notifyUserId,
                    MessageContentId = rejectedRentalRequestMessageContent.MessageContentId,
                    NotificationStatusId = 1,
                    NotificationTimestamp = DateTime.Now
                };

                context.Notifications.Add(notification);
                //track the changes
                auditLogger.TrackChanges(currentUserId, Global.sourceId);
                context.SaveChanges();
            }
        }

        //function to notify the user when approving a request
        private void notifyApprove(int userId)
        {
            //after approving the rental request send a notification to the user that made the request
            var notifyUserId = userId;
            var approvedRentalRequestMessageContent = context.MessageContents.Include(mc => mc.MessageType)
                 .FirstOrDefault(m => m.MessageType.MessageTypeTitle == "Rental Request Approved");

            if (approvedRentalRequestMessageContent == null)
            {
                //create a new message content
                approvedRentalRequestMessageContent = new MessageContent
                {
                    MessageTypeId = context.MessageTypes.Where(mt => mt.MessageTypeTitle == "Rental Request Approved").Select(mt => mt.MessageTypeId).FirstOrDefault(),
                    MessageContentText = "Your rental request has been approved.",
                };
            }

            if (approvedRentalRequestMessageContent != null)
            {
                var notification = new Notification
                {
                    UserId = notifyUserId,
                    MessageContentId = approvedRentalRequestMessageContent.MessageContentId,
                    NotificationStatusId = 1,
                    NotificationTimestamp = DateTime.Now
                };

                context.Notifications.Add(notification);
                //track the changes
                auditLogger.TrackChanges(currentUserId, Global.sourceId);
                context.SaveChanges();
            }
        }


    }
}
