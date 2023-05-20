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
		Database.Login Verify { get; set; }
		private readonly CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
		public static Homepage mainScreen;
		public Login()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			MySqlConnection connection = Connection.connection;
			Verify = new Database.Login();
			int login;
			if (connection.State == ConnectionState.Open)
			{
				switch (currentCulture.TwoLetterISOLanguageName)
				{
					case ("de"):
						login = Verify.verifyLogin(textBoxUserName.Text, textBoxPassword.Text);
						if (login > 0)
						{
							MessageBox.Show("Login bewährt");
							this.Hide();
							mainScreen = new Homepage(login);
							//I use a lambda expression here to create an event handler for the mainScreen.FormClosed event
							mainScreen.FormClosed += (s, args) => this.Close();
							mainScreen.Show();
						}
						else
						{
							MessageBox.Show("Benutzername oder Password nicht korrekt!");
						}
						break;
					default:
						login = Verify.verifyLogin(textBoxUserName.Text, textBoxPassword.Text);
						if (login > 0)
						{
							MessageBox.Show("Login success");
							this.Hide();
							mainScreen = new Homepage(login);
							//I use a lambda expression here to create an event handler for the mainScreen.FormClosed event
							mainScreen.FormClosed += (s, args) => this.Close();
							mainScreen.Show();
						}
						else
						{
							MessageBox.Show("Username or password is incorrect!");
						}
						break;
				}
			}
			else
			{
				MessageBox.Show("No active MySQL server connection found at localhost:3306");
			}
		}

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
