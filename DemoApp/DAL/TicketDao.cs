using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Ticket;

namespace DAL
{
    public class TicketDao: DAO
    {
        public TicketDao() : base() // Call the base class constructor to establish the connection
        {
            collection = database.GetCollection<Ticket>("Garden-group"); // Specify your ticket collection name here
          //  collection.InsertOne(newTicket);
        }
        //Ticket newTicket = new Ticket
        //{
        //    TicketStatus = Status.Open,
        //    Type = IncidentType.Hardware,
        //    IncidentSubject = "Server Issue",
        //    Id = 1,
        //    Subject = "Server Down",
        //    User = "admin",
        //    Date = DateTime.UtcNow,
        //    PriorityType = Priority.High,
        //    Deadline = "2023-09-30",
        //    Description = "The server is currently down and needs immediate attention."
        //};

       

        


        

    }
}
