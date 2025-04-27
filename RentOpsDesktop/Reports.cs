using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentOpsDesktop
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnCustomerReports_Click(object sender, EventArgs e)
        {
            CustomerReport screen = new CustomerReport();
            screen.StartPosition = FormStartPosition.CenterScreen; // Center the form
            this.Hide();
            screen.Show();
        }

        private void btnRentalHistoryReports_Click(object sender, EventArgs e)
        {
            RentalReports screen = new RentalReports();
            screen.StartPosition = FormStartPosition.CenterScreen; // Center the form
            this.Hide();
            screen.Show();
        }
    }
}
