using System;
using C969_ncarrel.Database;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class City //db has a table for cities, so may need city objects
    {
        public int cityId;
        public string city;
        public int countryId;
        public string country;
    }
    public class Address //db has table for addresses, so may need address objects
    {
        public int addressId;
        public string address;
        public string address2;
        public int cityId;
        public string postalCode;
        public string phone;
        public City city;
    }
    public class Customer //need customer objects to manip customer data
    {
        public int customerId;
        public string customerName;
        public int addressId;
        public string active;
        public Address address;
    }
    public class CustomerData : Connection //separate from Customer? Couldn't find a good solution to include customer object here
    {
        public QueryDB customerSearch = new QueryDB();
        public BindingList<Customer> result;
        public void Update(int customerId, Customer newData, Customer oldData)
        {

        }
        public int Create(Customer newCustomer)
        {
            // create a new Customer and add it to the list
            int result = 0; //placeholder
            return result;
        }
        public void Delete(int customerId)
        {

        }
        public BindingList<Customer> GetCustomers()
        {
            result = new BindingList<Customer>();
            string sqlString = "SELECT a.customerId, a.customerName, a.active, b.addressId, b.address, b.address2, c.cityId, b.postalCode, b.phone, c.city, d.countryId, d.country FROM (customer a LEFT JOIN address b ON a.addressId = b.addressId LEFT JOIN city c ON b.cityId = c.cityId LEFT JOIN country d ON c.countryId = d.countryId)";
            var incomingData = customerSearch.Query(sqlString);
            foreach (var incomingCollumn in incomingData)
            {
                var customer = new Customer();
                var address = new Address();
                var city = new City();

                customer.customerId = int.Parse(incomingCollumn[0]);
                customer.customerName = incomingCollumn[1];
                customer.active = incomingCollumn[2];
                customer.addressId = address.addressId = int.Parse(incomingCollumn[3]);
                address.address = incomingCollumn[4];
                address.address2 = incomingCollumn[5];
                address.cityId = city.cityId = int.Parse(incomingCollumn[6]);
                address.postalCode = incomingCollumn[7];
                address.phone = incomingCollumn[8];
                city.city = incomingCollumn[9];
                city.countryId = int.Parse(incomingCollumn[10]);
                city.country = incomingCollumn[11];

                address.city = city;
                customer.address = address;

                result.Add(customer);
            }
            return result;
        }
    }

    public class QueryDB : Connection // General method to query the MySql database using MySql.Data.MySqlClient. This might be used to populate dgv objects.
    {
        public List<List<string>> Query(string input)
        {
            cmd = new MySqlCommand(input, connection);
            reader = cmd.ExecuteReader();
            // resultList is a list which contains lists of strings
            var resultList = new List<List<string>>();
            // FieldCount gets the number of columns in the selected row
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
            // dispose of the reader
            reader.Close();
            // this is returning something unexpected. It should be returning a binding list of all rows but instead returns the current user's permissions. Why???
            return resultList;
        }
    }
}
