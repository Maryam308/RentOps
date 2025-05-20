using Microsoft.AspNetCore.Mvc;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.IdentityModel.Abstractions;
using RentOpsObjects.Services;
using Microsoft.AspNetCore.Authorization;


namespace RentOpsWebApp.Controllers
{
    [Authorize]
    public class EquipmentController : Controller
    {

        RentOpsDBContext _context;
        AuditLogger logger;
        IHttpContextAccessor _httpContextAccessor;

        public EquipmentController(RentOpsDBContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            logger = new AuditLogger(_context);
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Administrator,Rental Manager")]
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
        [Authorize(Roles = "Administrator,Rental Manager")]
        public IActionResult AddEquipment(EquipmentViewModel model)
        {
            try
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

                model.NewEquipment.UserId = userId;
                _context.Equipment.Add(model.NewEquipment);

                if (model.NewEquipment.RentalPrice <= 0)
                {
                    ModelState.AddModelError("newEquipment.RentalPrice", "Rental Price must be greater than 0.");
                }


                if (ModelState.IsValid)
                {

                    //print to console for debugging
                    Console.WriteLine("ModelState is valid will call logger");

                    _context.Equipment.Add(model.NewEquipment);

                    // Track changes before the new entity is saved

                    logger.TrackChanges(currentUserId, 1);


                    _context.SaveChanges();

                    TempData["CreateSuccess"] = "Equipment added successfully.";

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
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }

        }



        [Authorize(Roles = "Administrator")]
        private ViewResult LoadManageCategoriesView(bool showModal = false)
        {
            var categories = _context.EquipmentCategories.ToList();
            ViewBag.ShowModal = showModal;
            return View("ManageCategories", categories);
        }


        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult AddCategory()
        {
            // Just set flag to show modal
            return LoadManageCategoriesView(showModal: true);

        }

        // POST: Handle form submission from modal (Save button)(add and edit categories)
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult SubmitModal(int CategoryId, string CategoryTitle)
        {

            try 
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

                if (string.IsNullOrWhiteSpace(CategoryTitle))
                {
                    TempData["CreateSuccess"] = "Category title cannot be empty!";
                    return RedirectToAction("ManageCategories");
                }

                if (CategoryId > 0) // If CategoryId exists, update instead of adding
                {
                    var category = _context.EquipmentCategories.Find(CategoryId);
                    if (category == null) return NotFound();

                    category.EquipmentCategoryTitle = CategoryTitle;
                    _context.SaveChanges();
                    TempData["CreateSuccess"] = "Category updated successfully!";
                }
                else // Otherwise, it's a new category
                {
                    
                    //check if the category already exists
                    var existingCategory = _context.EquipmentCategories
                        .FirstOrDefault(c => c.EquipmentCategoryTitle.Equals(CategoryTitle));

                    if (existingCategory != null)
                    {
                        TempData["CreateSuccess"] = "Category already exists!";
                        return RedirectToAction("ManageCategories");
                    }


                        var newCategory = new EquipmentCategory { EquipmentCategoryTitle = CategoryTitle };
                    _context.EquipmentCategories.Add(newCategory);

                    //track the changes
                    logger.TrackChanges(currentUserId, 1);

                    _context.SaveChanges();
                    TempData["CreateSuccess"] = "Category added successfully!";
                }

                return RedirectToAction("ManageCategories");
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult ManageCategories()
        {
            // Return with modal hidden
            return LoadManageCategoriesView();
        }

        public IActionResult Equipment(string SearchEquipmentName, string SearchEquipmentId, string SearchCategory, string SearchAvailability, string SearchCondition, int page = 1)
        {
            try
            {
                int pageSize = 25;

                //get all equipment from the database with includes
                var equipmentQuery = _context.Equipment
                    .Include(e => e.ConditionStatus)
                    .Include(e => e.EquipmentCategory)
                    .Include(e => e.AvailabilityStatus)
                    .AsQueryable();

                //If equipment name filter is used, we filter the list retrieved above
                if (!String.IsNullOrEmpty(SearchEquipmentName))
                {
                    equipmentQuery = equipmentQuery.Where(p =>
                        p.EquipmentName != null && p.EquipmentName.Contains(SearchEquipmentName, StringComparison.OrdinalIgnoreCase)
                    );
                }

                //if the equipment id filter is used, we filter the list retrieved above
                if (!String.IsNullOrEmpty(SearchEquipmentId))
                {
                    equipmentQuery = equipmentQuery.Where(p => p.EquipmentId == Convert.ToInt32(SearchEquipmentId));
                }

                //if the equipment category filter is used, we filter the list retrieved above
                if (!String.IsNullOrEmpty(SearchCategory))
                {
                    equipmentQuery = equipmentQuery.Where(p => p.EquipmentCategoryId == Convert.ToInt32(SearchCategory));
                }

                //if the equipment availability filter is used, we filter the list retrieved above
                if (!String.IsNullOrEmpty(SearchAvailability))
                {
                    equipmentQuery = equipmentQuery.Where(p => p.AvailabilityStatusId == Convert.ToInt32(SearchAvailability));
                }

                //if the equipment condition filter is used, we filter the list retrieved above
                if (!String.IsNullOrEmpty(SearchCondition))
                {
                    equipmentQuery = equipmentQuery.Where(p => p.ConditionStatusId == Convert.ToInt32(SearchCondition));
                }

                //get total count for pagination
                int totalCount = equipmentQuery.Count();

                //apply pagination
                var pagedEquipment = equipmentQuery
                    .OrderBy(e => e.EquipmentId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                //create viewmodel and assign the lists
                var viewmodel = new EquipmentViewModel
                {
                    Equipment = pagedEquipment,
                    EquipmentCategories = _context.EquipmentCategories.ToList(),
                    EquipmentAvailability = _context.AvailabilityStatuses.ToList(),
                    EquipmentStatuses = _context.ConditionStatuses.ToList(),
                    CurrentPage = page,
                    TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize)
                };

                // Fetch the current user id
                var userEmail = User?.Identity?.Name;

                var currentUserId = _context.Users
                    .FirstOrDefault(u => u.Email == userEmail)?.UserId;

                int userId = 1;
                if (currentUserId != null)
                {
                    userId = (int)currentUserId;
                }

                var user = _context.Users
                    .FirstOrDefault(u => u.Email == userEmail);

                var userRoleTitle = _context.Roles.FirstOrDefault(r => r.RoleId == user.RoleId)?.RoleTitle; // Assuming RoleId is foreign key in Users table
                ViewBag.UserId = userId;
                ViewBag.UserRoleTitle = userRoleTitle; // Store role title in ViewBag

                return View(viewmodel);
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }

        }

        //GET to navigate to the delete page
        [Authorize(Roles = "Administrator,Rental Manager")]
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
        [Authorize(Roles = "Administrator,Rental Manager")]
        public IActionResult DeletePost(int? id)
        {
            try
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


                //print to console for debugging
                Console.WriteLine("DeletePost method called");


                //find the equipment object in the database
                var equipmentObject = _context.Equipment.Find(id);

                //check if the object is null 
                if (equipmentObject == null)
                    return NotFound();

                //loop through all the equipments in the rental transaction and set the equipment id to null
                foreach (var rentalTransaction in _context.RentalTransactions.Where(r => r.EquipmentId == id))
                {
                    rentalTransaction.EquipmentId = null;
                }

                //loop through all the equipments in the rental request and set the equipment id to null
                foreach (var rentalRequest in _context.RentalRequests.Where(r => r.EquipmentId == id))
                {
                    rentalRequest.EquipmentId = null;
                }



                //remove the equipment object from the database and save changes
                _context.Equipment.Remove(equipmentObject);


                //call the logger to track changes
                logger.TrackChanges(userId, 1);


                _context.SaveChanges();

                //add success message to tempdata
                TempData["CreateSuccess"] = "Equipmetn Deleted Successfully";
                return RedirectToAction("Equipment");
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }


        }

        //GET to navigate to the edit page
        [Authorize(Roles = "Administrator,Rental Manager")]
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
        [Authorize(Roles = "Administrator,Rental Manager")]
        public IActionResult Edit(EquipmentViewModel toEditEquipment)
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

                //check if the id is null or 0
                if (toEditEquipment.NewEquipment.RentalPrice <= 0)
                {
                    ModelState.AddModelError("newEquipment.RentalPrice", "Rental Price must be greater than 0.");
                }


                //check if modelstate is valid
                if (ModelState.IsValid)
                {
                    //update the equipment object in the database and save changes
                    _context.Equipment.Update(toEditEquipment.NewEquipment);

                    //track the changes
                    //logger.TrackChanges(userId, 1);

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
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
    }

}

        //get to navigate to the request page
        [Authorize(Roles = "Customer")]
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
        [Authorize(Roles = "Customer")]
        public IActionResult Request(EquipmentViewModel model)
        {
            try
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


                if (model.RentalRequest.RentalStartDate >= model.RentalRequest.RentalReturnDate)
                {
                    ModelState.AddModelError("RentalRequest.RentalReturnDate", "Pickup date must be before return date.");

                }

                model.RentalRequest.UserId = userId;

                model.RentalRequest.EquipmentId = model.NewEquipment.EquipmentId; // Set the EquipmentId to the selected equipment
                model.RentalRequest.RentalRequestTimestamp = DateTime.Now; // Set the RentalRequestTimestamp to the current date and time
                model.RentalRequest.RentalRequestStatusId = 1; // Set the RentalRequestStatusId to 1 

                // Remove validation errors for Equipment
                ModelState.Remove("NewEquipment");
                ModelState.Remove("NewEquipment.EquipmentName");
                ModelState.Remove("NewEquipment.EquipmentDescription");
                ModelState.Remove("NewEquipment.RentalPrice");

                //track the changes
                logger.TrackChanges(userId, 1);

                if (!ModelState.IsValid)
                {
                    TempData["Error"] = "Something went wrong, Check your data and try again.";
                    return RedirectToAction("Request", new { id = model.NewEquipment.EquipmentId });

                }

                try
                {

                    // Save to database
                    _context.RentalRequests.Add(model.RentalRequest);

                    //track the changes
                    logger.TrackChanges(userId, 1);

                    _context.SaveChanges();

                    //after making a rental request send a notification to the user that made the request
                    var notifyUserId = model.RentalRequest.UserId;

                    var newRequestMessageContent = _context.MessageContents.Include(mc => mc.MessageType)
                        .FirstOrDefault(m => m.MessageType.MessageTypeTitle == "Rental Request Pending Approval");

                    if (newRequestMessageContent == null)
                    {
                        //create a new message content
                        newRequestMessageContent = new MessageContent
                        {
                            MessageTypeId = _context.MessageTypes.Where(mt => mt.MessageTypeTitle == "Rental Request Pending Approval").Select(mt => mt.MessageTypeId).FirstOrDefault(),
                            MessageContentText = "Rental Request Pending Approval: Thank you for choosing RentOps! Your rental request has been sent successfully and is pending approval.",
                        };
                    }


                    if (newRequestMessageContent != null)
                    {
                        var notification = new Notification
                        {
                            UserId = notifyUserId,
                            MessageContentId = newRequestMessageContent.MessageContentId,
                            NotificationStatusId = 1,
                            NotificationTimestamp = DateTime.Now
                        };

                        _context.Notifications.Add(notification);
                        //track the changes
                        logger.TrackChanges(userId, 1);
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

                        //track the changes
                        logger.TrackChanges(userId, 1);

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
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }

        }

        //get to navigate to the feedback page
        public IActionResult Details(int? id)
        {
            try
            {
                if (id == null || id == 0)
                    return NotFound();

                var equipmentObject = _context.Equipment.Include(e => e.AvailabilityStatus).Include(e => e.ConditionStatus).Include(e => e.EquipmentCategory).FirstOrDefault(e => e.EquipmentId == id);

                if (equipmentObject == null)
                    return NotFound();

                //check the role if the user is admin or rental manager
                var userEmail = User?.Identity?.Name;
                var currentUserId = _context.Users
                    .FirstOrDefault(u => u.Email == userEmail)?.UserId;
                int userId = 1;
                if (currentUserId != null)
                {
                    userId = (int)currentUserId;
                }
                var user = _context.Users
                    .FirstOrDefault(u => u.Email == userEmail);
                var userRoleTitle = _context.Roles.FirstOrDefault(r => r.RoleId == user.RoleId)?.RoleTitle; // Assuming RoleId is foreign key in Users table

                
                    //fetch all feedbacks related to the equipment
                     var allFeedbacks = _context.Feedbacks
                        .Include(f => f.RentalTransaction)
                        .Where(f => f.RentalTransaction != null && f.RentalTransaction.EquipmentId == id);

                if (userRoleTitle == "Customer")
                {
                    //filter the feedbacks to not include hidden ones 
                     allFeedbacks = _context.Feedbacks
                        .Include(f => f.RentalTransaction)
                        .Where(f => f.RentalTransaction != null && f.RentalTransaction.EquipmentId == id && f.IsHidden == false);
                }

                

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
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }

        }

        [HttpPost]
        [Authorize(Roles = "Administrator,Rental Manager")]
        public ActionResult ToggleFeedbackVisibility(int id)
        {
            try
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

                var feedback = _context.Feedbacks.Find(id);
                if (feedback != null)
                {
                    feedback.IsHidden = !feedback.IsHidden;

                    logger.TrackChanges(userId, 2);
                    _context.SaveChanges();
                }
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }

        }


        //delete equipment category and all its equipment

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult DeleteCategory(int id)
        {
            try {

                // Fetch the current user id
                var userEmail = User?.Identity?.Name;
                var currentUserId = _context.Users
                    .FirstOrDefault(u => u.Email == userEmail)?.UserId;

                int userId = 1;
                if (currentUserId != null)
                {
                    userId = (int)currentUserId;
                }

                //find the equipment category object in the database
                var equipmentCategoryObject = _context.EquipmentCategories.Find(id);
                //check if the equipment category object is null
                if (equipmentCategoryObject == null)
                    return NotFound();

                //remove all the equipment that belongs to this category
                var equipmentList = _context.Equipment.Where(e => e.EquipmentCategoryId == id).ToList();
                foreach (var equipment in equipmentList)
                {
                    //loop through all the equipments in the rental transaction and set the equipment id to null
                    foreach (var rentalTransaction in _context.RentalTransactions.Where(r => r.EquipmentId == equipment.EquipmentId))
                    {
                        rentalTransaction.EquipmentId = null;
                    }

                    //loop through all the equipments in the rental request and set the equipment id to null
                    foreach (var rentalRequest in _context.RentalRequests.Where(r => r.EquipmentId == equipment.EquipmentId))
                    {
                        rentalRequest.EquipmentId = null;
                    }

                    _context.Equipment.Remove(equipment);

                    //track the changes
                    logger.TrackChanges(userId, 1);
                }

                //save changes to the database
                _context.SaveChanges();

                //remove the equipment category object from the database and save changes
                _context.EquipmentCategories.Remove(equipmentCategoryObject);

                //track the changes
                logger.TrackChanges(userId, 1);

                _context.SaveChanges();
                //add success message to tempdata
                TempData["CreateSuccess"] = "Equipment Category Deleted Successfully";
                return RedirectToAction("ManageCategories");          
            
            }
            catch(Exception ex) {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult SaveCategory(int CategoryId, string CategoryTitle)
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

            try { 
                    if (string.IsNullOrEmpty(CategoryTitle))
                {
                    TempData["CreateSuccess"] = "Category title cannot be empty!";
                    return RedirectToAction("ManageCategories");
                }

                if (CategoryId > 0) // Editing existing category
                {
                    var category = _context.EquipmentCategories.Find(CategoryId);
                    if (category == null) return NotFound();

                    category.EquipmentCategoryTitle = CategoryTitle;

                    //track the changes
                    logger.TrackChanges(userId, 1);

                    _context.SaveChanges();
                    TempData["CreateSuccess"] = "Category updated successfully!";
                }
                else // Adding new category
                {
                    var newCategory = new EquipmentCategory { EquipmentCategoryTitle = CategoryTitle };
                    _context.EquipmentCategories.Add(newCategory);

                    //track the changes
                    logger.TrackChanges(userId, 1);

                    _context.SaveChanges();
                    TempData["CreateSuccess"] = "Category added successfully!";
                }

                return RedirectToAction("ManageCategories");
            
            
            }catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }

            
        }





    }
}
