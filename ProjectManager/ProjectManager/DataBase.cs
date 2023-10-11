using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectManager
{
    internal class DataBase
    {
        MySqlConnection connection = new MySqlConnection(
            //"server=sql11.freemysqlhosting.net;" +
            "server=db4free.net;" +
            "port=3306;" +
            "username=sql11649513;" +
            "password=tGeVZXBrfG;" +
            "database=sql11649513;" +
            "charset=utf8mb4"
        );

        /// <summary>
        /// Открыть соеденение с СУБД.
        /// </summary>
        public void openConnection()
        {
            if( connection.State == System.Data.ConnectionState.Closed ) 
                connection.Open();
        }

        /// <summary>
        /// Закрыть соеденение с СУБД.
        /// </summary>
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        
        /// <summary>
        /// Получить подключение.
        /// </summary>
        /// <returns></returns>
        public MySqlConnection getConnection()
        {
            return connection;
        }

        /// <summary>
        /// Получить всех ответственных из СУБД.
        /// </summary>
        /// <returns></returns>
        public MySqlDataReader GetAllResponsible()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `responsible`", connection);

            return command.ExecuteReader();
        }

        /// <summary>
        /// Получить все задачи из СУБД.
        /// </summary>
        /// <returns></returns>
         public MySqlDataReader GetAllTasks()
         {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `taskDB`", connection);

            return command.ExecuteReader();
         }

        /// <summary>
        /// Получить информацию о задаче по Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task taksById(int id)
        {
            Task taskInfo = new Task();
            
            var tasks = GetAllTasks();
            while (tasks.Read())
            {
                if (id == (int)tasks.GetValue(0))
                {
                    taskInfo.Id = id;
                    taskInfo.Name = tasks.GetValue(1).ToString();
                    taskInfo.Status = taskInfo.GetStatus(tasks.GetValue(2).ToString());
                    taskInfo.Priority = taskInfo.GetPriority(tasks.GetValue(3).ToString());
                    taskInfo.Responsible = new Responsible(tasks.GetValue(4).ToString());
                    taskInfo.Deadline = (int)tasks.GetValue(5);
                    taskInfo.Description = tasks.GetValue(6).ToString();
                }       
            }
            return taskInfo;
        }
    }
}
