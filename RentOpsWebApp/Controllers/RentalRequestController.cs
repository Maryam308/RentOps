﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using RentOpsObjects.Services;

namespace RentOpsWebApp.Controllers
{
    [Authorize(Roles = "Administrator,Rental Manager")]
    public class RentalRequestController : Controller
    {
        private RentOpsDBContext _context;
        AuditLogger _auditLogger;  

        public RentalRequestController(RentOpsDBContext context)
        {
            _context = context;
            _auditLogger = new AuditLogger(context);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RentalRequest(string SearchRentalRequestId, string SearchRentalRequestStatusId, string searchequipmentId, int page = 1)
        {
            try
            {
                int pageSize = 25;

                //get all rental requests from the database and include their related entities
                IEnumerable<RentalRequest> rentalRequestsList = _context.RentalRequests
                    .Include(r => r.RentalRequestStatus)
                    .Include(r => r.Equipment)
                    .Include(r => r.User)
                    .OrderByDescending(r => r.RentalStartDate)
                    .ToList();

                // Filtering system

                //if the rental request id filter is used, we filter the list retrieved above
                if (!String.IsNullOrEmpty(SearchRentalRequestId))
                {
                    rentalRequestsList = rentalRequestsList.Where(p =>
                        p.RentalRequestId == Convert.ToInt32(SearchRentalRequestId)
                    );
                }

                //if the equipment id filter is used, we filter the list retrieved above
                if (!String.IsNullOrEmpty(searchequipmentId))
                {
                    rentalRequestsList = rentalRequestsList.Where(p =>
                        p.EquipmentId == Convert.ToInt32(searchequipmentId)
                    );
                }

                //if the rental request status id filter is used, we filter the list retrieved above
                if (!String.IsNullOrEmpty(SearchRentalRequestStatusId))
                {
                    rentalRequestsList = rentalRequestsList.Where(p =>
                        p.RentalRequestStatusId == Convert.ToInt32(SearchRentalRequestStatusId)
                    );
                }

                //calculate total pages and apply pagination on the filtered result
                int totalCount = rentalRequestsList.Count();
                var pagedRequests = rentalRequestsList
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                //create viewmodel and assign the lists
                var rentalRequestViewModel = new RentalRequestViewModel
                {
                    rentalRequests = pagedRequests,
                    rentalRequestStatuses = _context.RentalRequestStatuses.ToList(),
                    equipmentTitle = _context.Equipment.ToList(),
                    CurrentPage = page,
                    TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize)
                };

                return View(rentalRequestViewModel);
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }
        }


        public IActionResult Review(int id)
        {

            try { 
                var rentalRequest = _context.RentalRequests
                    .Include(r => r.RentalRequestStatus)
                    .Include(r => r.Equipment)
                    .Include(r => r.User)
                    .FirstOrDefault(r => r.RentalRequestId == id);

                if (rentalRequest == null)
                {
                    return NotFound();
                }

                var rentalRequestViewModel = new RentalRequestViewModel
                {
                    RentalRequest = rentalRequest,
                    rentalRequestStatuses = _context.RentalRequestStatuses.ToList(),
                };

                return View(rentalRequestViewModel);
            
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }

            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Review(RentalRequestViewModel model)
        {
            // Fetch the current user id
            var userEmail = User?.Identity?.Name;
            var currentUserId = _context.Users
                .FirstOrDefault(u => u.Email == userEmail)?.UserId;

            int userId = 1;
            if (currentUserId != null)
            {
                userId = (int)currentUserId;
            }


            try
            {
                if (model.RentalRequest.RentalRequestId == 0)
                {
                    TempData["Error"] = "Invalid Rental Request ID.";
                    return RedirectToAction("RentalRequest");
                }

                RentalRequest rentalRequest = _context.RentalRequests.FirstOrDefault(r => r.RentalRequestId == model.RentalRequest.RentalRequestId);

                if (!ModelState.IsValid)
                {
                    TempData["Error"] = "Something went wrong while creating the rental request.";
                    return RedirectToAction("Review", new { id = model.RentalRequest.RentalRequestId });
                }

                if (rentalRequest == null)
                {
                    TempData["Error"] = "Rental request not found.";
                    return RedirectToAction("Review", new { id = model.RentalRequest.EquipmentId });
                }

                // Use system local time
                DateTime currentTime = DateTime.Now;

                // If the status hasn't changed, skip notification
                if (model.RentalRequest.RentalRequestStatusId == rentalRequest.RentalRequestStatusId)
                {
                    TempData["NoChange"] = "No changes were made to the rental request status.";
                    return RedirectToAction("RentalRequest");
                }

                

                // Handle Rejected Requests
                if (model.RentalRequest.RentalRequestStatusId == 3)
                {
                    rentalRequest.RentalRequestStatusId = 3;
                    _context.Entry(rentalRequest).Property(r => r.RentalRequestStatusId).IsModified = true;
                    _context.SaveChanges();

                    //after rejecting the rental request send a notification to the user that made the request
                    var notifyUserId = rentalRequest.UserId;
                    var rejectedRentalRequestMessageContent = _context.MessageContents.Include(mc => mc.MessageType)
                        .FirstOrDefault(m => m.MessageType.MessageTypeTitle == "Rental Request Rejected");

                    if (rejectedRentalRequestMessageContent == null)
                    {
                        //create a new message content
                        rejectedRentalRequestMessageContent = new MessageContent
                        {
                            MessageTypeId = _context.MessageTypes.Where(mt => mt.MessageTypeTitle == "Rental Request Approved").Select(mt => mt.MessageTypeId).FirstOrDefault(),
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

                        _context.Notifications.Add(notification);
                        //log before saving changes
                        _auditLogger.TrackChanges(userId, 1);
                        _context.SaveChanges();
                    }

                    TempData["Rejected"] = "Rental request has been rejected.";
                    return RedirectToAction("RentalRequest");
                }

                // Handle Approved Requests
                if (model.RentalRequest.RentalRequestStatusId == 2)
                {
                    rentalRequest.RentalRequestStatusId = 2;
                    _context.Entry(rentalRequest).Property(r => r.RentalRequestStatusId).IsModified = true;
                    _context.SaveChanges();


                    //after approving the rental request send a notification to the user that made the request
                    var notifyUserId = rentalRequest.UserId;
                    var approvedRentalRequestMessageContent = _context.MessageContents.Include(mc => mc.MessageType)
                         .FirstOrDefault(m => m.MessageType.MessageTypeTitle == "Rental Request Approved");

                    if (approvedRentalRequestMessageContent == null)
                    {
                        //create a new message content
                        approvedRentalRequestMessageContent = new MessageContent
                        {
                            MessageTypeId = _context.MessageTypes.Where(mt => mt.MessageTypeTitle == "Rental Request Approved").Select(mt => mt.MessageTypeId).FirstOrDefault(),
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

                        _context.Notifications.Add(notification);
                        //log before saving changes
                        _auditLogger.TrackChanges(userId, 1);

                        _context.SaveChanges();
                    }

                    var transaction = new RentalTransaction
                    {
                        RentalTransactionTimestamp = currentTime,
                        RentalRequestId = rentalRequest.RentalRequestId,
                        EquipmentId = rentalRequest.EquipmentId,
                        PickupDate = rentalRequest.RentalStartDate,
                        ReturnDate = rentalRequest.RentalReturnDate,
                        RentalFee = rentalRequest.RentalTotalCost,
                        EmployeeId = _context.Users
                                    .FirstOrDefault(u => u.Email == User.Identity.Name).UserId,
                        PaymentId = null
                    };

                    //change the equipment status to rented
                    var equipment = _context.Equipment.FirstOrDefault(e => e.EquipmentId == rentalRequest.EquipmentId);
                    if (equipment != null)
                    {
                        equipment.AvailabilityStatusId = 2; 
                        _context.Entry(equipment).Property(e => e.AvailabilityStatusId).IsModified = true;
                        _context.SaveChanges();
                    }

                    if (model.UploadedAgreement != null && model.UploadedAgreement.Length > 0)
                    {
                        if (Path.GetExtension(model.UploadedAgreement.FileName).ToLower() != ".pdf")
                        {
                            ModelState.AddModelError("UploadedFile", "Only PDF files are allowed.");
                            return View(model);
                        }

                        using var memoryStream = new MemoryStream();
                        await model.UploadedAgreement.CopyToAsync(memoryStream);

                        var document = new Document
                        {
                            UserId = userId,
                            FileName = model.UploadedAgreement.FileName,
                            UploadDate = currentTime,
                            FileTypeId = 4,
                            StoragePath = "",
                            FileData = memoryStream.ToArray()
                        };

                        _context.Documents.Add(document);
                        await _context.SaveChangesAsync();

                        transaction.Documents = new List<Document> { document };
                    }

                    _context.RentalTransactions.Add(transaction);
                    _context.SaveChanges();

                    TempData["CreateSuccess"] = "Rental Request Approved! A transaction has been created.";
                }

                return RedirectToAction("RentalRequest");
            }
            catch (Exception ex)
            {
                //log the exception
                _auditLogger.LogException(userId,ex.Message, ex.StackTrace.ToString(),1);
                //save the error message to the viewbag

                ViewBag.ErrorMessage = ex.Message;

                // return  error view 

                return View("Error");

            }
        }




        

    }
}
