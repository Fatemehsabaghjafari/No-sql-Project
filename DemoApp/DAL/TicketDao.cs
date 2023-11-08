using Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using static Model.Ticket;

namespace DAL
{
    public class TicketDao: DAO
    {
        public TicketDao() : base() // Call the base class constructor to establish the connection
        {
            collection1 = database.GetCollection<Ticket>("Garden-group"); // Specify your ticket collection name here
          
        }
        public List<Ticket> GetAllTickets()
        {
            return collection1.Find(_ => true).ToList();
        }
        public void AddTicket(Ticket ticket)
        {
            collection1.InsertOne(ticket);
        }
        public void UpdateTicket(Ticket ticket, Status status)
        {
            ticket.TicketStatus = status;
            collection1.ReplaceOne(x => x.Id == ticket.Id, ticket);
        }

        public void EditTicket(Ticket ticket)
        {
            collection1.ReplaceOne(x => x.Id == ticket.Id, ticket);
        }
        public void DeleteTicket(Ticket ticket) 
        {
            collection1.DeleteOne(x => x.Id == ticket.Id);
        }

        public Ticket GetTicketById(Ticket ticket)
        {
            // Use MongoDB query to find a ticket by ID
            return collection1.Find(x => x.Id == ticket.Id).FirstOrDefault();
        }
        public List<Ticket> GetSortedTicketsByPriority()
        {
            return collection1.Find(_ => true)
            .Sort(Builders<Ticket>.Sort.Ascending(t => t.PriorityType))
            .ToList();
            //return collection1.Find(_ => true)
            //    .SortByDescending(t => (int) t.PriorityType)
            //    .ToList();
        }
    }
}
