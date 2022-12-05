using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tkgDatabase
{
    class variables
    {
        //member
        public static String username, password;
        public static String accountID, highestAccountNumID, classSelectedID, classID, classGymID, highestClassNumID;
        public static int newHighestAccountNumID, newHighestClassNumID;
        public static DataTable getMemClassesTable;
        public static MySqlDataAdapter getMemClassIDAdapter;

        public static List<String> listOfMemClassIDs, listOfAvailClassIDs, listOfAvailInstructorIDs, listOfClasses, listOfAvailClassGyms;

        public static String availClassName, availClassID, availInstructorID, availClassGymID, availClassGymName, availClassGymLocation;

        //admin lists
        public static List<String> listOfAdminMemberIDs, listOfAdminMemberAccountIDs, listOfAdminClassIDs, listOfAdminInstructorIDs, listOfAdminVendorIDs, listOfAccountUsers;
        public static String adminClassID, adminClassName;
        public static String adminMemID, adminMemFName, adminMemLName, adminMemAccountID;
        public static String adminInstructorID, adminInstructorFName, adminInstructorLName;
        public static String adminVendorID, adminVendorName, adminVendorLocation, adminVendorPhone;
        //admin global variable
        public static String adminSelectedMemberID, adminSelectedMemberAccountID, adminSelectedClassID, adminSelectedInstructorID, adminSelectedVendorID;

        public static String membershipType = "Standard";

        public static List<String> listOfAddClassGymIDs, listOfAddClassInstructors, listOfAddClassInstructorGymIDs, listOfAdminGymIDs;
        public static String addClassGymID, addClassGymName, addClassGymLocation, getHighestClassNumber;
        public static String addClassInstructorID, addClassInstructorFName, addClassInstructorLName, addClassInstructorGymID;

        public static String getHighestInstructorID, highestInstructorID, getHighestVendorID, highestVendorNumID, getHighestGymID, highestGymNumID, adminSelectedGymID;
        public static String adminGymID, adminGymName, adminGymLocation, adminGymPhone;

        public static List<String> listOfVendorGymsFilter, listOfVendorSupplies, listOfVendorEquipment, listOfEquipment;
        public static String addVendorGymID, addVendorGymName, addVendorGymLocation, vendorEquipmentID;
    }
}
