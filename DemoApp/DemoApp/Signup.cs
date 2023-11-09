using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Model.Employee;

namespace DemoApp
{
    public partial class Signup : Form
    {
        private readonly EmployeeService employeeService;
        public Signup()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
        }

        private void loginFromSignupBtn_Click(object sender, EventArgs e)
        {
            Login logInForm = new Login();
            this.Hide();
            logInForm.ShowDialog();
            this.Close();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            string firstName = firstnameTextbox.Text;
            string lastName = lastnametextbox.Text;
            //  string role = roletextBox.Text;
            EmployeeType type = (Employee.EmployeeType)comboBoxRole.SelectedValue;

            string email = emailTextbox.Text;
            string userName = usernameTextBox.Text;
            string password = passwordTextbox.Text;
            string confirmPassword = confirmTextbox.Text;

            employeeService.AddUserAccount(firstName, lastName, type, email, userName, password);
            MessageBox.Show("User added successfully!");
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            Array employeeType = Enum.GetValues(typeof(Employee.EmployeeType));
            comboBoxRole.DataSource = employeeType;
            comboBoxRole.DisplayMember = "ToString";
        }
    }
}
