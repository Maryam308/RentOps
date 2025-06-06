﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using RentOpsObjects.Services;

namespace RentOpsWebApp.Controllers
{
    [Authorize]
    public class NotificationController : Controller
    {
        private readonly RentOpsDBContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private  AuditLogger _auditLogger;

        public NotificationController(RentOpsDBContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _auditLogger = new AuditLogger(_context);
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: Notification
        public async Task<IActionResult> Notification(string statusFilter = "All", string sortOrder = "Descending")
        {
            var userId = _context.Users
                .FirstOrDefault(u => u.Email == User.Identity.Name)?.UserId;

            

            //only allow the user to see their own notifications
            if (userId == null)
                return NotFound();
            
            // Get notifications based on the status filter
            var notificationsQuery = _context.Notifications
                .Include(n => n.MessageContent)
                .Include(n => n.NotificationStatus)
                .Where(n => n.UserId == userId);


            // Filter by status (All, Unread, Read)
            if (statusFilter != "All")
            {
                notificationsQuery = notificationsQuery.Where(n => n.NotificationStatus.NotificationStatusTitle == statusFilter);
            }

            // Sort by NotificationTimestamp
            notificationsQuery = sortOrder == "Descending"
                ? notificationsQuery.OrderByDescending(n => n.NotificationTimestamp)
                : notificationsQuery.OrderBy(n => n.NotificationTimestamp);

            var notifications = await notificationsQuery.ToListAsync();

            // Return the view with the notifications
            ViewData["CurrentStatusFilter"] = statusFilter;
            ViewData["CurrentSortOrder"] = sortOrder;

            return View(notifications);
        }




        public async Task<IActionResult> Details(int id)
        {
            var userId = _context.Users
                .FirstOrDefault(u => u.Email == User.Identity.Name)?.UserId;

            try {

                var notification = await _context.Notifications
                .Include(n => n.MessageContent)
                .Include(n => n.NotificationStatus)
                .FirstOrDefaultAsync(n => n.NotificationId == id);

                if (notification == null)
                    return NotFound();

                if (notification.UserId != userId)
                    return Forbid();

                // Mark as read
                if (notification.NotificationStatus.NotificationStatusTitle == "Unread")
                {
                    var readStatus = await _context.NotificationStatuses
                        .FirstOrDefaultAsync(s => s.NotificationStatusTitle == "Read");

                    if (readStatus != null)
                    {
                        notification.NotificationStatusId = readStatus.NotificationStatusId;
                        await _context.SaveChangesAsync();
                    }
                }

                // Build base view model
                var viewModel = new NotificationDetailsViewModel
                {
                    MessageContentText = notification.MessageContent?.MessageContentText,
                    NotificationStatusTitle = notification.NotificationStatus?.NotificationStatusTitle,
                    NotificationTimestamp = notification.NotificationTimestamp
                };


                var rentalRequest = await _context.RentalRequests
                    .Include(r => r.RentalRequestStatus)
                    .Include(r => r.Equipment)
                    .Include(r => r.User)
                    .FirstOrDefaultAsync(r =>
                        r.UserId == notification.UserId &&
                        r.RentalRequestTimestamp.Date == notification.NotificationTimestamp.Date);

                if (rentalRequest != null)
                {
                    viewModel.RentalRequestId = rentalRequest.RentalRequestId;
                    viewModel.RentalRequestStatusTitle = rentalRequest.RentalRequestStatus?.RentalRequestStatusTitle;
                    viewModel.EquipmentTitle = rentalRequest.Equipment?.EquipmentName ?? "Equipment Not Found";
                    viewModel.UserFullName = rentalRequest.User?.FirstName;
                    viewModel.RentalStartDate = rentalRequest.RentalStartDate.ToDateTime(TimeOnly.MinValue);
                    viewModel.RentalReturnDate = rentalRequest.RentalReturnDate.ToDateTime(TimeOnly.MinValue);
                }

                return View(viewModel);


            }
            catch(Exception ex) {

                _auditLogger.LogException(userId, ex.Message, ex.StackTrace, 1);
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }

            
        }

    }
}
