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
            collection2 = database.GetCollection<Employee>("employee"); // Specify your ticket collection name here

        }
        public List<Employee> GetAllEmployees()
        {
            return collection2.Find(_ => true).ToList();
        }
           
        public void AddEmployee(Employee employee)
        {
            collection2.InsertOne(employee);
        }
        public List<Employee> GetServiceDeskEmployees()
        {
            return collection2.Find(employee => employee.Type == Employee.EmployeeType.ServiceDesk).ToList();
        }
        public List<Employee> GetNormalEmployees()
        {
            return collection2.Find(employee => employee.Type == Employee.EmployeeType.Employee).ToList();
        }
        public void InsertUser(Employee user)
        {
            collection2.InsertOne(user);
        }



        public Employee AuthenticateUser(string username, string password)
        {
            // Retrieve user from DAL by username
            var filter = Builders<Employee>.Filter.Eq("FirstName", username);

            Employee user = collection2.Find(filter).FirstOrDefault();

            if (user != null)
            {
                // Perform password validation using BCrypt
                if (password == user.Password)
                {
                    return user; // Return authenticated user
                }
            }

            return null; // Authentication failed
        }


    }
}
