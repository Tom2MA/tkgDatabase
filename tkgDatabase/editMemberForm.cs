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
    public partial class editMemberForm : Form
    {
        private static MySqlConnection connection;
        public editMemberForm()
        {
            InitializeComponent();
            establishConnection();

            String getAccountNumber = "SELECT * FROM ACCOUNTS WHERE ACCOUNT_ID = "+variables.adminSelectedMemberAccountID+";";
            MySqlCommand getAccountNumCommand = new MySqlCommand(getAccountNumber, connection);
            connection.Open();
            MySqlDataReader accountNumReader = getAccountNumCommand.ExecuteReader();
            accountNumReader.Read();
            String accountUser = accountNumReader.GetString("ACCOUNT_USERNAME");
            String accountPass = accountNumReader.GetString("ACCOUNT_PASSWORD");
            connection.Close();

            String getMemberNumber = "SELECT * FROM MEMBERS WHERE MEM_ID = " + variables.adminSelectedMemberID + ";";
            MySqlCommand getMemberNumCommand = new MySqlCommand(getMemberNumber, connection);
            connection.Open();
            MySqlDataReader memberNumReader = getMemberNumCommand.ExecuteReader();
            memberNumReader.Read();
            String memberFName = memberNumReader.GetString("MEM_FNAME");
            String memberLName = memberNumReader.GetString("MEM_LNAME");
            String memberAddress = memberNumReader.GetString("MEM_ADDRESS");
            String memberPhone = memberNumReader.GetString("MEM_PHONE");
            connection.Close();

            usernameBox.Text = accountUser;
            passwordBox.Text = accountPass;
            firstNameBox.Text = memberFName;
            lastNameBox.Text = memberLName;
            addressBox.Text = memberAddress;
            phoneBox.Text = memberPhone;

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

            variables.membershipType = "Standard";
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameBox.Text) || String.IsNullOrEmpty(passwordBox.Text) || String.IsNullOrEmpty(firstNameBox.Text) || String.IsNullOrEmpty(lastNameBox.Text) || String.IsNullOrEmpty(addressBox.Text) || String.IsNullOrEmpty(phoneBox.Text))
            {
                MessageBox.Show("Error! Please make sure that all the boxes are completely filled out.", "Error!", MessageBoxButtons.OK);
            }

            else if (phoneBox.Text.Length < 10)
            {
                MessageBox.Show("Error! Please make sure that the phone number is completely filled out.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                if (variables.membershipType == "Standard")
                {
                    String removeAccountClassesQuery = "DELETE FROM CLASS_ENROLL WHERE ACCOUNT_ID = "+ variables.adminSelectedMemberAccountID + ";";
                    MySqlCommand removeAccountClassesCommand = new MySqlCommand(removeAccountClassesQuery, connection);
                    connection.Open();
                    MySqlDataReader removeAccountClassesReader = removeAccountClassesCommand.ExecuteReader();
                    removeAccountClassesReader.Read();
                    connection.Close();
                }

                String updateAccountQuery = "UPDATE ACCOUNTS SET ACCOUNT_PASSWORD = '" + passwordBox.Text + "' WHERE ACCOUNT_ID = " + variables.adminSelectedMemberAccountID + ";";
                MySqlCommand updateAccountCommand = new MySqlCommand(updateAccountQuery, connection);
                connection.Open();
                MySqlDataReader updateAccountReader = updateAccountCommand.ExecuteReader();
                updateAccountReader.Read();
                connection.Close();

                String updateMemberQuery = "UPDATE MEMBERS SET MEM_FNAME = '" + firstNameBox.Text + "', MEM_LNAME = '" + lastNameBox.Text + "', MEM_PHONE = '" + phoneBox.Text + "', MEM_ADDRESS = '" + addressBox.Text + "', MEM_MEMBERSHIP = '" + variables.membershipType + "' WHERE MEM_ID = " + variables.adminSelectedMemberID + ";";
                MySqlCommand updateMemberCommand = new MySqlCommand(updateMemberQuery, connection);
                connection.Open();
                MySqlDataReader updateMemberReader = updateMemberCommand.ExecuteReader();
                updateMemberReader.Read();
                connection.Close();

                MessageBox.Show(firstNameBox.Text + " " + lastNameBox.Text + " has been successfully updated!", "Success!", MessageBoxButtons.OK);

                this.Close();
                adminForm backToAdmin = new adminForm();
                backToAdmin.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminForm backToAdmin = new adminForm();
            backToAdmin.Show();
        }
    }
}
