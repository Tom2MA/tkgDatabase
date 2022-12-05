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
using MySql.Data.MySqlClient;

namespace tkgDatabase
{
    public partial class memberForm : Form
    {
        private static MySqlConnection connection;
        public memberForm()
        {
            InitializeComponent();
            establishConnection();

            String getAccountIDQuery = "SELECT ACCOUNT_ID FROM ACCOUNTS WHERE ACCOUNT_USERNAME = '" + variables.username + "' AND ACCOUNT_PASSWORD = '" + variables.password + "';";
            MySqlCommand accountIDer = new MySqlCommand(getAccountIDQuery, connection);
            connection.Open();
            MySqlDataReader accountIDReader = accountIDer.ExecuteReader();
            accountIDReader.Read();
            variables.accountID = accountIDReader.GetString("ACCOUNT_ID");
            idBox.Text = variables.accountID;
            connection.Close();

            String getAccountQuery = "SELECT * FROM MEMBERS WHERE ACCOUNT_ID = '"+variables.accountID+"';";
            MySqlCommand accountCreater = new MySqlCommand(getAccountQuery, connection);
            connection.Open();
            MySqlDataReader accountReader = accountCreater.ExecuteReader();
            accountReader.Read();
            firstNameBox.Text = accountReader.GetString("MEM_FNAME");
            lastNameBox.Text = accountReader.GetString("MEM_LNAME");
            addressBox.Text = accountReader.GetString("MEM_ADDRESS");
            phoneBox.Text = accountReader.GetString("MEM_PHONE");
            membershipBox.Text = accountReader.GetString("MEM_MEMBERSHIP");
            connection.Close();


            if (membershipBox.Text == "Standard")
            {
                membershipBox.ForeColor = Color.Red;
            }
            else if (membershipBox.Text == "Premium")
            {
                membershipBox.ForeColor = SystemColors.Highlight;
            }

            variables.listOfMemClassIDs = new List<String>();
            String getMemClassIDQuery = "SELECT * FROM CLASS_ENROLL WHERE ACCOUNT_ID = " + variables.accountID;
            variables.getMemClassIDAdapter = new MySqlDataAdapter(getMemClassIDQuery, connection);
            variables.getMemClassesTable = new DataTable();
            variables.getMemClassIDAdapter.Fill(variables.getMemClassesTable);
            foreach (DataRow classIDRow in variables.getMemClassesTable.Rows)
            {
                variables.classID = classIDRow[1].ToString();
                String getClassNameQuery = "SELECT * FROM CLASSES WHERE CLASS_ID = "+variables.classID+";";
                MySqlCommand getClassNameCreater = new MySqlCommand(getClassNameQuery, connection);
                connection.Open();
                MySqlDataReader getClassNameReader = getClassNameCreater.ExecuteReader();
                getClassNameReader.Read();
                String myCurrentClassID = getClassNameReader.GetString("CLASS_ID");
                String myCurrentClassName = getClassNameReader.GetString("CLASS_NAME");
                connection.Close();

                yourClassesList.Items.Add(myCurrentClassName);
                variables.listOfMemClassIDs.Add(myCurrentClassID);
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form openLoginForm = new loginForm();
            openLoginForm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (membershipBox.Text == "Standard")
            {
                MessageBox.Show("You are not a premium member. Please upgrade your membership before registering for classes.", "Error!", MessageBoxButtons.OK);
            }

            else if (membershipBox.Text == "Premium")
            {
                this.Close();
                Form openAvailiableClassesForm = new availiableClassesForm();
                openAvailiableClassesForm.Show();
            }
 
        }

        private void yourClassesList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (yourClassesList.SelectedIndex == -1)
            {
                // do nothing
            }

            else
            {
                String classSelectedName = yourClassesList.Text;
                String classSelectedClassID = variables.listOfMemClassIDs.ElementAt(yourClassesList.SelectedIndex);
                String getGymIDQuery = "SELECT GYM_ID FROM CLASSES WHERE CLASS_ID = " + classSelectedClassID + " AND CLASS_NAME = '"+classSelectedName+"';";
                MySqlCommand getGymIDCreater = new MySqlCommand(getGymIDQuery, connection);
                connection.Open();
                MySqlDataReader getGymIDReader = getGymIDCreater.ExecuteReader();
                getGymIDReader.Read();
                String classGymID = getGymIDReader.GetString("GYM_ID");
                connection.Close();

                String getGymInstructorIDQuery = "SELECT INSTRUCTOR_ID FROM CLASSES WHERE CLASS_NAME = '" + classSelectedName + "' AND GYM_ID = " + classGymID + ";";
                MySqlCommand gymInstructorIDCreater = new MySqlCommand(getGymInstructorIDQuery, connection);
                connection.Open();
                MySqlDataReader gymInstructorIDReader = gymInstructorIDCreater.ExecuteReader();
                gymInstructorIDReader.Read();
                String gymInstructorID = gymInstructorIDReader.GetString("INSTRUCTOR_ID");
                connection.Close();

                String getGymInstructorNameQuery = "SELECT * FROM INSTRUCTORS WHERE INSTRUCTOR_ID = " + gymInstructorID + ";";
                MySqlCommand gymInstructorNameCreater = new MySqlCommand(getGymInstructorNameQuery, connection);
                connection.Open();
                MySqlDataReader gymInstructorNameReader = gymInstructorNameCreater.ExecuteReader();
                gymInstructorNameReader.Read();
                String instructorFName = gymInstructorNameReader.GetString("INSTRUCTOR_FNAME");
                String instructorLName = gymInstructorNameReader.GetString("INSTRUCTOR_LNAME");
                instructorBox.Text = instructorFName + " " + instructorLName;
                connection.Close();

                String getGymClassInfoQuery = "SELECT * FROM CLASSES WHERE CLASS_NAME = '" + classSelectedName + "' AND GYM_ID = " + classGymID + ";";
                MySqlCommand gymClassInfoCreater = new MySqlCommand(getGymClassInfoQuery, connection);
                connection.Open();
                MySqlDataReader gymClassInfoReader = gymClassInfoCreater.ExecuteReader();
                gymClassInfoReader.Read();
                dayBox.Text = gymClassInfoReader.GetString("CLASS_DAYS");
                connection.Close();

                String getGymClassTimeStartQuery = "SELECT TIME_FORMAT(CLASS_TIMESTART, \"%r\") FROM CLASSES WHERE CLASS_NAME = '" + classSelectedName + "' AND GYM_ID = " + classGymID + ";";
                MySqlCommand getGymClassTimeStartCreater = new MySqlCommand(getGymClassTimeStartQuery, connection);
                connection.Open();
                MySqlDataReader getGymClassTimeStartReader = getGymClassTimeStartCreater.ExecuteReader();
                getGymClassTimeStartReader.Read();
                startBox.Text = getGymClassTimeStartReader.GetString("TIME_FORMAT(CLASS_TIMESTART, \"%r\")");
                connection.Close();

                String getGymClassTimeEndQuery = "SELECT TIME_FORMAT(CLASS_TIMEEND, \"%r\") FROM CLASSES WHERE CLASS_NAME = '" + classSelectedName + "' AND GYM_ID = " + classGymID + ";";
                MySqlCommand getGymClassTimeEndCreater = new MySqlCommand(getGymClassTimeEndQuery, connection);
                connection.Open();
                MySqlDataReader getGymClassTimeEndReader = getGymClassTimeEndCreater.ExecuteReader();
                getGymClassTimeEndReader.Read();
                endBox.Text = getGymClassTimeEndReader.GetString("TIME_FORMAT(CLASS_TIMEEND, \"%r\")");
                connection.Close();

                String getClassGymLocQuery = "SELECT GYM_LOCATION FROM GYMS WHERE GYM_ID = '" + classGymID + "';";
                MySqlCommand getClassGymLocCreater = new MySqlCommand(getClassGymLocQuery, connection);
                connection.Open();
                MySqlDataReader getClassGymLocReader = getClassGymLocCreater.ExecuteReader();
                getClassGymLocReader.Read();
                yourClassLocBox.Text = getClassGymLocReader.GetString("GYM_LOCATION");
                connection.Close();


            }

        }
    }
}
