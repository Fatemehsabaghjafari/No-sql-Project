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
    public partial class sign_up : Form
    {
        private readonly EmployeeService employeeService;

        public sign_up()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            Array employeeType = Enum.GetValues(typeof(Employee.EmployeeType));
            comboBoxRole.DataSource = employeeType;
            comboBoxRole.DisplayMember = "ToString";
        }

        private void loginFromSignupBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            string firstName = firstnameTextbox.Text;
            string lastName = lastnametextbox.Text;
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;
            EmployeeType type = (Employee.EmployeeType)comboBoxRole.SelectedValue;
            string userName = usernameTextBox.Text;

            // Validate input fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            try
            {
                employeeService.AddUserAccount(firstName, lastName, type, userName, email, password);
                MessageBox.Show("User added successfully!");

                // Additional logic if needed, e.g., auto-login

                Login loginForm = new Login();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
            }
        }
    }
}
