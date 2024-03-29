﻿using Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

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






    }
}
