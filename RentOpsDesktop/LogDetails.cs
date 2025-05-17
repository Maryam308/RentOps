using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using RentOpsObjects.Model;
using RentOpsObjects.Services;


namespace RentOpsDesktop
{
    public partial class LogDetails : Form
    {
        RentOpsDBContext dbContext;
        int logId;
        AuditLogger logger;
        int currentUserId;

        public LogDetails(int logId)
        {
            InitializeComponent();

            dbContext = new RentOpsDBContext();
            logger = new AuditLogger(dbContext); //create a logger object
            currentUserId = Global.EmployeeID; //get the current user id
            this.logId = logId;
            LoadData();


        }


        //function to load data 
        private void LoadData()
        {
            try 
            {
                //select the data to be displayed in the gridview
                var log = dbContext.Logs.Select(l => new
                {
                    l.LogId,
                    l.User.FirstName,
                    l.User.LastName,
                    l.LogType.LogTypeTitle,
                    l.Source.SourceTitle,
                    l.LogTimestamp,
                    l.Exception,
                    l.UserAction,
                    l.AffectedData,
                    l.CurrentValue,
                    l.PreviousValue

                }).Where(l => l.LogId == logId).FirstOrDefault();

                //set labels values
                lblLogID.Text = log.LogId.ToString();
                lblLogType.Text = log.LogTypeTitle;
                lblSource.Text = log.SourceTitle;
                lblLogTimestamp.Text = log.LogTimestamp.ToString();
                lblUserAction.Text = log.UserAction;
                lblUserName.Text = log.FirstName + " " + log.LastName;
                lblUserID.Text = log.LogId.ToString();
                lblOriginalValue.Text = log.PreviousValue;
                lblCurrentValue.Text = log.CurrentValue;

                if (log.Exception == null)
                {
                    lblException.Text = "No Exception";
                }
                else
                {
                    lblException.Text = log.Exception;
                }
            }
            catch (Exception ex)
            {
                //log the exception
                logger.LogException(currentUserId, ex.Message, ex.StackTrace.ToString(), Global.sourceId ?? 2);

                //show the error message
                MessageBox.Show("An error occurred while loading the form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //close the form and open the main form
            this.Close();
            AuditLog logDetails = new AuditLog();
            logDetails.Show();
        }

        private void LogDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
