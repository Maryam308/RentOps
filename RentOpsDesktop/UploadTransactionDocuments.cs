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
    public partial class UploadTransactionDocuments : Form
    {
        public Document agreement;
        public Document idVerfication;

        public UploadTransactionDocuments()
        {
            InitializeComponent();

        }

        private void UploadTransactionDocuments_Load(object sender, EventArgs e)
        {

        }
    }
}
