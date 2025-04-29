using Microsoft.AspNetCore.Mvc;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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
            if (model.newEquipment.RentalPrice <= 0)
            {
                ModelState.AddModelError("newEquipment.RentalPrice", "Rental Price must be greater than 0.");
            }
            
            model.newEquipment.UserId = 1; // Set the UserId to 1 for now, as we don't have user authentication yet.
            //check if modelstate is valid

            if (ModelState.IsValid)
            {
                _context.Equipment.Add(model.newEquipment);
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
                    newEquipment = model.newEquipment // so the input stays
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
                newEquipment = equipmentObject,
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
            //find the equipment object in the database
            var equipmentObject = _context.Equipment.Find(id);

            //check if the object is null 
            if (equipmentObject == null)
                return NotFound();

            //remove the equipment object from the database and save changes
            _context.Equipment.Remove(equipmentObject);
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
                newEquipment = equipmentObject,
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
            if (toEditEquipment.newEquipment.RentalPrice <= 0)
            {
                ModelState.AddModelError("newEquipment.RentalPrice", "Rental Price must be greater than 0.");
            }


            //as a placeholder, we will set the user id to 1
            toEditEquipment.newEquipment.UserId = 1;

            //check if modelstate is valid
            if (ModelState.IsValid)
            {
                //update the equipment object in the database and save changes
                _context.Equipment.Update(toEditEquipment.newEquipment);
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
                    newEquipment = toEditEquipment.newEquipment // so the input stays
                };

                return View("Equipment", viewmodel);

            }

        }


    }
}
