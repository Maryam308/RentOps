using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RentOpsObjects.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RentOpsWebApp.Data;
using RentOpsObjects.Services;

namespace RentOpsDesktop
{
    public partial class Login : Form
    {

        RentOpsDBContext dbContext;
        private IServiceProvider serviceProvider;
        private RentOpsWebApp.Data.RentOpsWebAppContext identityDbContext;
        AuditLogger logger;

        //used to track the previous login attempts
        private string? previousEmail = null;
        private string? previousPassword = null;


        public Login()
        {
            InitializeComponent();
            //Initializing database context object
            dbContext = new RentOpsDBContext();
            logger = new AuditLogger(dbContext);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                //verify if the user exists and if the username and password are correct
                var signInResults = await VerifyUserNamePassword(txtEmail.Text, txtPassword.Text);

                //capture current email and password from the input fields
                string currentEmail = txtEmail.Text.Trim();
                string currentPassword = txtPassword.Text.Trim();

                if (signInResults == true) //if user is verified
                {
                    //change the password if it is correct
                    previousPassword = "[REDACTED]";

                    //log the login activity
                    logger.LogLoginActivity(Global.user.UserId, 2, "User logged in", previousEmail, previousPassword, currentEmail, currentPassword);

                    // reset previous attempt trackers
                    previousEmail = null;
                    previousPassword = null;

                    //do something.. i.e. navigate to next forms
                    UserEquipmentDashboard home = new UserEquipmentDashboard();
                    this.Hide();
                    home.Show();
                }
                else //if user is not verified
                {
                    //log failed login attempt
                    logger.LogLoginActivity(null, 2, "Login failed", previousEmail, previousPassword, currentEmail, currentPassword);

                    //save current attempt as previous for next login
                    previousEmail = currentEmail;
                    previousPassword = currentPassword;

                    //show error message
                    MessageBox.Show("Error: The username or password are not correct", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                //log unexpected error during login process
                logger.LogException(null, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);

                //show error message
                MessageBox.Show("Unexpected error occurred during login: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public async Task<bool> VerifyUserNamePassword(string userName, string password)
        {
            try
            {


                var services = new ServiceCollection();
                ConfigureServices(services);
                serviceProvider = services.BuildServiceProvider();

                var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
                var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var founduser = await userManager.FindByEmailAsync(txtEmail.Text);

                if (founduser != null)
                {
                    var passCheck = await userManager.CheckPasswordAsync(founduser, password) == true;

                    if (passCheck)
                    {
                        var roles = await userManager.GetRolesAsync(founduser);

                        //save into global class

                        //fetch the user from the dbcontext to match the one from the identity context 
                        Global.user = dbContext.Users.FirstOrDefault(x => x.Email == founduser.Email) ?? null;

                        Global.RoleName = roles.FirstOrDefault();


                    }
                    return passCheck;
                }
                return false;
            }
            catch (Exception ex)
            {
                logger.LogException(null, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                MessageBox.Show("Error from verifying " + ex);
                return false;
            }
        }

        private void ConfigureServices(IServiceCollection services)
        {
            try
            {

                services.AddEntityFrameworkSqlServer()
                    .AddDbContext<RentOpsWebApp.Data.RentOpsWebAppContext>();

                // Register UserManager & RoleManager
                services.AddIdentity<IdentityUser, IdentityRole>()
                   .AddEntityFrameworkStores<RentOpsWebApp.Data.RentOpsWebAppContext>()
                   .AddDefaultTokenProviders();

                // UserManager & RoleManager require logging and HttpContext dependencies
                services.AddLogging();
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            }
            catch (Exception ex)
            {
                logger.LogException(null, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);
                MessageBox.Show("Error from configuring services");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
