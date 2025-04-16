using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentOpsObjects.Model;

namespace RentOpsDesktop
{
    public partial class Login : Form
    {
        //Declaring database context object
        RentOpsDBContext dbContext;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Fetch the employee object from the database
            var emp = dbContext.Users
                .Where(e => e.Email == txtEmail.Text)
                .FirstOrDefault();

            //Assign the fetched employee ID to the global variable
            Global.EmployeeID = emp.UserId;
        }
    }
}
