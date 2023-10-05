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
        public TileTask()
        {
            InitializeComponent();
        }
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
        public void setStatus(string status)
        {
            comboStatus.SelectedText = status;
        }
        public void setPriority(string priority)
        {
            comboPriority.SelectedItem = priority;
        }
    }
}
