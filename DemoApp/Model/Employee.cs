
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public ObjectId Id { get; set; }  
        public string Password { get; set; }
        public EmployeeType Type { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  Ticket Ticket { get; set; }
        public string PhoneNumber { get; set; }

    }
    public enum EmployeeType { Regular, ServiceDesk}
}
