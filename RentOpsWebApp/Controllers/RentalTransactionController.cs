using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using RentOpsObjects.Services;

namespace RentOpsWebApp.Controllers
{
    public class RentalTransactionController : Controller
    {

        private RentOpsDBContext _context;

        //declare the logger to track changes
        AuditLogger logger;

        public RentalTransactionController(RentOpsDBContext context)
        {
            //initialize both the context and the logger
            _context = context;
            logger = new AuditLogger(_context);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RentalTransaction(string searchRentalTransactionId, string SearchRentalRequestId, string searchEmployeeId, string SearchEquipment, string SearchTransactionDate, string SearchPayment)
        {

            IEnumerable<RentalTransaction> rentalTransactions = _context.RentalTransactions
                .Include(rt => rt.Equipment)
                .Include(rt => rt.Employee)
                .Include(rt => rt.RentalRequest)
                    .ThenInclude(rr => rr.User)
                .Include(rt => rt.User)
                .Include(rt => rt.Customer)
                .Include(rt => rt.Payment)
                .OrderByDescending(rt => rt.RentalTransactionTimestamp)
                .ToList();

            //filtering system

            //If return record id is used, we filter the list retrieved above
            if (!String.IsNullOrEmpty(searchRentalTransactionId))
            {
                rentalTransactions = rentalTransactions.Where(p =>
                    p.RentalTransactionId == Convert.ToInt32(searchRentalTransactionId)
                );
            }

            if (!String.IsNullOrEmpty(SearchRentalRequestId))
            {
                rentalTransactions = rentalTransactions.Where(p =>
                    p.RentalRequestId == Convert.ToInt32(SearchRentalRequestId)
                );
            }

            if (!String.IsNullOrEmpty(searchEmployeeId))
            {
                rentalTransactions = rentalTransactions.Where(p =>
                    p.EmployeeId == Convert.ToInt32(searchEmployeeId)
                );
            }

            if (!String.IsNullOrEmpty(SearchEquipment))
            {
                rentalTransactions = rentalTransactions.Where(p =>
                    p.EquipmentId == Convert.ToInt32(SearchEquipment)
                );
            }


            if (!String.IsNullOrEmpty(SearchPayment))
            {

                //if searchpayment is = paid then we filter the list to show only the paid transactions
                if (SearchPayment == "Paid")
                {
                    rentalTransactions = rentalTransactions.Where(p =>
                        p.Payment != null
                    );
                }
                else if (SearchPayment == "Not Paid") {

                    rentalTransactions = rentalTransactions.Where(p =>
                        p.Payment == null
                    );

                }
            }


            if (!string.IsNullOrEmpty(SearchTransactionDate))
            {
                DateTime searchTimestamp;
                if (DateTime.TryParse(SearchTransactionDate, out searchTimestamp))
                {
                    rentalTransactions = rentalTransactions.Where(p => p.RentalTransactionTimestamp.Date == searchTimestamp.Date);
                }
            }




            var rentalTransactionViewModel = new RentalTransactionViewModel
            {
                rentalTransactions = rentalTransactions,
                equipmentTitle = _context.Equipment.ToList(),
            };

            return View(rentalTransactionViewModel);
        }



        //GET method for the edit action
        public IActionResult Edit(int? id) {

            //check if the id is null then return a (not found) page 
            if (id == null)
            {
                return NotFound();
            }

            //fetch the transaction to edit and include its details
            var rentaltransaction = _context.RentalTransactions
                .Include(rt => rt.RentalRequest)
                .ThenInclude(rr => rr.User)
                .Include(rt => rt.RentalRequest)
                .ThenInclude(rr => rr.Equipment)
                .Include(rt => rt.Equipment)
                .Include(rt => rt.Customer)
                .Include(rt => rt.User)
                .Include(rt => rt.Documents)
                .Include(rt => rt.Payment)
                .ThenInclude(p => p.PaymentMethod)
                .Include(rt => rt.Payment)
                .ThenInclude(p => p.PaymentStatus).Where(rt => rt.RentalTransactionId == id).FirstOrDefault();

            if (rentaltransaction == null)
            {
                return NotFound();
            }

            var rentalTransactionViewModel = new RentalTransactionViewModel
            {
                //pass the new rental transaction to the view model
                rentalTransaction = rentaltransaction,
                //pass the list of payment methods to the view model
                PaymentMethod = _context.PaymentMethods.ToList(),
                //pass the list of payment status to the view model
                PaymentStatus = _context.PaymentStatuses.ToList(),



            };

            return View(rentalTransactionViewModel);
        }



        //the function for downloading a file
        public async Task<IActionResult> Download(int id)
        {
            var document = await _context.Documents.FindAsync(id);


            if (document == null)
            {
                return NotFound();
            }

            // Return the file as a downloadable response
            return File(
                fileContents: document.FileData,
                contentType: "application/pdf", // Assuming all stored files are PDFs
                fileDownloadName: document.FileName
            );

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(RentalTransactionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Return the view with validation errors
                return View("Edit", model);
            }

            // Fetch the transaction from the database, including the join table
            var transaction = await _context.RentalTransactions
                .Include(t => t.Payment)
                .Include(t => t.Documents)
                .FirstOrDefaultAsync(t => t.RentalTransactionId == model.rentalTransaction.RentalTransactionId);

            if (transaction == null)
            {
                return NotFound();
            }

            // Update transaction details
            transaction.Deposit = model.rentalTransaction.Deposit;
            transaction.PickupDate = model.rentalTransaction.PickupDate;
            transaction.ReturnDate = model.rentalTransaction.ReturnDate;
            transaction.RentalFee = model.rentalTransaction.RentalFee;

            // Handle payment details
            if (model.rentalTransaction.Payment != null)
            {
                if (transaction.Payment == null)
                {
                    // Create new payment record
                    var payment = new Payment
                    {
                        PaymentMethodId = model.rentalTransaction.Payment.PaymentMethodId,
                        PaymentStatusId = model.rentalTransaction.Payment.PaymentStatusId,
                        // Set other payment properties as needed
                    };
                    _context.Payments.Add(payment);
                    await _context.SaveChangesAsync(); // Save to get PaymentId

                    transaction.PaymentId = payment.PaymentId;
                    transaction.Payment = payment;

                    //after the payment is done and added to the transaction send a notification to the user that made the request
                    var notifyUserId = transaction.RentalRequest.UserId;

                    var approvedMessageContent = _context.MessageContents.Include(mc => mc.MessageType)
                        .FirstOrDefault(m => m.MessageType.MessageTypeTitle == "Successful Payment");

                    if (approvedMessageContent == null)
                    {
                        //create a new message content
                        approvedMessageContent  = new MessageContent
                        {
                            MessageTypeId = _context.MessageTypes.Where(mt => mt.MessageTypeTitle == "Successful Payment").Select(mt => mt.MessageTypeId).FirstOrDefault(),
                            MessageContentText = "Your payment has been successfully processed.",
                        };
                    }
                        
                    if (approvedMessageContent != null)
                    {
                        var notification = new Notification
                        {
                            UserId = notifyUserId,
                            MessageContentId = approvedMessageContent.MessageContentId,
                            NotificationStatusId = 1,
                            NotificationTimestamp = DateTime.Now
                        };

                        _context.Notifications.Add(notification);
                        _context.SaveChanges();
                    }



                }
                else
                {
                    // Update existing payment
                    transaction.Payment.PaymentMethodId = model.rentalTransaction.Payment.PaymentMethodId;
                    transaction.Payment.PaymentStatusId = model.rentalTransaction.Payment.PaymentStatusId;
                }
            }

            // Handle document updates (m:n resolving table)
            // Rental Agreement
            if (model.agreementIsModified)
            {
                // Remove old rental agreement if exists
                var oldAgreement = transaction.Documents.FirstOrDefault(d => d.FileTypeId == 4);
                if (oldAgreement != null)
                {
                    transaction.Documents.Remove(oldAgreement);
                    _context.Documents.Remove(oldAgreement);
                }

                // Add new rental agreement if uploaded
                if (model.UploadedAgreement != null && model.UploadedAgreement.Length > 0)
                {
                    using var ms = new MemoryStream();
                    await model.UploadedAgreement.CopyToAsync(ms);
                    var document = new Document
                    {
                        UserId = 1, // Replace with actual user ID
                        FileName = model.UploadedAgreement.FileName,
                        FileTypeId = 4,
                        StoragePath = "",
                        UploadDate = DateTime.UtcNow,
                        FileData = ms.ToArray(),
                    };
                    _context.Documents.Add(document);
                    // Add to resolving table (EF Core will handle m:n)
                    transaction.Documents.Add(document);
                }

            }

            // ID Verification
            if (model.idVerificationIsModified)
            {
                // Remove old ID verification if exists
                var oldIdVerification = transaction.Documents.FirstOrDefault(d => d.FileTypeId == 5);
                if (oldIdVerification != null)
                {
                    transaction.Documents.Remove(oldIdVerification);
                    _context.Documents.Remove(oldIdVerification);
                }

                // Add new ID verification if uploaded
                if (model.UploadedIdVerification != null && model.UploadedIdVerification.Length > 0)
                {
                    using var ms = new MemoryStream();
                    await model.UploadedIdVerification.CopyToAsync(ms);
                    var document = new Document
                    {
                        UserId = 1, // Replace with actual user ID
                        FileName = model.UploadedIdVerification.FileName,
                        StoragePath = "",
                        UploadDate = DateTime.UtcNow,
                        FileTypeId = 5,
                        FileData = ms.ToArray(),
                    };
                    _context.Documents.Add(document);
                    // Add to resolving table (EF Core will handle m:n)
                    transaction.Documents.Add(document);
                }

            }

            _context.RentalTransactions.Update(transaction);
            await _context.SaveChangesAsync();

            return RedirectToAction("RentalTransaction");
        }

    }


    }
