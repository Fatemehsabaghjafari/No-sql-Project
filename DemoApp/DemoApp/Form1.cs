using System;
using System.Windows.Forms;
using Logic;
using Model;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        private Databases databases;
        private TicketService ticketService;
       
        public Form1()
        {
            InitializeComponent();
            databases = new Databases();
            ticketService = new TicketService();
         //   Bar1.Value = CalculateProgressValue();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            var dbList = databases.Get_All_Databases();
            
            foreach (var db in dbList)
            {
                //listBox1.Items.Add(db.name);
            }
            List<Ticket> tickets = ticketService.GetAllTickets();
            TicketView(tickets);
            int ticketNumbers = tickets.Count;
            AllTicketslbl.Text = ticketNumbers.ToString();
            int openTickets = 0;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.TicketStatus == Ticket.Status.Open)
                {
                    openTickets++;
                }
            }
            OpenTicketlbl.Text = openTickets.ToString();

        }
       
        
        private List<Ticket> TicketView(List<Ticket> tickets)
        {

            TicketslistView.Items.Clear();
            TicketslistView.Columns.Clear();
            TicketslistView.Columns.Add("ID", 100);
            TicketslistView.Columns.Add("Subject", 300);
            TicketslistView.Columns.Add("User", 150);
            TicketslistView.Columns.Add("Date", 150);
            TicketslistView.Columns.Add("Status", 150);

            foreach (Ticket ticket in tickets)
            {
                ListViewItem listViewItem = new ListViewItem(ticket.Id.ToString());
                listViewItem.SubItems.Add(ticket.IncidentSubject);
                listViewItem.SubItems.Add(ticket.User.FirstName);
                listViewItem.SubItems.Add(ticket.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                TicketslistView.Items.Add(listViewItem);
            }
            return tickets;
            
        }
        private void IncidentManagementBtn_Click(object sender, EventArgs e)
        {
            DashboardPanel.Visible= false;
            UserViewPanel.Visible= false;
            IncidentViewPanel.Visible = true;
        }

        private void DashboarBtn_Click(object sender, EventArgs e)
        {
            DashboardPanel.Visible = true;
            UserViewPanel.Visible = false;
            IncidentViewPanel.Visible = false;
        }

        private void UserManagementBtn_Click(object sender, EventArgs e)
        {
            DashboardPanel.Visible = false;
            UserViewPanel.Visible = true;
            IncidentViewPanel.Visible = false;
        }

        private void AddIncidentBtn_Click(object sender, EventArgs e)
        {
            AddTicket addTicket = new AddTicket();
            addTicket.ShowDialog();
        }

        private void TicketViewBtn_Click(object sender, EventArgs e)
        {
            DashboardPanel.Visible = false;
            UserViewPanel.Visible = false;
            IncidentViewPanel.Visible = true;

        }

        private void Bar1_Click(object sender, EventArgs e)
        {
            Bar1.Value = CalculateProgressValue();
        }
        private int CalculateProgressValue()
        {
            List<Ticket> tickets = ticketService.GetAllTickets();
            int openTickets = 0;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.TicketStatus == Ticket.Status.Open)
                {
                    openTickets++;
                }
            }

            Bar1.Maximum = tickets.Count;

            // Ensure progressValue is within the valid range
            int progressValue = (int)(((double)openTickets / Bar1.Maximum) * 100);
            progressValue = Math.Max(Bar1.Minimum, Math.Min(Bar1.Maximum, progressValue));

            return progressValue;
        }

        
    }
}
