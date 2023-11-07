using System;
using System.Windows.Forms;
using Logic;
using Model;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DemoApp
{
    public partial class Dashboard : Form
    {
        private Databases databases;
        private TicketService ticketService;
       
        public Dashboard()
        {
            InitializeComponent();
            databases = new Databases();
            ticketService = new TicketService();
            Bar1.Value = CalculateProgressValue();
            Bar2.Value = CalculateProgressValue();
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
            AllTickets_lbl.Text = ticketNumbers.ToString();
            int openTickets = 0;
            int passedDeadlineTickets = 0;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.TicketStatus == Ticket.Status.Open)
                {
                    openTickets++;
                    if (ticket.Deadline < DateTime.Now)
                    {
                        passedDeadlineTickets++;
                    }
                }
               
            }
            OpenTicketlbl.Text = openTickets.ToString();
            DealineTicketslbl.Text = passedDeadlineTickets.ToString();
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
                listViewItem.SubItems.Add(ticket.Subject);
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

        //private void Bar1_Click(object sender, EventArgs e)
        //{
        //    Bar1.Value = CalculateProgressValue();
        //}

        private int CalculateProgressValue()
        {
            List<Ticket> tickets = ticketService.GetAllTickets();
            int openTickets = 0;
            int overdueTickets = 0;

            DateTime currentDate = DateTime.Now;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.TicketStatus == Ticket.Status.Open)
                {
                    openTickets++;
                    if (ticket.Deadline < currentDate)
                    {
                        overdueTickets++;
                    }
                }
            }

            int progressValueBar1 = 0;
            int progressValueBar2 = 0;

            if (Bar1.Maximum != 0)
            {
                progressValueBar1 = (int)((openTickets / (double)Bar1.Maximum) * 100);
                progressValueBar1 = Math.Max(Bar1.Minimum, Math.Min(Bar1.Maximum, progressValueBar1));
                Bar1.Value = progressValueBar1;
            }

            if (Bar2.Maximum != 0)
            {
                progressValueBar2 = (int)((overdueTickets / (double)Bar2.Maximum) * 100);
                progressValueBar2 = Math.Max(Bar2.Minimum, Math.Min(Bar2.Maximum, progressValueBar2));
                Bar2.Value = progressValueBar2;
            }

            Bar1.Refresh();
            Bar2.Refresh();

            return overdueTickets;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
           
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        //private int CalculateProgressValue()
        //{
        //    List<Ticket> tickets = ticketService.GetAllTickets();
        //    int openTickets = 0;

        //    foreach (Ticket ticket in tickets)
        //    {
        //        if (ticket.TicketStatus == Ticket.Status.Open)
        //        {
        //            openTickets++;
        //        }
        //    }
        //    Bar1.Minimum = 0;
        //    Bar1.Maximum = tickets.Count;

        //    // Ensure progressValue is within the valid range
        //    int progressValue = (int)((openTickets / Bar1.Maximum) * 100);
        //    progressValue = Math.Max(Bar1.Minimum, Math.Min(Bar1.Maximum, progressValue));
        //    Bar1.Update(); 
        //    return progressValue;

        //}


    }
}
