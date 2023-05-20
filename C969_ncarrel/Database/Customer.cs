using System;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Windows.Forms;

namespace C969_ncarrel.Database
{
    //public class Customer
    //{
    //    public int customerId;
    //    public string customerName;
    //    public int addressId;
    //    public string active;
    //    public Address address;
    //}
    public class Customer : Connection
    {
        public int customerId;
        public string customerName;
        public int addressId;
        public string active;
        public Address address;

        public QueryDB customerConnection = new QueryDB();
        public BindingList<Customer> blCustomers;
        public User currentUser = new User();
        string userName;
        public void Update(int customerId, string customerName, bool active, string address, string address2, string postalCode, string phone, string city, string country)
        {
            userName = currentUser.GetUserName(C969_ncarrel.Login.mainScreen.UserId);
            var updateCountry = new Country();
            var updateCity = new City();
            var updateAddress = new Address();
            var newCountryId = updateCountry.GetId(country);
            var newCityId = updateCity.GetId(city, newCountryId);
            var newAddressId = updateAddress.GetId(address, address2, newCityId, postalCode, phone);
            try
            {
                var sqlString = 
                    $"UPDATE customer " +
                    $"SET customerName='" + MySqlHelper.EscapeString(customerName) + $"',addressId={newAddressId},active={active},lastUpdate=now(),lastUpdateBy='{userName}' WHERE customerId={customerId};";
                _ = customerConnection.Query(sqlString);
            }
            catch(Exception e)
            {
                MessageBox.Show($"Please check that all required fields have been filled. \n{e}");
            }
        }
        public void Create(string customerName, bool active, string address, string address2, string postalCode, string phone, string city, string country)
        {
            var newCustCountry = new Country();
            var newCustCity = new City();
            var newCustAddress = new Address();
            var countryId = newCustCountry.GetId(country);
            var cityId = newCustCity.GetId(city, countryId);
            var addressId = newCustAddress.GetId(address, address2, cityId, postalCode, phone);
            try
            {
                var sqlString = 
                    $"INSERT INTO customer(customerName,addressId,active,createDate,createdBy,lastUpdate,lastUpdateBy) " +
                    $"VALUES('" + MySqlHelper.EscapeString(customerName) + $"',{addressId},{active},now(),'{userName}',now(),'{userName}')";
                _ = customerConnection.Query(sqlString);
            }
            catch(Exception e)
            {
                MessageBox.Show($"Please check that all required fields have been filled. \n{e}");
            }
        }
        public void Delete(int customerId)
        {
            string sqlString =
                $"DELETE FROM appointment WHERE customerId={customerId};" +
                $"DELETE FROM customer WHERE customerId={customerId};"; //alternatively, cascade
            var warning = MessageBox.Show($"Are you sure you want to delete customer {customerId}? All of this customer 's appointments will also be deleted.", $"Delete {customerId}?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch(warning)
            {
                case DialogResult.Yes:
                    _ = customerConnection.Query(sqlString);
                    MessageBox.Show($"Successfully deleted customer {customerId}");
                    break;
                default:
                    MessageBox.Show($"No customers were deleted");
                    break;
            }
        }
        public BindingList<Customer> GetCustomers()
        {
            blCustomers = new BindingList<Customer>();
            string sqlString = 
                "SELECT a.customerId, a.customerName, a.active, b.addressId, b.address, b.address2, c.cityId, b.postalCode, b.phone, c.city, d.countryId, d.country " +
                "FROM (customer a LEFT JOIN address b ON a.addressId = b.addressId LEFT JOIN city c ON b.cityId = c.cityId LEFT JOIN country d ON c.countryId = d.countryId)";
            var dataIn = customerConnection.Query(sqlString);
            foreach (var collumnIn in dataIn)
            {
                var customer = new Customer();
                var address = new Address();
                var city = new City();
                var country = new Country();
                
                customer.customerId = int.Parse(collumnIn[0]);
                customer.customerName = collumnIn[1];
                customer.active = collumnIn[2];
                customer.addressId = address.addressId = int.Parse(collumnIn[3]);
                address.address = collumnIn[4];
                address.address2 = collumnIn[5];
                address.cityId = city.cityId = int.Parse(collumnIn[6]);
                address.postalCode = collumnIn[7];
                address.phone = collumnIn[8];
                city.city = collumnIn[9];
                city.countryId = country.countryId = int.Parse(collumnIn[10]);
                country.country = collumnIn[11];

                city.country = country;
                address.city = city;
                customer.address = address;

                blCustomers.Add(customer);
            }
            return blCustomers;
        }
    }
}
