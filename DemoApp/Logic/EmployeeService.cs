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
