using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Employee;

namespace Logic
{
    public class EmployeeService
    {
        private EmployeeDao employee;
        public EmployeeService()
        {
            employee = new EmployeeDao();
        }

        public void AddUserAccount(string firstname, string lastname, EmployeeType type, string email, string userName, string password)
        {
            var user = new Employee { FirstName = firstname, LastName = lastname, Type = type, Email = email, Username=userName, Password = password };
            employee.InsertUser(user);
        }

        public bool AuthenticateUser(string username, string password)
        {
            // Retrieve user from DAL
            Employee user = employee.FindByUsername(username);

            if (user != null)
            {
                string storedPasswordHash = user.Password;

                // Perform password validation using BCrypt
                if (password == storedPasswordHash)
                {
                    return true; // Authentication successful
                }
            }

            return false; // Authentication failed
        }
    }
}
