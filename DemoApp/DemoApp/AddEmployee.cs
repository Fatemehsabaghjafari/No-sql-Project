using Logic;
using Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class AddEmployee : Form
    {
        private EmployeeService employeeService;
        public AddEmployee()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
        }
        

        

        private void cancelUserBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AddEmployee_Load(object sender, EventArgs e)
        {
            Array employeeType =Enum.GetValues(typeof(Employee.EmployeeType));
            userTypeCombo.DataSource= employeeType;
            userTypeCombo.DisplayMember = "ToString";

            Array locations = Enum.GetValues(typeof(Employee.Locations));
            locationCombo.DataSource = locations;
            locationCombo.DisplayMember = "ToString";
        }
        public Employee NewEmployee()
        {
            Employee employee = new Employee
            {
                FirstName = firstNameTxt.Text, 
                LastName = lastNameTxt.Text,
                Email = emailTxt.Text,
                PhoneNumber = phoneTxt.Text,
                Type= (Employee.EmployeeType)userTypeCombo.SelectedValue,
                Location= (Employee.Locations)locationCombo.SelectedValue,
            };
            employeeService.AddEmployee(employee);
            return employee;

        }
       
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            NewEmployee();
            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearUserInputFields();
        }
        private void ClearUserInputFields()
        {

            firstNameTxt.Text = "";
            lastNameTxt.Text = "";
            emailTxt.Text = "";
            phoneTxt.Text = "";
            userTypeCombo.SelectedIndex = 0;
            locationCombo.SelectedIndex = 0;
        }

        

        
    }
}
