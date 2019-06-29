using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_6_MySQL
{
    class Database
    {
        public static string ConnectionPath = "server=localhost;user=root";
        public static bool IsDatabaseOK = false;
        public static string ConnectedDatabase = "";
        public static int ExistingFilledRows = 0;

        public static event EventHandler<DatabaseChangedEventArgs> ConnectedDatabaseChanged;

        //rozsyłanie zdarzenia
        public static void OnConnectedDatabaseChanged(DatabaseChangedEventArgs e)
        {
            EventHandler<DatabaseChangedEventArgs> connectedDatabaseChanged = 
                ConnectedDatabaseChanged;
            if (connectedDatabaseChanged != null)
                connectedDatabaseChanged(null, e);
        }

    }
}
