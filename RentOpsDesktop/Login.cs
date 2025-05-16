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

namespace RentOpsDesktop
{
    public partial class Login : Form
    {
        //Declaring database context object
        RentOpsDBContext dbContext;

        private IServiceProvider serviceProvider;
        private RentOpsWebApp.Data.RentOpsWebAppContext identityDbContext;

        public Login()
        {
            InitializeComponent();
            //Initializing database context object
            dbContext = new RentOpsDBContext();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            var signInResults = await VerifyUserNamePassword(txtEmail.Text, txtPassword.Text);
            if (signInResults == true) //if user is verified
            {
                //do something.. i.e. navigate to next forms
                UserEquipmentDashboard home = new UserEquipmentDashboard();
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Error. The username or password are not correct");
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
                MessageBox.Show("Error from configuring services");
            }
        }



    }
}
