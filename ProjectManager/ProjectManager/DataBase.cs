using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public MySqlDataReader GetTaskById(int id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `taskDB` WHERE id = @id", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            return command.ExecuteReader();
        }

        /// <summary>
        /// Получить информацию о задаче по Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void TaksById(int id)
        {
            connection.Open();

            var tasks = GetTaskById(id);
            
            while (tasks.Read())
            {
                if (id == (int)tasks.GetValue(0))
                {
                    Task.Id = id;
                    Task.Name = tasks.GetValue(1).ToString();
                    Task.Status = tasks.GetValue(2).ToString();
                    Task.Priority = tasks.GetValue(3).ToString();
                    Task.Responsible = tasks.GetValue(4).ToString();
                    Task.Deadline = (int)tasks.GetValue(5);
                    Task.Description = tasks.GetValue(6).ToString();
                }       
            }
            connection.Close();
        }

        public void SaveTask(bool needNew)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string request;
            if (needNew)
            {
                request = "INSERT INTO `taskDB` (name, status, deadline, priority, responsible, description) " +
                "VALUES (@name, @status, @deadline, @priority, @responsible, @description)";
            }
            else
            {
                request = $"UPDATE `taskDB` SET `name` = @name, `status` = @status, `priority` = @priority," +
                    $" `responsible` = @responsible, `description` = @description WHERE `taskDB`.`id` = @id";
            }
            MySqlCommand command = new MySqlCommand(request, getConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Task.Id;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Task.Name;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = Task.Description;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = Task.Status;
            command.Parameters.Add("@deadline", MySqlDbType.Int32).Value = Task.Deadline;
            command.Parameters.Add("@priority", MySqlDbType.VarChar).Value = Task.Priority;
            command.Parameters.Add("@responsible", MySqlDbType.VarChar).Value = Task.Responsible;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
