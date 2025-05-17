using Microsoft.AspNetCore.Mvc;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.IdentityModel.Abstractions;
using RentOpsObjects.Services;

namespace RentOpsWebApp.Controllers
{
    public class EquipmentController : Controller
    {

        RentOpsDBContext _context;

        public EquipmentController(RentOpsDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult AddEquipment()
        {
            var viewmodel = new EquipmentViewModel
            {
                //get all equipment categories from the database
                EquipmentCategories = _context.EquipmentCategories.ToList(),
                //get all equipment availability statuses from the database
                EquipmentAvailability = _context.AvailabilityStatuses.ToList(),
                //get all equipment condition statuses from the database
                EquipmentStatuses = _context.ConditionStatuses.ToList()

            };

            return View(viewmodel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddEquipment(EquipmentViewModel model)
        {
            if (model.NewEquipment.RentalPrice <= 0)
            {
                ModelState.AddModelError("newEquipment.RentalPrice", "Rental Price must be greater than 0.");
            }
            
            model.NewEquipment.UserId = 1; // Set the UserId to 1 for now, as we don't have user authentication yet.
            //check if modelstate is valid

            if (ModelState.IsValid)
            {

                //print to console for debugging
                Console.WriteLine("ModelState is valid will call logger");

                _context.Equipment.Add(model.NewEquipment);

                // Track changes before the new entity is saved
                var logger = new AuditLogger(_context);
                logger.TrackChanges(model.NewEquipment.UserId, 1);


                _context.SaveChanges();

                TempData["CreateSuccess"] = "Equipment added successfully.";

                return RedirectToAction("Equipment");
            }
            else { 
                
                // Validation failed => reload everything again
                    var equipmentList = _context.Equipment
                        .Include(e => e.ConditionStatus)
                        .Include(e => e.EquipmentCategory)
                        .Include(e => e.AvailabilityStatus)
                        .ToList();

                var viewmodel = new EquipmentViewModel
                {
                    Equipment = equipmentList,
                    EquipmentCategories = _context.EquipmentCategories.ToList(),
                    EquipmentAvailability = _context.AvailabilityStatuses.ToList(),
                    EquipmentStatuses = _context.ConditionStatuses.ToList(),
                    NewEquipment = model.NewEquipment // so the input stays
                };

                return View("Equipment", viewmodel);
            
            }

                
        }




        private ViewResult LoadManageCategoriesView(bool showModal = false)
        {
            var categories = _context.EquipmentCategories.ToList();
            ViewBag.ShowModal = showModal;
            return View("ManageCategories", categories);
        }


        [HttpPost]
        public IActionResult AddCategory()
        {
            // Just set flag to show modal
            return LoadManageCategoriesView(showModal: true);

        }

        // POST: Handle form submission from modal (Save button)
        [HttpPost]
        public IActionResult SubmitModal(string categoryTitle)
        {
            // we will use the user input to create a new category in equipment category table
            try {

                //create a new category
                EquipmentCategory newCategory = new EquipmentCategory
                {
                    EquipmentCategoryTitle = categoryTitle
                };

                //save the new category to the database
                _context.EquipmentCategories.Add(newCategory);
                _context.SaveChanges();


            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine(ex.Message);
            }


            // Return with modal hidden
            return LoadManageCategoriesView();
        }

        public IActionResult ManageCategories()
        {
            // Return with modal hidden
            return LoadManageCategoriesView();
        }

        public IActionResult Equipment(string SearchEquipmentName, string SearchEquipmentId, string SearchCategory, string SearchAvailability , string SearchCondition)
        {
            IEnumerable<Equipment> equipmentList = _context.Equipment
                .Include(e => e.ConditionStatus)
                .Include(e => e.EquipmentCategory)
                .Include(e => e.AvailabilityStatus)
                .ToList();

            //If equipment name filter is used, we filter the list retrieved above
            if (!String.IsNullOrEmpty(SearchEquipmentName))
            {
                equipmentList = equipmentList.Where(p =>
                    p.EquipmentName != null && p.EquipmentName.Contains(SearchEquipmentName, StringComparison.OrdinalIgnoreCase)
                );
            }

            //if the equipment id filter is used, we filter the list retrieved above
            if (!String.IsNullOrEmpty(SearchEquipmentId))
            {
                equipmentList = equipmentList.Where(p => p.EquipmentId == Convert.ToInt32(SearchEquipmentId));
            }

            //if the equipment category filter is used, we filter the list retrieved above
            if (!String.IsNullOrEmpty(SearchCategory))
            {
                equipmentList = equipmentList.Where(p => p.EquipmentCategoryId == Convert.ToInt32(SearchCategory));
            }

            //if the equipment availability filter is used, we filter the list retrieved above
            if (!String.IsNullOrEmpty(SearchAvailability))
            {
                equipmentList = equipmentList.Where(p => p.AvailabilityStatusId == Convert.ToInt32(SearchAvailability));
            }

            //if the equipment condition filter is used, we filter the list retrieved above
            if (!String.IsNullOrEmpty(SearchCondition))
            {
                equipmentList = equipmentList.Where(p => p.ConditionStatusId == Convert.ToInt32(SearchCondition));
            }


            var viewmodel = new EquipmentViewModel
            {
                //get all equipment from the database
                Equipment = equipmentList,
                //get all equipment categories from the database
                EquipmentCategories = _context.EquipmentCategories.ToList(),
                //get all equipment availability statuses from the database
                EquipmentAvailability = _context.AvailabilityStatuses.ToList(),
                //get all equipment condition statuses from the database
                EquipmentStatuses = _context.ConditionStatuses.ToList()

            };

            //var user = _context.Users.FirstOrDefault(u => u.Email == User.Identity.Name);
            //var userId = _context.Users.FirstOrDefault(u => u.Email == User.Identity.Name)?.UserId;
            //var userRoleTitle = _context.Roles.FirstOrDefault(r => r.RoleId == user.RoleId)?.RoleTitle; // Assuming RoleId is foreign key in Users table
            //ViewBag.UserId = userId;
            //ViewBag.UserRoleTitle = userRoleTitle; // Store role title in ViewBag

            return View(viewmodel);

        }

        //GET to navigate to the delete page
        public IActionResult Delete(int? id)
        {
            //check if the id is null or 0
            if (id == null || id == 0)
                return NotFound();

            //find the equipment object in the database
            var equipmentObject = _context.Equipment.Find(id);

            //check if the equipment object is null
            if (equipmentObject == null)
                return NotFound();

            var viewmodel = new EquipmentViewModel
            {
                NewEquipment = equipmentObject,
                //get all equipment categories from the database
                EquipmentCategories = _context.EquipmentCategories,
                //get all equipment availability statuses from the database
                EquipmentAvailability = _context.AvailabilityStatuses,
                //get all equipment condition statuses from the database
                EquipmentStatuses = _context.ConditionStatuses
            };
            return View(viewmodel);
        }

        //POST to delete the equipment object from the database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            //print to console for debugging
            Console.WriteLine("DeletePost method called");


            //find the equipment object in the database
            var equipmentObject = _context.Equipment.Find(id);

            //check if the object is null 
            if (equipmentObject == null)
                return NotFound();

            


            //remove the equipment object from the database and save changes
            _context.Equipment.Remove(equipmentObject);


            //call the logger to track changes
            var logger = new AuditLogger(_context);
            logger.TrackChanges(equipmentObject.UserId, 1);


            _context.SaveChanges();

            //add success message to tempdata
            TempData["CreateSuccess"] = "Equipmetn Deleted Successfully";
            return RedirectToAction("Equipment");

        }

        //GET to navigate to the edit page
        public IActionResult Edit(int? id)
        {
            //check if the id is null or 0
            if (id == null || id == 0)
                return NotFound();

            //find the equipment object in the database
            var equipmentObject = _context.Equipment.Find(id);

            //check if the equipment object is null
            if (equipmentObject == null)
                return NotFound();

            var viewmodel = new EquipmentViewModel
            {
                NewEquipment = equipmentObject,
                //get all equipment categories from the database
                EquipmentCategories = _context.EquipmentCategories,
                //get all equipment availability statuses from the database
                EquipmentAvailability = _context.AvailabilityStatuses,
                //get all equipment condition statuses from the database
                EquipmentStatuses = _context.ConditionStatuses
            };
            return View(viewmodel);
        }

        //POST to edit the equipment object in the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EquipmentViewModel toEditEquipment)
        {
            //check if the id is null or 0
            if (toEditEquipment.NewEquipment.RentalPrice <= 0)
            {
                ModelState.AddModelError("newEquipment.RentalPrice", "Rental Price must be greater than 0.");
            }


            //as a placeholder, we will set the user id to 1
            toEditEquipment.NewEquipment.UserId = 1;

            //check if modelstate is valid
            if (ModelState.IsValid)
            {
                //update the equipment object in the database and save changes
                _context.Equipment.Update(toEditEquipment.NewEquipment);
                _context.SaveChanges();

                //add success message to tempdata
                TempData["CreateSuccess"] = "Equipment Updated Successfully.";

                //redirect to the equipment page
                return RedirectToAction("Equipment");
            }
            else
            {

                // Validation failed => reload everything again
                var equipmentList = _context.Equipment
                    .Include(e => e.ConditionStatus)
                    .Include(e => e.EquipmentCategory)
                    .Include(e => e.AvailabilityStatus)
                    .ToList();

                //create a new viewmodel object and pass the equipment list to it
                var viewmodel = new EquipmentViewModel
                {
                    Equipment = equipmentList,
                    EquipmentCategories = _context.EquipmentCategories.ToList(),
                    EquipmentAvailability = _context.AvailabilityStatuses.ToList(),
                    EquipmentStatuses = _context.ConditionStatuses.ToList(),
                    NewEquipment = toEditEquipment.NewEquipment // so the input stays
                };

                return View("Equipment", viewmodel);

            }

        }

        //get to navigate to the request page
        public IActionResult Request(int? id)
        {
            //check if the id is null or 0
            if (id == null || id == 0)
                return NotFound();

            //find the equipment object in the database
            var equipmentObject = _context.Equipment.Find(id);

            //check if the equipment object is null
            if (equipmentObject == null)
                return NotFound();

            var viewmodel = new EquipmentViewModel
            {
                NewEquipment = equipmentObject,
                //get all equipment categories from the database
                EquipmentCategories = _context.EquipmentCategories,
                //get all equipment availability statuses from the database
                EquipmentAvailability = _context.AvailabilityStatuses,
                //get all equipment condition statuses from the database
                EquipmentStatuses = _context.ConditionStatuses,

            };
            return View(viewmodel);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Request(EquipmentViewModel model)
        {
           

            if (model.RentalRequest.RentalStartDate >= model.RentalRequest.RentalReturnDate)
            {
                ModelState.AddModelError("RentalRequest.RentalReturnDate", "Pickup date must be before return date.");
                
            } 
            
            model.RentalRequest.UserId = _context.Users
        .FirstOrDefault(u => u.Email == User.Identity.Name).UserId;
            model.RentalRequest.EquipmentId = model.NewEquipment.EquipmentId; // Set the EquipmentId to the selected equipment
            model.RentalRequest.RentalRequestTimestamp = DateTime.Now; // Set the RentalRequestTimestamp to the current date and time
            model.RentalRequest.RentalRequestStatusId = 1; // Set the RentalRequestStatusId to 1 

            // Remove validation errors for Equipment
            ModelState.Remove("NewEquipment");
            ModelState.Remove("NewEquipment.EquipmentName");
            ModelState.Remove("NewEquipment.EquipmentDescription");
            ModelState.Remove("NewEquipment.RentalPrice");


            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Something went wrong, Check your data and try again.";
                return RedirectToAction("Request", new { id = model.NewEquipment.EquipmentId });

            }

            try
            {

                // Save to database
                _context.RentalRequests.Add(model.RentalRequest);
                _context.SaveChanges();

                // Retrieve the message content for Pending Approval status from the database
                var pendingMessageContent = _context.MessageContents
                    .FirstOrDefault(m => m.MessageContentText == "Rental Request Pending Approval: Thank you for choosing RentOps! Your rental request has been sent successfully and is pending approval.");

                if (pendingMessageContent != null )
                {
                    // Create a notification for the user
                    var notification = new Notification
                    {
                        UserId = model.RentalRequest.UserId,
                        MessageContentId = pendingMessageContent.MessageContentId,
                        NotificationStatusId = 1, // 1 means "unread"
                        NotificationTimestamp = DateTime.Now
                    };

                    // Add the notification to the database
                    _context.Notifications.Add(notification);
                    _context.SaveChanges();

                    // Retrieve the message content for admin and manager notification
                    var adminMessageContent = _context.MessageContents
                        .FirstOrDefault(m => m.MessageContentText == "New Rental Request! Please approve or reject the request.");

                    // Notify all admins and managers about the new rental request
                    var adminAndManagers = _context.Users
                        .Where(u => u.RoleId == 1 || u.RoleId == 2) // RoleId 1 for Admin, 2 for Manager
                        .ToList();

                    foreach (var user in adminAndManagers)
                    {
                        if (adminMessageContent != null)
                        {
                            var adminNotification = new Notification
                            {
                                UserId = user.UserId,
                                MessageContentId = adminMessageContent.MessageContentId,
                                NotificationStatusId = 1, // 1 means "unread"
                                NotificationTimestamp = DateTime.Now
                            };

                            _context.Notifications.Add(adminNotification);
                        }
                    }

                    _context.SaveChanges(); // Save the notifications for admins and managers
                }


                TempData["CreateSuccess"] = "Rental Request Created Successfully.";

                return RedirectToAction("Equipment");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Something went wrong while creating the rental request. Please try again.";
                Console.WriteLine(ex.Message);
                return View(model);
            }
        }

        //get to navigate to the feedback page
        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var equipmentObject = _context.Equipment.Include(e => e.AvailabilityStatus).Include(e => e.ConditionStatus).Include(e => e.EquipmentCategory).FirstOrDefault(e => e.EquipmentId == id);
           
            if (equipmentObject == null)
                return NotFound();

            // Fetch feedbacks and execute the query immediately
            var allFeedbacks = _context.Feedbacks
                .Include(f => f.RentalTransaction)
                .Where(f => f.RentalTransaction != null && f.RentalTransaction.EquipmentId == id) ;

            var viewmodel = new EquipmentViewModel
            {
                NewEquipment = equipmentObject,
                EquipmentCategories = _context.EquipmentCategories,
                EquipmentAvailability = _context.AvailabilityStatuses,
                EquipmentStatuses = _context.ConditionStatuses,
                EquipmentFeedbacks = allFeedbacks.ToList(),
            };

            return View(viewmodel);

        }


        }
}
