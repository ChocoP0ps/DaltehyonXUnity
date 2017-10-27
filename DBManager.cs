using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaltehyonXUnity
{
    class DBManager
    {
        private static DBManager instance;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public static DBManager getInstance()
        {
            if(instance == null)
            {
                return instance = new DBManager();
            }
            else
            {
                return instance;
            }
        }

        //Constructor
        public DBManager()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "daltehyon";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return this.connection;
        }
    }
}
