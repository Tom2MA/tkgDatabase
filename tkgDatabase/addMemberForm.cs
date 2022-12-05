using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkgDatabase
{
    public partial class addMemberForm : Form
    {
        private static MySqlConnection connection;
        public addMemberForm()
        {
            InitializeComponent(); 
            establishConnection();

            try
            {
                String getHighestAccountNumber = "SELECT MAX(ACCOUNT_ID)+1 FROM ACCOUNTS";
                MySqlCommand getHighestAccountNumberer = new MySqlCommand(getHighestAccountNumber, connection);
                connection.Open();
                MySqlDataReader accountHighestNumberReader = getHighestAccountNumberer.ExecuteReader();
                accountHighestNumberReader.Read();
                variables.highestAccountNumID = accountHighestNumberReader.GetString("MAX(ACCOUNT_ID)+1");
                connection.Close();
            }

            catch
            {
                variables.highestAccountNumID = "1";
            }

            variables.listOfAccountUsers = new List<String>();
            String getAccountUsers = "SELECT * FROM ACCOUNTS;";
            MySqlDataAdapter getAccountUsersAdapter = new MySqlDataAdapter(getAccountUsers, connection);
            DataTable getAccountUsersTable = new DataTable();
            getAccountUsersAdapter.Fill(getAccountUsersTable);
            foreach (DataRow accountRow in getAccountUsersTable.Rows)
            {
                String accountID = accountRow[0].ToString();
                String getAccountInfoQuery = "SELECT * FROM ACCOUNTS WHERE ACCOUNT_ID = " + accountID + ";";
                MySqlCommand getAccountInfoCreater = new MySqlCommand(getAccountInfoQuery, connection);
                connection.Open();
                MySqlDataReader getAccountInfoReader = getAccountInfoCreater.ExecuteReader();
                getAccountInfoReader.Read();
                String currentAccountUser = getAccountInfoReader.GetString("ACCOUNT_USERNAME");
                connection.Close();

                variables.listOfAccountUsers.Add(currentAccountUser);
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminForm backToAdmin = new adminForm();
            backToAdmin.Show();
        }
        private void standardBox_Click(object sender, EventArgs e)
        {
            if (premiumBox.Checked == true)
            {
                standardBox.Checked = true;
                premiumBox.Checked = false;
                variables.membershipType = "Standard";
            }
            else
            {
                standardBox.Checked = true;
                variables.membershipType = "Standard";
            }
            
            Debug.WriteLine(variables.membershipType);
        }

        private void premiumBox_Click(object sender, EventArgs e)
        {
            if (standardBox.Checked == true)
            {
                premiumBox.Checked = true;
                standardBox.Checked = false;
                variables.membershipType = "Premium";
            }
            else
            {
                premiumBox.Checked = true;
                variables.membershipType = "Premium";
            }
            Debug.WriteLine(variables.membershipType);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            String highestMemberNumID = variables.highestAccountNumID;

            if (String.IsNullOrEmpty(usernameBox.Text) || String.IsNullOrEmpty(passwordBox.Text) || String.IsNullOrEmpty(firstNameBox.Text) || String.IsNullOrEmpty(lastNameBox.Text) || String.IsNullOrEmpty(addressBox.Text) || String.IsNullOrEmpty(phoneBox.Text))
            {
                MessageBox.Show("Error! Please make sure that all the boxes are completely filled out.", "Error!", MessageBoxButtons.OK);
            }

            else if (phoneBox.Text.Length < 10)
            {
                MessageBox.Show("Error! Please make sure that the phone number is completely filled out.", "Error!", MessageBoxButtons.OK);
            }

            else if (variables.listOfAccountUsers.Contains(usernameBox.Text))
            {
                MessageBox.Show("The username selected is already chosen. Please select another username and try again.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                String createAccountQuery = "INSERT INTO ACCOUNTS VALUES(" + variables.highestAccountNumID + ", '" + usernameBox.Text + "','" + passwordBox.Text + "');";
                MySqlCommand accountCreater = new MySqlCommand(createAccountQuery, connection);
                MySqlDataReader accountCreaterReader;
                connection.Open();
                accountCreaterReader = accountCreater.ExecuteReader();
                connection.Close();

                String createMemberQuery = "INSERT INTO MEMBERS VALUES(" + highestMemberNumID + ", '" + firstNameBox.Text + "','" + lastNameBox.Text + "', '" + phoneBox.Text + "', '" + addressBox.Text + "', '"+variables.membershipType+"', " + variables.highestAccountNumID + ");";
                MySqlCommand memberCreater = new MySqlCommand(createMemberQuery, connection);
                MySqlDataReader memberCreaterReader;
                connection.Open();
                memberCreaterReader = memberCreater.ExecuteReader();
                connection.Close();

                MessageBox.Show("Account Successfully Created!", "Account Created", MessageBoxButtons.OK);
                this.Close();
                adminForm backToAdmin = new adminForm();
                backToAdmin.Show();

            }

        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void showPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordBox.Checked)
            {
                passwordBox.UseSystemPasswordChar = false; //show password when clicked
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true; //hide password when clicked
            }
        }
    }
}
