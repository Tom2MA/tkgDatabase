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
    public partial class addInstructorForm : Form
    {
        private static MySqlConnection connection;
        public addInstructorForm()
        {
            InitializeComponent();
            establishConnection();

            try
            {
                variables.getHighestInstructorID = "SELECT MAX(INSTRUCTOR_ID)+1 FROM INSTRUCTORS";
                MySqlCommand getHighestInstructorCommand = new MySqlCommand(variables.getHighestInstructorID, connection);
                connection.Open();
                MySqlDataReader highestInstructorReader = getHighestInstructorCommand.ExecuteReader();
                highestInstructorReader.Read();
                variables.highestInstructorID = highestInstructorReader.GetString("MAX(INSTRUCTOR_ID)+1");
                connection.Close();
            }
            
            catch
            {
                variables.highestInstructorID = "0";
            }

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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form backToAdminForm = new adminForm();
            backToAdminForm.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String instructorGymID = variables.listOfAddClassGymIDs.ElementAt(gymLocCombo.SelectedIndex);
            if (String.IsNullOrEmpty(firstNameBox.Text) || String.IsNullOrEmpty(lastNameBox.Text))
            {
                MessageBox.Show("Error! One of the boxes is empty or not filled in. Please fill in and try again.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                String addInstructorQuery = "INSERT INTO INSTRUCTORS VALUES (" + variables.highestInstructorID + ", '" + firstNameBox.Text + "', '" + lastNameBox.Text + "', " + instructorGymID + ");";
                MySqlCommand addInstructorCommand = new MySqlCommand(addInstructorQuery, connection);
                connection.Open();
                MySqlDataReader addInstructorReader = addInstructorCommand.ExecuteReader();
                addInstructorReader.Read();
                connection.Close();

                MessageBox.Show(firstNameBox.Text + " " + lastNameBox.Text + " has been successfully created!", "Success!", MessageBoxButtons.OK);

                this.Close();
                adminForm backToAdmin = new adminForm();
                backToAdmin.Show();
            }
        }

        private void gymLocCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String instructorGymID = variables.listOfAddClassGymIDs.ElementAt(gymLocCombo.SelectedIndex);
            Debug.WriteLine(instructorGymID);
        }
    }
}
