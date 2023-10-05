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
    public partial class SignUp : Form
    {
        private readonly EmployeeService employeeService;
        public SignUp()
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
            string role = roletextBox.Text;
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;
            string confirmPassword = confirmTextbox.Text;

            employeeService.AddUserAccount(firstName, lastName, role, email, password);
            MessageBox.Show("User added successfully!");

        }
    }
}
