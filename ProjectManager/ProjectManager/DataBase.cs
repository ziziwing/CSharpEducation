using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    internal class DataBase
    {
        MySqlConnection connection = new MySqlConnection(
            "server=sql11.freemysqlhosting.net;" +
            "port=3306;" +
            "username=sql11649513;" +
            "password=tGeVZXBrfG;" +
            "database=sql11649513;"
            );

        public void openConnection()
        {
            if( connection.State == System.Data.ConnectionState.Closed ) 
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        /*public MySqlDataReader GetAllResponsible()
         {
             DataBase db = new DataBase();
             db.openConnection();

             MySqlCommand command = new MySqlCommand("SELECT * FROM `responsible`", db.getConnection());

             var data = command.ExecuteReader();

             return data;
         }
         public MySqlDataReader GetAllTasks()
         {
             DataBase db = new DataBase();

             db.openConnection();

             MySqlCommand command = new MySqlCommand("SELECT * FROM `taskDB`", db.getConnection());

             db.closeConnection();

             return command.ExecuteReader();
         }*/
    }
}
