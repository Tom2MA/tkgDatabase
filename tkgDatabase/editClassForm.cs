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
    public partial class editClassForm : Form
    {
        private static MySqlConnection connection;
        public editClassForm()
        {
            InitializeComponent();
            establishConnection();

            String getClassIDQuery = "SELECT * FROM CLASSES WHERE CLASS_ID = " + variables.adminSelectedClassID + ";"; //query for selected class
            MySqlCommand getClassIDCommand = new MySqlCommand(getClassIDQuery, connection);
            connection.Open();
            MySqlDataReader classIDReader = getClassIDCommand.ExecuteReader();
            classIDReader.Read();
            String className = classIDReader.GetString("CLASS_NAME");
            String classTimeStart = classIDReader.GetString("CLASS_TIMESTART");
            String classTimeEnd = classIDReader.GetString("CLASS_TIMEEND"); 
            String classDays = classIDReader.GetString("CLASS_DAYS"); //get values
            String classInstructorID = classIDReader.GetString("INSTRUCTOR_ID");
            String classGymID = classIDReader.GetString("GYM_ID");
            connection.Close();

            classNameBox.Text = className;
            startTimePicker.Value = DateTime.Parse(classTimeStart);
            endTimePicker.Value = DateTime.Parse(classTimeEnd); //fill UI based on class ID
            classDaysBox.Text = classDays;

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

                instructorCombo.Items.Add(variables.addClassInstructorFName + " " + variables.addClassInstructorLName); //add to UI names for instructors
                variables.listOfAddClassInstructors.Add(variables.addClassInstructorID); //list instructor IDs
                variables.listOfAddClassInstructorGymIDs.Add(variables.addClassInstructorGymID); //list gym IDs associated with instructors
            }
            instructorCombo.SelectedIndex = Int32.Parse(classInstructorID);

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
            gymLocCombo.SelectedIndex = Int32.Parse(classGymID);

        }

        public static void establishConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "password";
            builder.Database = "tkgDatabase";
            builder.SslMode = MySqlSslMode.Disabled;
            builder.ConvertZeroDateTime = true;
            connection = new MySqlConnection(builder.ToString());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminForm backToAdmin = new adminForm(); //back to admin page
            backToAdmin.Show();
        }

        private void instructorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String currentInstructorID = variables.listOfAddClassInstructors.ElementAt(instructorCombo.SelectedIndex);
            String currentGymID = variables.listOfAddClassInstructorGymIDs.ElementAt(instructorCombo.SelectedIndex);
            Debug.WriteLine(currentInstructorID);
            Debug.WriteLine(currentGymID);

            String getGymName = "SELECT * FROM GYMS WHERE GYM_ID = " + currentGymID + ";";
            MySqlCommand getGymNameCreater = new MySqlCommand(getGymName, connection);
            connection.Open();
            MySqlDataReader getGymNameReader = getGymNameCreater.ExecuteReader();
            getGymNameReader.Read();
            String currentGymName = getGymNameReader.GetString("GYM_NAME");
            connection.Close();

            instructorBox.Text = currentGymName;
        }

        private void gymLocCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String currentGymLoc = variables.listOfAddClassGymIDs.ElementAt(gymLocCombo.SelectedIndex); //test variable
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String startTime = startTimePicker.Value.ToString("HH:mm:ss");
            String endTime = endTimePicker.Value.ToString("HH:mm:ss"); //String conversion
            String currentInstructorID = variables.listOfAddClassInstructors.ElementAt(instructorCombo.SelectedIndex);
            String currentGymID = variables.listOfAddClassGymIDs.ElementAt(gymLocCombo.SelectedIndex);

            if (String.IsNullOrEmpty(classNameBox.Text) || String.IsNullOrEmpty(classDaysBox.Text)) //if boxes are empty display messagebox
            {
                MessageBox.Show("Error! One of the boxes is empty or not filled in. Please fill in and try again.", "Error!", MessageBoxButtons.OK);
            }

            else
            { //query to update class
                String editClassQuery = "UPDATE CLASSES SET CLASS_NAME = '" + classNameBox.Text + "', CLASS_TIMESTART = '" + startTime + "', CLASS_TIMEEND = '" + endTime + "', CLASS_DAYS = '" + classDaysBox.Text + "', INSTRUCTOR_ID = " + currentInstructorID + ", GYM_ID = " + currentGymID + " WHERE CLASS_ID = " + variables.adminSelectedClassID + ";";
                MySqlCommand editClassCommand = new MySqlCommand(editClassQuery, connection);
                connection.Open();
                MySqlDataReader editClassReader = editClassCommand.ExecuteReader();
                editClassReader.Read();
                connection.Close();

                MessageBox.Show(classNameBox.Text + " has been successfully updated!", "Success!", MessageBoxButtons.OK); //success message

                this.Close();
                adminForm backToAdmin = new adminForm(); //go back to admin page
                backToAdmin.Show();
            }
        }
    }
}
