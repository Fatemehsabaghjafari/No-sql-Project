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
using System.Globalization;


namespace DemoApp
{
    public partial class EditTicketForm : Form
    {
        private Ticket ticket;
        private TicketService ticketService;

        public EditTicketForm(Ticket selectedTicket)
        {
            InitializeComponent();
            ticket = selectedTicket;
            ticketService = new TicketService();
            subjectTextBox.Text = ticket.IncidentSubject;
            userTextBox.Text = ticket.User.FirstName;
            dateTextBox.Text = ticket.Date.ToString("yyyy-MM-dd HH:mm:ss");
            statusTextBox.Text = ticket.TicketStatus.ToString();
        }

        private void SaveChangesBtn_Click_1(object sender, EventArgs e)
        {
            ticket.IncidentSubject = subjectTextBox.Text;
            ticket.User.FirstName = userTextBox.Text;
            ticket.Date = DateTime.ParseExact(dateTextBox.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            ticket.TicketStatus = (Ticket.Status)Enum.Parse(typeof(Ticket.Status), statusTextBox.Text);

            // Call the UpdateTicket method in your DAO
            ticketService.UpdateTicket(ticket);

            // Close the form
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
