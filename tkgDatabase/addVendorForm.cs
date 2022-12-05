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
    public partial class addVendorForm : Form
    {
        private static MySqlConnection connection;
        public addVendorForm()
        {
            InitializeComponent();
            establishConnection();

            try
            {
                variables.getHighestVendorID = "SELECT MAX(VENDOR_ID)+1 FROM VENDORS";
                MySqlCommand getHighestVendorCommand = new MySqlCommand(variables.getHighestVendorID, connection);
                connection.Open();
                MySqlDataReader vendorHighestNumberReader = getHighestVendorCommand.ExecuteReader();
                vendorHighestNumberReader.Read();
                variables.highestVendorNumID = vendorHighestNumberReader.GetString("MAX(VENDOR_ID)+1");
                connection.Close();
            }

            catch
            {
                variables.highestVendorNumID = "0";
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(vendorNameBox.Text) || String.IsNullOrEmpty(vendorAddressBox.Text) || String.IsNullOrEmpty(vendorPhoneBox.Text))
            {
                MessageBox.Show("Error! One of the boxes is empty or not filled in. Please fill in and try again.", "Error!", MessageBoxButtons.OK);
            }

            else if (vendorPhoneBox.Text.Length < 10)
            {
                MessageBox.Show("Error! Please make sure that the phone number is completely filled out.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                String addVendorQuery = "INSERT INTO VENDORS VALUES (" + variables.highestVendorNumID + ", '" + vendorNameBox.Text + "', '" + vendorAddressBox.Text + "', '" + vendorPhoneBox.Text + "');";
                MySqlCommand addVendorCommand = new MySqlCommand(addVendorQuery, connection);
                connection.Open();
                MySqlDataReader addVendorReader = addVendorCommand.ExecuteReader();
                addVendorReader.Read();

                MessageBox.Show(vendorNameBox.Text + " has been successfully added!", "Success!", MessageBoxButtons.OK);

                connection.Close();

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

        private void vendorPhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
