﻿
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
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.IncidentViewPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.UserViewPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddIncidentBtn = new System.Windows.Forms.Button();
            this.TicketslistView = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DashboardPanel.SuspendLayout();
            this.IncidentViewPanel.SuspendLayout();
            this.UserViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(806, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Desk";
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
            this.button1.Location = new System.Drawing.Point(-2, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(341, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Incident Management";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(687, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(346, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "User Management";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Controls.Add(this.IncidentViewPanel);
            this.DashboardPanel.Location = new System.Drawing.Point(3, 3);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1006, 582);
            this.DashboardPanel.TabIndex = 6;
            // 
            // IncidentViewPanel
            // 
            this.IncidentViewPanel.Controls.Add(this.textBox1);
            this.IncidentViewPanel.Controls.Add(this.TicketslistView);
            this.IncidentViewPanel.Controls.Add(this.AddIncidentBtn);
            this.IncidentViewPanel.Controls.Add(this.label3);
            this.IncidentViewPanel.Location = new System.Drawing.Point(3, 0);
            this.IncidentViewPanel.Name = "IncidentViewPanel";
            this.IncidentViewPanel.Size = new System.Drawing.Size(1006, 582);
            this.IncidentViewPanel.TabIndex = 7;
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
            this.UserViewPanel.Controls.Add(this.DashboardPanel);
            this.UserViewPanel.Location = new System.Drawing.Point(12, 145);
            this.UserViewPanel.Name = "UserViewPanel";
            this.UserViewPanel.Size = new System.Drawing.Size(1006, 582);
            this.UserViewPanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // TicketslistView
            // 
            this.TicketslistView.HideSelection = false;
            this.TicketslistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.TicketslistView.Location = new System.Drawing.Point(31, 131);
            this.TicketslistView.Name = "TicketslistView";
            this.TicketslistView.Size = new System.Drawing.Size(910, 434);
            this.TicketslistView.TabIndex = 4;
            this.TicketslistView.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 789);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserViewPanel);
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
            this.IncidentViewPanel.ResumeLayout(false);
            this.IncidentViewPanel.PerformLayout();
            this.UserViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

