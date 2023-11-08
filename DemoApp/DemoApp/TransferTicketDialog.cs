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
           
            foreach (Employee employee in employees)
            {
                listBoxEmployees.Items.Add(employee);
            }
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedItem != null && listBoxEmployees.SelectedItem is Employee)
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
