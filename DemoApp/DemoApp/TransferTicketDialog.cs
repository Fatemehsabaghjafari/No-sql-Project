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
    public partial class TransferTicketDialog : Form
    {
        public Employee SelectedEmployee { get; private set; }
        public TransferTicketDialog(List<Employee> employees)
        {
            InitializeComponent();
            List<Employee> serviceDeskEmployees = employees.Where(employee => employee.Type == Employee.EmployeeType.ServiceDesk).ToList();
            foreach (Employee employee in serviceDeskEmployees)
            {
                listBoxEmployees.Items.Add(employee.FirstName +" "+ employee.LastName);
            }
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedItem != null)
            {
                SelectedEmployee = (Employee)listBoxEmployees.SelectedItem;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select an employee to transfer the ticket to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
