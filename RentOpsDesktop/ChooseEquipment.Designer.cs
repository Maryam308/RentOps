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
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(592, 53);
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
            dgvEquipment.Location = new Point(91, 207);
            dgvEquipment.Margin = new Padding(6, 6, 6, 6);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersWidth = 62;
            dgvEquipment.Size = new Size(1592, 582);
            dgvEquipment.TabIndex = 87;
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
            btnNext.Location = new Point(1423, 830);
            btnNext.Margin = new Padding(6, 4, 6, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(303, 94);
            btnNext.TabIndex = 96;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // ChooseEquipment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1777, 977);
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
    }
}