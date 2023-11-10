using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

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
        public List<Ticket> GetTicketsByUser(Employee user)
        {
            return ticketDao.GetTicketsByUser(user);
        }
        public void AddTicket(Ticket ticket)
        {
            ticketDao.AddTicket(ticket);
        }
        public void UpdateTicket(Ticket ticket)
        {
            ticketDao.UpdateTicket(ticket);
        }
        public void DeleteTicket(Ticket ticket)
        {
            ticketDao.DeleteTicket(ticket);
        }
        public List<Ticket> GetTicketsBySearchTerm(string searchTerm)
        {
            return ticketDao.GetTicketsBySearchTerm(searchTerm);
        }
        public Ticket GetTicketById(ObjectId ticketid)
        {
            return ticketDao.GetTicketById(ticketid);
        }
        public List<Ticket> GetSortedTickets()
        {
            return ticketDao.GetSortedTicketsByPriority();
        }

    }
}
