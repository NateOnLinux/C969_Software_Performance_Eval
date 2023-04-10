using System;
using C969_ncarrel.Database;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace C969_ncarrel.Database
{
    public class Appointment : Connection
    {
        //all vars are named the exact same as in the database for readability
        public int appointmentId;
        public int customerId;
        public int userId;
        public string title;
        public string description;
        public string location;
        public string contact;
        public string type;
        public string url;
        public DateTime start;
        public DateTime end;
        public DateTime createDate;
        public string createdBy;
        public DateTime lastUpdate;
        public string lastUpdateBy;
        
        public bool ConflictCheck(DateTime start, DateTime end)
        {
            //using start and end, check that no other appointments occupy the time slot. If another appointment occupies the time slot, return false and show error dialogue
            return true;
        }
        
        public int Create(int appointmentId, Appointment newAppointment)
        {
            // using appointment data, add or update appointment entries
            return appointmentId;
        }

        public void Delete(int appointmentId)
        {
            //using the appointmentID parameter, "DELETE FROM appointment WHERE appointmentId = " + appointmentID + ";";
        }

    }
    public class Country
    {
        public int countryId;
        public string country;
    }
    public class City
    {
        public int cityId;
        public string city;
        public int countryId;
        public Country country;
    }
    public class Address
    {
        public int addressId;
        public string address;
        public string address2;
        public int cityId;
        public string postalCode;
        public string phone;
        public City city;
    }
    public class Customer
    {
        public int customerId;
        public string customerName;
        public int addressId;
        public string active;
        public Address address;
    }
    public class CustomerData : Connection //separate from Customer? Couldn't find a good solution to include customer object here
    {
        public QueryDB customerConnection = new QueryDB();
        public BindingList<Customer> blCustomers;
        public void Update(int customerId, Customer newData, Customer oldData)
        {

        }
        public void Create(string customerName, bool active, string address, string address2, string postalCode, string phone, string city, string country)
        {
            var user = "test"; //TODO: Store user on login for use here

            ///<<ISSUE>>
            ///Low prio - it aint broke so don't fix it
            ///
            ///There's probably a better way to do this.
            ///One statement going to "else" means everything else will also go to "else" - new contry=new city=new address 
            ///BUT, statements going through "if" does not mean everything else will go to "if" - could have existing country+existing city+new address, or existing country+new city+new address 
            ///Will need to ask somebody to help me with this
            ///<</ISSUE>
            ///<<example>>
            ///The lines _ = customerConnection.Query(sqlString); may be replaced with the following:
            ////     cmd = new MySqlCommand(sqlString, connection); 
            ////     cmd.ExecuteNonQuery();
            ///<</example>>

            //Check Country
            int countryId;
            string sqlString = $"SELECT countryId FROM country WHERE country='{country}';";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            
            if(reader.HasRows) //Get the countryId
            {
                reader.Read();
                countryId = Convert.ToInt32(reader.GetValue(0));
                reader.Close();
            }
            else //Create a new country and get its Id
            {
                reader.Close();
                sqlString = $"INSERT INTO country(country,createDate,createdBy,lastUpdate,lastUpdateBy) VALUES('{country}',now(),'{user}',now(),'{user}');";
                _ = customerConnection.Query(sqlString);
                countryId = (int)cmd.LastInsertedId;
            }

            //Check City
            int cityId;
            sqlString = $"SELECT cityId FROM city WHERE city='{city}' AND countryId={countryId}";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            if(reader.HasRows) //Get the cityId
            {
                reader.Read();
                cityId = Convert.ToInt32(reader.GetValue(0));
                reader.Close();
            }
            else //Create a new city and get its Id
            {
                reader.Close();
                sqlString = $"INSERT INTO city(city,countryId,createDate,createdBy,lastUpdate,lastUpdateBy) VALUES('{city}','{countryId}',now(),'{user}',now(),'{user}');";
                _ = customerConnection.Query(sqlString);
                cityId = (int)cmd.LastInsertedId;
            }

            //Check Address
            int addressId;
            // select the address ID for which address, address 2, cityId, and postalCode are an exact match
            sqlString = $"SELECT addressId FROM address WHERE address='{address}' AND address2='{address2}' AND cityId={cityId} AND postalCode='{postalCode}';";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            if(reader.HasRows) //get addressId
            {
                reader.Read();
                addressId = Convert.ToInt32(reader.GetValue(0));
                reader.Close();
            }
            else //create new address and get its Id
            {
                reader.Close();
                sqlString = $"INSERT INTO address(address,address2,cityId,postalCode,phone,createDate,createdBy,lastUpdate,lastUpdateBy) VALUES('{address}','{address2}',{cityId},{postalCode},'{phone}',now(),'{user}',now(),'{user}');";
                _ = customerConnection.Query(sqlString);
                addressId = (int)cmd.LastInsertedId;
            }

            //Take the countryId, cityId, and addressId values we got above and use them to create a new Customer entry
            sqlString = $"INSERT INTO customer(customerName,addressId,active,createDate,createdBy,lastUpdate,lastUpdateBy) VALUES('{customerName}',{addressId},{active},now(),'{user}',now(),'{user}')";
            _ = customerConnection.Query(sqlString); //'_ = Foo();' disposes the returned data because we're just running the INSERT INTO but no query
        }
        public void Delete(int customerId)
        {
            string sqlString = $"DELETE FROM customer WHERE customerId={customerId}";
            var warning = MessageBox.Show($"Are you sure you want to delete customer {customerId}?", $"Delete {customerId}?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            string sqlString = "SELECT a.customerId, a.customerName, a.active, b.addressId, b.address, b.address2, c.cityId, b.postalCode, b.phone, c.city, d.countryId, d.country FROM (customer a LEFT JOIN address b ON a.addressId = b.addressId LEFT JOIN city c ON b.cityId = c.cityId LEFT JOIN country d ON c.countryId = d.countryId)";
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
                city.countryId = int.Parse(collumnIn[10]);
                country.country = collumnIn[11];

                city.country = country;
                address.city = city;
                customer.address = address;

                blCustomers.Add(customer);
            }
            return blCustomers;
        }
    }

    public class QueryDB : Connection // General method to query the MySql database using MySql.Data.MySqlClient. This might be used to populate dgv objects.
    {
        public List<List<string>> Query(string input)
        {
            cmd = new MySqlCommand(input, connection);
            reader = cmd.ExecuteReader();
            var resultList = new List<List<string>>();
            var columns = reader.FieldCount;
            // increment count until all columns have been added and loop until reader.Read() returns false
            while (reader.Read())
            {
                List<string> dataEntry = new List<string>();
                int count = 0;
                while(count < columns)
                {
                    dataEntry.Add(reader.GetString(count));
                    count++;
                }
                resultList.Add(dataEntry);
            }
            reader.Close();
            return resultList;
        }
    }
}
