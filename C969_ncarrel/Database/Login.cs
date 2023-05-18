using System;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace C969_ncarrel.Database
{
    class Login : Connection
    {
        public int verifyLogin(string username, string password)
        {
            cmd = new MySqlCommand("SELECT userId FROM user WHERE userName = '" + username + "' AND password = '" + password + "'", connection);
            reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                var users = reader.GetValue(0) ?? -1;
                if(users is null)
                {
                    reader.Close();
                    using (StreamWriter logFile = new StreamWriter("c969_log.txt"))
                    {
                        logFile.WriteLine($"Failed authentication attempt for \"{username}\" at {DateTime.Now:s}");
                    }
                    return 0;
                }
                else
                {
                    using (StreamWriter logFile = new StreamWriter("c969_log.txt"))
                    {
                        logFile.WriteLine($"Authentication successful for user {Convert.ToInt32(reader.GetValue(0))} ({username}) at {DateTime.Now:s}");
                    }
                    var userId = Convert.ToInt32(reader.GetValue(0));
                    reader.Close();
                    return userId;
                }
            }
            catch (Exception ex)
            {
                reader.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
