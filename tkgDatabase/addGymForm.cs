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
    public partial class addGymForm : Form
    {
        private static MySqlConnection connection;
        public addGymForm()
        {
            InitializeComponent();
            establishConnection();

            try
            {
                variables.getHighestGymID = "SELECT MAX(GYM_ID)+1 FROM GYMS";
                MySqlCommand getHighestGymCommand = new MySqlCommand(variables.getHighestGymID, connection);
                connection.Open();
                MySqlDataReader gymHighestNumberReader = getHighestGymCommand.ExecuteReader();
                gymHighestNumberReader.Read();
                variables.highestGymNumID = gymHighestNumberReader.GetString("MAX(GYM_ID)+1");
                connection.Close();
            }

            catch
            {
                variables.highestGymNumID = "0";
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

        private void addButton_Click(object sender, EventArgs e)
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
                String addGymQuery = "INSERT INTO GYMS VALUES (" + variables.highestGymNumID + ", '" + nameBox.Text + "', '" + locationBox.Text + "', '" + phoneBox.Text + "');";
                MySqlCommand addGymCommand = new MySqlCommand(addGymQuery, connection);
                connection.Open();
                MySqlDataReader addGymReader = addGymCommand.ExecuteReader();
                addGymReader.Read();

                MessageBox.Show("Gym with city name \"" + nameBox.Text + "\" has been successfully added!", "Success!", MessageBoxButtons.OK);

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
