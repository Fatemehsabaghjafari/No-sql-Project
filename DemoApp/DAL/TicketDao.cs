using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        //public List<Ticket> GetTicketsByUser(Employee user)
        //{
        //    return collection1.Find(ticket => ticket.User.Id == user.Id).ToList();
        //}

        public void DeleteTicket(Ticket ticket)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.Id, ticket.Id);
            collection1.DeleteOne(filter);
        }

        public void UpdateTicket(Ticket ticket)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.Id, ticket.Id);
            var update = Builders<Ticket>.Update
                .Set(t => t.IncidentSubject, ticket.IncidentSubject)
                .Set(t => t.User, ticket.User)
                .Set(t => t.Date, ticket.Date)
                .Set(t => t.TicketStatus, ticket.TicketStatus);

            collection1.UpdateOne(filter, update);
        }

        public List<Ticket> GetTicketsByUser(Employee user)
        {
            return collection1.Find(ticket => ticket.User.Id == user.Id).ToList();
        }

        public List<Ticket> GetTicketsBySearchTerm(string searchTerm)
        {
            return collection1.Find(ticket =>
                ticket.IncidentSubject.ToLower().Contains(searchTerm.ToLower()) ||
                ticket.User.FirstName.ToLower().Contains(searchTerm.ToLower())
            ).ToList();
        }
    }
}
