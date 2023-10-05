using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EmployeeService
    {
        private EmployeeDao employee;
        public EmployeeService()
        {
            employee = new EmployeeDao();
        }

        public void AddUserAccount(string firstname, string lastname, string role, string email, string password)
        {
            var user = new Employee { FirstName = firstname, LastName = lastname, Role = role, Email = email, Password = password };
            employee.InsertUser(user);
        }
    }
}
