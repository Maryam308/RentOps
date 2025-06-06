﻿using System;
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
    public partial class Landing : Form
    {
        RentOpsDBContext context;
        
        public Landing()
        {
            InitializeComponent();
            context = new RentOpsDBContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            //center the form
            login.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            login.Show();

        }

        private void Landing_Load(object sender, EventArgs e)
        {
            try 
            {
                //when loadding the application fetch the source id 
                // Fetch the sourceId for "Form Application"
                var sourceId = context.Sources
                    .Where(s => s.SourceTitle == "Form Application")
                    .Select(s => s.SourceId)
                    .FirstOrDefault(); // Retrieves the first matching sourceId or default (0 if not found)

                //assign the source to the global if not zero
                if(sourceId != 0)
                {
                    // override the sourceId
                        Global.sourceId = sourceId;
                }
                
            }
            catch (Exception ex)
            {
                //show the error message
                MessageBox.Show("An error occurred while loading the application: " + ex.Message);
            }


        }
    }
}
