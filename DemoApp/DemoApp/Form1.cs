using System;
using System.Windows.Forms;
using Logic;
using Model;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        private Databases databases;
        private TicketService ticketService;
        private EmployeeService employeeService;

        public Form1()
        {
            InitializeComponent();
            databases = new Databases();
            ticketService = new TicketService();
            employeeService = new EmployeeService();
            
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
            List<Employee> employees = employeeService.GetAllEmployees();
            TicketView(tickets);
            UserView(employees);

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
        private List<Employee> UserView(List<Employee> employees, string filterEmail = "")
        {

            UserlistView.Items.Clear();
            UserlistView.Columns.Clear();
            UserlistView.Columns.Add("ID", 50);
            UserlistView.Columns.Add("Email", 200);
            UserlistView.Columns.Add("FirstName", 150);
            UserlistView.Columns.Add("LastName", 150);
            UserlistView.Columns.Add("Phone", 150);
            UserlistView.Columns.Add("Type", 150);
            UserlistView.Columns.Add("Location", 150);



            foreach (Employee employee in employees)
            {
                if (string.IsNullOrEmpty(filterEmail) || employee.Email.ToLower().Contains(filterEmail.ToLower()))
                {
                    ListViewItem listViewItem = new ListViewItem(employee.Id.ToString());
                    listViewItem.SubItems.Add(employee.Email);
                    listViewItem.SubItems.Add(employee.FirstName);
                    listViewItem.SubItems.Add(employee.LastName);
                    listViewItem.SubItems.Add(employee.PhoneNumber);
                    listViewItem.SubItems.Add(employee.Type.ToString());
                    listViewItem.SubItems.Add(employee.Location.ToString());
                    UserlistView.Items.Add(listViewItem);
                }
            }

            return employees;
        }
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
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

        private void FindbyEmailtextBox_TextChanged(object sender, EventArgs e)
        {
            UserView(employeeService.GetAllEmployees(), FindbyEmailtextBox.Text);
            FindbyEmailtextBox.ForeColor = Color.Black;
        }
    }
}
