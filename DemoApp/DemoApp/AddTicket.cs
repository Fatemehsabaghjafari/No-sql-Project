using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class AddTicket : Form
    {
        private TicketService ticketService;
        private EmployeeService employeeService;
        private Employee loggedInEmployee;

        public AddTicket(Employee employee)
        {
            InitializeComponent();
            ticketService = new TicketService();
            employeeService = new EmployeeService();
            this.loggedInEmployee = employee;
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {
            LoadUserComboBox();
            LoadIncidentTypeComboBox();
            LoadIncidentPriorityComboBox();
        }

        private void LoadUserComboBox()
        {
            List<Employee> employeeList;

            // Check if the logged-in employee is an employee
            if (loggedInEmployee.Type == Employee.EmployeeType.Employee)
            {
                // If the logged-in user is an employee, only show their name in the combo box
                employeeList = new List<Employee> { loggedInEmployee };
                UserIncidentComboBox.Enabled = false; // Disable the combo box
            }
            else
            {
                // If the logged-in user is an admin, show all employees in the combo box
                employeeList = employeeService.GetAllEmployees();
            }

            UserIncidentComboBox.DataSource = null;
            UserIncidentComboBox.DataSource = employeeList;
            UserIncidentComboBox.DisplayMember = "FullName";
        }

        private void LoadIncidentTypeComboBox()
        {
            Array incidentTypes = Enum.GetValues(typeof(Ticket.IncidentType));
            IncidentTypeComboBox.DataSource = incidentTypes;
            IncidentTypeComboBox.DisplayMember = "ToString";
        }

        private void LoadIncidentPriorityComboBox()
        {
            Array priorities = Enum.GetValues(typeof(Ticket.Priority));
            IncidentPriorityComboBox.DataSource = priorities;
            IncidentPriorityComboBox.DisplayMember = "ToString";
        }

        public Ticket CreateNewTicket()
        {
            Employee selectedUser = (Employee)UserIncidentComboBox.SelectedItem;
            Ticket.IncidentType selectedIncidentType = (Ticket.IncidentType)IncidentTypeComboBox.SelectedItem;
            Ticket.Priority selectedPriority = (Ticket.Priority)IncidentPriorityComboBox.SelectedItem;

            // Check if the logged-in employee is an employee
            if (loggedInEmployee.Type == Employee.EmployeeType.Employee)
            {
                // Regular employees can only add tickets for themselves
                if (selectedUser != loggedInEmployee)
                {
                    MessageBox.Show("Regular employees can only add tickets for themselves.", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            Ticket ticket = new Ticket
            {
                Date = IncidentDateTimePicker.Value,
                IncidentSubject = IncidentSubjectTxtBox.Text,
                User = selectedUser,
                Type = selectedIncidentType,
                PriorityType = selectedPriority,
                Deadline = IncidentDeadlinePicker.Value,
                Description = IncidentDescriptionTxtBox.Text,
                TicketStatus = Ticket.Status.Open
            };

            ticketService.AddTicket(ticket);
            return ticket;
        }
        public void ClearTextbox()
        {
            IncidentSubjectTxtBox.Clear();
            IncidentDescriptionTxtBox.Clear();
        }

        private void SubmitTicketBtn_Click(object sender, EventArgs e)
        {
            Ticket newTicket = CreateNewTicket();
            if (newTicket != null)
            {
                MessageBox.Show("Ticket submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ClearTextbox();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
