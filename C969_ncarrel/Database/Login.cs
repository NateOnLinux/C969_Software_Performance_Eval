using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace C969_ncarrel.Database
{
    class Login : Connection
    {
        public bool verifyLogin(string username, string password)
        {
            bool login = false;

            cmd = new MySqlCommand("SELECT * FROM USER WHERE userName = '" + username + "' AND password = '" + password + "'", connection);
            DataTable dt = new DataTable();
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            try
            {
                if (dt.Rows.Count > 0)
                {
                    login = true;
                }
                return login;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return login;
            }
        }
    }
}
