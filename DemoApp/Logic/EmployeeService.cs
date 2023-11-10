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

        //private readonly 
        EmployeeDao employeeDao;


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
        public List <Employee> GetNormalEmployees()
        {
            return employeeDao.GetNormalEmployees();
        }
        public List<Employee> GetServiceDeskEmployee()
        {
            return employeeDao.GetServiceDeskEmployees();
        }
        public void AddUserAccount(string firstname, string lastname, EmployeeType type, string username, string email, string password)
        {
            var user = new Employee { FirstName = firstname, LastName = lastname, Type = type, Username = username, Email = email, Password = password };
            employeeDao.InsertUser(user);
        }

        public Employee AuthenticateUser(string username, string password)
        {
            return employeeDao.AuthenticateUser(username, password);
        }



    }
}
