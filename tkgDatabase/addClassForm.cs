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
    public partial class addClassForm : Form
    {
        private static MySqlConnection connection;
        public addClassForm()
        {
            InitializeComponent();
            establishConnection();

            try
            {
                variables.getHighestClassNumber = "SELECT MAX(CLASS_ID)+1 FROM CLASSES";
                MySqlCommand getHighestClassNumberer = new MySqlCommand(variables.getHighestClassNumber, connection);
                connection.Open();
                MySqlDataReader classHighestNumberReader = getHighestClassNumberer.ExecuteReader();
                classHighestNumberReader.Read();
                variables.highestClassNumID = classHighestNumberReader.GetString("MAX(CLASS_ID)+1");
                connection.Close();
            }

            catch
            {
                variables.highestClassNumID = "0";
            }

            //listInstructors
            variables.listOfAddClassInstructorGymIDs = new List<String>();
            variables.listOfAddClassInstructors = new List<String>();
            String getClassInstructors = "SELECT * FROM INSTRUCTORS;";
            MySqlDataAdapter classInstructorsCreater = new MySqlDataAdapter(getClassInstructors, connection);
            DataTable classInstructorsTable = new DataTable();
            classInstructorsCreater.Fill(classInstructorsTable);
            foreach (DataRow instructorsRow in classInstructorsTable.Rows)
            {
                String currentClassInstructorID = instructorsRow[0].ToString();
                String currentClassInstructorFName = instructorsRow[1].ToString();
                String currentClassInstructorLName = instructorsRow[2].ToString();
                String currentClassInstructorGymID = instructorsRow[3].ToString();
                String getClassInstructorInfoQuery = "SELECT * FROM INSTRUCTORS WHERE INSTRUCTOR_ID = " + currentClassInstructorID + ";";
                MySqlCommand getClassInstructorInfoCreater = new MySqlCommand(getClassInstructorInfoQuery, connection);
                connection.Open();
                MySqlDataReader getClassInstructorInfoReader = getClassInstructorInfoCreater.ExecuteReader();
                getClassInstructorInfoReader.Read();
                variables.addClassInstructorID = getClassInstructorInfoReader.GetString("INSTRUCTOR_ID");
                variables.addClassInstructorFName = getClassInstructorInfoReader.GetString("INSTRUCTOR_FNAME");
                variables.addClassInstructorLName = getClassInstructorInfoReader.GetString("INSTRUCTOR_LNAME");
                variables.addClassInstructorGymID = getClassInstructorInfoReader.GetString("GYM_ID");
                connection.Close();

                instructorCombo.Items.Add(variables.addClassInstructorFName + " " + variables.addClassInstructorLName);
                variables.listOfAddClassInstructors.Add(variables.addClassInstructorID);
                variables.listOfAddClassInstructorGymIDs.Add(variables.addClassInstructorGymID);
            }
            instructorCombo.SelectedIndex = 0;

            //listGyms
            variables.listOfAddClassGymIDs = new List<String>();
            String getClassGymIDs = "SELECT * FROM GYMS;";
            MySqlDataAdapter classGymIDsCreater = new MySqlDataAdapter(getClassGymIDs, connection);
            DataTable classGymIDsTable = new DataTable();
            classGymIDsCreater.Fill(classGymIDsTable);
            foreach (DataRow gymRow in classGymIDsTable.Rows)
            {
                String currentClassGymID = gymRow[0].ToString();
                String currentClassGymName = gymRow[1].ToString();
                String currentClassGymLocation = gymRow[2].ToString();
                String currentClassGymPhone = gymRow[3].ToString();
                String getClassGymInfoQuery = "SELECT * FROM GYMS WHERE GYM_ID = " + currentClassGymID + " AND GYM_NAME = '" + currentClassGymName + "';";
                MySqlCommand getClassGymInfoCreater = new MySqlCommand(getClassGymInfoQuery, connection);
                connection.Open();
                MySqlDataReader getClassGymInfoReader = getClassGymInfoCreater.ExecuteReader();
                getClassGymInfoReader.Read();
                variables.addClassGymID = getClassGymInfoReader.GetString("GYM_ID");
                variables.addClassGymName = getClassGymInfoReader.GetString("GYM_NAME");
                variables.addClassGymLocation = getClassGymInfoReader.GetString("GYM_LOCATION");
                connection.Close();

                gymLocCombo.Items.Add(variables.addClassGymName);
                variables.listOfAddClassGymIDs.Add(variables.addClassGymID);
            }
            gymLocCombo.SelectedIndex = 0;

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

        private void createButton_Click(object sender, EventArgs e)
        {
            String startTime = startTimePicker.Value.ToString("HH:mm:ss");
            String endTime = endTimePicker.Value.ToString("HH:mm:ss");
            String currentInstructorID = variables.listOfAddClassInstructors.ElementAt(instructorCombo.SelectedIndex);
            String currentGymID = variables.listOfAddClassGymIDs.ElementAt(gymLocCombo.SelectedIndex);

            if (String.IsNullOrEmpty(classNameBox.Text) || String.IsNullOrEmpty(classDaysBox.Text))
            {
                MessageBox.Show("Error! One of the boxes is empty or not filled in. Please fill in and try again.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                String createClassQuery = "INSERT INTO CLASSES VALUES ("+ variables.highestClassNumID + ", '"+classNameBox.Text+"', '"+startTime+"', '"+endTime+"', '"+classDaysBox.Text+"', "+currentInstructorID+", "+currentGymID+");";
                MySqlCommand createClassCommand = new MySqlCommand(createClassQuery, connection);
                connection.Open();
                MySqlDataReader createClassReader = createClassCommand.ExecuteReader();
                createClassReader.Read();
                connection.Close();

                MessageBox.Show(classNameBox.Text + " has been successfully created!", "Success!", MessageBoxButtons.OK);

                this.Close();
                adminForm backToAdmin = new adminForm();
                backToAdmin.Show();
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminForm backToAdmin = new adminForm();
            backToAdmin.Show();
        }

        private void instructorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String currentInstructorID = variables.listOfAddClassInstructors.ElementAt(instructorCombo.SelectedIndex);
            String currentGymID = variables.listOfAddClassInstructorGymIDs.ElementAt(instructorCombo.SelectedIndex);
            Debug.WriteLine(currentInstructorID);
            Debug.WriteLine(currentGymID);

            String getGymName = "SELECT * FROM GYMS WHERE GYM_ID = "+currentGymID+";";
            MySqlCommand getGymNameCreater = new MySqlCommand(getGymName, connection);
            connection.Open();
            MySqlDataReader getGymNameReader = getGymNameCreater.ExecuteReader();
            getGymNameReader.Read();
            String currentGymName = getGymNameReader.GetString("GYM_NAME");
            connection.Close();

            instructorBox.Text = currentGymName;

            gymLocCombo.Text = currentGymName;

        }

        private void gymLocCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String currentGymLoc = variables.listOfAddClassGymIDs.ElementAt(gymLocCombo.SelectedIndex);
            Debug.WriteLine(currentGymLoc);
        }
    }
}
