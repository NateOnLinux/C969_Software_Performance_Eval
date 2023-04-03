using C969_ncarrel.Database;
using System.ComponentModel;
using System.Data;

namespace C969_ncarrel
{
    class CustomerView
    {
        private BindingList<Customer> AllCustomers = new BindingList<Customer>();
        private CustomerData CustomerData = new CustomerData();

        public DataTable PopulateCustomers()
        {
            var tableCustomers = new DataTable();
            AllCustomers = CustomerData.GetCustomers();
            tableCustomers.Columns.Add("Customer ID");
            tableCustomers.Columns.Add("Name");
            tableCustomers.Columns.Add("Status");
            tableCustomers.Columns.Add("Phone");
            tableCustomers.Columns.Add("Address");
            tableCustomers.Columns.Add("Address ln. 2");
            tableCustomers.Columns.Add("City");
            tableCustomers.Columns.Add("ZIP");
            tableCustomers.Columns.Add("Country");
            foreach (var entry in AllCustomers)
            {
                string customerStatus = entry.active == "False" ? "Inactive" : "Active";
                tableCustomers.Rows.Add(entry.customerId, entry.customerName, customerStatus, entry.address.phone, entry.address.address, entry.address.address2, entry.address.city.city, entry.address.postalCode, entry.address.city.country);
            }
            return tableCustomers;
        }
    }
}
