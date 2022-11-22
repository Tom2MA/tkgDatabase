using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tkgDatabase
{
    public static class connector
    {
        public static MySqlConnection connection;
        private static MySqlCommand cmd = null;

        public static void establishConnection()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.UserID = "root";
                builder.Password = "password";
                builder.Database = "tkgDatabase";
                builder.SslMode = MySqlSslMode.Disabled;
                connection = new MySqlConnection(builder.ToString());
                MessageBox.Show("Connected", "Connected", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed", "Failed", MessageBoxButtons.OK);
            }
        }

    }
}
