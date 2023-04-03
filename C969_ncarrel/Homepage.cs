using C969_ncarrel.Database;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace C969_ncarrel
{
    public partial class Homepage : Form
    {
        private CustomerView CustomerView = new CustomerView();

        public Homepage()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = CustomerView.PopulateCustomers();
            dgvAppointments.DataSource = CustomerView.PopulateCustomers();
        }
    }
}
