using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TicketService
    {
        private readonly TicketDao ticketDao;


        public TicketService()
        {
            ticketDao = new TicketDao();
        }
        public List<Ticket> GetAllTickets()
        {
            return ticketDao.GetAllTickets();
        }
        public void AddTicket(Ticket ticket)
        {
            ticketDao.AddTicket(ticket);
        }
        public void UpdateTicketStatus(Ticket ticket, Ticket.Status status)
        {
            ticketDao.UpdateTicket(ticket, status);
        }
        public void EditTicket(Ticket ticket)
        {
            ticketDao.EditTicket(ticket);
        }
        public void DeleteTicket(Ticket ticket)
        {
            ticketDao.DeleteTicket(ticket);
        }
        public Ticket GetTicketById(Ticket ticket)
        {
           
            return ticketDao.GetTicketById(ticket);
        }
    }
}
