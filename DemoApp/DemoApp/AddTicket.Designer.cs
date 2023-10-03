namespace DemoApp
{
    partial class AddTicket
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
            this.IncidentSubjectTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SubmitTicketBtn = new System.Windows.Forms.Button();
            this.IncidentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IncidentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.UserIncidentComboBox = new System.Windows.Forms.ComboBox();
            this.IncidentPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.IncidentDeadlineComboBox = new System.Windows.Forms.ComboBox();
            this.IncidentDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IncidentSubjectTxtBox
            // 
            this.IncidentSubjectTxtBox.Location = new System.Drawing.Point(190, 117);
            this.IncidentSubjectTxtBox.Name = "IncidentSubjectTxtBox";
            this.IncidentSubjectTxtBox.Size = new System.Drawing.Size(100, 22);
            this.IncidentSubjectTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create new incident ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date/time reported: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject of incident";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type of incident: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reported by user: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Priority: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Deadline/follow up: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Description: ";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(190, 407);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(110, 35);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "CANCEL";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SubmitTicketBtn
            // 
            this.SubmitTicketBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubmitTicketBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SubmitTicketBtn.Location = new System.Drawing.Point(326, 407);
            this.SubmitTicketBtn.Name = "SubmitTicketBtn";
            this.SubmitTicketBtn.Size = new System.Drawing.Size(161, 35);
            this.SubmitTicketBtn.TabIndex = 10;
            this.SubmitTicketBtn.Text = "SUBMIT TICKET";
            this.SubmitTicketBtn.UseVisualStyleBackColor = false;
            this.SubmitTicketBtn.Click += new System.EventHandler(this.SubmitTicketBtn_Click);
            // 
            // IncidentDateTimePicker
            // 
            this.IncidentDateTimePicker.Location = new System.Drawing.Point(190, 71);
            this.IncidentDateTimePicker.Name = "IncidentDateTimePicker";
            this.IncidentDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.IncidentDateTimePicker.TabIndex = 11;
            // 
            // IncidentTypeComboBox
            // 
            this.IncidentTypeComboBox.FormattingEnabled = true;
            this.IncidentTypeComboBox.Items.AddRange(new object[] {
            "Software",
            "Hardware"});
            this.IncidentTypeComboBox.Location = new System.Drawing.Point(190, 154);
            this.IncidentTypeComboBox.Name = "IncidentTypeComboBox";
            this.IncidentTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.IncidentTypeComboBox.TabIndex = 12;
            // 
            // UserIncidentComboBox
            // 
            this.UserIncidentComboBox.FormattingEnabled = true;
            this.UserIncidentComboBox.Location = new System.Drawing.Point(190, 203);
            this.UserIncidentComboBox.Name = "UserIncidentComboBox";
            this.UserIncidentComboBox.Size = new System.Drawing.Size(121, 24);
            this.UserIncidentComboBox.TabIndex = 13;
            // 
            // IncidentPriorityComboBox
            // 
            this.IncidentPriorityComboBox.AllowDrop = true;
            this.IncidentPriorityComboBox.FormattingEnabled = true;
            this.IncidentPriorityComboBox.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.IncidentPriorityComboBox.Location = new System.Drawing.Point(190, 244);
            this.IncidentPriorityComboBox.Name = "IncidentPriorityComboBox";
            this.IncidentPriorityComboBox.Size = new System.Drawing.Size(121, 24);
            this.IncidentPriorityComboBox.TabIndex = 14;
            // 
            // IncidentDeadlineComboBox
            // 
            this.IncidentDeadlineComboBox.FormattingEnabled = true;
            this.IncidentDeadlineComboBox.Items.AddRange(new object[] {
            "1 Day",
            "2 Days",
            "3 Days",
            "4 Days",
            "5 Days",
            "6 Days",
            "7 Days"});
            this.IncidentDeadlineComboBox.Location = new System.Drawing.Point(190, 296);
            this.IncidentDeadlineComboBox.Name = "IncidentDeadlineComboBox";
            this.IncidentDeadlineComboBox.Size = new System.Drawing.Size(121, 24);
            this.IncidentDeadlineComboBox.TabIndex = 15;
            // 
            // IncidentDescriptionTxtBox
            // 
            this.IncidentDescriptionTxtBox.Location = new System.Drawing.Point(190, 341);
            this.IncidentDescriptionTxtBox.Name = "IncidentDescriptionTxtBox";
            this.IncidentDescriptionTxtBox.Size = new System.Drawing.Size(218, 22);
            this.IncidentDescriptionTxtBox.TabIndex = 16;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 485);
            this.Controls.Add(this.IncidentDescriptionTxtBox);
            this.Controls.Add(this.IncidentDeadlineComboBox);
            this.Controls.Add(this.IncidentPriorityComboBox);
            this.Controls.Add(this.UserIncidentComboBox);
            this.Controls.Add(this.IncidentTypeComboBox);
            this.Controls.Add(this.IncidentDateTimePicker);
            this.Controls.Add(this.SubmitTicketBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncidentSubjectTxtBox);
            this.Name = "AddTicket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.AddTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IncidentSubjectTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SubmitTicketBtn;
        private System.Windows.Forms.DateTimePicker IncidentDateTimePicker;
        private System.Windows.Forms.ComboBox IncidentTypeComboBox;
        private System.Windows.Forms.ComboBox UserIncidentComboBox;
        private System.Windows.Forms.ComboBox IncidentPriorityComboBox;
        private System.Windows.Forms.ComboBox IncidentDeadlineComboBox;
        private System.Windows.Forms.TextBox IncidentDescriptionTxtBox;
    }
}