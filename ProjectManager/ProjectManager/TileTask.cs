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
using static ProjectManager.Task;

namespace ProjectManager
{
    public partial class TileTask : UserControl
    {
       /// <summary>
       /// Инициализация объекта.
       /// </summary>
        public TileTask()
        {
            InitializeComponent();
            FillResponsible();
        }

        #region Инициализация полей формы.

        /// <summary>
        /// Устанавливает в плитку Id задачи.
        /// </summary>
        /// <param name="id"></param>
        public void setId(string id)
        {
            labelId.Text = id;
        }

        /// <summary>
        /// Устанавливает в плитку имя задачи .
        /// </summary>
        /// <param name="name"></param>
        public void setName(string name)
        {
            labelName.Text = name;
        }

        /// <summary>
        /// Выбирает и устанавливает из списка ответственного.
        /// </summary>
        /// <param name="name"></param>
        public void setResponcible(string name)
        {
            var index = comboResponsible.FindString(name);
            comboResponsible.SelectedIndex = index;
        }

        /// <summary>
        /// Выбирает и устанавливает статус из списка статусов.
        /// </summary>
        /// <param name="status"></param>
        public void setStatus(string status)
        {
            var index = comboStatus.FindString(status);
            comboStatus.SelectedIndex = index;
        }

        /// <summary>
        /// Выбирает и устанавливает приоритет из списка приоритетов.
        /// </summary>
        /// <param name="priority"></param>
        public void setPriority(string priority)
        {
            var index = comboPriority.FindString(priority);
            comboPriority.SelectedIndex = index;
        }

        /// <summary>
        /// Заполнить поле выбора ответственного значениями из СУБД.
        /// </summary>
        private void FillResponsible()
        {
            DataBase db = new DataBase();

            db.openConnection();

            var data = db.GetAllResponsible();

            while (data.Read())
            {
                comboResponsible.Items.Add(data.GetString("name"));
            }

            db.closeConnection();
        }

        #endregion

        #region Событие формы.

        private void tableTile_MouseClick(object sender, MouseEventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.ViewTaskInfoByTile((Convert.ToInt32(labelId.Text)));
        }

        private void tableTile_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.ViewTaskInfoByTile((Convert.ToInt32(labelId.Text)));
        }

        #endregion

    }
}
