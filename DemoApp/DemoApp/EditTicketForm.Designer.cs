namespace DemoApp
{
    partial class EditTicketForm
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
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.EditDeadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesBtn.Location = new System.Drawing.Point(97, 330);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(132, 51);
            this.SaveChangesBtn.TabIndex = 0;
            this.SaveChangesBtn.Text = "Save Changes";
            this.SaveChangesBtn.UseVisualStyleBackColor = false;
            this.SaveChangesBtn.Click += new System.EventHandler(this.SaveChangesBtn_Click_1);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(97, 67);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(191, 22);
            this.subjectTextBox.TabIndex = 1;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(97, 138);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(191, 22);
            this.userTextBox.TabIndex = 4;
            // 
            // EditDeadlinePicker
            // 
            this.EditDeadlinePicker.Location = new System.Drawing.Point(97, 201);
            this.EditDeadlinePicker.Name = "EditDeadlinePicker";
            this.EditDeadlinePicker.Size = new System.Drawing.Size(200, 22);
            this.EditDeadlinePicker.TabIndex = 18;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(97, 273);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 24);
            this.statusComboBox.TabIndex = 19;
            // 
            // EditTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 418);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.EditDeadlinePicker);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.SaveChangesBtn);
            this.Name = "EditTicketForm";
            this.Text = "EditTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveChangesBtn;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.DateTimePicker EditDeadlinePicker;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}