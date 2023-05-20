using System;
using MySql.Data.MySqlClient;

namespace C969_ncarrel.Database
{
    public class Country : Connection
    {
        public int countryId;
        public string country;
        public int GetId(string country)
        {
            QueryDB customerConnection = new QueryDB();
            var userName = new User().GetUserName(C969_ncarrel.Login.mainScreen.UserId);
            var sqlString = "SELECT countryId FROM country WHERE country='" + MySqlHelper.EscapeString(country) + "'";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                countryId = Convert.ToInt32(reader.GetValue(0));
                reader.Close();
                return countryId;
            }
            else //create new country
            {
                reader.Close();
                sqlString = 
                    $"INSERT INTO country(country,createDate,createdBy,lastUpdate,lastUpdateBy) " +
                    $"VALUES('"
                    + MySqlHelper.EscapeString(country)
                    + $"',now(),'{userName}',now(),'{userName}');";
                _ = customerConnection.Query(sqlString);
                countryId = (int)cmd.LastInsertedId;
                return countryId;
            }
        }
    }
}
