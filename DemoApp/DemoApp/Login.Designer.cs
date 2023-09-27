namespace DemoApp
{
    partial class Login
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
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.confirmTextbox = new System.Windows.Forms.TextBox();
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(450, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(351, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(351, 361);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(83, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(351, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(351, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(355, 275);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(359, 26);
            this.emailTextbox.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(355, 393);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(359, 26);
            this.usernameTextBox.TabIndex = 6;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(355, 505);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(359, 26);
            this.passwordTextbox.TabIndex = 7;
            // 
            // confirmTextbox
            // 
            this.confirmTextbox.Location = new System.Drawing.Point(355, 617);
            this.confirmTextbox.Name = "confirmTextbox";
            this.confirmTextbox.Size = new System.Drawing.Size(359, 26);
            this.confirmTextbox.TabIndex = 8;
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.SignUpbtn.Location = new System.Drawing.Point(473, 704);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(124, 46);
            this.SignUpbtn.TabIndex = 9;
            this.SignUpbtn.Text = "Sign Up";
            this.SignUpbtn.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 886);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.confirmTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox confirmTextbox;
        private System.Windows.Forms.Button SignUpbtn;
    }
}