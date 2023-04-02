using System;
using C969_ncarrel.Database;
using System.Data;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace C969_ncarrel
{
	public partial class Login : Form
	{
		Database.Login verify { get; set; }
		CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;

		public Login()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			MySqlConnection con = Connection.connection;
			verify = new Database.Login();
			bool login;

			if (currentCulture.TwoLetterISOLanguageName == "de")
            {
				if (con.State == ConnectionState.Open)
				{
					login = verify.verifyLogin(textBoxUserName.Text, textBoxPassword.Text);
					if (login == true)
					{
						MessageBox.Show("Login bewährt");
						this.Hide();
						Homepage homepage = new Homepage();
						homepage.Show();
					}
					else
					{
						MessageBox.Show("Benutzername oder Password nicht korrekt!");
					}
				}
				else
					MessageBox.Show("No active MySQL server connection found at localhost:3306");
			}
			else
			{
				if (con.State == ConnectionState.Open)
				{
					login = verify.verifyLogin(textBoxUserName.Text, textBoxPassword.Text);
					if (login == true)
					{
						MessageBox.Show("Login success");
						this.Hide();
						Homepage homepage = new Homepage();
						homepage.Show();
					}
					else
					{
						MessageBox.Show("Username or password is incorrect!");
					}
				}
				else
					MessageBox.Show("No active MySQL server connection found at localhost:3306");
			}
		}
	}
}
