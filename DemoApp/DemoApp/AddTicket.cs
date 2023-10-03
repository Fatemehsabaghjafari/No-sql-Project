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
       
        public AddTicket()
        {
            InitializeComponent();
            ticketService= new TicketService();
            employeeService = new EmployeeService();
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {
            List<Employee> employeeList = employeeService.GetAllEmployees();
            List<string> userNames = employeeList.Select(emp => emp.FirstName).ToList();
            UserIncidentComboBox.DataSource = null;
            UserIncidentComboBox.DataSource = userNames;
            UserIncidentComboBox.DisplayMember = "FirstName";
        }
        public Ticket NewTicket()
        {
            Ticket ticket = new Ticket
            {
                Date = IncidentDateTimePicker.Value,
                IncidentSubject = IncidentSubjectTxtBox.Text,
                Type = (Ticket.IncidentType)IncidentTypeComboBox.SelectedItem,
                User = (Employee)UserIncidentComboBox.SelectedItem,
                PriorityType = (Ticket.Priority)IncidentPriorityComboBox.SelectedItem,
                Deadline = IncidentDeadlinePicker.Value,
                Description= IncidentDescriptionTxtBox.Text,

            };
            ticketService.AddTicket(ticket);
            return ticket;
        }
        

        private void SubmitTicketBtn_Click(object sender, EventArgs e)
        {
           NewTicket();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
