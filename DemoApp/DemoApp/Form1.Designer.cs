
namespace DemoApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DashboarBtn = new System.Windows.Forms.Button();
            this.IncidentManagementBtn = new System.Windows.Forms.Button();
            this.UserManagementBtn = new System.Windows.Forms.Button();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AllTicketslbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.OpenTicketlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bar1 = new CircularProgressBar.CircularProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Bar2 = new CircularProgressBar.CircularProgressBar();
            this.TicketViewBtn = new System.Windows.Forms.Button();
            this.Incidentlbl = new System.Windows.Forms.Label();
            this.IncidentViewPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TicketslistView = new System.Windows.Forms.ListView();
            this.AddIncidentBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UserViewPanel = new System.Windows.Forms.Panel();
            this.UserlistView = new System.Windows.Forms.ListView();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.FindbyEmailtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DashboardPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.IncidentViewPanel.SuspendLayout();
            this.UserViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(751, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Desk";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // DashboarBtn
            // 
            this.DashboarBtn.Location = new System.Drawing.Point(9, 102);
            this.DashboarBtn.Name = "DashboarBtn";
            this.DashboarBtn.Size = new System.Drawing.Size(348, 40);
            this.DashboarBtn.TabIndex = 3;
            this.DashboarBtn.Text = "Dashboard";
            this.DashboarBtn.UseVisualStyleBackColor = true;
            this.DashboarBtn.Click += new System.EventHandler(this.DashboarBtn_Click);
            // 
            // IncidentManagementBtn
            // 
            this.IncidentManagementBtn.Location = new System.Drawing.Point(357, 102);
            this.IncidentManagementBtn.Name = "IncidentManagementBtn";
            this.IncidentManagementBtn.Size = new System.Drawing.Size(336, 40);
            this.IncidentManagementBtn.TabIndex = 4;
            this.IncidentManagementBtn.Text = "Incident Management";
            this.IncidentManagementBtn.UseVisualStyleBackColor = true;
            this.IncidentManagementBtn.Click += new System.EventHandler(this.IncidentManagementBtn_Click);
            // 
            // UserManagementBtn
            // 
            this.UserManagementBtn.Location = new System.Drawing.Point(692, 102);
            this.UserManagementBtn.Name = "UserManagementBtn";
            this.UserManagementBtn.Size = new System.Drawing.Size(346, 40);
            this.UserManagementBtn.TabIndex = 5;
            this.UserManagementBtn.Text = "User Management";
            this.UserManagementBtn.UseVisualStyleBackColor = true;
            this.UserManagementBtn.Click += new System.EventHandler(this.UserManagementBtn_Click);
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DashboardPanel.Controls.Add(this.groupBox2);
            this.DashboardPanel.Controls.Add(this.groupBox1);
            this.DashboardPanel.Controls.Add(this.TicketViewBtn);
            this.DashboardPanel.Controls.Add(this.Incidentlbl);
            this.DashboardPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DashboardPanel.Location = new System.Drawing.Point(9, 148);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1039, 670);
            this.DashboardPanel.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.AllTicketslbl);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.OpenTicketlbl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Bar1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(48, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 463);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // AllTicketslbl
            // 
            this.AllTicketslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTicketslbl.Location = new System.Drawing.Point(212, 261);
            this.AllTicketslbl.Name = "AllTicketslbl";
            this.AllTicketslbl.Size = new System.Drawing.Size(47, 63);
            this.AllTicketslbl.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(169, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 63);
            this.label10.TabIndex = 16;
            this.label10.Text = "/";
            // 
            // OpenTicketlbl
            // 
            this.OpenTicketlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTicketlbl.Location = new System.Drawing.Point(126, 261);
            this.OpenTicketlbl.Name = "OpenTicketlbl";
            this.OpenTicketlbl.Size = new System.Drawing.Size(50, 63);
            this.OpenTicketlbl.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unresloved Incidents";
            // 
            // Bar1
            // 
            this.Bar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Bar1.AnimationSpeed = 500;
            this.Bar1.BackColor = System.Drawing.Color.Transparent;
            this.Bar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Bar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Bar1.InnerMargin = 2;
            this.Bar1.InnerWidth = -1;
            this.Bar1.Location = new System.Drawing.Point(30, 135);
            this.Bar1.MarqueeAnimationSpeed = 2000;
            this.Bar1.Name = "Bar1";
            this.Bar1.OuterColor = System.Drawing.Color.Gray;
            this.Bar1.OuterMargin = -50;
            this.Bar1.OuterWidth = 51;
            this.Bar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bar1.ProgressWidth = 50;
            this.Bar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Bar1.Size = new System.Drawing.Size(320, 320);
            this.Bar1.StartAngle = 270;
            this.Bar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Bar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Bar1.SubscriptText = "";
            this.Bar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Bar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Bar1.SuperscriptText = "";
            this.Bar1.TabIndex = 8;
            this.Bar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Bar1.Value = 68;
            this.Bar1.Click += new System.EventHandler(this.Bar1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "All tickets currently open";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Bar2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(558, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 463);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Incidents past deadline";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "These tickets need your immedate attention";
            // 
            // Bar2
            // 
            this.Bar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Bar2.AnimationSpeed = 500;
            this.Bar2.BackColor = System.Drawing.Color.Transparent;
            this.Bar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Bar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Bar2.InnerMargin = 2;
            this.Bar2.InnerWidth = -1;
            this.Bar2.Location = new System.Drawing.Point(33, 118);
            this.Bar2.MarqueeAnimationSpeed = 2000;
            this.Bar2.Name = "Bar2";
            this.Bar2.OuterColor = System.Drawing.Color.Gray;
            this.Bar2.OuterMargin = -50;
            this.Bar2.OuterWidth = 51;
            this.Bar2.ProgressColor = System.Drawing.Color.Red;
            this.Bar2.ProgressWidth = 50;
            this.Bar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Bar2.Size = new System.Drawing.Size(320, 320);
            this.Bar2.StartAngle = 270;
            this.Bar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Bar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Bar2.SubscriptText = "";
            this.Bar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Bar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Bar2.SuperscriptText = "";
            this.Bar2.TabIndex = 9;
            this.Bar2.Text = "2";
            this.Bar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Bar2.Value = 50;
            // 
            // TicketViewBtn
            // 
            this.TicketViewBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TicketViewBtn.Location = new System.Drawing.Point(832, 38);
            this.TicketViewBtn.Name = "TicketViewBtn";
            this.TicketViewBtn.Size = new System.Drawing.Size(119, 41);
            this.TicketViewBtn.TabIndex = 11;
            this.TicketViewBtn.Text = "Show List";
            this.TicketViewBtn.UseVisualStyleBackColor = false;
            this.TicketViewBtn.Click += new System.EventHandler(this.TicketViewBtn_Click);
            // 
            // Incidentlbl
            // 
            this.Incidentlbl.AutoSize = true;
            this.Incidentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incidentlbl.Location = new System.Drawing.Point(3, 24);
            this.Incidentlbl.Name = "Incidentlbl";
            this.Incidentlbl.Size = new System.Drawing.Size(318, 46);
            this.Incidentlbl.TabIndex = 10;
            this.Incidentlbl.Text = "Current Incident";
            // 
            // IncidentViewPanel
            // 
            this.IncidentViewPanel.Controls.Add(this.textBox1);
            this.IncidentViewPanel.Controls.Add(this.TicketslistView);
            this.IncidentViewPanel.Controls.Add(this.AddIncidentBtn);
            this.IncidentViewPanel.Controls.Add(this.label3);
            this.IncidentViewPanel.Location = new System.Drawing.Point(9, 148);
            this.IncidentViewPanel.Name = "IncidentViewPanel";
            this.IncidentViewPanel.Size = new System.Drawing.Size(1045, 611);
            this.IncidentViewPanel.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 5;
            // 
            // TicketslistView
            // 
            this.TicketslistView.HideSelection = false;
            this.TicketslistView.Location = new System.Drawing.Point(31, 131);
            this.TicketslistView.Name = "TicketslistView";
            this.TicketslistView.Size = new System.Drawing.Size(910, 434);
            this.TicketslistView.TabIndex = 4;
            this.TicketslistView.UseCompatibleStateImageBehavior = false;
            this.TicketslistView.View = System.Windows.Forms.View.Details;
            // 
            // AddIncidentBtn
            // 
            this.AddIncidentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddIncidentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddIncidentBtn.Location = new System.Drawing.Point(765, 49);
            this.AddIncidentBtn.Name = "AddIncidentBtn";
            this.AddIncidentBtn.Size = new System.Drawing.Size(176, 41);
            this.AddIncidentBtn.TabIndex = 3;
            this.AddIncidentBtn.Text = "CREATE INCIDENT";
            this.AddIncidentBtn.UseVisualStyleBackColor = false;
            this.AddIncidentBtn.Click += new System.EventHandler(this.AddIncidentBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Overview tickets";
            // 
            // UserViewPanel
            // 
            this.UserViewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserViewPanel.Controls.Add(this.UserlistView);
            this.UserViewPanel.Controls.Add(this.AddUserBtn);
            this.UserViewPanel.Controls.Add(this.FindbyEmailtextBox);
            this.UserViewPanel.Controls.Add(this.label4);
            this.UserViewPanel.Location = new System.Drawing.Point(9, 148);
            this.UserViewPanel.Name = "UserViewPanel";
            this.UserViewPanel.Size = new System.Drawing.Size(1006, 805);
            this.UserViewPanel.TabIndex = 8;
            // 
            // UserlistView
            // 
            this.UserlistView.HideSelection = false;
            this.UserlistView.Location = new System.Drawing.Point(16, 186);
            this.UserlistView.Name = "UserlistView";
            this.UserlistView.Size = new System.Drawing.Size(987, 484);
            this.UserlistView.TabIndex = 19;
            this.UserlistView.UseCompatibleStateImageBehavior = false;
            this.UserlistView.View = System.Windows.Forms.View.Details;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.AddUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AddUserBtn.Location = new System.Drawing.Point(484, 71);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(190, 57);
            this.AddUserBtn.TabIndex = 18;
            this.AddUserBtn.Text = "+ ADD NEW USER";
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // FindbyEmailtextBox
            // 
            this.FindbyEmailtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindbyEmailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindbyEmailtextBox.ForeColor = System.Drawing.Color.LightGray;
            this.FindbyEmailtextBox.Location = new System.Drawing.Point(28, 72);
            this.FindbyEmailtextBox.Multiline = true;
            this.FindbyEmailtextBox.Name = "FindbyEmailtextBox";
            this.FindbyEmailtextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FindbyEmailtextBox.Size = new System.Drawing.Size(338, 49);
            this.FindbyEmailtextBox.TabIndex = 11;
            this.FindbyEmailtextBox.Text = "Filter by E-mail";
           
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 51);
            this.label4.TabIndex = 1;
            this.label4.Text = "User management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(136, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 1015);
            this.Controls.Add(this.UserViewPanel);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.IncidentViewPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserManagementBtn);
            this.Controls.Add(this.IncidentManagementBtn);
            this.Controls.Add(this.DashboarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.IncidentViewPanel.ResumeLayout(false);
            this.IncidentViewPanel.PerformLayout();
            this.UserViewPanel.ResumeLayout(false);
            this.UserViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DashboarBtn;
        private System.Windows.Forms.Button IncidentManagementBtn;
        private System.Windows.Forms.Button UserManagementBtn;
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel IncidentViewPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel UserViewPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView TicketslistView;
        private System.Windows.Forms.Button AddIncidentBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FindbyEmailtextBox;
        private System.Windows.Forms.Button AddUserBtn;
        private CircularProgressBar.CircularProgressBar Bar2;
        private CircularProgressBar.CircularProgressBar Bar1;
        private System.Windows.Forms.Label Incidentlbl;
        private System.Windows.Forms.Button TicketViewBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label OpenTicketlbl;
        private System.Windows.Forms.Label AllTicketslbl;
        private System.Windows.Forms.ListView UserlistView;
    }
}

