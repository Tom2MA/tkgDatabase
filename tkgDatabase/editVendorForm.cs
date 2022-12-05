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
    public partial class editVendorForm : Form
    {
        private static MySqlConnection connection;
        public editVendorForm()
        {
            InitializeComponent();
            establishConnection();

            String getVendorID = "SELECT * FROM VENDORS WHERE VENDOR_ID = " + variables.adminSelectedVendorID + ";";
            MySqlCommand getVendorIDCommand = new MySqlCommand(getVendorID, connection);
            connection.Open();
            MySqlDataReader vendorIDReader = getVendorIDCommand.ExecuteReader();
            vendorIDReader.Read();
            String vendorName = vendorIDReader.GetString("VENDOR_NAME");
            String vendorLocation = vendorIDReader.GetString("VENDOR_LOCATION");
            String vendorPhone = vendorIDReader.GetString("VENDOR_PHONE");
            connection.Close();

            nameBox.Text = vendorName;
            addressBox.Text = vendorLocation;
            phoneBox.Text = vendorPhone;

            //listVendorLocationFilterGyms
            variables.listOfVendorGymsFilter = new List<String>();
            String getVendorGymIDs = "SELECT * FROM GYMS;";
            MySqlDataAdapter vendorGymIDsCommand = new MySqlDataAdapter(getVendorGymIDs, connection);
            DataTable vendorGymIDsTable = new DataTable();
            vendorGymIDsCommand.Fill(vendorGymIDsTable);
            foreach (DataRow gymRow in vendorGymIDsTable.Rows)
            {
                String currentVendorGymID = gymRow[0].ToString();
                String currentVendorGymName = gymRow[1].ToString();
                String currentVendorGymLocation = gymRow[2].ToString();
                String currentVendorGymPhone = gymRow[3].ToString();
                String getVendorGymInfoQuery = "SELECT * FROM GYMS WHERE GYM_ID = " + currentVendorGymID + " AND GYM_NAME = '" + currentVendorGymName + "';";
                MySqlCommand getVendorGymInfoCommand = new MySqlCommand(getVendorGymInfoQuery, connection);
                connection.Open();
                MySqlDataReader getVendorGymInfoReader = getVendorGymInfoCommand.ExecuteReader();
                getVendorGymInfoReader.Read();
                variables.addVendorGymID = getVendorGymInfoReader.GetString("GYM_ID");
                variables.addVendorGymName = getVendorGymInfoReader.GetString("GYM_NAME");
                variables.addVendorGymLocation = getVendorGymInfoReader.GetString("GYM_LOCATION");
                connection.Close();

                locationCombo.Items.Add(variables.addVendorGymName);
                variables.listOfVendorGymsFilter.Add(variables.addVendorGymID);
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
            builder.ConvertZeroDateTime = true;
            connection = new MySqlConnection(builder.ToString());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form backToAdmin = new adminForm();
            backToAdmin.Show();
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(addressBox.Text) || String.IsNullOrEmpty(phoneBox.Text))
            {
                MessageBox.Show("Error! One of the boxes is empty or not filled in. Please fill in and try again.", "Error!", MessageBoxButtons.OK);
            }

            else if (phoneBox.Text.Length < 10)
            {
                MessageBox.Show("Error! Please make sure that the phone number is completely filled out.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                String editVendorQuery = "UPDATE VENDORS SET VENDOR_NAME = '" + nameBox.Text + "', VENDOR_LOCATION = '" + addressBox.Text + "', VENDOR_PHONE = '" + phoneBox.Text + "' WHERE VENDOR_ID = " + variables.adminSelectedVendorID + ";";
                MySqlCommand editVendorCommand = new MySqlCommand(editVendorQuery, connection);
                connection.Open();
                MySqlDataReader editVendorReader = editVendorCommand.ExecuteReader();
                editVendorReader.Read();

                MessageBox.Show(nameBox.Text + " has been successfully saved!", "Success!", MessageBoxButtons.OK);

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

        private void locationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendorSupplyList.Items.Clear();
            vendorEquipmentList.Items.Clear();
            String currentGymSelected = variables.listOfVendorGymsFilter.ElementAt(locationCombo.SelectedIndex);

            //listVendorSupplies
            variables.listOfVendorSupplies = new List<String>();
            String getVendorSupplies = "SELECT * FROM VENDOR_SUPPLY LEFT JOIN VENDOR_EQUIPMENT ON VENDOR_SUPPLY.VENDOREQUIPMENT_ID = VENDOR_EQUIPMENT.VENDOREQUIPMENT_ID WHERE VENDOR_ID = "+variables.adminSelectedVendorID+" AND GYM_ID = "+currentGymSelected+";";
            MySqlDataAdapter vendorSuppliesCommand = new MySqlDataAdapter(getVendorSupplies, connection);
            DataTable vendorSuppliesTable = new DataTable();
            vendorSuppliesCommand.Fill(vendorSuppliesTable);
            foreach (DataRow supplyRow in vendorSuppliesTable.Rows)
            {
                String currentSupplyVendorID = supplyRow[0].ToString();
                String currentSupplyGymID = supplyRow[1].ToString();
                String currentSupplyVendorEquipmentID = supplyRow[2].ToString();
                String currentEquipmentVendorEquipmentID = supplyRow[3].ToString();
                String currentEquipmentVendorEquipmentName = supplyRow[4].ToString();
                String getSupplyInfoQuery = "SELECT * FROM VENDOR_EQUIPMENT WHERE VENDOREQUIPMENT_ID = "+currentEquipmentVendorEquipmentID+";";
                MySqlCommand getSupplyInfoCommand = new MySqlCommand(getSupplyInfoQuery, connection);
                connection.Open();
                MySqlDataReader getSupplyInfoReader = getSupplyInfoCommand.ExecuteReader();
                getSupplyInfoReader.Read();
                String vendorEquipmentID = getSupplyInfoReader.GetString("VENDOREQUIPMENT_ID");
                String vendorEquipmentName = getSupplyInfoReader.GetString("VENDOREQUIPMENT_NAME");
                connection.Close();

                variables.listOfVendorSupplies.Add(vendorEquipmentID);
                vendorSupplyList.Items.Add(vendorEquipmentName);
            }

            //listVendorEquipment
            variables.listOfVendorEquipment = new List<String>();
            String getVendorEquipment = "SELECT * FROM VENDOR_EQUIPMENT;";
            MySqlDataAdapter vendorEquipmentCommand = new MySqlDataAdapter(getVendorEquipment, connection);
            DataTable vendorEquipmentTable = new DataTable();
            vendorEquipmentCommand.Fill(vendorEquipmentTable);
            foreach (DataRow equipmentRow in vendorEquipmentTable.Rows)
            {
                String currentVendorEquipmentID = equipmentRow[0].ToString();
                String currentVendorEquipmentName = equipmentRow[1].ToString();
                String getEquipmentInfoQuery = "SELECT * FROM VENDOR_EQUIPMENT WHERE VENDOREQUIPMENT_ID = " + currentVendorEquipmentID + ";";
                MySqlCommand getEquipmentInfoCommand = new MySqlCommand(getEquipmentInfoQuery, connection);
                connection.Open();
                MySqlDataReader getEquipmentInfoReader = getEquipmentInfoCommand.ExecuteReader();
                getEquipmentInfoReader.Read();
                String vendorEquipmentID = getEquipmentInfoReader.GetString("VENDOREQUIPMENT_ID");
                String vendorEquipmentName = getEquipmentInfoReader.GetString("VENDOREQUIPMENT_NAME");
                connection.Close();

                variables.listOfVendorEquipment.Add(vendorEquipmentID);
                vendorEquipmentList.Items.Add(vendorEquipmentName);
            }
            
        }
        private void vendorEquipmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vendorEquipmentList.SelectedIndex == -1)
            {
                // do nothing
            }

            else
            {
                variables.vendorEquipmentID = variables.listOfVendorEquipment.ElementAt(vendorEquipmentList.SelectedIndex);
                Debug.WriteLine(variables.vendorEquipmentID.ToString()); ;
                String getEquipmentID = "SELECT * FROM VENDOR_EQUIPMENT WHERE VENDOREQUIPMENT_ID = "+ variables.vendorEquipmentID + ";";
                MySqlCommand getEquipmentIDCommand = new MySqlCommand(getEquipmentID, connection);
                connection.Open();
                MySqlDataReader getEquipmentIDReader = getEquipmentIDCommand.ExecuteReader();
                getEquipmentIDReader.Read();
                variables.vendorEquipmentID = getEquipmentIDReader.GetString("VENDOREQUIPMENT_ID");
                String vendorEquipmentName = getEquipmentIDReader.GetString("VENDOREQUIPMENT_NAME");
                connection.Close();
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (vendorEquipmentList.Items.Count == 0)
            {
                MessageBox.Show("Error! Please select a vendor location first to add equipment items!", "Error!", MessageBoxButtons.OK);
            }

            else if (vendorEquipmentList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select equipment to add to vendor supply.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                variables.listOfEquipment = new List<String>();
                String selectedEquipmentID = variables.listOfVendorEquipment.ElementAt(vendorEquipmentList.SelectedIndex);
                String getEquipmentIDQuery = "SELECT * FROM VENDOR_SUPPLY WHERE VENDOR_ID = " + variables.adminSelectedVendorID + " AND GYM_ID = " + variables.listOfVendorGymsFilter.ElementAt(locationCombo.SelectedIndex) + ";";
                MySqlDataAdapter getEquipmentIDAdapter = new MySqlDataAdapter(getEquipmentIDQuery, connection);
                DataTable getEquipmentIDTable = new DataTable();
                getEquipmentIDAdapter.Fill(getEquipmentIDTable);
                foreach (DataRow equipmentIDRow in getEquipmentIDTable.Rows)
                {
                    String equipmentID = equipmentIDRow[2].ToString();
                    Debug.WriteLine(equipmentIDRow);
                    variables.listOfEquipment.Add(equipmentID);
                }

                if (vendorEquipmentList.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select equipment to add to vendor supply.", "Error!", MessageBoxButtons.OK);
                }

                else if (variables.listOfEquipment.Any(variables.vendorEquipmentID.Contains) == true)
                {
                    MessageBox.Show("Equipment cannot be added as equipment is already supplied by the vendor at this location.\nPlease select another equipment item to add.", "Error!", MessageBoxButtons.OK);
                }

                else
                {
                    String addEquipmentID = "INSERT INTO VENDOR_SUPPLY VALUES (" + variables.adminSelectedVendorID + ", " + variables.listOfVendorGymsFilter.ElementAt(locationCombo.SelectedIndex) + ", " + variables.vendorEquipmentID + ");";
                    MySqlCommand addEquipmentIDCommand = new MySqlCommand(addEquipmentID, connection);
                    connection.Open();
                    MySqlDataReader addEquipmentIDReader = addEquipmentIDCommand.ExecuteReader();
                    addEquipmentIDReader.Read();
                    connection.Close();

                    MessageBox.Show(vendorEquipmentList.Text + " has been added to vendor supply!", "Success!", MessageBoxButtons.OK);

                    vendorSupplyList.Items.Clear();
                    //relistVendorSupplies
                    variables.listOfVendorSupplies = new List<String>();
                    String getVendorSupplies = "SELECT * FROM VENDOR_SUPPLY LEFT JOIN VENDOR_EQUIPMENT ON VENDOR_SUPPLY.VENDOREQUIPMENT_ID = VENDOR_EQUIPMENT.VENDOREQUIPMENT_ID WHERE VENDOR_ID = " + variables.adminSelectedVendorID + " AND GYM_ID = " + variables.listOfVendorGymsFilter.ElementAt(locationCombo.SelectedIndex) + ";";
                    MySqlDataAdapter vendorSuppliesCommand = new MySqlDataAdapter(getVendorSupplies, connection);
                    DataTable vendorSuppliesTable = new DataTable();
                    vendorSuppliesCommand.Fill(vendorSuppliesTable);
                    foreach (DataRow supplyRow in vendorSuppliesTable.Rows)
                    {
                        String currentSupplyVendorID = supplyRow[0].ToString();
                        String currentSupplyGymID = supplyRow[1].ToString();
                        String currentSupplyVendorEquipmentID = supplyRow[2].ToString();
                        String currentEquipmentVendorEquipmentID = supplyRow[3].ToString();
                        String currentEquipmentVendorEquipmentName = supplyRow[4].ToString();
                        String getSupplyInfoQuery = "SELECT * FROM VENDOR_EQUIPMENT WHERE VENDOREQUIPMENT_ID = " + currentEquipmentVendorEquipmentID + ";";
                        MySqlCommand getSupplyInfoCommand = new MySqlCommand(getSupplyInfoQuery, connection);
                        connection.Open();
                        MySqlDataReader getSupplyInfoReader = getSupplyInfoCommand.ExecuteReader();
                        getSupplyInfoReader.Read();
                        String vendorEquipmentID = getSupplyInfoReader.GetString("VENDOREQUIPMENT_ID");
                        String vendorEquipmentName = getSupplyInfoReader.GetString("VENDOREQUIPMENT_NAME");
                        connection.Close();

                        variables.listOfVendorSupplies.Add(vendorEquipmentID);
                        vendorSupplyList.Items.Add(vendorEquipmentName);
                    }
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

            if (vendorEquipmentList.Items.Count == 0)
            {
                MessageBox.Show("Error! Please select a vendor location first to remove equipment items!", "Error!", MessageBoxButtons.OK);
            }

            else if (vendorEquipmentList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select equipment to remove from vendor supply.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                variables.listOfEquipment = new List<String>();
                String selectedEquipmentID = variables.listOfVendorEquipment.ElementAt(vendorEquipmentList.SelectedIndex);
                String getEquipmentIDQuery = "SELECT * FROM VENDOR_SUPPLY WHERE VENDOR_ID = " + variables.adminSelectedVendorID + " AND GYM_ID = " + variables.listOfVendorGymsFilter.ElementAt(locationCombo.SelectedIndex) + ";";
                MySqlDataAdapter getEquipmentIDAdapter = new MySqlDataAdapter(getEquipmentIDQuery, connection);
                DataTable getEquipmentIDTable = new DataTable();
                getEquipmentIDAdapter.Fill(getEquipmentIDTable);
                foreach (DataRow equipmentIDRow in getEquipmentIDTable.Rows)
                {
                    String equipmentID = equipmentIDRow[2].ToString();
                    Debug.WriteLine(equipmentIDRow);
                    variables.listOfEquipment.Add(equipmentID);
                }

                if (vendorEquipmentList.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select equipment to remove from vendor supply.", "Error!", MessageBoxButtons.OK);
                }

                else if (variables.listOfEquipment.Any(variables.vendorEquipmentID.Contains) == false)
                {
                    MessageBox.Show("Equipment cannot be removed as equipment is not supplied by the vendor at this location.\nPlease select another equipment item to remove.", "Error!", MessageBoxButtons.OK);
                }

                else
                {
                    String deleteEquipmentID = "DELETE FROM VENDOR_SUPPLY WHERE VENDOR_ID = " + variables.adminSelectedVendorID + " AND GYM_ID = " + variables.listOfVendorGymsFilter.ElementAt(locationCombo.SelectedIndex) + " AND VENDOREQUIPMENT_ID = " + variables.vendorEquipmentID + ";";
                    MySqlCommand deleteEquipmentIDCommand = new MySqlCommand(deleteEquipmentID, connection);
                    connection.Open();
                    MySqlDataReader deleteEquipmentIDReader = deleteEquipmentIDCommand.ExecuteReader();
                    deleteEquipmentIDReader.Read();
                    connection.Close();

                    MessageBox.Show(vendorEquipmentList.Text + " has been removed from vendor!", "Success!", MessageBoxButtons.OK);

                    vendorSupplyList.Items.Clear();
                    //relistVendorSupplies
                    variables.listOfVendorSupplies = new List<String>();
                    String getVendorSupplies = "SELECT * FROM VENDOR_SUPPLY LEFT JOIN VENDOR_EQUIPMENT ON VENDOR_SUPPLY.VENDOREQUIPMENT_ID = VENDOR_EQUIPMENT.VENDOREQUIPMENT_ID WHERE VENDOR_ID = " + variables.adminSelectedVendorID + " AND GYM_ID = " + variables.listOfVendorGymsFilter.ElementAt(locationCombo.SelectedIndex) + ";";
                    MySqlDataAdapter vendorSuppliesCommand = new MySqlDataAdapter(getVendorSupplies, connection);
                    DataTable vendorSuppliesTable = new DataTable();
                    vendorSuppliesCommand.Fill(vendorSuppliesTable);
                    foreach (DataRow supplyRow in vendorSuppliesTable.Rows)
                    {
                        String currentSupplyVendorID = supplyRow[0].ToString();
                        String currentSupplyGymID = supplyRow[1].ToString();
                        String currentSupplyVendorEquipmentID = supplyRow[2].ToString();
                        String currentEquipmentVendorEquipmentID = supplyRow[3].ToString();
                        String currentEquipmentVendorEquipmentName = supplyRow[4].ToString();
                        String getSupplyInfoQuery = "SELECT * FROM VENDOR_EQUIPMENT WHERE VENDOREQUIPMENT_ID = " + currentEquipmentVendorEquipmentID + ";";
                        MySqlCommand getSupplyInfoCommand = new MySqlCommand(getSupplyInfoQuery, connection);
                        connection.Open();
                        MySqlDataReader getSupplyInfoReader = getSupplyInfoCommand.ExecuteReader();
                        getSupplyInfoReader.Read();
                        String vendorEquipmentID = getSupplyInfoReader.GetString("VENDOREQUIPMENT_ID");
                        String vendorEquipmentName = getSupplyInfoReader.GetString("VENDOREQUIPMENT_NAME");
                        connection.Close();

                        variables.listOfVendorSupplies.Add(vendorEquipmentID);
                        vendorSupplyList.Items.Add(vendorEquipmentName);
                    }
                }
            }
        }


    }
}
