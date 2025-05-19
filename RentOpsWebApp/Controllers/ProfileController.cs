using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentOpsObjects.Model;
using Microsoft.EntityFrameworkCore;
using RentOpsWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using RentOpsObjects.Services;


namespace RentOpsWebApp.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private  RentOpsDBContext _context;
        private  UserManager<IdentityUser> _userManager;


        public ProfileController(RentOpsDBContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

        //get user profile
        public async Task<IActionResult> Details()
        {

            // Get current user's email from login
            var userEmail = User.Identity?.Name;
            if (string.IsNullOrEmpty(userEmail))
                return Unauthorized();
            var user = await _context.Users
                .Include(u => u.RentalTransactionUsers)
                .FirstOrDefaultAsync(u => u.Email == userEmail);

            int currentUserId = user.UserId;

            //only allow user to see their own profile
            if (user == null || user.UserId != currentUserId)
                return Forbid();


            if (user == null)
                return NotFound();

            var model = new ProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserId = user.UserId,
                EmailAddress = user.Email,
                PhoneNumber = user.PhoneNumber,
                TotalRentals = user.RentalTransactionUsers.Count()
            };

            return View("Profile", model);
        }

    }
}
