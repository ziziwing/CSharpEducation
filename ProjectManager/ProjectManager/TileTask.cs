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
        }
        #region Инициализация полей формы.
        /// <summary>
        /// Устанавливает в плитку Задачи имя.
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
           comboResponsible.SelectedValue = name;
        }
        /// <summary>
        /// Выбирает и устанавливает статус из списка статусов.
        /// </summary>
        /// <param name="status"></param>
        public void setStatus(string status)
        {
            comboStatus.SelectedText = status;
        }
        /// <summary>
        /// Выбирает и устанавливает приоритет из списка приоритетов.
        /// </summary>
        /// <param name="priority"></param>
        public void setPriority(string priority)
        {
            comboPriority.SelectedItem = priority;
        }
        #endregion

        #region Событие формы.
        private void tableTile_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.ViewTaskInfoByTile((int)Tag);
        }
        #endregion
    }
}
