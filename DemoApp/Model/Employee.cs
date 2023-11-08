using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        //  public int Id { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public EmployeeType Type { get; set; }
        public string Email { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public enum EmployeeType { Regular, ServiceDesk }

    }
    
}
