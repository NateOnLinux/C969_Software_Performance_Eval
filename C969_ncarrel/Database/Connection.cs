using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace C969_ncarrel.Database
{
    public class Connection
    {
        public static MySqlConnection connection { get; set; }
        public static MySqlCommand cmd { get; set; }
        public static MySqlDataAdapter adapter { get; set; }
        public static MySqlDataReader reader { get; set; }
        //public static string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        public static void startConn()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            try
            {
                connection = new MySqlConnection(connectionString);
                // open new connection to sql server
                connection.Open();

                MessageBox.Show("Connected to MySQL server");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void closeConn()
        {
            try
            {
                if (connection != null)
                    connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
