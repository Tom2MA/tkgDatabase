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
    public partial class editGymForm : Form
    {
        private static MySqlConnection connection;
        public editGymForm()
        {
            InitializeComponent();
            establishConnection();

            String getGymNumber = "SELECT * FROM GYMS WHERE GYM_ID = " + variables.adminSelectedGymID + ";";
            MySqlCommand getGymNumCommand = new MySqlCommand(getGymNumber, connection);
            connection.Open();
            MySqlDataReader gymNumReader = getGymNumCommand.ExecuteReader();
            gymNumReader.Read();
            String gymCityName = gymNumReader.GetString("GYM_NAME");
            String gymLocation = gymNumReader.GetString("GYM_LOCATION");
            String gymPhone = gymNumReader.GetString("GYM_PHONE");
            connection.Close();

            nameBox.Text = gymCityName;
            locationBox.Text = gymLocation;
            phoneBox.Text = gymPhone;
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
            adminForm backToAdmin = new adminForm();
            backToAdmin.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(locationBox.Text) || String.IsNullOrEmpty(phoneBox.Text))
            {
                MessageBox.Show("Error! One of the boxes is empty or not filled in. Please fill in and try again.", "Error!", MessageBoxButtons.OK);
            }

            else if (phoneBox.Text.Length < 10)
            {
                MessageBox.Show("Error! Please make sure that the phone number is completely filled out.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                String editGymQuery = "UPDATE GYMS SET GYM_NAME = '" +nameBox.Text+ "', GYM_LOCATION = '" +locationBox.Text+ "', GYM_PHONE = '" +phoneBox.Text+ "' WHERE GYM_ID = "+variables.adminSelectedGymID+";";
                MySqlCommand editGymCommand = new MySqlCommand(editGymQuery, connection);
                connection.Open();
                MySqlDataReader editGymReader = editGymCommand.ExecuteReader();
                editGymReader.Read();

                MessageBox.Show("Gym with city name \"" + nameBox.Text + "\" has been successfully updated!", "Success!", MessageBoxButtons.OK);

                connection.Close();

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
    }
}
