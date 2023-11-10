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

namespace DemoApp
{
    public partial class Login : Form
    {
        private Employee employee;
        private readonly EmployeeService employeeService;
        public Login()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
        }
        private void signupFromLoginBtn_Click(object sender, EventArgs e)
        {
            sign_up signUpForm = new sign_up();
            this.Hide();
            signUpForm.ShowDialog();
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextbox.Text;

            employee = employeeService.AuthenticateUser(username, password);

            if (employee != null)
            {   
                Form1 mainForm = new Form1(employee);
                mainForm.Show(); 
                this.Hide();                                  

            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
        }
    }
}
