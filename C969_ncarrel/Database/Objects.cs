using System;
using C969_ncarrel.Database;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace C969_ncarrel.Database
{
    public class User
    {
        public int userId;
        public string userName;
        public string password;
        bool active;
    }
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

        QueryDB ApptConnection;
        BindingList<Appointment> blAppointments;
        public bool ConflictCheck(int appointmentId, DateTime start, DateTime end)
        {
            //Need to get the currently signed in user at this point
            int tmpUser = 1;
            var sqlString =
                $"SELECT appointmentId FROM appointment WHERE NOT appointmentId = '{appointmentId}' AND userId = '{tmpUser}' AND start <= '{end:yyyy-MM-dd HH:mm:ss}' AND end >= '{start:yyyy-MM-dd HH:mm:ss}'";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                var conflictAppt = Convert.ToInt32(reader.GetValue(0));
                MessageBox.Show($"There is a time conflict with Appointment {conflictAppt}. Please select a different time.\nYour appointment was not saved.", "New Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reader.Close();
                return true;
            }
            else if (end < start)
            {
                MessageBox.Show($"Start time cannot be after End time.\nYour appointment was not saved.", "New Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }
        
        public void Create(Appointment newAppointment)
        {
            userId = 1;
            ApptConnection = new QueryDB();
            if (ConflictCheck(-1,newAppointment.start, newAppointment.end)) //Creating a new appointment so just set apptId to -1 for conflict check
                return;
            var sqlString = 
                $"INSERT INTO appointment(customerId,userId,title,description,location,contact,type,url,start,end,createDate,createdBy,lastUpdate,lastUpdateBy) " +
                $"VALUES ({newAppointment.customerId},{newAppointment.userId},'" + MySqlHelper.EscapeString(newAppointment.title) + $"','{newAppointment.description}','{newAppointment.location}','{newAppointment.contact}'," +
                $"'{newAppointment.type}','{newAppointment.url}','{newAppointment.start.ToString("yyyy-MM-dd HH:mm:ss")}','{newAppointment.end.ToString("yyyy-MM-dd HH:mm:ss")}',now(),'test',now(),'test');";
            _ = ApptConnection.Query(sqlString);
        }

        public void Delete(int appointmentId)
        {
            //using appointmentID parameter, "DELETE FROM appointment WHERE appointmentId={appointmentID};
            ApptConnection = new QueryDB();
            string sqlString = $"DELETE FROM appointment WHERE appointmentId={appointmentId}";
            var warning = MessageBox.Show($"Are you sure you want to delete appointment {appointmentId}?", $"Delete {appointmentId}?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (warning)
            {
                case DialogResult.Yes:
                    _ = ApptConnection.Query(sqlString);
                    MessageBox.Show($"Successfully deleted appointment {appointmentId}");
                    break;
                default:
                    MessageBox.Show($"No appointments were deleted");
                    break;
            }
        }

        public void Update(int appointmentId, Appointment appointment)
        {
            ApptConnection = new QueryDB();
            if (ConflictCheck(appointmentId,appointment.start,appointment.end))
                return;
            var sqlString = $"UPDATE appointment SET customerId={appointment.customerId},title='{appointment.title}',description='{appointment.description}'," +
                $"location='{appointment.location}',contact='{appointment.contact}',type='{appointment.type}',url='{appointment.url}'," +
                $"start='{appointment.start.ToString("yyyy-MM-dd HH:mm:ss")}',end='{appointment.end.ToString("yyyy-MM-dd HH:mm:ss")}',lastUpdate=now(),lastUpdateBy='test' " +
                $"WHERE appointmentId={appointmentId};";
            _ = ApptConnection.Query(sqlString);
        }

        public BindingList<Appointment> GetAppointments()
        {
            ApptConnection = new QueryDB();
            blAppointments = new BindingList<Appointment>();
            string sqlString = "SELECT * FROM appointment";
            var dataIn = ApptConnection.Query(sqlString);
            foreach (var collumnIn in dataIn)
            {
                var appointment = new Appointment();

                appointment.appointmentId = int.Parse(collumnIn[0]);
                appointment.customerId = int.Parse(collumnIn[1]);
                appointment.userId = int.Parse(collumnIn[2]);
                appointment.title = collumnIn[3];
                appointment.description = collumnIn[4];
                appointment.location = collumnIn[5];
                appointment.contact = collumnIn[6];
                appointment.type = collumnIn[7];
                appointment.url = collumnIn[8];
                appointment.start = DateTime.Parse(collumnIn[9]);
                appointment.end = DateTime.Parse(collumnIn[10]);

                blAppointments.Add(appointment);
            }
            return blAppointments;
        }

        public Appointment GetAppointments(int appointmentId) //Get a specific appointment if given the ID
        {
            ApptConnection = new QueryDB();
            string sqlString = $"SELECT * FROM appointment WHERE appointmentId={appointmentId};";
            var dataIn = ApptConnection.Query(sqlString);
            var appointment = new Appointment();
            foreach (var collumnIn in dataIn) //alternatively, "appointment.(field) = dataIn[0][i];"
            {
                //var appointment = new Appointment();
                appointment.appointmentId = int.Parse(collumnIn[0]);
                appointment.customerId = int.Parse(collumnIn[1]);
                appointment.userId = int.Parse(collumnIn[2]);
                appointment.title = collumnIn[3];
                appointment.description = collumnIn[4];
                appointment.location = collumnIn[5];
                appointment.contact = collumnIn[6];
                appointment.type = collumnIn[7];
                appointment.url = collumnIn[8];
                appointment.start = DateTime.Parse(collumnIn[9]);
                appointment.end = DateTime.Parse(collumnIn[10]);
            }
            return appointment;
        }
    }
    public class Country : Connection
    {
        public int countryId;
        public string country;

        //public QueryDB customerConnection = new QueryDB();
        public int GetId(string country)
        {
            QueryDB customerConnection = new QueryDB();
            var sqlString = $"SELECT countryId FROM country WHERE country='{country}';";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows) //Get the countryId
            {
                reader.Read();
                countryId = Convert.ToInt32(reader.GetValue(0));
                reader.Close();
                return countryId;
            }
            else //Create a new country and get its Id
            {
                reader.Close();
                sqlString = $"INSERT INTO country(country,createDate,createdBy,lastUpdate,lastUpdateBy) VALUES('{country}',now(),'test',now(),'test');";
                _ = customerConnection.Query(sqlString);
                countryId = (int)cmd.LastInsertedId;
                return countryId;
            }
        }
    }
    public class City : Connection
    {
        public int cityId;
        public string city;
        public int countryId;
        public Country country;

        public int GetId(string city, int countryId)
        {
            QueryDB customerConnection = new QueryDB();
            var sqlString = $"SELECT cityId FROM city WHERE city='{city}' AND countryId={countryId}";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows) //Get the cityId
            {
                reader.Read();
                cityId = Convert.ToInt32(reader.GetValue(0));
                reader.Close();
                return cityId;
            }
            else //Create a new city and get its Id
            {
                reader.Close();
                sqlString = $"INSERT INTO city(city,countryId,createDate,createdBy,lastUpdate,lastUpdateBy) VALUES('{city}','{countryId}',now(),'test',now(),'test');";
                _ = customerConnection.Query(sqlString);
                cityId = (int)cmd.LastInsertedId;
                return cityId;
            }
        }
    }
    public class Address : Connection
    {
        public int addressId;
        public string address;
        public string address2;
        public int cityId;
        public string postalCode;
        public string phone;
        public City city;

        public int GetId(string address, string address2, int cityId, string postalCode, string phone)
        {
            QueryDB customerConnection = new QueryDB();
            // select the address ID for which address, address 2, cityId, and postalCode are an exact match
            var sqlString = $"SELECT addressId FROM address WHERE address='{address}' AND address2='{address2}' AND cityId={cityId} AND postalCode='{postalCode}' AND phone='{phone}';";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows) //get addressId
            {
                reader.Read();
                addressId = Convert.ToInt32(reader.GetValue(0));
                reader.Close();
                return addressId;
            }
            else //create new address and get its Id
            {
                reader.Close();
                sqlString = $"INSERT INTO address(address,address2,cityId,postalCode,phone,createDate,createdBy,lastUpdate,lastUpdateBy) VALUES('{address}','{address2}',{cityId},{postalCode},'{phone}',now(),'test',now(),'test');";
                _ = customerConnection.Query(sqlString);
                addressId = (int)cmd.LastInsertedId;
                return addressId;
            }
        }
    }
    public class Customer
    {
        public int customerId;
        public string customerName;
        public int addressId;
        public string active;
        public Address address;
    }
    public class CustomerData : Connection
    {
        public QueryDB customerConnection = new QueryDB();
        public BindingList<Customer> blCustomers;
        public void Update(int customerId, string customerName, bool active, string address, string address2, string postalCode, string phone, string city, string country)
        {
            var user = "test"; //TODO: Store user on login
            var updateCountry = new Country();
            var updateCity = new City();
            var updateAddress = new Address();
            var newCountryId = updateCountry.GetId(country);
            var newCityId = updateCity.GetId(city, newCountryId);
            var newAddressId = updateAddress.GetId(address, address2, newCityId, postalCode, phone);
            var sqlString = $"UPDATE customer SET customerName='{customerName}',addressId={newAddressId},active={active},lastUpdate=now(),lastUpdateBy='{user}' WHERE customerId={customerId};";
            _ = customerConnection.Query(sqlString);
        }
        public void Create(string customerName, bool active, string address, string address2, string postalCode, string phone, string city, string country)
        {
            var user = "test"; //TODO: Store user on login
            var newCustCountry = new Country();
            var newCustCity = new City();
            var newCustAddress = new Address();
            var countryId = newCustCountry.GetId(country);
            var cityId = newCustCity.GetId(city, countryId);
            var addressId = newCustAddress.GetId(address, address2, cityId, postalCode, phone);
            //Take the countryId, cityId, and addressId values we got above and use them to create a new Customer entry
            var sqlString = $"INSERT INTO customer(customerName,addressId,active,createDate,createdBy,lastUpdate,lastUpdateBy) VALUES('{customerName}',{addressId},{active},now(),'{user}',now(),'{user}')";
            _ = customerConnection.Query(sqlString);
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

    public class QueryDB : Connection // General method to query the MySql database using MySql.Data.MySqlClient.
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
