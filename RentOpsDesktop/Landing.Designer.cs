namespace RentOpsDesktop
{
    partial class Landing
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 48.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(135, 66, 62);
            lblTitle.Location = new Point(586, 210);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(368, 108);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "RentOps";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(135, 66, 62);
            label1.Location = new Point(541, 354);
            label1.Name = "label1";
            label1.Size = new Size(463, 37);
            label1.TabIndex = 1;
            label1.Text = " RentOps, the Smarter Way to Equip.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rentOpsLogo;
            pictureBox1.Location = new Point(69, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 611);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "Landing";
            Text = "Landing";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private PictureBox pictureBox1;
    }
}