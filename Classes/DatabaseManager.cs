using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace UNDAC_App.Classes
{
    internal class DatabaseManager
    {

        // Method to return a database connection
        public SQLiteConnection DBconn()
        {
            // Sotre the app system path
            var systempath = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the system path with the DB filename
            var fullpath = Path.Combine(systempath, "UNDAC.db");

            // Instantiate an SQLite connection passing the DB file path as param
            SQLiteConnection conn = new SQLiteConnection(fullpath);

            // Return the database connection
            return conn;
        }

    }
}
