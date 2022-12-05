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
    public partial class adminForm : Form
    {
        private static MySqlConnection connection;
        public adminForm()
        {
            InitializeComponent();
            establishConnection();

            //listAdminMembers
            variables.listOfAdminMemberIDs = new List<String>();
            variables.listOfAdminMemberAccountIDs = new List<String>();
            String getAdminMembers = "SELECT * FROM MEMBERS;"; //get all members query
            MySqlDataAdapter adminMembersCreater = new MySqlDataAdapter(getAdminMembers, connection);
            DataTable adminMembersTable = new DataTable();
            adminMembersCreater.Fill(adminMembersTable);
            foreach (DataRow memberRow in adminMembersTable.Rows)
            {
                String currentAdminMemberID = memberRow[0].ToString();
                String currentAdminMemberFName = memberRow[1].ToString();
                String currentAdminMemberLName = memberRow[2].ToString(); 
                //get member info based on ID query
                String getAdminMemInfoQuery = "SELECT * FROM MEMBERS WHERE MEM_ID = " + currentAdminMemberID + " AND MEM_FNAME = '" + currentAdminMemberFName + "' AND MEM_LNAME = '"+currentAdminMemberLName+"';";
                MySqlCommand getAdminMemInfoCreater = new MySqlCommand(getAdminMemInfoQuery, connection);
                connection.Open();
                MySqlDataReader getAdminMemInfoReader = getAdminMemInfoCreater.ExecuteReader();
                getAdminMemInfoReader.Read();
                variables.adminMemID = getAdminMemInfoReader.GetString("MEM_ID");
                variables.adminMemFName = getAdminMemInfoReader.GetString("MEM_FNAME"); //get values for each member
                variables.adminMemLName = getAdminMemInfoReader.GetString("MEM_LNAME");
                variables.adminMemAccountID = getAdminMemInfoReader.GetString("ACCOUNT_ID");
                connection.Close();

                membersList.Items.Add(variables.adminMemFName+" "+variables.adminMemLName); //send names to UI
                variables.listOfAdminMemberIDs.Add(variables.adminMemID); //send member IDs to list
                variables.listOfAdminMemberAccountIDs.Add(variables.adminMemAccountID); //send account IDs to list

            }

            //listAdminClasses
            variables.listOfAdminClassIDs = new List<String>();
            String getAdminClasses = "SELECT * FROM CLASSES;"; //get all classes query
            MySqlDataAdapter adminClassesCreater = new MySqlDataAdapter(getAdminClasses, connection);
            DataTable adminClassesTable = new DataTable();
            adminClassesCreater.Fill(adminClassesTable);
            foreach (DataRow classRow in adminClassesTable.Rows)
            {
                String currentAdminClassID = classRow[0].ToString();
                String currentAdminClassName = classRow[1].ToString(); //get class info based on ID
                //get class info based on ID query
                String getAdminClassInfoQuery = "SELECT * FROM CLASSES WHERE CLASS_ID = " + currentAdminClassID + " AND CLASS_NAME = '" + currentAdminClassName + "';";
                MySqlCommand getAdminClassInfoCreater = new MySqlCommand(getAdminClassInfoQuery, connection);
                connection.Open();
                MySqlDataReader getAdminClassInfoReader = getAdminClassInfoCreater.ExecuteReader();
                getAdminClassInfoReader.Read();
                variables.adminClassID = getAdminClassInfoReader.GetString("CLASS_ID"); //get values for each class
                variables.adminClassName = getAdminClassInfoReader.GetString("CLASS_NAME");
                connection.Close();

                classesList.Items.Add(variables.adminClassName); //send classes to UI
                variables.listOfAdminClassIDs.Add(variables.adminClassID); //send class IDs to list

            }

            //listAdminInstructors
            variables.listOfAdminInstructorIDs = new List<String>();
            String getAdminInstructors = "SELECT * FROM INSTRUCTORS;"; //get all instructors query
            MySqlDataAdapter adminInstructorsCreater = new MySqlDataAdapter(getAdminInstructors, connection);
            DataTable adminInstructorsTable = new DataTable();
            adminInstructorsCreater.Fill(adminInstructorsTable);
            foreach (DataRow instructorRow in adminInstructorsTable.Rows)
            {
                String currentAdminInstructorID = instructorRow[0].ToString();
                String currentAdminInstructorFName = instructorRow[1].ToString(); 
                String currentAdminInstructorLName = instructorRow[2].ToString();
                //get instructor info based on ID query
                String getAdminInstructorInfoQuery = "SELECT * FROM INSTRUCTORS WHERE INSTRUCTOR_ID = " + currentAdminInstructorID + " AND INSTRUCTOR_FNAME = '" + currentAdminInstructorFName + "' AND INSTRUCTOR_LNAME = '" + currentAdminInstructorLName + "';";
                MySqlCommand getAdminInstructorInfoCreater = new MySqlCommand(getAdminInstructorInfoQuery, connection);
                connection.Open();
                MySqlDataReader getAdminInstructorInfoReader = getAdminInstructorInfoCreater.ExecuteReader();
                getAdminInstructorInfoReader.Read();
                variables.adminInstructorID = getAdminInstructorInfoReader.GetString("INSTRUCTOR_ID");
                variables.adminInstructorFName = getAdminInstructorInfoReader.GetString("INSTRUCTOR_FNAME"); //get values for each instructor
                variables.adminInstructorLName = getAdminInstructorInfoReader.GetString("INSTRUCTOR_LNAME");
                connection.Close();

                instructorsList.Items.Add(variables.adminInstructorFName + " " + variables.adminInstructorLName); //send names to UI
                variables.listOfAdminInstructorIDs.Add(variables.adminInstructorID); //send instructor IDs to list

            }


            //listAdminVendors
            variables.listOfAdminVendorIDs = new List<String>();
            String getAdminVendors = "SELECT * FROM VENDORS;"; //get all vendors query
            MySqlDataAdapter adminVendorsCreater = new MySqlDataAdapter(getAdminVendors, connection);
            DataTable adminVendorsTable = new DataTable();
            adminVendorsCreater.Fill(adminVendorsTable);
            foreach (DataRow vendorRow in adminVendorsTable.Rows)
            {
                String currentAdminVendorID = vendorRow[0].ToString();
                String currentAdminVendorName = vendorRow[1].ToString();
                //get vendor info based on ID query
                String getAdminVendorInfoQuery = "SELECT * FROM VENDORS WHERE VENDOR_ID = " + currentAdminVendorID + " AND VENDOR_NAME = '" + currentAdminVendorName + "';";
                MySqlCommand getAdminVendorInfoCreater = new MySqlCommand(getAdminVendorInfoQuery, connection);
                connection.Open();
                MySqlDataReader getAdminVendorInfoReader = getAdminVendorInfoCreater.ExecuteReader();
                getAdminVendorInfoReader.Read();
                variables.adminVendorID = getAdminVendorInfoReader.GetString("VENDOR_ID");
                variables.adminVendorName = getAdminVendorInfoReader.GetString("VENDOR_NAME"); //get values for each vendor
                variables.adminVendorLocation = getAdminVendorInfoReader.GetString("VENDOR_LOCATION");
                connection.Close();

                vendorsList.Items.Add(variables.adminVendorName); //send vendor names to UI
                variables.listOfAdminVendorIDs.Add(variables.adminVendorID); //send vendor IDs to list

            }

            //listAdminGyms
            variables.listOfAdminGymIDs = new List<String>();
            String getAdminGyms = "SELECT * FROM GYMS;"; //get all gyms query
            MySqlDataAdapter adminGymsCreater = new MySqlDataAdapter(getAdminGyms, connection);
            DataTable adminGymsTable = new DataTable();
            adminGymsCreater.Fill(adminGymsTable);
            foreach (DataRow gymRow in adminGymsTable.Rows)
            {
                String currentAdminGymID = gymRow[0].ToString();
                String currentAdminGymName = gymRow[1].ToString();
                //get gym info based on ID query
                String getAdminGymInfoQuery = "SELECT * FROM GYMS WHERE GYM_ID = " + currentAdminGymID + " AND GYM_NAME = '" + currentAdminGymName + "';";
                MySqlCommand getAdminGymInfoCreater = new MySqlCommand(getAdminGymInfoQuery, connection);
                connection.Open();
                MySqlDataReader getAdminGymInfoReader = getAdminGymInfoCreater.ExecuteReader();
                getAdminGymInfoReader.Read();
                variables.adminGymID = getAdminGymInfoReader.GetString("GYM_ID");
                variables.adminGymName = getAdminGymInfoReader.GetString("GYM_NAME"); //get values for each gym
                variables.adminGymLocation = getAdminGymInfoReader.GetString("GYM_LOCATION");
                variables.adminGymPhone = getAdminGymInfoReader.GetString("GYM_PHONE");
                connection.Close();

                gymsList.Items.Add(variables.adminGymName); //send gym names to UI
                variables.listOfAdminGymIDs.Add(variables.adminGymID); //send gym IDs to list
            }

            //listLocationFilterGyms
            variables.listOfAddClassGymIDs = new List<String>();
            String getClassGymIDs = "SELECT * FROM GYMS;"; //get all gyms for filter query
            MySqlDataAdapter classGymIDsCreater = new MySqlDataAdapter(getClassGymIDs, connection);
            DataTable classGymIDsTable = new DataTable();
            classGymIDsCreater.Fill(classGymIDsTable);
            foreach (DataRow gymRow in classGymIDsTable.Rows)
            {
                String currentClassGymID = gymRow[0].ToString();
                String currentClassGymName = gymRow[1].ToString();
                //get gym info based on ID query
                String getClassGymInfoQuery = "SELECT * FROM GYMS WHERE GYM_ID = " + currentClassGymID + " AND GYM_NAME = '" + currentClassGymName + "';";
                MySqlCommand getClassGymInfoCreater = new MySqlCommand(getClassGymInfoQuery, connection);
                connection.Open();
                MySqlDataReader getClassGymInfoReader = getClassGymInfoCreater.ExecuteReader();
                getClassGymInfoReader.Read();
                variables.addClassGymID = getClassGymInfoReader.GetString("GYM_ID");
                variables.addClassGymName = getClassGymInfoReader.GetString("GYM_NAME"); //get filter values
                variables.addClassGymLocation = getClassGymInfoReader.GetString("GYM_LOCATION");
                connection.Close();

                locationCombo.Items.Add(variables.addClassGymName); //send gym names to filter
                variables.listOfAddClassGymIDs.Add(variables.addClassGymID); //send gym IDs to filter
            }

        }

        public static void establishConnection()
        {   //connector to database
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
            Environment.Exit(1); //exit
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (membersList.SelectedIndex > -1)
            {
                this.Close();
                Form editMemberPage = new editMemberForm(); //open edit page if member is selected
                editMemberPage.Show();
            }

            else if (classesList.SelectedIndex > -1)
            {

                this.Close();
                Form editClassPage = new editClassForm(); //open edit page if class is selected
                editClassPage.Show();
            }

            else if (instructorsList.SelectedIndex > -1)
            {

                this.Close();
                Form editInstructorPage = new editInstructorForm(); //open edit page if instructor is selected
                editInstructorPage.Show();
            }

            else if (vendorsList.SelectedIndex > -1)
            {

                this.Close();
                Form editVendorPage = new editVendorForm(); //open edit page if vendor is selected
                editVendorPage.Show();
            }

            else if (gymsList.SelectedIndex > -1)
            {

                this.Close();
                Form editGymPage = new editGymForm(); //open edit page if gym is selected
                editGymPage.Show();
            }

            else
            {
                MessageBox.Show("Nothing is selected, please select an item from a list and try again.", "Error!", MessageBoxButtons.OK); //nothing is selected
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form loginPage = new loginForm(); //go back to login form
            loginPage.Show();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form addMemberPage = new addMemberForm(); //open add member page
            addMemberPage.Show();
        }

        private void membersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (membersList.SelectedIndex == -1)
            {
                // do nothing
            }

            else if (membersList.SelectedIndex > -1)
            {
                classesList.SelectedIndex = -1;
                instructorsList.SelectedIndex = -1;
                vendorsList.SelectedIndex = -1;
                variables.adminSelectedMemberID = variables.listOfAdminMemberIDs.ElementAt(membersList.SelectedIndex); //get member ID
                variables.adminSelectedMemberAccountID = variables.listOfAdminMemberAccountIDs.ElementAt(membersList.SelectedIndex); //get account ID
            }
            
        }

        private void classesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classesList.SelectedIndex == -1)
            {
                // do nothing
            }

            else if (classesList.SelectedIndex > -1)
            {
                membersList.SelectedIndex = -1;
                instructorsList.SelectedIndex = -1;
                vendorsList.SelectedIndex = -1;
                gymsList.SelectedIndex = -1;
                variables.adminSelectedClassID = variables.listOfAdminClassIDs.ElementAt(classesList.SelectedIndex); //get class ID
            }
        }

        private void instructorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (instructorsList.SelectedIndex == -1)
            {
                // do nothing
            }

            else if (instructorsList.SelectedIndex > -1)
            {
                membersList.SelectedIndex = -1;
                classesList.SelectedIndex = -1;
                vendorsList.SelectedIndex = -1;
                gymsList.SelectedIndex = -1;
                variables.adminSelectedInstructorID = variables.listOfAdminInstructorIDs.ElementAt(instructorsList.SelectedIndex); //get instructor ID
            }

        }

        private void vendorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vendorsList.SelectedIndex == -1)
            {
                // do nothing
            }

            else if (vendorsList.SelectedIndex > -1)
            {
                membersList.SelectedIndex = -1;
                classesList.SelectedIndex = -1;
                instructorsList.SelectedIndex = -1;
                gymsList.SelectedIndex = -1;
                variables.adminSelectedVendorID = variables.listOfAdminVendorIDs.ElementAt(vendorsList.SelectedIndex); //get vendor ID
            }
        }

        private void gymsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gymsList.SelectedIndex == -1)
            {
                // do nothing
            }

            else if (gymsList.SelectedIndex > -1)
            {
                membersList.SelectedIndex = -1;
                classesList.SelectedIndex = -1;
                instructorsList.SelectedIndex = -1;
                vendorsList.SelectedIndex = -1;
                variables.adminSelectedGymID = variables.listOfAdminGymIDs.ElementAt(gymsList.SelectedIndex); //get gym ID
            }
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            if (membersList.SelectedIndex == -1)
            {
                MessageBox.Show("Error! No member is selected, please select a member to remove.", "Error!", MessageBoxButtons.OK); //nothing is selected
            }

            else
            {
                //remove account and all linked to member ID queries
                String removeMemberClassesQuery = "DELETE FROM CLASS_ENROLL WHERE ACCOUNT_ID = " + variables.adminSelectedMemberAccountID + ";";
                MySqlCommand removeMemberClassesCreater = new MySqlCommand(removeMemberClassesQuery, connection);
                connection.Open();
                MySqlDataReader removeMemberClassesReader = removeMemberClassesCreater.ExecuteReader();
                removeMemberClassesReader.Read();
                connection.Close();

                String removeMemberQuery = "DELETE FROM MEMBERS WHERE MEM_ID = " + variables.adminSelectedMemberID + ";";
                MySqlCommand removeMemberCreater = new MySqlCommand(removeMemberQuery, connection);
                connection.Open();
                MySqlDataReader removeMemberReader = removeMemberCreater.ExecuteReader();
                removeMemberReader.Read();
                connection.Close();

                String removeAccountQuery = "DELETE FROM ACCOUNTS WHERE ACCOUNT_ID = " + variables.adminSelectedMemberAccountID + ";";
                MySqlCommand removeAccountCreater = new MySqlCommand(removeAccountQuery, connection);
                connection.Open();
                MySqlDataReader removeAccountReader = removeAccountCreater.ExecuteReader();
                removeAccountReader.Read();
                connection.Close();

                MessageBox.Show(membersList.SelectedItem.ToString() + " has been successfully removed!", "Success!", MessageBoxButtons.OK); //success message

                this.Close();
                Form openAdminForm = new adminForm(); //restart UI
                openAdminForm.Show();
            }
        }

        private void locationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            classesList.Items.Clear();
            instructorsList.Items.Clear(); //clear UI and insert new filter names below
            gymsList.Items.Clear();

            String currentGymLoc = variables.listOfAddClassGymIDs.ElementAt(locationCombo.SelectedIndex);

            //listAdminClasses
            variables.listOfAdminClassIDs = new List<String>();
            String getAdminClasses = "SELECT * FROM CLASSES WHERE GYM_ID = " + currentGymLoc + ";";
            MySqlDataAdapter adminClassesCreater = new MySqlDataAdapter(getAdminClasses, connection);
            DataTable adminClassesTable = new DataTable();
            adminClassesCreater.Fill(adminClassesTable);
            foreach (DataRow classRow in adminClassesTable.Rows)
            {
                String currentAdminClassID = classRow[0].ToString();
                String currentAdminClassName = classRow[1].ToString();
                String currentAdminClassTimeStart = classRow[2].ToString();
                String currentAdminClassTimeEnd = classRow[3].ToString();
                String currentAdminClassDays = classRow[4].ToString();
                String currentAdminClassInstructor = classRow[5].ToString();
                String currentAdminClassGymID = classRow[6].ToString();
                String getAdminClassInfoQuery = "SELECT * FROM CLASSES WHERE CLASS_ID = " + currentAdminClassID + " AND CLASS_NAME = '" + currentAdminClassName + "' AND GYM_ID = " + currentGymLoc + ";";
                MySqlCommand getAdminClassInfoCreater = new MySqlCommand(getAdminClassInfoQuery, connection);
                connection.Open();
                MySqlDataReader getAdminClassInfoReader = getAdminClassInfoCreater.ExecuteReader();
                getAdminClassInfoReader.Read();
                variables.adminClassID = getAdminClassInfoReader.GetString("CLASS_ID");
                variables.adminClassName = getAdminClassInfoReader.GetString("CLASS_NAME");
                connection.Close();

                classesList.Items.Add(variables.adminClassName);
                variables.listOfAdminClassIDs.Add(variables.adminClassID);

            }

            //listAdminInstructors
            variables.listOfAdminInstructorIDs = new List<String>();
            String getAdminInstructors = "SELECT * FROM INSTRUCTORS WHERE GYM_ID = " + currentGymLoc + ";";
            MySqlDataAdapter adminInstructorsCreater = new MySqlDataAdapter(getAdminInstructors, connection);
            DataTable adminInstructorsTable = new DataTable();
            adminInstructorsCreater.Fill(adminInstructorsTable);
            foreach (DataRow instructorRow in adminInstructorsTable.Rows)
            {
                String currentAdminInstructorID = instructorRow[0].ToString();
                String currentAdminInstructorFName = instructorRow[1].ToString();
                String currentAdminInstructorLName = instructorRow[2].ToString();
                String currentAdminInstructorGymID = instructorRow[3].ToString();
                String getAdminInstructorInfoQuery = "SELECT * FROM INSTRUCTORS WHERE INSTRUCTOR_ID = " + currentAdminInstructorID + " AND INSTRUCTOR_FNAME = '" + currentAdminInstructorFName + "' AND INSTRUCTOR_LNAME = '" + currentAdminInstructorLName + "' AND GYM_ID = " + currentGymLoc + ";";
                MySqlCommand getAdminInstructorInfoCreater = new MySqlCommand(getAdminInstructorInfoQuery, connection);
                connection.Open();
                MySqlDataReader getAdminInstructorInfoReader = getAdminInstructorInfoCreater.ExecuteReader();
                getAdminInstructorInfoReader.Read();
                variables.adminInstructorID = getAdminInstructorInfoReader.GetString("INSTRUCTOR_ID");
                variables.adminInstructorFName = getAdminInstructorInfoReader.GetString("INSTRUCTOR_FNAME");
                variables.adminInstructorLName = getAdminInstructorInfoReader.GetString("INSTRUCTOR_LNAME");
                connection.Close();

                instructorsList.Items.Add(variables.adminInstructorFName + " " + variables.adminInstructorLName);
                variables.listOfAdminInstructorIDs.Add(variables.adminInstructorID);

            }

            //listAdminGyms
            variables.listOfAdminGymIDs = new List<String>();
            String getAdminGyms = "SELECT * FROM GYMS WHERE GYM_ID = " +currentGymLoc + ";";
            MySqlDataAdapter adminGymsCreater = new MySqlDataAdapter(getAdminGyms, connection);
            DataTable adminGymsTable = new DataTable();
            adminGymsCreater.Fill(adminGymsTable);
            foreach (DataRow gymRow in adminGymsTable.Rows)
            {
                String currentAdminGymID = gymRow[0].ToString();
                String currentAdminGymName = gymRow[1].ToString();
                String currentAdminGymLocation = gymRow[2].ToString();
                String currentAdminGymPhone = gymRow[3].ToString();
                String getAdminGymInfoQuery = "SELECT * FROM GYMS WHERE GYM_ID = " + currentAdminGymID + " AND GYM_NAME = '" + currentAdminGymName + "';";
                MySqlCommand getAdminGymInfoCreater = new MySqlCommand(getAdminGymInfoQuery, connection);
                connection.Open();
                MySqlDataReader getAdminGymInfoReader = getAdminGymInfoCreater.ExecuteReader();
                getAdminGymInfoReader.Read();
                variables.adminGymID = getAdminGymInfoReader.GetString("GYM_ID");
                variables.adminGymName = getAdminGymInfoReader.GetString("GYM_NAME");
                variables.adminGymLocation = getAdminGymInfoReader.GetString("GYM_LOCATION");
                variables.adminGymPhone = getAdminGymInfoReader.GetString("GYM_PHONE");
                connection.Close();

                gymsList.Items.Add(variables.adminGymName);
                variables.listOfAdminGymIDs.Add(variables.adminGymID);
            }
        }



        private void addClassButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form addClassPage = new addClassForm(); //open add class page
            addClassPage.Show();
        }

        private void removeClassButton_Click(object sender, EventArgs e)
        {
            if (classesList.SelectedIndex == -1)
            {
                MessageBox.Show("Error! No class is selected, please select a class to remove.", "Error!", MessageBoxButtons.OK); //nothing is selected
            }

            else
            {
                //delete all linked to class ID query
                String removeAllFromClass = "DELETE FROM CLASS_ENROLL WHERE CLASS_ID = " + variables.adminSelectedClassID + ";";
                MySqlCommand removeAllFromClassCreater = new MySqlCommand(removeAllFromClass, connection);
                connection.Open();
                MySqlDataReader removeAllFromClassReader = removeAllFromClassCreater.ExecuteReader();
                removeAllFromClassReader.Read();
                connection.Close();

                String removeClassQuery = "DELETE FROM CLASSES WHERE CLASS_ID = " + variables.adminSelectedClassID + ";";
                MySqlCommand removeClassCreater = new MySqlCommand(removeClassQuery, connection);
                connection.Open();
                MySqlDataReader removeClassReader = removeClassCreater.ExecuteReader();
                removeClassReader.Read();
                connection.Close();

                MessageBox.Show(classesList.SelectedItem.ToString() + " has been successfully removed!", "Success!", MessageBoxButtons.OK); //success message

                this.Close();
                Form openAdminForm = new adminForm(); //restart UI
                openAdminForm.Show();

            }
        }

        private void addInstructorButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form addInstructorPage = new addInstructorForm(); //open add instructor page
            addInstructorPage.Show();
        }

        private void removeInstructorButton_Click(object sender, EventArgs e)
        {
            if (instructorsList.SelectedIndex == -1)
            {
                MessageBox.Show("Error! No instructor is selected, please select an instructor to remove.", "Error!", MessageBoxButtons.OK); //nothing is selected
            }

            else
            {
                DialogResult warningDialog = MessageBox.Show("Dropping instructor will drop any classes or class enrollments that instructor teaches.\n\nContinue?", "Warning!", MessageBoxButtons.YesNo);
                //display warning
                if (warningDialog == DialogResult.Yes)
                {
                    //delete all linked to instructor ID queries
                    String removeAllFromInstructorClass = "DELETE FROM CLASS_ENROLL WHERE INSTRUCTOR_ID = " + variables.adminSelectedInstructorID + ";";
                    MySqlCommand removeAllFromInstructorClassCreater = new MySqlCommand(removeAllFromInstructorClass, connection);
                    connection.Open();
                    MySqlDataReader removeAllFromInstructorClassReader = removeAllFromInstructorClassCreater.ExecuteReader();
                    removeAllFromInstructorClassReader.Read();
                    connection.Close();

                    String removeFromInstructorClass = "DELETE FROM CLASSES WHERE INSTRUCTOR_ID = " + variables.adminSelectedInstructorID + ";";
                    MySqlCommand removeFromInstructorClassCreater = new MySqlCommand(removeFromInstructorClass, connection);
                    connection.Open();
                    MySqlDataReader removeFromInstructorClassReader = removeFromInstructorClassCreater.ExecuteReader();
                    removeFromInstructorClassReader.Read();
                    connection.Close();

                    String removeInstructorQuery = "DELETE FROM INSTRUCTORS WHERE INSTRUCTOR_ID = " + variables.adminSelectedInstructorID + ";";
                    MySqlCommand removeInstructorCreater = new MySqlCommand(removeInstructorQuery, connection);
                    connection.Open();
                    MySqlDataReader removeInstructorReader = removeInstructorCreater.ExecuteReader();
                    removeInstructorReader.Read();
                    connection.Close();

                    MessageBox.Show(instructorsList.SelectedItem.ToString() + " has been successfully removed!", "Success!", MessageBoxButtons.OK);

                    this.Close();
                    Form openAdminForm = new adminForm(); //restart UI
                    openAdminForm.Show();
                }
                else if (warningDialog == DialogResult.No)
                {
                    //do nothing
                }

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form restartAdminPage = new adminForm(); //clear filter UI restart
            restartAdminPage.Show();
        }

        private void addVendorButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form addVendorPage = new addVendorForm(); //open add vendor page
            addVendorPage.Show();
        }

        private void removeVendorButton_Click(object sender, EventArgs e)
        {
            if (vendorsList.SelectedIndex == -1)
            {
                MessageBox.Show("Error! No vendor is selected, please select a vendor to remove.", "Error!", MessageBoxButtons.OK);
            }

            else
            {
                String removeAllFromVendor = "DELETE FROM VENDOR_SUPPLY WHERE VENDOR_ID = " + variables.adminSelectedVendorID + ";";
                MySqlCommand removeAllFromVendorCreater = new MySqlCommand(removeAllFromVendor, connection);
                connection.Open();
                MySqlDataReader removeAllFromVendorReader = removeAllFromVendorCreater.ExecuteReader();
                removeAllFromVendorReader.Read();
                connection.Close();

                String removeVendorQuery = "DELETE FROM VENDORS WHERE VENDOR_ID = " + variables.adminSelectedVendorID + ";";
                MySqlCommand removeVendorCreater = new MySqlCommand(removeVendorQuery, connection);
                connection.Open();
                MySqlDataReader removeVendorReader = removeVendorCreater.ExecuteReader();
                removeVendorReader.Read();
                connection.Close();

                MessageBox.Show(vendorsList.SelectedItem.ToString() + " has been successfully removed!", "Success!", MessageBoxButtons.OK);

                this.Close();
                Form openAdminForm = new adminForm(); //restart UI
                openAdminForm.Show();

            }
        }

        private void addGymButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form addGymPage = new addGymForm(); //open add gym page
            addGymPage.Show();
        }

        private void removeGymButton_Click(object sender, EventArgs e)
        {
            if (gymsList.SelectedIndex == -1)
            {
                MessageBox.Show("Error! No gym is selected, please select a gym to remove.", "Error!", MessageBoxButtons.OK); //nothing is selected
            }

            else
            {
                DialogResult warningDialog = MessageBox.Show("Dropping gym will drop EVERYTHING linked to that specific gym.\n\nContinue?", "Warning!", MessageBoxButtons.YesNo);
                //display warning
                if (warningDialog == DialogResult.Yes)
                {
                    //remove everything linked to gym
                    String removeAllFromGymClass = "DELETE FROM CLASS_ENROLL WHERE CLASS_ID = (SELECT CLASS_ID FROM CLASSES WHERE GYM_ID = " + variables.adminSelectedGymID + ");";
                    MySqlCommand removeAllFromGymClassCreater = new MySqlCommand(removeAllFromGymClass, connection);
                    connection.Open();
                    MySqlDataReader removeAllFromGymClassReader = removeAllFromGymClassCreater.ExecuteReader();
                    removeAllFromGymClassReader.Read();
                    connection.Close();

                    String removeAllFromGymInstructor = "DELETE FROM CLASS_ENROLL WHERE INSTRUCTOR_ID = (SELECT INSTRUCTOR_ID FROM INSTRUCTORS WHERE GYM_ID = " + variables.adminSelectedGymID + ");";
                    MySqlCommand removeAllFromGymInstructorCreater = new MySqlCommand(removeAllFromGymInstructor, connection);
                    connection.Open();
                    MySqlDataReader removeAllFromGymInstructorReader = removeAllFromGymInstructorCreater.ExecuteReader();
                    removeAllFromGymInstructorReader.Read();
                    connection.Close();

                    String removeFromGymClasses = "DELETE FROM CLASSES WHERE GYM_ID = " + variables.adminSelectedGymID + ";";
                    MySqlCommand removeFromGymClassesCreater = new MySqlCommand(removeFromGymClasses, connection);
                    connection.Open();
                    MySqlDataReader removeFromGymClassesReader = removeFromGymClassesCreater.ExecuteReader();
                    removeFromGymClassesReader.Read();
                    connection.Close();

                    String removeAllFromInstructorGymClass = "DELETE FROM CLASSES WHERE INSTRUCTOR_ID = (SELECT INSTRUCTOR_ID FROM INSTRUCTORS WHERE GYM_ID = " + variables.adminSelectedGymID + ");";
                    MySqlCommand removeAllFromInstructorGymClassCreater = new MySqlCommand(removeAllFromInstructorGymClass, connection);
                    connection.Open();
                    MySqlDataReader removeAllFromInstructorGymClassReader = removeAllFromInstructorGymClassCreater.ExecuteReader();
                    removeAllFromInstructorGymClassReader.Read();
                    connection.Close();

                    String removeAllFromInstructorGym = "DELETE FROM INSTRUCTORS WHERE GYM_ID = " + variables.adminSelectedGymID + ";";
                    MySqlCommand removeAllFromInstructorGymCreater = new MySqlCommand(removeAllFromInstructorGym, connection);
                    connection.Open();
                    MySqlDataReader removeAllFromInstructorGymReader = removeAllFromInstructorGymCreater.ExecuteReader();
                    removeAllFromInstructorGymReader.Read();
                    connection.Close();

                    String removeVendorSupplyGymQuery = "DELETE FROM VENDOR_SUPPLY WHERE GYM_ID = " + variables.adminSelectedGymID + ";";
                    MySqlCommand removeVendorSupplyGymCreater = new MySqlCommand(removeVendorSupplyGymQuery, connection);
                    connection.Open();
                    MySqlDataReader removeVendorSupplyGymReader = removeVendorSupplyGymCreater.ExecuteReader();
                    removeVendorSupplyGymReader.Read();
                    connection.Close();

                    String deleteGymQuery = "DELETE FROM GYMS WHERE GYM_ID = " + variables.adminSelectedGymID + ";";
                    MySqlCommand deleteGymCommand = new MySqlCommand(deleteGymQuery, connection);
                    connection.Open();
                    MySqlDataReader deleteGymReader = deleteGymCommand.ExecuteReader();
                    deleteGymReader.Read();
                    connection.Close();

                    MessageBox.Show(gymsList.SelectedItem.ToString() + " has been successfully removed!", "Success!", MessageBoxButtons.OK);

                    this.Close();
                    Form openAdminForm = new adminForm(); //restart UI
                    openAdminForm.Show();
                }
                else if (warningDialog == DialogResult.No)
                {
                    //do nothing
                };

            }
        }

        
    }
}
