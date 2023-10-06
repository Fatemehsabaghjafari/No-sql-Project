using Logic;
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
        private readonly EmployeeService employeeService;
        public Login()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
        }

        private void signupFromLoginBtn_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            this.Hide();
            signUpForm.ShowDialog();
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextbox.Text;

            employeeService.AuthenticateUser(username, password);

            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();

        }
    }
}
