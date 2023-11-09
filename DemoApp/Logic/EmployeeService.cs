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

       
        public void AddUserAccount(string firstname, string lastname, EmployeeType type, string email, string userName, string password)
        {
            var user = new Employee { FirstName = firstname, LastName = lastname, Type = type, Email = email, Username=userName, Password = password };
            employeeDao.InsertUser(user);
        }

        public bool AuthenticateUser(string username, string password)
        {
            // Retrieve user from DAL
            Employee user = employeeDao.FindByUsername(username);

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


        private readonly EmployeeDao employeeDao;


        public EmployeeService()
        {
            employeeDao = new EmployeeDao();
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDao.GetAllEmployees();
        }
        public void AddEmployee(Employee employee)
        {
            employeeDao.AddEmployee(employee);
        }

    }
}
