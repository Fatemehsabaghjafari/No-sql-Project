
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.IncidentViewPanel = new System.Windows.Forms.Panel();
            this.UserViewPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TicketslistView = new System.Windows.Forms.ListView();
            this.AddIncidentBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bar1 = new CircularProgressBar.CircularProgressBar();
            this.Bar2 = new CircularProgressBar.CircularProgressBar();
            this.Incidentlbl = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DashboardPanel.SuspendLayout();
            this.IncidentViewPanel.SuspendLayout();
            this.UserViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(336, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Incident Management";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(692, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(346, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "User Management";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DashboardPanel.Controls.Add(this.groupBox2);
            this.DashboardPanel.Controls.Add(this.groupBox1);
            this.DashboardPanel.Controls.Add(this.button5);
            this.DashboardPanel.Controls.Add(this.Incidentlbl);
            this.DashboardPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DashboardPanel.Location = new System.Drawing.Point(9, 148);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1039, 582);
            this.DashboardPanel.TabIndex = 6;
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
            // UserViewPanel
            // 
            this.UserViewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserViewPanel.Controls.Add(this.button4);
            this.UserViewPanel.Controls.Add(this.textBox2);
            this.UserViewPanel.Controls.Add(this.label4);
            this.UserViewPanel.Location = new System.Drawing.Point(9, 148);
            this.UserViewPanel.Name = "UserViewPanel";
            this.UserViewPanel.Size = new System.Drawing.Size(1006, 805);
            this.UserViewPanel.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.GreenYellow;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(484, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 57);
            this.button4.TabIndex = 18;
            this.button4.Text = "+ ADD NEW USER";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.LightGray;
            this.textBox2.Location = new System.Drawing.Point(28, 72);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(338, 49);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Filter by E-mail";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.Bar1.Text = "1";
            this.Bar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Bar1.Value = 50;
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
            this.Bar2.Value = 5;
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
            this.Incidentlbl.Click += new System.EventHandler(this.Incidentlbl_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(832, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 41);
            this.button5.TabIndex = 11;
            this.button5.Text = "Show List";
            this.button5.UseVisualStyleBackColor = false;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Bar1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(48, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 463);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 996);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.UserViewPanel);
            this.Controls.Add(this.IncidentViewPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.IncidentViewPanel.ResumeLayout(false);
            this.IncidentViewPanel.PerformLayout();
            this.UserViewPanel.ResumeLayout(false);
            this.UserViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel IncidentViewPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel UserViewPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView TicketslistView;
        private System.Windows.Forms.Button AddIncidentBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private CircularProgressBar.CircularProgressBar Bar2;
        private CircularProgressBar.CircularProgressBar Bar1;
        private System.Windows.Forms.Label Incidentlbl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

