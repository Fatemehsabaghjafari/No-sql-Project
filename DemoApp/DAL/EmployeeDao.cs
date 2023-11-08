using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;


namespace DAL
{
    public class EmployeeDao : DAO
    {
        public EmployeeDao() : base() // Call the base class constructor to establish the connection
        {
            collection2 = database.GetCollection<Employee>("Employee"); // Specify your ticket collection name here
        }
            public void InsertUser(Employee user)
        {
            collection2.InsertOne(user);
        }

        public Employee FindByUsername(string username)
        {
            var filter = Builders<Employee>.Filter.Eq("Firstname", username);
            return collection2.Find(filter).FirstOrDefault();
        }

    }
}
