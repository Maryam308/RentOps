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
    public partial class AddRentalTransaction : Form
    {
        RentOpsDBContext context;
        int equipmentId;

        public AddRentalTransaction(int equipmentId)
        {
            InitializeComponent();

            context = new RentOpsDBContext();

            this.equipmentId = equipmentId;

        }

        private void btnAddRentalTransaction_Click(object sender, EventArgs e)
        {
            //add the rental transaction 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddRentalTransaction_Load(object sender, EventArgs e)
        {
            //load the equipment name
            var equipment = context.Equipment.FirstOrDefault(e => e.EquipmentId == equipmentId);

            txtEquipment.Text = equipment.EquipmentName;

        }
    }
}
