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
        EditingState currentState;
        struct EditingState
        {
            public EditingState(int id, bool editing) => (Id, Editing) = (id, editing);
            public int Id { get; }
            public bool Editing { get; }
        }
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

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);
            tbCustName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            if ((string)dgvCustomers.CurrentRow.Cells[2].FormattedValue == "Active")
            {
                rbActive.Checked = true;
            }
            else
            {
                rbInactive.Checked = true;
            }
            tbCustPhone.Text = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            tbCustAddress.Text = dgvCustomers.CurrentRow.Cells[4].Value.ToString();
            tbCustAddress2.Text = dgvCustomers.CurrentRow.Cells[5].Value.ToString();
            tbCustCity.Text = dgvCustomers.CurrentRow.Cells[6].Value.ToString();
            tbCustZIP.Text = dgvCustomers.CurrentRow.Cells[7].Value.ToString();
            cbCustCountry.Text = dgvCustomers.CurrentRow.Cells[8].Value.ToString();
            currentState = new EditingState(id, true);
            labelEditWarning.Visible = true;
            labelEditWarning.Text = $"Currently editing UID {id}";
        }

        private void btnCustEdit_Click(object sender, EventArgs e)
        {
            if (!currentState.Editing)
            {
                MessageBox.Show("You are not currently editing a customer. Double click a customer to start editing");
                return;
            }
            else
            {
                var result = MessageBox.Show($"Are you sure you want to edit {dgvCustomers.CurrentRow.Cells[1].Value} (UID {Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value)})?", "Confirm changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    modifyDB.Update(currentState.Id, tbCustName.Text, rbActive.Checked, tbCustAddress.Text, tbCustAddress2.Text, tbCustZIP.Text, tbCustPhone.Text, tbCustCity.Text, cbCustCountry.Text);
                    UpdateDataGrids();
                    currentState = new EditingState(-1, false);
                    labelEditWarning.Visible = false;
                }
            }
        }
    }
}
