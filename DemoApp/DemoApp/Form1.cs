using System;
using System.Windows.Forms;
using Logic;
using Model;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.Linq;
using MongoDB.Bson;

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
      

        public Form1(Employee employee)
        {
            InitializeComponent();
            databases = new Databases();
            ticketService = new TicketService();
            employeeService = new EmployeeService();  
            this.loggedInEmployee = employee;

            Bar1.Value = CalculateProgressValue();
            Bar2.Value = CalculateProgressValue();

            updateTimer = new Timer();
            updateTimer.Interval = 5000; // Set the interval in milliseconds (e.g., 5000 for 5 seconds)
            updateTimer.Tick += UpdateTimer_Tick; // Set the event handler for the Tick event
            updateTimer.Start(); // Start the timer

            this.FormClosing += Form1_FormClosing;

        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            RefreshListView(); // Call your refresh method here or any other method you want to execute periodically
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateTimer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dbList = databases.Get_All_Databases();
            
            foreach (var db in dbList)
            {
                //listBox1.Items.Add(db.name);
            }
            if (loggedInEmployee != null)
            {
                if (loggedInEmployee.Type == Employee.EmployeeType.Employee)
                {
                    tickets = ticketService.GetTicketsByUser(loggedInEmployee);
                    TransferTicketBtn.Visible = false;
                    DeleteTicketBtn.Visible = false;
                    updateBtn.Visible = false;
                }
                else if (loggedInEmployee.Type == Employee.EmployeeType.ServiceDesk)
                {
                    tickets = ticketService.GetSortedTickets();
                    TransferTicketBtn.Visible = true;
                    DeleteTicketBtn.Visible = true;
                    updateBtn.Visible = true;

                }
                else
                {
                    // Handle other employee types if necessary
                    tickets = new List<Ticket>();
                }
            }
            else
            {
                tickets = new List<Ticket>();
            }
            List<Employee> employees = employeeService.GetAllEmployees();
            TicketView(tickets);
            UserView(employees);

            int ticketNumbers = tickets.Count;
            AllTicketslbl.Text = ticketNumbers.ToString();
            int openTickets = 0;
            int passedDeadlineTickets = 0;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.TicketStatus == Ticket.Status.Open)
                {
                    openTickets++;
                }
                if (ticket.Deadline < DateTime.Now)
                {
                    passedDeadlineTickets++;
                }
            }
            OpenTicketlbl.Text = openTickets.ToString();
            Bar2.Text = passedDeadlineTickets.ToString();

            openRadioBtn.CheckedChanged += (s, ev) => FilterTickets(Ticket.Status.Open);
            closeRadioBtn.CheckedChanged += (s, ev) => FilterTickets(Ticket.Status.Close);
            ResolvedRadioBtn.CheckedChanged += (s, ev) => FilterTickets(Ticket.Status.Resolved);
            ShowTickets();

        }
        public void RefreshListView()
        {
            // Clear the items in the ListView
            TicketslistView.Items.Clear();

            // Repopulate the ListView with updated data
            if (loggedInEmployee.Type == Employee.EmployeeType.Employee)
            {
                // This is a regular employee, get only their own tickets
                tickets = ticketService.GetTicketsByUser(loggedInEmployee);
            }
            else
            {
                tickets = ticketService.GetSortedTickets();
            }
          
            TicketView(tickets);
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
            try
            {
                if (loggedInEmployee != null)
                {
                    AddTicket addTicketForm = new AddTicket(loggedInEmployee);
                    addTicketForm.Owner = this; // Set the owner form to Form1
                    addTicketForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No logged-in employee found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (UnauthorizedTicketAccessException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TicketView(List<Ticket> tickets)
        {
            TicketslistView.Items.Clear();
            TicketslistView.Columns.Clear();
            TicketslistView.Columns.Add("ID", 100);
            TicketslistView.Columns.Add("Subject", 300);
            TicketslistView.Columns.Add("User", 150);
            TicketslistView.Columns.Add("Date", 150);
            TicketslistView.Columns.Add("Status", 150);
            TicketslistView.Columns.Add("Type", 150);
            TicketslistView.Columns.Add("Priority", 150);


            foreach (Ticket ticket in tickets)
            {
                string typeAsString = Enum.GetName(typeof(Ticket.IncidentType), ticket.Type);
                string priorityAsString = Enum.GetName(typeof(Ticket.Priority), ticket.PriorityType);
              
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
            try
            {
                if (loggedInEmployee != null)
                {
                    AddTicket addTicket = new AddTicket(loggedInEmployee);
                    addTicket.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No logged-in employee found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (UnauthorizedTicketAccessException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TicketViewBtn_Click(object sender, EventArgs e)
        {
            DashboardPanel.Visible = false;
            UserViewPanel.Visible = false;
            IncidentViewPanel.Visible = true;

        }

        private void Bar1_Click(object sender, EventArgs e)
        {
           // Bar1.Value = CalculateProgressValue();
        }
        private int CalculateProgressValue()
        {

            if (loggedInEmployee.Type == Employee.EmployeeType.Employee)
            {
                // This is a regular employee, get only their own tickets
                tickets = ticketService.GetTicketsByUser(loggedInEmployee);
            }
            else if (loggedInEmployee.Type == Employee.EmployeeType.ServiceDesk)
            {

                tickets = ticketService.GetAllTickets();

            }
            else
            {
                // Handle other employee types if necessary
                tickets = new List<Ticket>();
            }

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


        private void FindbyEmailtextBox_TextChanged(object sender, EventArgs e)
        {
            UserView(employeeService.GetAllEmployees(), FindbyEmailtextBox.Text);
            FindbyEmailtextBox.ForeColor = Color.Black;
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            searchTerm = SearchTxtBox.Text.ToLower();

            List<Ticket> filteredTickets = ticketService.GetTicketsBySearchTerm(searchTerm);

            TicketView(filteredTickets);
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
                    TicketView(tickets);
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
                    TicketView(tickets);
                }
            }
            else
            {
                MessageBox.Show("Please select a ticket to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowTickets()
        {
            TicketslistView.Items.Clear();
            TicketView(tickets);
        }
       
        private void FilterTickets(Ticket.Status? filterStatus)
        {
            TicketslistView.BeginUpdate(); // Suspend the layout to improve performance
            TicketslistView.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                if (filterStatus == null || ticket.TicketStatus == filterStatus)
                {
                    string typeAsString = Enum.GetName(typeof(Ticket.IncidentType), ticket.Type);
                    string priorityAsString = Enum.GetName(typeof(Ticket.Priority), ticket.PriorityType);

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

            TicketslistView.EndUpdate(); // Resume layout and redraw
        }


    }
}
