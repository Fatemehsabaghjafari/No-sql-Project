﻿using Model;
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
          
        }
       
       

        


        

    }
}
