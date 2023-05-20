using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace C969_ncarrel.Database
{

    public class QueryDB : Connection // General method to query the MySql database using MySql.Data.MySqlClient.
    {
        public List<List<string>> Query(string input)
        {
            cmd = new MySqlCommand(input, connection);
            reader.Close();
            reader = cmd.ExecuteReader();
            var resultList = new List<List<string>>();
            var columns = reader.FieldCount;
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
