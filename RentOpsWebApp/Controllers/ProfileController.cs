using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentOpsObjects.Model;
using Microsoft.EntityFrameworkCore;
using RentOpsWebApp.ViewModels;


namespace RentOpsWebApp.Controllers
{
    public class ProfileController : Controller
    {
        private readonly RentOpsDBContext _context;
        private readonly UserManager<IdentityUser> _userManager;

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

        public async Task<IActionResult> Details()
        {

            // Get current user's email from login
            // var userEmail = User.Identity?.Name;
            // if (string.IsNullOrEmpty(userEmail))
            //     return Unauthorized();
            // var user = await _context.Users
            //     .Include(u => u.RentalTransactionUsers)
            //     .FirstOrDefaultAsync(u => u.Email == userEmail);

            // INSTEAD: Fetch user by hardcoded user ID
            int userId = 16;
            var user = await _context.Users
                .Include(u => u.RentalTransactionUsers)
                .FirstOrDefaultAsync(u => u.UserId == userId);

            if (user == null)
                return NotFound();

            var model = new ProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailAddress = user.Email,
                PhoneNumber = user.PhoneNumber,
                TotalRentals = user.RentalTransactionUsers.Count()
            };

            return View("Profile", model);
        }

    }
}
