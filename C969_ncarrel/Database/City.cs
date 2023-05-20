using System;
using MySql.Data.MySqlClient;

namespace C969_ncarrel.Database
{
    public class City : Connection
    {
        public int cityId;
        public string city;
        public int countryId;
        public Country country;

        public int GetId(string city, int countryId)
        {
            QueryDB customerConnection = new QueryDB();
            var userName = new User().GetUserName(C969_ncarrel.Login.mainScreen.UserId);
            var sqlString = $"SELECT cityId FROM city WHERE city='" + MySqlHelper.EscapeString(city) + $"' AND countryId={countryId}";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                cityId = Convert.ToInt32(reader.GetValue(0));
                reader.Close();
                return cityId;
            }
            else //create new city
            {
                reader.Close();
                sqlString = 
                    $"INSERT INTO city(city,countryId,createDate,createdBy,lastUpdate,lastUpdateBy) "
                    + $"VALUES('"
                    + MySqlHelper.EscapeString(city)
                    + $"','{countryId}',now(),'{userName}',now(),'{userName}');";
                _ = customerConnection.Query(sqlString);
                cityId = (int)cmd.LastInsertedId;
                return cityId;
            }
        }
    }
}
