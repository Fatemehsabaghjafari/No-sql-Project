﻿using Model;
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
       
       

        


        

    }
}
