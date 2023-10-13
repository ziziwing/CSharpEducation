using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProjectManager
{
    internal class DataBase
    {

        #region Установления соединения с БД.

        MySqlConnection connection = new MySqlConnection(
        "server=sql11.freemysqlhosting.net;" +
        "server=db4free.net;" +
        "port=3306;" +
        "username=sql11649513;" +
        "password=tGeVZXBrfG;" +
        "database=sql11649513;" +
        "charset=utf8mb4"
        //"server=151.115.53.213;" +
        //"port=3306;" +
        //"username=root;" +
        //"password=0XzcrrFJJM4YWcfR;" +
        //"database=sql11649513;" +
        //"charset=utf8mb4"
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
        /// <returns>Соединение с БД</returns>
        public MySqlConnection getConnection()
        {
            return connection;
        }

        #endregion

        #region Запросы к БД.

        /// <summary>
        /// Получить всех ответственных из СУБД.
        /// </summary>
        /// <returns>тип MySqlDataReader - запись об ответственных</returns>
        public MySqlDataReader GetAllResponsible()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `responsible`", connection);

            return command.ExecuteReader();
        }

        /// <summary>
        /// Получить все задачи из СУБД.
        /// </summary>
        /// <returns>тип MySqlDataReader - запись о задачах.</returns>
        public MySqlDataReader GetAllTasks()
         {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `taskDB`", connection);

            return command.ExecuteReader();
         }

        /// <summary>
        /// Запрос на получение задачи по нужному Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>тип MySqlDataReader - запись о задаче.</returns>
        public MySqlDataReader GetTaskById(int id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `taskDB` WHERE id = @id", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            return command.ExecuteReader();
        }

        /// <summary>
        /// Получить последнюю добавленную строку в БД.
        /// </summary>
        /// <returns>тип MySqlDataReader - запись о последней добавленной задаче.</returns>
        public MySqlDataReader GetLastTask()
        {            
            MySqlCommand command = new MySqlCommand("SELECT * FROM `taskDB` ORDER BY id DESC LIMIT 1", connection);

            return command.ExecuteReader();
        }

        #endregion

        #region Обработки запросов.

        /// <summary>
        /// Получить информацию о задаче по Id.
        /// </summary>
        /// <param name="id"></param>
        public Task TaksById(int id)
        {
            connection.Open();

            var tasks = GetTaskById(id);

            Task task = new Task();

            while (tasks.Read())
            {
                if (id == (int)tasks.GetValue(0))
                {
                    task.Id = id;
                    task.Name = tasks.GetValue(1).ToString();
                    task.Status = tasks.GetValue(2).ToString();
                    task.Priority = tasks.GetValue(3).ToString();
                    task.Responsible = tasks.GetValue(4).ToString();
                    task.Deadline = (int)tasks.GetValue(5);
                    task.Description = tasks.GetValue(6).ToString();
                }       
            }
            connection.Close();

            return task;
        }

        /// <summary>
        /// Сохранить задачу в БД.
        /// </summary>
        /// <param name="needNew"></param>
        public void SaveTask(bool needNew, Task task)
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

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = task.Id;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = task.Name;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = task.Description;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = task.Status;
            command.Parameters.Add("@deadline", MySqlDbType.Int32).Value = task.Deadline;
            command.Parameters.Add("@priority", MySqlDbType.VarChar).Value = task.Priority;
            command.Parameters.Add("@responsible", MySqlDbType.VarChar).Value = task.Responsible;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// Возращает последнюю задачу в БД.
        /// </summary>
        /// <param name="list"></param>
        /// <returns>тип Task - экземпляр класса с данными о задаче.</returns>
        public Task LastTask()
        {
            Task task = new Task();

            connection.Open();

            var data = GetLastTask();
           
            while (data.Read())
            {
                task.Id = (int)data.GetValue(0);
                task.Name = data.GetValue(1).ToString();
                task.Status = data.GetValue(2).ToString();
                task.Priority = data.GetValue(3).ToString();
                task.Responsible = data.GetValue(4).ToString();
                task.Deadline = (int)data.GetValue(5);
                task.Description = data.GetValue(6).ToString();
            }
            connection.Close();

            return task;
        }
    }
    #endregion
}
