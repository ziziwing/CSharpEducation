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
        internal void ViewTasks()
        {
            flowPanel.Controls.Clear();

            DataBase db = new DataBase();
            db.openConnection();   

            var data = db.GetAllTasks();

            while (data.Read())
            {
                TileTask tileTask = new TileTask()
                {
                    Tag = data.GetValue(0).ToString(),
                    Name = data.GetValue(1).ToString(),
                    Parent = flowPanel
                };
                
                tileTask.setId(data.GetString("id"));
                tileTask.setName(data.GetString("name"));
                tileTask.setStatus(data.GetString("status"));
                tileTask.setPriority(data.GetString("priority"));
                tileTask.setResponcible(data.GetString("responsible"));
            }
            db.closeConnection();
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
            TaskForm openForm = new TaskForm();
            openForm.Show();
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
    }
}
