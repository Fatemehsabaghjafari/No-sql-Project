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
      //  private Employee loggedInEmployee;

        public AddTicket()
        {
            InitializeComponent();
            ticketService= new TicketService();
            employeeService = new EmployeeService();
         //   this.loggedInEmployee = loggedInEmployee;
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {
            List<Employee> employeeList = employeeService.GetAllEmployees();
            UserIncidentComboBox.DataSource = null;
            UserIncidentComboBox.DataSource = employeeList;
            UserIncidentComboBox.DisplayMember = "FirstName";

            Array incidentTypes = Enum.GetValues(typeof(Ticket.IncidentType));
            IncidentTypeComboBox.DataSource = incidentTypes;
            IncidentTypeComboBox.DisplayMember = "ToString";

            Array priorities = Enum.GetValues(typeof(Ticket.Priority));
            IncidentPriorityComboBox.DataSource = priorities;
            IncidentPriorityComboBox.DisplayMember = "ToString";


        }
        public Ticket NewTicket()
        {
            Ticket ticket = new Ticket
            {
                Date = IncidentDateTimePicker.Value,
                IncidentSubject = IncidentSubjectTxtBox.Text,
                User = (Employee)UserIncidentComboBox.SelectedItem,
                Type = (Ticket.IncidentType)IncidentTypeComboBox.SelectedItem,
                PriorityType = (Ticket.Priority)IncidentPriorityComboBox.SelectedItem,
                Deadline = IncidentDeadlinePicker.Value,
                Description = IncidentDescriptionTxtBox.Text,
                TicketStatus = Ticket.Status.Open
            };
          
            //if (loggedInEmployee.Type == Employee.EmployeeType.Employee)
            //{
            //    // This is a regular employee, can only add ticket for themselves
            //    if (ticket.User != loggedInEmployee)
            //    {
            //        throw new UnauthorizedTicketAccessException("Regular employees can only add tickets for themselves.");
            //    }

            //    ticket.User = loggedInEmployee;
            //}
            //else if (loggedInEmployee.Type == Employee.EmployeeType.ServiceDesk)
            //{
            //    // This is a service desk employee, can add ticket for all employees
            //    ticket.User = (Employee)UserIncidentComboBox.SelectedItem;
            //}

            ticketService.AddTicket(ticket);
            return ticket;
        }




        private void SubmitTicketBtn_Click(object sender, EventArgs e)
        {
            NewTicket();
            MessageBox.Show("Ticket submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    

        private void CancelBtn_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
