using C969_ncarrel.Database;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System;

namespace C969_ncarrel
{
    class DataTables : Connection
    {
        private BindingList<Customer> AllCustomers = new BindingList<Customer>();
        private BindingList<Appointment> AllAppointments = new BindingList<Appointment>();
        private CustomerData CustomerData = new CustomerData();
        private Appointment Appointments = new Appointment();

        public DataTable PopulateCustomers()
        {
            var dtCustomers = new DataTable();
            AllCustomers = CustomerData.GetCustomers();
            dtCustomers.Columns.Add("Customer ID");
            dtCustomers.Columns.Add("Name");
            dtCustomers.Columns.Add("Status");
            dtCustomers.Columns.Add("Phone");
            dtCustomers.Columns.Add("Address");
            dtCustomers.Columns.Add("Address ln. 2");
            dtCustomers.Columns.Add("City");
            dtCustomers.Columns.Add("ZIP");
            dtCustomers.Columns.Add("Country");
            foreach (var entry in AllCustomers)
            {
                string customerStatus = entry.active == "False" ? "Inactive" : "Active";
                dtCustomers.Rows.Add(entry.customerId, entry.customerName, customerStatus, entry.address.phone, entry.address.address, entry.address.address2, entry.address.city.city, entry.address.postalCode, entry.address.city.country.country);
            }
            return dtCustomers;
        }

        public DataView PopulateAppointments(string filter)
        {
            var dtAppointments = new DataTable();
            AllAppointments = Appointments.GetAppointments();
            dtAppointments.Columns.Add("Appointment ID");
            dtAppointments.Columns.Add("Customer");
            dtAppointments.Columns.Add("Date");
            dtAppointments.Columns.Add("Start");
            dtAppointments.Columns.Add("End");
            dtAppointments.Columns.Add("Title");
            dtAppointments.Columns.Add("Type");
            foreach (var entry in AllAppointments)
            {
                var sqlString = $"SELECT customerName FROM customer WHERE customerId = {entry.customerId}";
                cmd = new MySqlCommand(sqlString,connection);
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    var customerName = reader.GetString(0);
                    dtAppointments.Rows.Add(entry.appointmentId, customerName, entry.start.ToString("MM/dd/yyyy"), entry.start.TimeOfDay, entry.end.TimeOfDay, entry.title, entry.type);
                }
                reader.Close();
            }
            var dvAppointments = new DataView(dtAppointments);
            dvAppointments.RowFilter = filter;
            return dvAppointments;
        }
    }
}
