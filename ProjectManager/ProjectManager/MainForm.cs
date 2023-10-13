using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class MainForm : Form
    {
        static List<Task> listTasks = new List<Task>();

        #region Создание формы

        /// <summary>
        /// Инициализирует основную форму.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ViewTasks();
        }

        /// <summary>
        /// Добавляет контрол на основную форму.
        /// </summary>
        private void CreateTaskControl()
        {
            UserControl TilePanel = new UserControl();
            TilePanel.Controls.Add(TilePanel);
            TilePanel.CreateControl();

            TilePanel.Show();
        }

        #endregion

        #region Служебные методы

        /// <summary>
        /// Показывает все созданные задачи на форме в виде плитки.
        /// </summary>
        public void ViewTasks()
        {
            DataBase db = new DataBase();

            db.openConnection();   

            var data = db.GetAllTasks();
            
            AddingToList(data);

            db.closeConnection();
        }

        public void RefreshTasks()
        {
            flowPanel.Controls.Clear();

            foreach (Task task in listTasks)
            {
                TileTask tileTask = new TileTask()
                {
                    Tag = task.Id,
                    Name = task.Name,
                    Parent = flowPanel
                };

                tileTask.setId(task.Id.ToString());
                tileTask.setName(task.Name);
                tileTask.setStatus(task.Status);
                tileTask.setPriority(task.Priority);
                tileTask.setResponcible(task.Responsible);
            }
        }

        /// <summary>
        /// Добавляем задачи в структуру для уменьшения обращений к БД.
        /// </summary>
        /// <param name="data"></param>
        private void AddingToList(MySqlDataReader data)
        {            
            while (data.Read())
            {
                Task task = new Task();

                task.Id = (int)data.GetValue(0);
                task.Name = data.GetString("name");
                task.Status = data.GetString("status");
                task.Deadline = (int)data.GetValue(5);
                task.Priority = data.GetString("priority");
                task.Responsible = data.GetString("responsible");
                task.Description = data.GetString("description");

                listTasks.Add(task);
            }
            data.Close();

            RefreshTasks();
        }

        #endregion

        #region Событие формы

        /// <summary>
        /// Событие: создание новой задачи.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Newtask_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.FormClosed += MainForm_Load;
            taskForm.Show();
        }
        /// <summary>
        /// Cобытие: создание нового ответственного.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddResponsible_Click(object sender, EventArgs e)
        {
            ResponcibleForm responcibleForm = new ResponcibleForm();
            responcibleForm.Show();
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.openConnection();

            var data = db.GetLastTask();

            AddingToList(data);

            db.closeConnection();

        }
    }
}
