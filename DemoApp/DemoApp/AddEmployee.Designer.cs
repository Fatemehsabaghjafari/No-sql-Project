namespace DemoApp
{
    partial class AddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.passwordCheck = new System.Windows.Forms.CheckBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.userTypeCombo = new System.Windows.Forms.ComboBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.locationCombo = new System.Windows.Forms.ComboBox();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.cancelUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New User";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type of user:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mai address:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone number:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Location brunch:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 598);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 37);
            this.label8.TabIndex = 7;
            this.label8.Text = "Send password?";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 598);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(450, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "Yes, a password e-mail will be sent to the user";
            // 
            // passwordCheck
            // 
            this.passwordCheck.Checked = true;
            this.passwordCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.passwordCheck.Location = new System.Drawing.Point(294, 596);
            this.passwordCheck.Name = "passwordCheck";
            this.passwordCheck.Size = new System.Drawing.Size(35, 37);
            this.passwordCheck.TabIndex = 9;
            this.passwordCheck.UseVisualStyleBackColor = true;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTxt.Location = new System.Drawing.Point(294, 252);
            this.firstNameTxt.Multiline = true;
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(454, 30);
            this.firstNameTxt.TabIndex = 13;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTxt.Location = new System.Drawing.Point(294, 307);
            this.lastNameTxt.Multiline = true;
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(454, 30);
            this.lastNameTxt.TabIndex = 11;
            // 
            // userTypeCombo
            // 
            this.userTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeCombo.FormattingEnabled = true;
            this.userTypeCombo.Location = new System.Drawing.Point(294, 363);
            this.userTypeCombo.Name = "userTypeCombo";
            this.userTypeCombo.Size = new System.Drawing.Size(454, 28);
            this.userTypeCombo.TabIndex = 13;
            this.userTypeCombo.Text = "Employee";
            // 
            // emailTxt
            // 
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxt.Location = new System.Drawing.Point(294, 421);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(454, 30);
            this.emailTxt.TabIndex = 14;
            // 
            // phoneTxt
            // 
            this.phoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTxt.Location = new System.Drawing.Point(294, 481);
            this.phoneTxt.Multiline = true;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(454, 30);
            this.phoneTxt.TabIndex = 15;
            // 
            // locationCombo
            // 
            this.locationCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationCombo.FormattingEnabled = true;
            this.locationCombo.Items.AddRange(new object[] {
            "Amsterdam",
            "Knuppeldam",
            "Headquarters (HQ)"});
            this.locationCombo.Location = new System.Drawing.Point(294, 542);
            this.locationCombo.Name = "locationCombo";
            this.locationCombo.Size = new System.Drawing.Size(454, 28);
            this.locationCombo.TabIndex = 16;
            this.locationCombo.Text = "Haarlem";
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addUserBtn.Location = new System.Drawing.Point(558, 681);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(190, 57);
            this.addUserBtn.TabIndex = 17;
            this.addUserBtn.Text = "ADD USER";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // cancelUserBtn
            // 
            this.cancelUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancelUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelUserBtn.Location = new System.Drawing.Point(294, 681);
            this.cancelUserBtn.Name = "cancelUserBtn";
            this.cancelUserBtn.Size = new System.Drawing.Size(186, 57);
            this.cancelUserBtn.TabIndex = 18;
            this.cancelUserBtn.Text = "CANCEL";
            this.cancelUserBtn.UseVisualStyleBackColor = false;
            this.cancelUserBtn.Click += new System.EventHandler(this.cancelUserBtn_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 774);
            this.Controls.Add(this.cancelUserBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.locationCombo);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.userTypeCombo);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.passwordCheck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "Haarlem";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox passwordCheck;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.ComboBox userTypeCombo;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.ComboBox locationCombo;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button cancelUserBtn;
    }
}

     