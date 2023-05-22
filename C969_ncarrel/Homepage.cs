﻿using C969_ncarrel.Database;
using System;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace C969_ncarrel
{
    public partial class Homepage : Form
    {
        private DataTables _DataTables = new DataTables();
        private readonly Customer Customer = new Customer();
        private Appointment Appointment;
        private EditingState currentState;
        public int UserId { get; set; }

        private struct EditingState
        {
            public EditingState(int id, bool editing) => (Id, Editing) = (id, editing);
            public int Id { get; }
            public bool Editing { get; }
        }
        public Homepage(int userId)
        {
            UserId = userId;
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void Homepage_Load(object sender, EventArgs e)
        {
            _ = new Appointment().CheckNext15();
            UpdateDataGrids();
        }

        private void btnCustNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    Customer.Create(tbCustName.Text, rbActive.Checked, tbCustAddress.Text, tbCustAddress2.Text, tbCustZIP.Text, tbCustPhone.Text, tbCustCity.Text, cbCustCountry.Text);
                    ClearFields();
                }
            }
            catch(Exception i)
            {
                Console.WriteLine(i);
            }
            UpdateDataGrids();
        }

        private void btnCustDelete_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value);
            Customer.Delete(id);
            UpdateDataGrids();
        }

        private void UpdateDataGrids()
        {
            var selectedDate = monthCalendar1.SelectionStart;
            RadioButton selectedFilter = new RadioButton();
            //I used a Lambda expression to determine which radio button in the array is checked (rb) => {rb.Checked}. This saves several lines and avoids the use of if/else if statements
            selectedFilter = new[] { rbDay, rbWeek, rbMonth }.FirstOrDefault(rb => rb.Checked);
            //I used a Lambda expression to create function `(rb) => {return "string";}`; 
            Func<RadioButton, string> filterSelector = rb =>
            {
                if (rb == rbDay)
                    return $"Date = '{selectedDate:MM/dd/yyyy}'";
                else if (rb == rbWeek)
                    return $"Date >= '{selectedDate:MM/dd/yyyy}' AND Date <= '{selectedDate.AddDays(7):MM/dd/yyyy}'";
                else if (rb == rbMonth)
                    return $"Date >= '{selectedDate:MM/dd/yyyy}' AND Date <= '{selectedDate:MM}/{DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month)}/{selectedDate.Year}'";
                else
                    return $"";
            };
            dgvCustomersAppt.DataSource = dgvCustomers.DataSource = _DataTables.PopulateCustomers();
            dgvCalendar.DataSource = _DataTables.PopulateAppointments(filterSelector(selectedFilter));
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
            btnCancel.Visible = true;
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
                    Customer.Update(currentState.Id, tbCustName.Text, rbActive.Checked, tbCustAddress.Text, tbCustAddress2.Text, tbCustZIP.Text, tbCustPhone.Text, tbCustCity.Text, cbCustCountry.Text);
                    UpdateDataGrids();
                    currentState = new EditingState(-1, false);
                    ClearFields();
                    labelEditWarning.Visible = false;
                    labelEditWarning2.Visible = false;
                    btnCancel.Visible = false;
                    btnCancel2.Visible = false;
                }
            }
        }

        private void dgvCustomersAppt_CellClick(object sender, DataGridViewCellEventArgs e) => tbApptsCustomer.Text = dgvCustomersAppt.CurrentRow.Cells[1].Value.ToString();

        private void btnApptSave_Click(object sender, EventArgs e)
        {
            Appointment = new Appointment();
            Appointment.customerId = Convert.ToInt32(dgvCustomersAppt.CurrentRow.Cells[0].Value);
            dtpApptStart.Value = DateTime.SpecifyKind(dtpApptStart.Value, DateTimeKind.Local);
            dtpApptEnd.Value = DateTime.SpecifyKind(dtpApptEnd.Value, DateTimeKind.Local);
            Appointment.title = tbApptTitle.Text;
            Appointment.description = tbApptDescription.Text;
            Appointment.location = tbApptLocation.Text;
            Appointment.contact = tbApptContact.Text;
            Appointment.type = tbApptType.Text;
            Appointment.url = tbApptURL.Text;
            Appointment.start = dtpApptStart.Value.ToUniversalTime();
            Appointment.end = dtpApptEnd.Value.ToUniversalTime();
            Appointment.userId = Login.mainScreen.UserId;

            if (!currentState.Editing)
            {
                var success = Appointment.Create(Appointment);
                if(success)
                {
                    ClearFields();
                }
            }
            else
            {
                var success = Appointment.Update(currentState.Id, Appointment);
                if(success)
                {
                    ClearFields();
                }
                currentState = new EditingState(-1,false);
            }
            UpdateDataGrids();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Appointment = new Appointment();
            var appointmentId = Convert.ToInt32(dgvCalendar.CurrentRow.Cells[0].Value);
            Appointment.Delete(appointmentId);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvCalendar.CurrentRow.Cells[0].Value);
            Appointment = new Appointment();
            Appointment = Appointment.GetAppointments(id);
            tbApptTitle.Text = Appointment.title;
            tbApptDescription.Text = Appointment.description;
            tbApptLocation.Text = Appointment.location;
            tbApptContact.Text = Appointment.contact;
            tbApptType.Text = Appointment.type;
            tbApptURL.Text = Appointment.url;
            dtpApptStart.Value = Appointment.start;
            dtpApptEnd.Value = Appointment.end;
            tabControlMainScreen.SelectedTab = tabPageAppointments;
            UpdateDataGrids();
            foreach (DataGridViewRow row in dgvCustomersAppt.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == Appointment.customerId)
                {
                    dgvCustomersAppt.Rows[row.Index].Selected = true;
                    tbApptsCustomer.Text = row.Cells[1].Value.ToString();
                }
            }
            currentState = new EditingState(id, true);
            labelEditWarning2.Text = $"Currently Editing Appointment {id}";
            labelEditWarning.Visible = true;
            labelEditWarning2.Visible = true;
            btnCancel.Visible = true;
            btnCancel2.Visible = true;
        }
        private void tabControlMainScreen_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (currentState.Editing)
            {
                var Confirm = MessageBox.Show($"You have unsaved changes. Continue without saving?", "Continue without saving?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Confirm == DialogResult.OK)
                {
                    ClearFields();
                    currentState = new EditingState(-1, false);
                }
                else if (Confirm == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) => UpdateDataGrids();

        private void rbDay_CheckedChanged(object sender, EventArgs e) => UpdateDataGrids();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult clear = currentState.Editing ? MessageBox.Show($"Stop editing? All fields will be reset.", "Stop editing?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) : MessageBox.Show($"Clear all fields?", "Stop editing?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (clear == DialogResult.Yes)
            {
                ClearFields();
                currentState = new EditingState(-1, false);
                labelEditWarning.Visible = false;
                labelEditWarning2.Visible = false;
                btnCancel.Visible = false;
                btnCancel2.Visible = false;
            }
        }

        private void btnGenReports_Click(object sender, EventArgs e)
        {
            var Report = new Report();
            Report.GenerateReport(1);
            reportsInfoLabel.Text = "Reports are saved to: " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\reports\";
            reportsInfoLabel.Visible = true;
        }
        private void ClearFields()
        {
            tbCustName.Text = "";
            tbCustAddress.Text = "";
            tbCustAddress2.Text = "";
            tbCustZIP.Text = "";
            tbCustPhone.Text = "";
            tbCustCity.Text = "";
            cbCustCountry.Text = "";
            tbApptTitle.Text = "";
            tbApptDescription.Text = "";
            tbApptLocation.Text = "";
            tbApptContact.Text = "";
            tbApptType.Text = "";
            tbApptURL.Text = "";
        }
    }
}
