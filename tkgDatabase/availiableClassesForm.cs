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
    public partial class availiableClassesForm : Form
    {
        private static MySqlConnection connection;
        public availiableClassesForm()
        {
            InitializeComponent();
            establishConnection();

            variables.listOfAvailClassIDs = new List<String>();

            String getGymClasses = "SELECT * FROM CLASSES;";
            MySqlDataAdapter gymClassesCreater = new MySqlDataAdapter(getGymClasses, connection);
            DataTable gymClassesTable = new DataTable();
            gymClassesCreater.Fill(gymClassesTable);
            foreach (DataRow classRow in gymClassesTable.Rows)
            {
                String currentAvailClassID = classRow[0].ToString();
                String currentAvailClassName = classRow[1].ToString();
                String getClassInfoQuery = "SELECT * FROM CLASSES WHERE CLASS_ID = " + currentAvailClassID + " AND CLASS_NAME = '"+ currentAvailClassName +"';";
                MySqlCommand getClassInfoCreater = new MySqlCommand(getClassInfoQuery, connection);
                connection.Open();
                MySqlDataReader getClassInfoReader = getClassInfoCreater.ExecuteReader();
                getClassInfoReader.Read();
                variables.availClassID = getClassInfoReader.GetString("CLASS_ID");
                variables.availClassName = getClassInfoReader.GetString("CLASS_NAME");
                connection.Close();
                Debug.WriteLine(variables.availClassID);

                availiableClassesList.Items.Add(currentAvailClassName);
                variables.listOfAvailClassIDs.Add(variables.availClassID);

            }

        }

        private void availiableClassesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (availiableClassesList.SelectedIndex == -1)
            {
                // do nothing
            }

            else
            {
                String classSelectedName = availiableClassesList.Text;
                String classAvailClassID = variables.listOfAvailClassIDs.ElementAt(availiableClassesList.SelectedIndex);
                Debug.WriteLine(classAvailClassID);
                String getGymIDQuery = "SELECT GYM_ID FROM CLASSES WHERE CLASS_ID = " + classAvailClassID + " AND CLASS_NAME = '" + classSelectedName + "';";
                MySqlCommand getGymIDCreater = new MySqlCommand(getGymIDQuery, connection);
                connection.Open();
                MySqlDataReader getGymIDReader = getGymIDCreater.ExecuteReader();
                getGymIDReader.Read();
                variables.classGymID = getGymIDReader.GetString("GYM_ID");
                connection.Close();

                String getGymInstructorIDQuery = "SELECT INSTRUCTOR_ID FROM CLASSES WHERE CLASS_NAME = '" + classSelectedName + "' AND GYM_ID = " + variables.classGymID + ";";
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

                String getGymClassInfoQuery = "SELECT * FROM CLASSES WHERE CLASS_NAME = '" + classSelectedName + "' AND GYM_ID = " + variables.classGymID + ";";
                MySqlCommand gymClassInfoCreater = new MySqlCommand(getGymClassInfoQuery, connection);
                connection.Open();
                MySqlDataReader gymClassInfoReader = gymClassInfoCreater.ExecuteReader();
                gymClassInfoReader.Read();
                dayBox.Text = gymClassInfoReader.GetString("CLASS_DAYS");
                variables.classSelectedID = gymClassInfoReader.GetString("CLASS_ID");
                connection.Close();

                String getGymClassTimeStartQuery = "SELECT TIME_FORMAT(CLASS_TIMESTART, \"%r\") FROM CLASSES WHERE CLASS_NAME = '" + classSelectedName + "' AND GYM_ID = " + variables.classGymID + ";";
                MySqlCommand getGymClassTimeStartCreater = new MySqlCommand(getGymClassTimeStartQuery, connection);
                connection.Open();
                MySqlDataReader getGymClassTimeStartReader = getGymClassTimeStartCreater.ExecuteReader();
                getGymClassTimeStartReader.Read();
                startBox.Text = getGymClassTimeStartReader.GetString("TIME_FORMAT(CLASS_TIMESTART, \"%r\")");
                connection.Close();

                String getGymClassTimeEndQuery = "SELECT TIME_FORMAT(CLASS_TIMEEND, \"%r\") FROM CLASSES WHERE CLASS_NAME = '" + classSelectedName + "' AND GYM_ID = " + variables.classGymID + ";";
                MySqlCommand getGymClassTimeEndCreater = new MySqlCommand(getGymClassTimeEndQuery, connection);
                connection.Open();
                MySqlDataReader getGymClassTimeEndReader = getGymClassTimeEndCreater.ExecuteReader();
                getGymClassTimeEndReader.Read();
                endBox.Text = getGymClassTimeEndReader.GetString("TIME_FORMAT(CLASS_TIMEEND, \"%r\")");
                connection.Close();

                String getGymClassLocQuery = "SELECT GYM_LOCATION FROM GYMS WHERE GYM_ID = "+variables.classGymID+";";
                MySqlCommand getGymClassLocCreater = new MySqlCommand(getGymClassLocQuery, connection);
                connection.Open();
                MySqlDataReader getGymClassLocReader = getGymClassLocCreater.ExecuteReader();
                getGymClassLocReader.Read();
                yourClassLocBox.Text = getGymClassLocReader.GetString("GYM_LOCATION");
                connection.Close();

            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f2 = new memberForm();
            f2.Show();
            this.Close();
        }

        public static void establishConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "35.222.26.3";
            builder.UserID = "root";
            builder.Password = "projectdatabase";
            builder.Database = "tkgDatabase";
            builder.SslMode = MySqlSslMode.Disabled;
            connection = new MySqlConnection(builder.ToString());
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            variables.listOfClasses = new List<String>();

            String getMemClassIDQuery = "SELECT * FROM CLASS_ENROLL WHERE ACCOUNT_ID = " + variables.accountID;
            variables.getMemClassIDAdapter = new MySqlDataAdapter(getMemClassIDQuery, connection);
            variables.getMemClassesTable = new DataTable();
            variables.getMemClassIDAdapter.Fill(variables.getMemClassesTable);
            foreach (DataRow classIDRow in variables.getMemClassesTable.Rows)
            {
                string classID = classIDRow[1].ToString();
                Debug.WriteLine(classID);
                variables.listOfClasses.Add(classID);
            }

            if (variables.listOfClasses.Any(variables.classSelectedID.Contains) == true)
            {
                MessageBox.Show("Class is already registered! Please select another class.", "Error!", MessageBoxButtons.OK);
            }

            else
            { 
                String registerClassQuery = "INSERT INTO CLASS_ENROLL VALUES (" + variables.accountID + ", " + variables.classSelectedID + ");";
                MySqlCommand registerClassCreater = new MySqlCommand(registerClassQuery, connection);
                connection.Open();
                MySqlDataReader registerClassReader = registerClassCreater.ExecuteReader();
                registerClassReader.Read();
                connection.Close();

                MessageBox.Show(availiableClassesList.Text + " has been registered!", "Success!", MessageBoxButtons.OK);
            }
            
        }

        private void unregisterButton_Click(object sender, EventArgs e)
        {
            variables.listOfClasses = new List<String>();

            String getMemClassIDQuery = "SELECT * FROM CLASS_ENROLL WHERE ACCOUNT_ID = " + variables.accountID;
            variables.getMemClassIDAdapter = new MySqlDataAdapter(getMemClassIDQuery, connection);
            variables.getMemClassesTable = new DataTable();
            variables.getMemClassIDAdapter.Fill(variables.getMemClassesTable);
            foreach (DataRow classIDRow in variables.getMemClassesTable.Rows)
            {
                string classID = classIDRow[1].ToString();
                Debug.WriteLine(classID);
                variables.listOfClasses.Add(classID);
            }

            if (variables.listOfClasses.Any(variables.classSelectedID.Contains) == false)
            {
                MessageBox.Show("Class is not registered! Please select a class to register.", "Error!", MessageBoxButtons.OK);
            }
            
            else
            {
                String unregisterClassQuery = "DELETE FROM CLASS_ENROLL WHERE ACCOUNT_ID = " + variables.accountID + " AND CLASS_ID = " + variables.classSelectedID + ";";
                MySqlCommand unregisterClassCreater = new MySqlCommand(unregisterClassQuery, connection);
                connection.Open();
                MySqlDataReader unregisterClassReader = unregisterClassCreater.ExecuteReader();
                unregisterClassReader.Read();
                connection.Close();

                MessageBox.Show("Class has been successfully unregistered!", "Success!", MessageBoxButtons.OK);
            }
        }

    }

}
