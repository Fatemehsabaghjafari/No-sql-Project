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

    }
}
