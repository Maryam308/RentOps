using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
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
    public partial class AuditLog : Form
    {
        private RentOpsDBContext dbContext;

        public AuditLog()
        {
            InitializeComponent();

            dbContext = new RentOpsDBContext();

        }

        private void AuditLog_Load(object sender, EventArgs e)
        {
            //load data into combo boxes

            // Create a placeholder item
            var defaultItem = new LogType { LogTypeId = 0, LogTypeTitle = "Select a Log Type" };

            // Load data into the ComboBox
            var logTypes = dbContext.LogTypes.ToList();

            // Insert the placeholder at the beginning
            logTypes.Insert(0, defaultItem);

            cmbLogType.DataSource = logTypes;
            cmbLogType.DisplayMember = "LogTypeTitle";
            cmbLogType.ValueMember = "LogTypeId";
            cmbLogType.SelectedIndex = 0;

            //load data into source combo box
            // Create a placeholder item
            var defaultItemSource = new Source { SourceId = 0, SourceTitle = "Select a Source" };

            // Load data into the ComboBox
            var sources = dbContext.Sources.ToList();

            // Insert the placeholder at the beginning
            sources.Insert(0, defaultItemSource);

            cmbSource.DataSource = sources;
            cmbSource.DisplayMember = "SourceTitle";
            cmbSource.ValueMember = "SourceId";
            cmbSource.SelectedIndex = 0;



            //load the data into the gridview
            LoadData();



        }


        //function to load data into the gridview
        private void LoadData()
        {
            IEnumerable<Log> logList = dbContext.Logs
               .Include(e => e.User)
               .Include(e => e.LogType)
               .Include(e => e.Source)
               .AsQueryable();


            //fetch the filters values from the combo boxes
            string SearchLogType = cmbLogType.SelectedValue?.ToString();
            string SearchSource = cmbSource.SelectedValue?.ToString();
            DateTime SearchTimestamp = dtpTimestamp.Value;


            //filter the logs based on the search criteria
            //if the search log type is not null or empty, we filter the logs based on the log type
            if (cmbLogType.SelectedValue.ToString() != "Select a Log Type" && (int)cmbLogType.SelectedValue != 0)
            {
                logList = logList.Where(e => e.LogType.LogTypeId == Convert.ToInt32(SearchLogType));
            }

            //if the search source is not null or empty, we filter the logs based on the source
            if (cmbSource.SelectedValue != null && (int)cmbSource.SelectedValue != 0)
            {
                logList = logList.Where(e => e.Source.SourceId == Convert.ToInt32(SearchSource));
            }

            //if the search timestamp is not null or empty, we filter the logs based on the date
            if (dtpTimestamp.Checked)
            {
                logList = logList.Where(l => l.LogTimestamp.Date == SearchTimestamp.Date);
            }


            //select the data to be displayed in the gridview
            var logData = logList.Select(l => new
            {
                l.LogId,
                l.User.FirstName,
                l.User.LastName,
                l.LogType.LogTypeTitle,
                l.Source.SourceTitle,
                l.LogTimestamp,
                l.Exception,
                l.UserAction,
                l.AffectedData

            }).ToList();

            //bind the data to the gridview
            dgvAuditLog.DataSource = logData;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset the filters
            cmbLogType.SelectedIndex = 0;
            cmbSource.SelectedIndex = 0;
            dtpTimestamp.Value = DateTime.Now;
            dtpTimestamp.Checked = false;

            //reload the data
            LoadData();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //load the data based on the filters
            LoadData();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView is empty
            if (dgvAuditLog.Rows.Count == 0)
            {
                MessageBox.Show("No Audit log available to view.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure a row is selected
            if (dgvAuditLog.SelectedRows.Count == 0 && dgvAuditLog.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a record to view.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow;
            if (dgvAuditLog.SelectedRows.Count > 0)
            {
                selectedRow = dgvAuditLog.SelectedRows[0];
            }
            else
            {
                int rowIndex = dgvAuditLog.SelectedCells[0].RowIndex;
                selectedRow = dgvAuditLog.Rows[rowIndex];
            }

            // Check if the selected row is the empty default row
            if (selectedRow.IsNewRow || selectedRow.Cells["LogId"].Value == null)
            {
                MessageBox.Show("This row is empty. Please select a valid Record to view.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ID of the selected equipment
            int selectedLogID = Convert.ToInt32(selectedRow.Cells["LogID"].Value);

            // Confirm the edit action
            DialogResult result = MessageBox.Show($"Are you sure you want to view the Log with ID {selectedLogID}?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                try
                {
                    // Pass the object to the edit screen constructor and show the form
                    LogDetails logDetails = new LogDetails(selectedLogID);
                    logDetails.StartPosition = FormStartPosition.CenterScreen; // Center the form
                    logDetails.Show();

                    //hide the current form
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
        }
    }
}
