namespace RentOpsDesktop
{
    partial class EquipmentInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlNavigation = new Panel();
            btnDeleteEquipmentInformation = new Button();
            btnEditEquipmentInformation = new Button();
            btnAddNewEquipment = new Button();
            btnBack = new Button();
            lblEquipmentInformation = new Label();
            btnSearch = new Button();
            btnFilter = new Button();
            dataGridView1 = new DataGridView();
            pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigation.BackgroundImageLayout = ImageLayout.None;
            pnlNavigation.Controls.Add(btnDeleteEquipmentInformation);
            pnlNavigation.Controls.Add(btnEditEquipmentInformation);
            pnlNavigation.Controls.Add(btnAddNewEquipment);
            pnlNavigation.Controls.Add(btnBack);
            pnlNavigation.Location = new Point(12, 12);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(400, 954);
            pnlNavigation.TabIndex = 0;
            // 
            // btnDeleteEquipmentInformation
            // 
            btnDeleteEquipmentInformation.BackColor = Color.FromArgb(187, 178, 169);
            btnDeleteEquipmentInformation.BackgroundImageLayout = ImageLayout.None;
            btnDeleteEquipmentInformation.FlatAppearance.BorderSize = 0;
            btnDeleteEquipmentInformation.FlatStyle = FlatStyle.Flat;
            btnDeleteEquipmentInformation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteEquipmentInformation.ForeColor = Color.Transparent;
            btnDeleteEquipmentInformation.Location = new Point(36, 546);
            btnDeleteEquipmentInformation.Name = "btnDeleteEquipmentInformation";
            btnDeleteEquipmentInformation.Size = new Size(337, 121);
            btnDeleteEquipmentInformation.TabIndex = 3;
            btnDeleteEquipmentInformation.Text = "Delete Equipment Information";
            btnDeleteEquipmentInformation.UseVisualStyleBackColor = false;
            // 
            // btnEditEquipmentInformation
            // 
            btnEditEquipmentInformation.BackColor = Color.FromArgb(187, 178, 169);
            btnEditEquipmentInformation.BackgroundImageLayout = ImageLayout.None;
            btnEditEquipmentInformation.FlatAppearance.BorderSize = 0;
            btnEditEquipmentInformation.FlatStyle = FlatStyle.Flat;
            btnEditEquipmentInformation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditEquipmentInformation.ForeColor = Color.Transparent;
            btnEditEquipmentInformation.Location = new Point(36, 352);
            btnEditEquipmentInformation.Name = "btnEditEquipmentInformation";
            btnEditEquipmentInformation.Size = new Size(337, 121);
            btnEditEquipmentInformation.TabIndex = 2;
            btnEditEquipmentInformation.Text = "Edit Equipment Information";
            btnEditEquipmentInformation.UseVisualStyleBackColor = false;
            btnEditEquipmentInformation.Click += button1_Click;
            // 
            // btnAddNewEquipment
            // 
            btnAddNewEquipment.BackColor = Color.FromArgb(187, 178, 169);
            btnAddNewEquipment.BackgroundImageLayout = ImageLayout.None;
            btnAddNewEquipment.FlatAppearance.BorderSize = 0;
            btnAddNewEquipment.FlatStyle = FlatStyle.Flat;
            btnAddNewEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewEquipment.ForeColor = Color.Transparent;
            btnAddNewEquipment.Location = new Point(36, 160);
            btnAddNewEquipment.Name = "btnAddNewEquipment";
            btnAddNewEquipment.Size = new Size(337, 121);
            btnAddNewEquipment.TabIndex = 1;
            btnAddNewEquipment.Text = "Add New Equipment";
            btnAddNewEquipment.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(139, 128, 116);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(36, 30);
            btnBack.Margin = new Padding(5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(337, 75);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblEquipmentInformation
            // 
            lblEquipmentInformation.AutoSize = true;
            lblEquipmentInformation.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEquipmentInformation.ForeColor = Color.FromArgb(135, 66, 62);
            lblEquipmentInformation.Location = new Point(608, 42);
            lblEquipmentInformation.Margin = new Padding(5, 0, 5, 0);
            lblEquipmentInformation.Name = "lblEquipmentInformation";
            lblEquipmentInformation.Size = new Size(862, 100);
            lblEquipmentInformation.TabIndex = 25;
            lblEquipmentInformation.Text = "Equipment Information";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(121, 86, 76);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources.search;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(712, 196);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(20, 0, 0, 0);
            btnSearch.Size = new Size(256, 70);
            btnSearch.TabIndex = 38;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(121, 86, 76);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.White;
            btnFilter.Image = Properties.Resources.filter;
            btnFilter.ImageAlign = ContentAlignment.MiddleLeft;
            btnFilter.Location = new Point(1117, 196);
            btnFilter.Margin = new Padding(5);
            btnFilter.Name = "btnFilter";
            btnFilter.Padding = new Padding(40, 0, 0, 0);
            btnFilter.Size = new Size(256, 70);
            btnFilter.TabIndex = 39;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(510, 336);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1170, 549);
            dataGridView1.TabIndex = 40;
            // 
            // EquipmentInformation
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 978);
            Controls.Add(dataGridView1);
            Controls.Add(btnFilter);
            Controls.Add(btnSearch);
            Controls.Add(lblEquipmentInformation);
            Controls.Add(pnlNavigation);
            Name = "EquipmentInformation";
            Text = "EquipmentInformation";
            pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavigation;
        private Button btnBack;
        private Button btnAddNewEquipment;
        private Button btnEditEquipmentInformation;
        private Button btnDeleteEquipmentInformation;
        private Label lblEquipmentInformation;
        private Button btnSearch;
        private Button btnFilter;
        private DataGridView dataGridView1;
    }
}