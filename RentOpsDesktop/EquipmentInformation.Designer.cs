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
            button1 = new Button();
            btnSelectRecord = new Button();
            btnEditEquipmentInformation = new Button();
            btnAddNewEquipment = new Button();
            btnBack1 = new Button();
            label4 = new Label();
            cmbUser = new ComboBox();
            btnSearch = new Button();
            label5 = new Label();
            txtEquipID = new TextBox();
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
            btnReset.Location = new Point(1519, 45);
            btnReset.Margin = new Padding(0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(201, 83);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dgvEquipment
            // 
            dgvEquipment.BackgroundColor = Color.WhiteSmoke;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Location = new Point(448, 401);
            dgvEquipment.Margin = new Padding(6);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersWidth = 51;
            dgvEquipment.Size = new Size(1244, 529);
            dgvEquipment.TabIndex = 20;
            // 
            // lblEquipmentDashboard
            // 
            lblEquipmentDashboard.AutoSize = true;
            lblEquipmentDashboard.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblEquipmentDashboard.ForeColor = Color.FromArgb(135, 66, 62);
            lblEquipmentDashboard.Location = new Point(464, 38);
            lblEquipmentDashboard.Margin = new Padding(6, 0, 6, 0);
            lblEquipmentDashboard.Name = "lblEquipmentDashboard";
            lblEquipmentDashboard.Size = new Size(700, 82);
            lblEquipmentDashboard.TabIndex = 17;
            lblEquipmentDashboard.Text = "Equipment Information";
            lblEquipmentDashboard.Click += lblRentalDashboard_Click;
            // 
            // cmbConditionStatus
            // 
            cmbConditionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConditionStatus.FormattingEnabled = true;
            cmbConditionStatus.Location = new Point(730, 316);
            cmbConditionStatus.Margin = new Padding(6, 4, 6, 4);
            cmbConditionStatus.Name = "cmbConditionStatus";
            cmbConditionStatus.Size = new Size(219, 40);
            cmbConditionStatus.TabIndex = 24;
            // 
            // cmbEquipmentCategory
            // 
            cmbEquipmentCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipmentCategory.FormattingEnabled = true;
            cmbEquipmentCategory.Location = new Point(470, 316);
            cmbEquipmentCategory.Margin = new Padding(6, 4, 6, 4);
            cmbEquipmentCategory.Name = "cmbEquipmentCategory";
            cmbEquipmentCategory.Size = new Size(219, 40);
            cmbEquipmentCategory.TabIndex = 25;
            // 
            // cmbAvailabilityStatus
            // 
            cmbAvailabilityStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailabilityStatus.FormattingEnabled = true;
            cmbAvailabilityStatus.Location = new Point(990, 316);
            cmbAvailabilityStatus.Margin = new Padding(6, 4, 6, 4);
            cmbAvailabilityStatus.Name = "cmbAvailabilityStatus";
            cmbAvailabilityStatus.Size = new Size(219, 40);
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
            btnFilter.Location = new Point(1519, 279);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(201, 83);
            btnFilter.TabIndex = 26;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 277);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 27;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(737, 277);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 28;
            label2.Text = "Condition Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(995, 277);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 32);
            label3.TabIndex = 29;
            label3.Text = "Availability Status";
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = Color.FromArgb(187, 178, 169);
            pnlNavigation.BackgroundImageLayout = ImageLayout.None;
            pnlNavigation.Controls.Add(button1);
            pnlNavigation.Controls.Add(btnSelectRecord);
            pnlNavigation.Controls.Add(btnEditEquipmentInformation);
            pnlNavigation.Controls.Add(btnAddNewEquipment);
            pnlNavigation.Controls.Add(btnBack1);
            pnlNavigation.Location = new Point(0, 2);
            pnlNavigation.Margin = new Padding(4, 2, 4, 2);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(399, 977);
            pnlNavigation.TabIndex = 30;
            pnlNavigation.Paint += pnlNavigation_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(187, 178, 169);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(41, 541);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(336, 122);
            button1.TabIndex = 26;
            button1.Text = "Delete Equipment Information";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSelectRecord
            // 
            btnSelectRecord.BackColor = Color.FromArgb(187, 178, 169);
            btnSelectRecord.BackgroundImageLayout = ImageLayout.None;
            btnSelectRecord.FlatAppearance.BorderSize = 0;
            btnSelectRecord.FlatStyle = FlatStyle.Flat;
            btnSelectRecord.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            btnSelectRecord.ForeColor = Color.White;
            btnSelectRecord.Location = new Point(4, 307);
            btnSelectRecord.Margin = new Padding(6, 4, 6, 4);
            btnSelectRecord.Name = "btnSelectRecord";
            btnSelectRecord.Size = new Size(373, 81);
            btnSelectRecord.TabIndex = 25;
            btnSelectRecord.Text = "Select a record to:";
            btnSelectRecord.UseVisualStyleBackColor = false;
            // 
            // btnEditEquipmentInformation
            // 
            btnEditEquipmentInformation.BackColor = Color.FromArgb(187, 178, 169);
            btnEditEquipmentInformation.BackgroundImageLayout = ImageLayout.None;
            btnEditEquipmentInformation.FlatAppearance.BorderSize = 0;
            btnEditEquipmentInformation.FlatStyle = FlatStyle.Flat;
            btnEditEquipmentInformation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditEquipmentInformation.ForeColor = Color.Transparent;
            btnEditEquipmentInformation.Location = new Point(43, 397);
            btnEditEquipmentInformation.Margin = new Padding(4, 2, 4, 2);
            btnEditEquipmentInformation.Name = "btnEditEquipmentInformation";
            btnEditEquipmentInformation.Size = new Size(336, 122);
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
            btnAddNewEquipment.Location = new Point(35, 160);
            btnAddNewEquipment.Margin = new Padding(4, 2, 4, 2);
            btnAddNewEquipment.Name = "btnAddNewEquipment";
            btnAddNewEquipment.Size = new Size(336, 122);
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
            btnBack1.Location = new Point(35, 30);
            btnBack1.Margin = new Padding(6, 4, 6, 4);
            btnBack1.Name = "btnBack1";
            btnBack1.Size = new Size(336, 75);
            btnBack1.TabIndex = 24;
            btnBack1.Text = "Back";
            btnBack1.UseVisualStyleBackColor = false;
            btnBack1.Click += btnBack1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1257, 277);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 32);
            label4.TabIndex = 31;
            label4.Text = "User";
            // 
            // cmbUser
            // 
            cmbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(1250, 316);
            cmbUser.Margin = new Padding(6, 4, 6, 4);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(219, 40);
            cmbUser.TabIndex = 32;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(121, 86, 76);
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnSearch.ForeColor = Color.FromArgb(241, 240, 234);
            btnSearch.Location = new Point(1519, 160);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(201, 83);
            btnSearch.TabIndex = 33;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1255, 157);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 32);
            label5.TabIndex = 39;
            label5.Text = "Equipment ID";
            // 
            // txtEquipID
            // 
            txtEquipID.BorderStyle = BorderStyle.FixedSingle;
            txtEquipID.Location = new Point(1250, 204);
            txtEquipID.Margin = new Padding(6, 4, 6, 4);
            txtEquipID.Name = "txtEquipID";
            txtEquipID.Size = new Size(219, 39);
            txtEquipID.TabIndex = 38;
            // 
            // EquipmentInformation
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 977);
            Controls.Add(label5);
            Controls.Add(txtEquipID);
            Controls.Add(btnSearch);
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
            Margin = new Padding(6);
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
        private Button btnSearch;
        private Label label5;
        private TextBox txtEquipID;
        private Button btnSelectRecord;
        private Button button1;
    }
}