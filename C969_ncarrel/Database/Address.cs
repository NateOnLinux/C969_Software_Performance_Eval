using System;
using MySql.Data.MySqlClient;

namespace C969_ncarrel.Database
{
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
            var userName = new User().GetUserName(C969_ncarrel.Login.mainScreen.UserId);
            var sqlString = 
                $"SELECT addressId "
                + $"FROM address "
                + $"WHERE address='"
                + MySqlHelper.EscapeString(address)
                + "' AND address2= '"
                + MySqlHelper.EscapeString(address2)
                + $"' AND cityId={cityId} AND postalCode='{postalCode}' AND phone='{phone}';";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                addressId = Convert.ToInt32(reader.GetValue(0));
                reader.Close();
                return addressId;
            }
            else //create new address
            {
                reader.Close();
                sqlString = 
                    $"INSERT INTO address(address,address2,cityId,postalCode,phone,createDate,createdBy,lastUpdate,lastUpdateBy) "
                    + $"VALUES('"
                    + MySqlHelper.EscapeString(address)
                    + "','"
                    + MySqlHelper.EscapeString(address2)
                    + $"',{cityId},{postalCode},'{phone}',now(),'{userName}',now(),'{userName}');";
                _ = customerConnection.Query(sqlString);
                addressId = (int)cmd.LastInsertedId;
                return addressId;
            }
        }
    }
}
