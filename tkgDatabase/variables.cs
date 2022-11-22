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
        public static String username, password;
        public static String accountID, highestAccountNumID, classSelectedID, classID, classGymID;
        public static int newHighestAccountNumID;
        public static DataTable getMemClassesTable;
        public static MySqlDataAdapter getMemClassIDAdapter;

        public static List<String> listOfMemClassIDs, listOfAvailClassIDs, listOfClasses;

        public static String availClassName, availClassID;
    }
}
