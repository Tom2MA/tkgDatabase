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
    public partial class loginForm : Form
    {
        private static MySqlConnection connection;
        public loginForm()
        {
            //begin form with establishing connection to database
            InitializeComponent();
            establishConnection();
        }

        public static void establishConnection()
        {
            //function that establishes connection to database, database is project server
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "35.222.26.3";
            builder.UserID = "root";
            builder.Password = "projectdatabase";
            builder.Database = "tkgDatabase";
            builder.SslMode = MySqlSslMode.Disabled;
            connection = new MySqlConnection(builder.ToString());
   
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //when login button is clicked
            variables.username = userBox.Text;
            variables.password = passwordBox.Text;

            String loginQuerry = "SELECT ACCOUNT_USERNAME, ACCOUNT_PASSWORD FROM ACCOUNTS WHERE ACCOUNT_USERNAME = '" + userBox.Text + "' AND ACCOUNT_PASSWORD = '" + passwordBox.Text + "';";
            MySqlDataAdapter loginAdapter = new MySqlDataAdapter(loginQuerry, connection); //Query to send to connection to gather login info

            DataTable loginTable = new DataTable();
            loginAdapter.Fill(loginTable);
            
                if (loginTable.Rows.Count > 0)
                {
                    if (variables.username == "admin" && variables.password == "adminsonly")
                    {
                        adminForm adminPage = new adminForm(); //admin account only, open admin form
                        adminPage.Show();
                        this.Hide();
                    }

                    else
                    {
                        variables.username = userBox.Text; //when user and password in textbox, open member form with member's info
                        variables.password = passwordBox.Text;
                        memberForm memberPage = new memberForm();
                        memberPage.Show();
                        this.Hide();
                    }
                }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerForm registerPage = new registerForm(); //when register button clicked on login, open register form
            registerPage.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1); //exit UI
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
