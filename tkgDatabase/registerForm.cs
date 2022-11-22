using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tkgDatabase
{
    public partial class registerForm : Form
    {
        private static MySqlConnection connection;
        public registerForm()
        {
            InitializeComponent();
            establishConnection();

            String getHighestAccountNumber = "SELECT MAX(ACCOUNT_ID) FROM ACCOUNTS";
            MySqlCommand getHighestAccountNumberer = new MySqlCommand(getHighestAccountNumber, connection);
            connection.Open();
            MySqlDataReader accountHighestNumberReader = getHighestAccountNumberer.ExecuteReader();
            accountHighestNumberReader.Read();
            variables.highestAccountNumID = accountHighestNumberReader.GetString("MAX(ACCOUNT_ID)");

            variables.newHighestAccountNumID = (Int32.Parse(variables.highestAccountNumID) + 1);
            connection.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm backToMain = new loginForm();
            backToMain.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameBox.Text) || String.IsNullOrEmpty(passwordBox.Text) || String.IsNullOrEmpty(firstNameBox.Text) || String.IsNullOrEmpty(lastNameBox.Text) || String.IsNullOrEmpty(addressBox.Text) || String.IsNullOrEmpty(phoneBox.Text))
            {
                MessageBox.Show("Error! Please make sure that all the boxes are completely filled out.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                String createAccountQuery = "INSERT INTO ACCOUNTS VALUES(" + variables.newHighestAccountNumID + ", '" + usernameBox.Text + "','" + passwordBox.Text + "');";
                MySqlCommand accountCreater = new MySqlCommand(createAccountQuery, connection);
                MySqlDataReader accountCreaterReader;
                connection.Open();
                accountCreaterReader = accountCreater.ExecuteReader();
                connection.Close();

                String createMemberQuery = "INSERT INTO MEMBERS VALUES(" + variables.newHighestAccountNumID + ", '" + firstNameBox.Text + "','" + lastNameBox.Text + "', '" + phoneBox.Text + "', '" + addressBox.Text + "', 'Standard', " + variables.newHighestAccountNumID + ");";
                MySqlCommand memberCreater = new MySqlCommand(createMemberQuery, connection);
                MySqlDataReader memberCreaterReader;
                connection.Open();
                memberCreaterReader = memberCreater.ExecuteReader();
                connection.Close();

                MessageBox.Show("Account Successfully Created!", "Account Created", MessageBoxButtons.OK);
                this.Close();
                loginForm backToMain = new loginForm();
                backToMain.Show();

            }

        }

        public static void establishConnection()
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "password";
            builder.Database = "tkgDatabase";
            builder.SslMode = MySqlSslMode.Disabled;
            connection = new MySqlConnection(builder.ToString());

        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
