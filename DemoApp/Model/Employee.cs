
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
       
        public string Password { get; set; }
        public string Username {  get; set; }

        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Locations Location { get; set; }
        public string PhoneNumber { get; set; }
        public EmployeeType Type { get; set; }
        public enum EmployeeType { Employee, ServiceDesk }
        public enum Locations {Haarlem, Amsterdam, Knuppeldam, Headquarters }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
   


}
    