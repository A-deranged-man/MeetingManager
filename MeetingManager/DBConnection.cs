using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CMP307_TayMark_App
{
    class DBConnection
    {
        private MySqlConnection connection = new MySqlConnection("datasource=www.example.com;port=3306;username=dbusername;password=dbpassword;database=databasename;");

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
