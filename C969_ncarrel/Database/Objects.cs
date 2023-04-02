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
        public int customerName;
        public int addressId;
        public string active;
        public Address address;
    }
    public class ListCustomers : Connection //separate from Customer? Couldn't find a good solution to include customer object here
    {
        public BindingList<Customer> customers = new BindingList<Customer>();
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
    }

    public class QueryDB : Connection // General method to query the MySql database using MySql.Data.MySqlClient. This might be used to populate dgv objects. Perhaps this belongs in its own file?
    {
        public BindingList<BindingList<string>> Query(string input)
        {
            // cmd and reader are defined in Connection.cs
            cmd = new MySqlCommand(input, connection);
            reader = cmd.ExecuteReader();
            // resultList is a binding list which contains binding lists of strings
            var resultList = new BindingList<BindingList<string>>();
            // FieldCount gets the number of columns in the selected row
            var columns = reader.FieldCount;
            // increment count until all columns have been added and loop until reader.Read() returns false
            while (reader.Read())
            {
                BindingList<string> dataEntry = new BindingList<string>();
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
