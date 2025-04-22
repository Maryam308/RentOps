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
            btnReset = new Button();
            dgvEquipment = new DataGridView();
            lblEquipmentDashboard = new Label();
            cmbConditionStatus = new ComboBox();
            cmbEquipmentCategory = new ComboBox();
            cmbAvailabilityStatus = new ComboBox();
            btnFilter = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlNavigation = new Panel();
            btnDeleteEquipmentInformation = new Button();
            btnEditEquipmentInformation = new Button();
            btnAddNewEquipment = new Button();
            btnBack1 = new Button();
            label4 = new Label();
            cmbUser = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            pnlNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(121, 86, 76);
            btnReset.BackgroundImageLayout = ImageLayout.None;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(241, 240, 234);
            btnReset.Location = new Point(939, 36);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(102, 41);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dgvEquipment
            // 
            dgvEquipment.BackgroundColor = Color.WhiteSmoke;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Location = new Point(286, 193);
            dgvEquipment.Margin = new Padding(3, 4, 3, 4);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersWidth = 51;
            dgvEquipment.Size = new Size(775, 389);
            dgvEquipment.TabIndex = 20;
            // 
            // lblEquipmentDashboard
            // 
            lblEquipmentDashboard.AutoSize = true;
            lblEquipmentDashboard.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblEquipmentDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            lblEquipmentDashboard.Location = new Point(286, 24);
            lblEquipmentDashboard.Name = "lblEquipmentDashboard";
            lblEquipmentDashboard.Size = new Size(448, 52);
            lblEquipmentDashboard.TabIndex = 17;
            lblEquipmentDashboard.Text = "Equipment Information";
            lblEquipmentDashboard.Click += lblRentalDashboard_Click;
            // 
            // cmbConditionStatus
            // 
            cmbConditionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConditionStatus.FormattingEnabled = true;
            cmbConditionStatus.Location = new Point(458, 137);
            cmbConditionStatus.Name = "cmbConditionStatus";
            cmbConditionStatus.Size = new Size(153, 28);
            cmbConditionStatus.TabIndex = 24;
            // 
            // cmbEquipmentCategory
            // 
            cmbEquipmentCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipmentCategory.FormattingEnabled = true;
            cmbEquipmentCategory.Location = new Point(275, 137);
            cmbEquipmentCategory.Name = "cmbEquipmentCategory";
            cmbEquipmentCategory.Size = new Size(162, 28);
            cmbEquipmentCategory.TabIndex = 25;
            // 
            // cmbAvailabilityStatus
            // 
            cmbAvailabilityStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailabilityStatus.FormattingEnabled = true;
            cmbAvailabilityStatus.Location = new Point(656, 137);
            cmbAvailabilityStatus.Name = "cmbAvailabilityStatus";
            cmbAvailabilityStatus.Size = new Size(187, 28);
            cmbAvailabilityStatus.TabIndex = 26;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(121, 86, 76);
            btnFilter.BackgroundImageLayout = ImageLayout.None;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnFilter.ForeColor = Color.FromArgb(241, 240, 234);
            btnFilter.Location = new Point(823, 36);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(102, 41);
            btnFilter.TabIndex = 26;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 114);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 27;
            label1.Text = "Filter by Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 114);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 28;
            label2.Text = "Filter by Condition Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(656, 114);
            label3.Name = "label3";
            label3.Size = new Size(184, 20);
            label3.TabIndex = 29;
            label3.Text = "Filter by Availability Status";
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigation.BackgroundImageLayout = ImageLayout.None;
            pnlNavigation.Controls.Add(btnDeleteEquipmentInformation);
            pnlNavigation.Controls.Add(btnEditEquipmentInformation);
            pnlNavigation.Controls.Add(btnAddNewEquipment);
            pnlNavigation.Controls.Add(btnBack1);
            pnlNavigation.Location = new Point(0, 1);
            pnlNavigation.Margin = new Padding(2, 1, 2, 1);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(246, 610);
            pnlNavigation.TabIndex = 30;
            pnlNavigation.Paint += pnlNavigation_Paint;
            // 
            // btnDeleteEquipmentInformation
            // 
            btnDeleteEquipmentInformation.BackColor = Color.FromArgb(187, 178, 169);
            btnDeleteEquipmentInformation.BackgroundImageLayout = ImageLayout.None;
            btnDeleteEquipmentInformation.FlatAppearance.BorderSize = 0;
            btnDeleteEquipmentInformation.FlatStyle = FlatStyle.Flat;
            btnDeleteEquipmentInformation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteEquipmentInformation.ForeColor = Color.Transparent;
            btnDeleteEquipmentInformation.Location = new Point(22, 341);
            btnDeleteEquipmentInformation.Margin = new Padding(2, 1, 2, 1);
            btnDeleteEquipmentInformation.Name = "btnDeleteEquipmentInformation";
            btnDeleteEquipmentInformation.Size = new Size(207, 76);
            btnDeleteEquipmentInformation.TabIndex = 3;
            btnDeleteEquipmentInformation.Text = "Delete Equipment Information";
            btnDeleteEquipmentInformation.UseVisualStyleBackColor = false;
            btnDeleteEquipmentInformation.Click += btnDeleteEquipmentInformation_Click;
            // 
            // btnEditEquipmentInformation
            // 
            btnEditEquipmentInformation.BackColor = Color.FromArgb(187, 178, 169);
            btnEditEquipmentInformation.BackgroundImageLayout = ImageLayout.None;
            btnEditEquipmentInformation.FlatAppearance.BorderSize = 0;
            btnEditEquipmentInformation.FlatStyle = FlatStyle.Flat;
            btnEditEquipmentInformation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditEquipmentInformation.ForeColor = Color.Transparent;
            btnEditEquipmentInformation.Location = new Point(22, 220);
            btnEditEquipmentInformation.Margin = new Padding(2, 1, 2, 1);
            btnEditEquipmentInformation.Name = "btnEditEquipmentInformation";
            btnEditEquipmentInformation.Size = new Size(207, 76);
            btnEditEquipmentInformation.TabIndex = 2;
            btnEditEquipmentInformation.Text = "Edit Equipment Information";
            btnEditEquipmentInformation.UseVisualStyleBackColor = false;
            btnEditEquipmentInformation.Click += btnEditEquipmentInformation_Click;
            // 
            // btnAddNewEquipment
            // 
            btnAddNewEquipment.BackColor = Color.FromArgb(187, 178, 169);
            btnAddNewEquipment.BackgroundImageLayout = ImageLayout.None;
            btnAddNewEquipment.FlatAppearance.BorderSize = 0;
            btnAddNewEquipment.FlatStyle = FlatStyle.Flat;
            btnAddNewEquipment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewEquipment.ForeColor = Color.Transparent;
            btnAddNewEquipment.Location = new Point(22, 100);
            btnAddNewEquipment.Margin = new Padding(2, 1, 2, 1);
            btnAddNewEquipment.Name = "btnAddNewEquipment";
            btnAddNewEquipment.Size = new Size(207, 76);
            btnAddNewEquipment.TabIndex = 1;
            btnAddNewEquipment.Text = "Add New Equipment";
            btnAddNewEquipment.UseVisualStyleBackColor = false;
            btnAddNewEquipment.Click += btnAddNewEquipment_Click;
            // 
            // btnBack1
            // 
            btnBack1.BackColor = Color.FromArgb(139, 128, 116);
            btnBack1.FlatAppearance.BorderSize = 0;
            btnBack1.FlatStyle = FlatStyle.Flat;
            btnBack1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack1.ForeColor = Color.White;
            btnBack1.Location = new Point(22, 19);
            btnBack1.Name = "btnBack1";
            btnBack1.Size = new Size(207, 47);
            btnBack1.TabIndex = 24;
            btnBack1.Text = "Back";
            btnBack1.UseVisualStyleBackColor = false;
            btnBack1.Click += btnBack1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(877, 114);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 31;
            label4.Text = "Filter by User";
            // 
            // cmbUser
            // 
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(877, 137);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(151, 28);
            cmbUser.TabIndex = 32;
            // 
            // EquipmentInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(cmbUser);
            Controls.Add(label4);
            Controls.Add(pnlNavigation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbAvailabilityStatus);
            Controls.Add(btnFilter);
            Controls.Add(cmbEquipmentCategory);
            Controls.Add(cmbConditionStatus);
            Controls.Add(btnReset);
            Controls.Add(dgvEquipment);
            Controls.Add(lblEquipmentDashboard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EquipmentInformation";
            Text = "EquipmentDashboard";
            FormClosing += EquipmentDashboard_FormClosing;
            Load += EquipmentDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            pnlNavigation.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private DataGridView dgvEquipment;
        private Label lblEquipmentDashboard;
        private ComboBox cmbConditionStatus;
        private ComboBox cmbEquipmentCategory;
        private ComboBox cmbAvailabilityStatus;
        private Button btnFilter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel pnlNavigation;
        private Button btnDeleteEquipmentInformation;
        private Button btnEditEquipmentInformation;
        private Button btnAddNewEquipment;
        private Button btnBack1;
        private Label label4;
        private ComboBox cmbUser;
    }
}