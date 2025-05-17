namespace RentOpsDesktop
{
    partial class LogDetails
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
            btnBack = new Button();
            lblAuditLog = new Label();
            label1 = new Label();
            pnlLogDetails = new Panel();
            lblSource = new Label();
            lblLogType = new Label();
            lblLogTimestamp = new Label();
            lblLogID = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            lblUserName = new Label();
            lblUserID = new Label();
            label13 = new Label();
            label14 = new Label();
            panel2 = new Panel();
            lblException = new Label();
            label7 = new Label();
            AffectedData = new Label();
            lblUserAction = new Label();
            label9 = new Label();
            lblCurrentValue = new Label();
            lblOriginalValue = new Label();
            label15 = new Label();
            label16 = new Label();
            label8 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            pnlLogDetails.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(121, 86, 76);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(22, 23);
            btnBack.Margin = new Padding(6, 4, 6, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(288, 94);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblAuditLog
            // 
            lblAuditLog.AutoSize = true;
            lblAuditLog.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0, true);
            lblAuditLog.ForeColor = Color.FromArgb(135, 66, 62);
            lblAuditLog.Location = new Point(685, 28);
            lblAuditLog.Margin = new Padding(6, 0, 6, 0);
            lblAuditLog.Name = "lblAuditLog";
            lblAuditLog.Size = new Size(530, 82);
            lblAuditLog.TabIndex = 14;
            lblAuditLog.Text = "Audit Log Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 41);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 51);
            label1.TabIndex = 16;
            label1.Text = "Log ID";
            // 
            // pnlLogDetails
            // 
            pnlLogDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlLogDetails.Controls.Add(lblSource);
            pnlLogDetails.Controls.Add(lblLogType);
            pnlLogDetails.Controls.Add(lblLogTimestamp);
            pnlLogDetails.Controls.Add(lblLogID);
            pnlLogDetails.Controls.Add(label5);
            pnlLogDetails.Controls.Add(label4);
            pnlLogDetails.Controls.Add(label3);
            pnlLogDetails.Controls.Add(label1);
            pnlLogDetails.Location = new Point(74, 230);
            pnlLogDetails.Margin = new Padding(6, 6, 6, 6);
            pnlLogDetails.Name = "pnlLogDetails";
            pnlLogDetails.Size = new Size(368, 689);
            pnlLogDetails.TabIndex = 17;
            // 
            // lblSource
            // 
            lblSource.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSource.Location = new Point(33, 538);
            lblSource.Margin = new Padding(6, 0, 6, 0);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(305, 45);
            lblSource.TabIndex = 23;
            lblSource.Text = "xx-xx-xx-xx-xx";
            lblSource.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogType
            // 
            lblLogType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogType.Location = new Point(33, 395);
            lblLogType.Margin = new Padding(6, 0, 6, 0);
            lblLogType.Name = "lblLogType";
            lblLogType.Size = new Size(305, 45);
            lblLogType.TabIndex = 22;
            lblLogType.Text = "xx-xx-xx-xx-xx";
            lblLogType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogTimestamp
            // 
            lblLogTimestamp.AutoSize = true;
            lblLogTimestamp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogTimestamp.Location = new Point(33, 241);
            lblLogTimestamp.Margin = new Padding(6, 0, 6, 0);
            lblLogTimestamp.Name = "lblLogTimestamp";
            lblLogTimestamp.Size = new Size(351, 45);
            lblLogTimestamp.TabIndex = 21;
            lblLogTimestamp.Text = "xx-xx-xx-xx-xx-xx-xx-xx";
            lblLogTimestamp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogID
            // 
            lblLogID.AutoSize = true;
            lblLogID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogID.Location = new Point(202, 41);
            lblLogID.Margin = new Padding(6, 0, 6, 0);
            lblLogID.Name = "lblLogID";
            lblLogID.Size = new Size(50, 45);
            lblLogID.TabIndex = 20;
            lblLogID.Text = "xx";
            lblLogID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(119, 478);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 51);
            label5.TabIndex = 19;
            label5.Text = "Source";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(102, 322);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 51);
            label4.TabIndex = 18;
            label4.Text = "Log Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 162);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(289, 51);
            label3.TabIndex = 17;
            label3.Text = "Log Timestamp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label2.Location = new Point(150, 149);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 51);
            label2.TabIndex = 17;
            label2.Text = "Log Details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label6.Location = new Point(535, 149);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(238, 51);
            label6.TabIndex = 18;
            label6.Text = "User Details";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(lblUserID);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Location = new Point(494, 230);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 689);
            panel1.TabIndex = 19;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(45, 316);
            lblUserName.Margin = new Padding(6, 0, 6, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(222, 45);
            lblUserName.TabIndex = 21;
            lblUserName.Text = "xx-xx-xx-xx-xx";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(111, 132);
            lblUserID.Margin = new Padding(6, 0, 6, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(50, 45);
            lblUserID.TabIndex = 20;
            lblUserID.Text = "xx";
            lblUserID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(39, 235);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(212, 51);
            label13.TabIndex = 17;
            label13.Text = "User Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(69, 66);
            label14.Margin = new Padding(6, 0, 6, 0);
            label14.Name = "label14";
            label14.Size = new Size(147, 51);
            label14.TabIndex = 16;
            label14.Text = "User ID";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblException);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(AffectedData);
            panel2.Controls.Add(lblUserAction);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lblCurrentValue);
            panel2.Controls.Add(lblOriginalValue);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label18);
            panel2.Location = new Point(825, 230);
            panel2.Margin = new Padding(6, 6, 6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(866, 689);
            panel2.TabIndex = 20;
            // 
            // lblException
            // 
            lblException.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblException.Location = new Point(312, 567);
            lblException.Margin = new Padding(6, 0, 6, 0);
            lblException.Name = "lblException";
            lblException.Size = new Size(490, 100);
            lblException.TabIndex = 25;
            lblException.Text = "None";
            lblException.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(93, 567);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(191, 51);
            label7.TabIndex = 24;
            label7.Text = "Exception";
            // 
            // AffectedData
            // 
            AffectedData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AffectedData.Location = new Point(431, 444);
            AffectedData.Margin = new Padding(6, 0, 6, 0);
            AffectedData.Name = "AffectedData";
            AffectedData.Size = new Size(370, 102);
            AffectedData.TabIndex = 23;
            AffectedData.Text = "No Data";
            AffectedData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserAction
            // 
            lblUserAction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserAction.Location = new Point(41, 444);
            lblUserAction.Margin = new Padding(6, 0, 6, 0);
            lblUserAction.Name = "lblUserAction";
            lblUserAction.Size = new Size(370, 102);
            lblUserAction.TabIndex = 22;
            lblUserAction.Text = "No Data";
            lblUserAction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(41, 132);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(347, 209);
            label9.TabIndex = 21;
            label9.Text = "No Data ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentValue
            // 
            lblCurrentValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentValue.Location = new Point(41, 132);
            lblCurrentValue.Margin = new Padding(6, 0, 6, 0);
            lblCurrentValue.Name = "lblCurrentValue";
            lblCurrentValue.Size = new Size(347, 209);
            lblCurrentValue.TabIndex = 21;
            lblCurrentValue.Text = "xx-xx-xx-xx-xx";
            lblCurrentValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOriginalValue
            // 
            lblOriginalValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOriginalValue.Location = new Point(455, 132);
            lblOriginalValue.Margin = new Padding(6, 0, 6, 0);
            lblOriginalValue.Name = "lblOriginalValue";
            lblOriginalValue.Size = new Size(347, 209);
            lblOriginalValue.TabIndex = 20;
            lblOriginalValue.Text = "No Data";
            lblOriginalValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(492, 390);
            label15.Margin = new Padding(6, 0, 6, 0);
            label15.Name = "label15";
            label15.Size = new Size(260, 51);
            label15.TabIndex = 19;
            label15.Text = "Affected Data";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(123, 390);
            label16.Margin = new Padding(6, 0, 6, 0);
            label16.Name = "label16";
            label16.Size = new Size(222, 51);
            label16.TabIndex = 18;
            label16.Text = "User Action";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(91, 41);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(263, 51);
            label8.TabIndex = 16;
            label8.Text = "Original Value";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(509, 41);
            label17.Margin = new Padding(6, 0, 6, 0);
            label17.Name = "label17";
            label17.Size = new Size(255, 51);
            label17.TabIndex = 17;
            label17.Text = "Current Value";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(97, 41);
            label18.Margin = new Padding(6, 0, 6, 0);
            label18.Name = "label18";
            label18.Size = new Size(263, 51);
            label18.TabIndex = 16;
            label18.Text = "Original Value";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label19.Location = new Point(1055, 149);
            label19.Margin = new Padding(6, 0, 6, 0);
            label19.Name = "label19";
            label19.Size = new Size(397, 51);
            label19.TabIndex = 21;
            label19.Text = "Action Affected Data";
            // 
            // LogDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 977);
            Controls.Add(label19);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pnlLogDetails);
            Controls.Add(btnBack);
            Controls.Add(lblAuditLog);
            Margin = new Padding(6, 6, 6, 6);
            Name = "LogDetails";
            Text = "LogDetails";
            Load += LogDetails_Load;
            pnlLogDetails.ResumeLayout(false);
            pnlLogDetails.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblAuditLog;
        private Label label1;
        private Panel pnlLogDetails;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblSource;
        private Label lblLogType;
        private Label lblLogTimestamp;
        private Label lblLogID;
        private Label label6;
        private Panel panel1;
        private Label lblUserName;
        private Label lblUserID;
        private Label label13;
        private Label label14;
        private Panel panel2;
        private Label AffectedData;
        private Label lblUserAction;
        private Label lblCurrentValue;
        private Label lblOriginalValue;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label lblException;
        private Label label7;
        private Label label9;
        private Label label8;
    }
}