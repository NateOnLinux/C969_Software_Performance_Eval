using C969_ncarrel.Database;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace C969_ncarrel
{
    public partial class Homepage : Form
    {
        private DataTables CustomerView = new DataTables();
        CustomerData modifyDB = new CustomerData();
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
            UpdateDataGrids();
        }

        private void btnCustNew_Click(object sender, EventArgs e)
        {
            modifyDB.Create(tbCustName.Text, rbActive.Checked, tbCustAddress.Text, tbCustAddress2.Text, tbCustZIP.Text, tbCustPhone.Text, tbCustCity.Text, cbCustCountry.Text); 
            UpdateDataGrids();
        }

        private void btnCustDelete_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);
            modifyDB.Delete(id);
            UpdateDataGrids();
        }

        private void UpdateDataGrids()
        {
            dgvCustomers.DataSource = CustomerView.PopulateCustomers();
            dgvAppointments.DataSource = CustomerView.PopulateCustomers();
        }
    }
}
