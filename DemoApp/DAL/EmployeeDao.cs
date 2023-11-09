


using Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;


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

        public List<Employee> GetAllEmployees()
        {
            return collection2.Find(_ => true).ToList();
        }
        public void AddEmployee(Employee employee)
        {
            collection2.InsertOne(employee);
        }
    }
}

