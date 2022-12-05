using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tkgDatabase
{
    public partial class editInstructorForm : Form
    {
        private static MySqlConnection connection;
        public editInstructorForm()
        {
            InitializeComponent();
            establishConnection();

            String getInstructorID = "SELECT * FROM INSTRUCTORS WHERE INSTRUCTOR_ID = " + variables.adminSelectedInstructorID + ";";
            MySqlCommand getInstructorIDCommand = new MySqlCommand(getInstructorID, connection);
            connection.Open();
            MySqlDataReader instructorIDReader = getInstructorIDCommand.ExecuteReader();
            instructorIDReader.Read();
            String instructorFName = instructorIDReader.GetString("INSTRUCTOR_FNAME");
            String instructorLName = instructorIDReader.GetString("INSTRUCTOR_LNAME");
            String instructorGymID = instructorIDReader.GetString("GYM_ID");
            connection.Close();

            firstNameBox.Text = instructorFName;
            lastNameBox.Text = instructorLName;

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
            gymLocCombo.SelectedIndex = Int32.Parse(instructorGymID);

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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form backToAdminForm = new adminForm();
            backToAdminForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String instructorGymID = variables.listOfAddClassGymIDs.ElementAt(gymLocCombo.SelectedIndex);
            if (String.IsNullOrEmpty(firstNameBox.Text) || String.IsNullOrEmpty(lastNameBox.Text))
            {
                MessageBox.Show("Error! One of the boxes is empty or not filled in. Please fill in and try again.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                String editInstructorQuery = "UPDATE INSTRUCTORS SET INSTRUCTOR_FNAME = '" + firstNameBox.Text + "', INSTRUCTOR_LNAME = '" + lastNameBox.Text + "', GYM_ID = " + instructorGymID + " WHERE INSTRUCTOR_ID = "+ variables.adminSelectedInstructorID +";";
                MySqlCommand editInstructorCommand = new MySqlCommand(editInstructorQuery, connection);
                connection.Open();
                MySqlDataReader editInstructorReader = editInstructorCommand.ExecuteReader();
                editInstructorReader.Read();
                connection.Close();

                MessageBox.Show(firstNameBox.Text + " " + lastNameBox.Text + " has been successfully updated!", "Success!", MessageBoxButtons.OK);

                this.Close();
                adminForm backToAdmin = new adminForm();
                backToAdmin.Show();
            }
        }
    }
}
