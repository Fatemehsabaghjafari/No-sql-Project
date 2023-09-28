using System.Windows.Forms;

namespace DemoApp
{
    partial class SignUp
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
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.confirmTextbox = new System.Windows.Forms.TextBox();
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loginFromSignupBtn = new System.Windows.Forms.Button();
            this.regularEmployeeRadiobtn = new System.Windows.Forms.RadioButton();
            this.servicedeskEmployeeRadiobtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(390, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(262, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(262, 558);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(83, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(262, 639);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(262, 730);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.AllowDrop = true;
            this.firstnameTextbox.Location = new System.Drawing.Point(266, 256);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(360, 26);
            this.firstnameTextbox.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(262, 581);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(360, 26);
            this.usernameTextBox.TabIndex = 6;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(262, 662);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(360, 26);
            this.passwordTextbox.TabIndex = 7;
            // 
            // confirmTextbox
            // 
            this.confirmTextbox.Location = new System.Drawing.Point(258, 753);
            this.confirmTextbox.Name = "confirmTextbox";
            this.confirmTextbox.Size = new System.Drawing.Size(360, 26);
            this.confirmTextbox.TabIndex = 8;
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.SignUpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbtn.Location = new System.Drawing.Point(366, 819);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(164, 54);
            this.SignUpbtn.TabIndex = 9;
            this.SignUpbtn.Text = "Sign Up";
            this.SignUpbtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(328, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Create a new account";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(245, 899);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "Already have an account?";
            // 
            // loginFromSignupBtn
            // 
            this.loginFromSignupBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginFromSignupBtn.FlatAppearance.BorderSize = 0;
            this.loginFromSignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginFromSignupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFromSignupBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.loginFromSignupBtn.Location = new System.Drawing.Point(495, 889);
            this.loginFromSignupBtn.Margin = new System.Windows.Forms.Padding(0);
            this.loginFromSignupBtn.Name = "loginFromSignupBtn";
            this.loginFromSignupBtn.Size = new System.Drawing.Size(107, 45);
            this.loginFromSignupBtn.TabIndex = 12;
            this.loginFromSignupBtn.Text = "Log in";
            this.loginFromSignupBtn.UseVisualStyleBackColor = false;
            this.loginFromSignupBtn.Click += new System.EventHandler(this.loginFromSignupBtn_Click);
            // 
            // regularEmployeeRadiobtn
            // 
            this.regularEmployeeRadiobtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regularEmployeeRadiobtn.Location = new System.Drawing.Point(262, 412);
            this.regularEmployeeRadiobtn.Name = "regularEmployeeRadiobtn";
            this.regularEmployeeRadiobtn.Size = new System.Drawing.Size(179, 43);
            this.regularEmployeeRadiobtn.TabIndex = 13;
            this.regularEmployeeRadiobtn.TabStop = true;
            this.regularEmployeeRadiobtn.Text = "Regular Employee";
            this.regularEmployeeRadiobtn.UseVisualStyleBackColor = true;
            // 
            // servicedeskEmployeeRadiobtn
            // 
            this.servicedeskEmployeeRadiobtn.AutoSize = true;
            this.servicedeskEmployeeRadiobtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.servicedeskEmployeeRadiobtn.Location = new System.Drawing.Point(427, 421);
            this.servicedeskEmployeeRadiobtn.Name = "servicedeskEmployeeRadiobtn";
            this.servicedeskEmployeeRadiobtn.Size = new System.Drawing.Size(197, 24);
            this.servicedeskEmployeeRadiobtn.TabIndex = 14;
            this.servicedeskEmployeeRadiobtn.TabStop = true;
            this.servicedeskEmployeeRadiobtn.Text = "ServiceDesk Employee";
            this.servicedeskEmployeeRadiobtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(262, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Select your role";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 26);
            this.textBox1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(262, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Last Name";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(264, 497);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(360, 26);
            this.emailTextbox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(262, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "First Name";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(932, 1038);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.servicedeskEmployeeRadiobtn);
            this.Controls.Add(this.regularEmployeeRadiobtn);
            this.Controls.Add(this.loginFromSignupBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.confirmTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.firstnameTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox confirmTextbox;
        private System.Windows.Forms.Button SignUpbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loginFromSignupBtn;
        private RadioButton regularEmployeeRadiobtn;
        private RadioButton servicedeskEmployeeRadiobtn;
        private Label label7;
        private TextBox textBox1;
        private Label label8;
        private TextBox emailTextbox;
        private Label label9;
    }
}

    
