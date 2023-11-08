using System;
using System.Windows.Forms;
using Logic;
using Model;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.Linq;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        private Databases databases;
        private TicketService ticketService;
        private EmployeeService employeeService;
        private Employee loggedInEmployee;
        private List<Ticket> tickets;
        private string searchTerm;
        public Form1()
        {
            InitializeComponent();
            databases = new Databases();
            ticketService = new TicketService();
            employeeService = new EmployeeService();
            
            //Bar1.Value = CalculateProgressValue();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            var dbList = databases.Get_All_Databases();
            
            foreach (var db in dbList)
            {
                //listBox1.Items.Add(db.name);
            }
            tickets = ticketService.GetAllTickets();
            List<Employee> employees = employeeService.GetAllEmployees();
            TicketView(tickets, searchTerm);
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

            //if (loggedInEmployee != null)
            //{
            //    if (loggedInEmployee.Type == Employee.EmployeeType.ServiceDesk)
            //    {
            //        TransferTicketBtn.Visible = true; // Show the button for service desk employees
            //    }
            //    else
            //    {
            //        TransferTicketBtn.Visible = false; // Hide the button for other employee types
            //    }
            //}
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

        //private void TicketView(List<Ticket> tickets)
        //{
        //    TicketslistView.Items.Clear();
        //    TicketslistView.Columns.Clear();
        //    TicketslistView.Columns.Add("ID", 100);
        //    TicketslistView.Columns.Add("Subject", 300);
        //    TicketslistView.Columns.Add("User", 150);
        //    TicketslistView.Columns.Add("Date", 150);
        //    TicketslistView.Columns.Add("Status", 150);

        //    Employee loggedInEmployee = GetLoggedInEmployee();

        //    foreach (Ticket ticket in tickets)
        //    {
        //        // If logged-in employee is a regular employee, only show their own tickets
        //        if (loggedInEmployee.Type == Employee.EmployeeType.Employee && ticket.User == loggedInEmployee)
        //        {
        //            ListViewItem listViewItem = new ListViewItem(ticket.Id.ToString());
        //            listViewItem.SubItems.Add(ticket.IncidentSubject);
        //            listViewItem.SubItems.Add(ticket.User.FirstName);
        //            listViewItem.SubItems.Add(ticket.Date.ToString("yyyy-MM-dd HH:mm:ss"));
        //            TicketslistView.Items.Add(listViewItem);
        //        }
        //        // If logged-in employee is a service desk employee, show all tickets
        //        else if (loggedInEmployee.Type == Employee.EmployeeType.ServiceDesk)
        //        {
        //            ListViewItem listViewItem = new ListViewItem(ticket.Id.ToString());
        //            listViewItem.SubItems.Add(ticket.IncidentSubject);
        //            listViewItem.SubItems.Add(ticket.User.FirstName);
        //            listViewItem.SubItems.Add(ticket.Date.ToString("yyyy-MM-dd HH:mm:ss"));
        //            TicketslistView.Items.Add(listViewItem);
        //        }
        //    }
        //}


        private List<Ticket> TicketView(List<Ticket> tickets, string searchTerm)
        {
            TicketslistView.Items.Clear();
            TicketslistView.Columns.Clear();
            TicketslistView.Columns.Add("ID", 200);
            TicketslistView.Columns.Add("Subject", 200);
            TicketslistView.Columns.Add("User", 100);
            TicketslistView.Columns.Add("Date", 120);
            TicketslistView.Columns.Add("Status", 100);
            TicketslistView.Columns.Add("Type", 100);
            TicketslistView.Columns.Add("Priority", 100);

            foreach (Ticket ticket in tickets)
            {
                string typeAsString = Enum.GetName(typeof(Ticket.IncidentType), ticket.Type);
                string priorityAsString = Enum.GetName(typeof(Ticket.Priority), ticket.PriorityType);

                if (string.IsNullOrWhiteSpace(searchTerm) ||
                    ticket.IncidentSubject.ToLower().Contains(searchTerm.ToLower()) ||
                    ticket.User.FirstName.ToLower().Contains(searchTerm.ToLower()))
                {
                    ListViewItem listViewItem = new ListViewItem(ticket.Id.ToString());
                    listViewItem.SubItems.Add(ticket.IncidentSubject);
                    listViewItem.SubItems.Add(ticket.User.FirstName);
                    listViewItem.SubItems.Add(ticket.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                    listViewItem.SubItems.Add(ticket.TicketStatus.ToString());
                    listViewItem.SubItems.Add(typeAsString);
                    listViewItem.SubItems.Add(priorityAsString);
                    TicketslistView.Items.Add(listViewItem);
                }
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
            //try
            //{
            //    if (loggedInEmployee != null)
            //    {
            //        AddTicket addTicket = new AddTicket(loggedInEmployee);
            //        addTicket.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No logged-in employee found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (UnauthorizedTicketAccessException ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
        //private int CalculateProgressValue()
        //{
        //    List<Ticket> tickets;
        //    Employee loggedInEmployee = GetLoggedInEmployee();

        //    if (loggedInEmployee.Type == Employee.EmployeeType.Employee)
        //    {
        //        // This is a regular employee, get only their own tickets
        //        tickets = ticketService.GetTicketsByUser(loggedInEmployee);
        //    }
        //    else if (loggedInEmployee.Type == Employee.EmployeeType.ServiceDesk)
        //    {
        //        // This is a service desk employee, get all tickets
        //        tickets = ticketService.GetAllTickets();
        //    }
        //    else
        //    {
        //        // Handle other employee types if necessary
        //        tickets = new List<Ticket>();
        //    }

        //    int openTickets = tickets.Count(t => t.TicketStatus == Ticket.Status.Open);

        //    Bar1.Maximum = tickets.Count;

        //    // Ensure progressValue is within the valid range
        //    int progressValue = (int)(((double)openTickets / Bar1.Maximum) * 100);
        //    progressValue = Math.Max(Bar1.Minimum, Math.Min(Bar1.Maximum, progressValue));

        //    return progressValue;
        //}

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

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            searchTerm = SearchTxtBox.Text.ToLower();

            List<Ticket> filteredTickets = new List<Ticket>();

            foreach (Ticket ticket in tickets) // Assuming 'tickets' is the list you're filtering
            {
                if (string.IsNullOrWhiteSpace(searchTerm) ||
                    ticket.IncidentSubject.ToLower().Contains(searchTerm) ||
                    ticket.User.FirstName.ToLower().Contains(searchTerm))
                {
                    filteredTickets.Add(ticket);
                }
            }

            TicketView(filteredTickets, searchTerm);
        }

        private void TransferTicketBtn_Click(object sender, EventArgs e)
        {
            if (TicketslistView.SelectedItems.Count == 1)
            {
                Ticket selectedTicket = tickets.Find(ticket => ticket.Id.ToString() == TicketslistView.SelectedItems[0].Text);

                TransferTicketDialog transferDialog = new TransferTicketDialog(employeeService.GetAllEmployees());
                DialogResult result = transferDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    selectedTicket.User = transferDialog.SelectedEmployee;
                    ticketService.UpdateTicket(selectedTicket);
                    TicketView(tickets, searchTerm);
                }
            }
            else
            {
                MessageBox.Show("Please select a ticket to transfer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTicketBtn_Click(object sender, EventArgs e)
        {
            if (TicketslistView.SelectedItems.Count == 1)
            {
                ListViewItem selectedListViewItem = TicketslistView.SelectedItems[0];
                Ticket selectedTicket = tickets.Find(ticket => ticket.Id.ToString() == selectedListViewItem.Text);

                // Remove the ticket from the list
                tickets.Remove(selectedTicket);

                // Remove the item from the ListView
                TicketslistView.Items.Remove(selectedListViewItem);

                // Call a method to delete the ticket from your data storage (e.g., database or file)
                ticketService.DeleteTicket(selectedTicket);
                RefreshListView();
            }
            else
            {
                MessageBox.Show("Please select a ticket to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshListView()
        {
            // Clear the items in the ListView
            TicketslistView.Items.Clear();

            // Repopulate the ListView with updated data
            List<Ticket> updatedTickets = ticketService.GetAllTickets();
            TicketView(updatedTickets, searchTerm);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (TicketslistView.SelectedItems.Count == 1)
            {
                Ticket selectedTicket = tickets.Find(ticket => ticket.Id.ToString() == TicketslistView.SelectedItems[0].Text);

                // Create an instance of EditTicketForm and pass the selected ticket
                EditTicketForm editTicketForm = new EditTicketForm(selectedTicket);
                DialogResult result = editTicketForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Ticket was successfully updated, refresh the view
                    TicketView(tickets, searchTerm);
                }
            }
            else
            {
                MessageBox.Show("Please select a ticket to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
