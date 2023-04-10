using C969_ncarrel.Database;
using System.ComponentModel;
using System.Data;

namespace C969_ncarrel
{
    class DataTables
    {
        private BindingList<Customer> AllCustomers = new BindingList<Customer>();
        private CustomerData CustomerData = new CustomerData();

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
    }
}
