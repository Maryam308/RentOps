namespace RentOpsDesktop
{
    partial class ChooseEquipment
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
            lblTitle = new Label();
            dgvEquipment = new DataGridView();
            button1 = new Button();
            btnNext = new Button();
            label1 = new Label();
            cmbEquipmentCategory = new ComboBox();
            btnFilter = new Button();
            label2 = new Label();
            cmbConditionStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(592, 33);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(691, 100);
            lblTitle.TabIndex = 86;
            lblTitle.Text = "Choose Equipment";
            // 
            // dgvEquipment
            // 
            dgvEquipment.BackgroundColor = Color.WhiteSmoke;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Location = new Point(138, 292);
            dgvEquipment.Margin = new Padding(6);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersWidth = 62;
            dgvEquipment.Size = new Size(1567, 538);
            dgvEquipment.TabIndex = 87;
            dgvEquipment.CellContentClick += dgvEquipment_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(139, 128, 116);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(52, 53);
            button1.Margin = new Padding(6, 4, 6, 4);
            button1.Name = "button1";
            button1.Size = new Size(288, 94);
            button1.TabIndex = 97;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(121, 86, 76);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(1437, 859);
            btnNext.Margin = new Padding(6, 4, 6, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(303, 94);
            btnNext.TabIndex = 96;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(986, 179);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 99;
            label1.Text = "Category";
            // 
            // cmbEquipmentCategory
            // 
            cmbEquipmentCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipmentCategory.FormattingEnabled = true;
            cmbEquipmentCategory.Location = new Point(981, 218);
            cmbEquipmentCategory.Margin = new Padding(6, 4, 6, 4);
            cmbEquipmentCategory.Name = "cmbEquipmentCategory";
            cmbEquipmentCategory.Size = new Size(219, 40);
            cmbEquipmentCategory.TabIndex = 98;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(121, 86, 76);
            btnFilter.BackgroundImageLayout = ImageLayout.None;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            btnFilter.ForeColor = Color.FromArgb(241, 240, 234);
            btnFilter.Location = new Point(1504, 179);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(201, 83);
            btnFilter.TabIndex = 102;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1246, 179);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 104;
            label2.Text = "Condition Status";
            // 
            // cmbConditionStatus
            // 
            cmbConditionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConditionStatus.FormattingEnabled = true;
            cmbConditionStatus.Location = new Point(1239, 218);
            cmbConditionStatus.Margin = new Padding(6, 4, 6, 4);
            cmbConditionStatus.Name = "cmbConditionStatus";
            cmbConditionStatus.Size = new Size(219, 40);
            cmbConditionStatus.TabIndex = 103;
            // 
            // ChooseEquipment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1777, 977);
            Controls.Add(label2);
            Controls.Add(cmbConditionStatus);
            Controls.Add(btnFilter);
            Controls.Add(label1);
            Controls.Add(cmbEquipmentCategory);
            Controls.Add(button1);
            Controls.Add(btnNext);
            Controls.Add(dgvEquipment);
            Controls.Add(lblTitle);
            Margin = new Padding(6, 4, 6, 4);
            Name = "ChooseEquipment";
            Text = "ChooseEquipment";
            Load += ChooseEquipment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvEquipment;
        private Button button1;
        private Button btnNext;
        private Label label1;
        private ComboBox cmbEquipmentCategory;
        private Button btnFilter;
        private Label label2;
        private ComboBox cmbConditionStatus;
    }
}