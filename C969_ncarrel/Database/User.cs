using MySql.Data.MySqlClient;

namespace C969_ncarrel.Database
{
    public class User : Connection
    {
        public int userId;
        public string userName;
        public string GetUserName(int userId)
        {
            var sqlString = $"SELECT userName FROM user WHERE userId = {userId}";
            cmd = new MySqlCommand(sqlString, connection);
            reader.Close();
            reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();
                userName = reader.GetFieldValue<string>(0);
                reader.Close();
            }
            else
            {
                userName = null;
                reader.Close();
            }
            return userName;
        }
    }
}
