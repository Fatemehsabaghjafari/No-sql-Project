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
        public SignUp()
        {
            InitializeComponent();
        }

        private void loginFromSignupBtn_Click(object sender, EventArgs e)
        {
            Login logInForm = new Login();
            this.Hide();
            logInForm.ShowDialog();
            this.Close();
        }
    }
}
