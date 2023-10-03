using System;
using System.Windows.Forms;
using Logic;
using Model;
using System.Collections.Generic;

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
    }
}
