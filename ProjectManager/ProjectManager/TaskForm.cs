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
using ProjectManager;

namespace ProjectManager
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
            FillResponsible();
        }

        #region События формы.

        #region Перетаскивание таски мышью.

        /// <summary>
        /// Точка отсчета для координат.
        /// </summary>
        internal Point lastPoint;

        /// <summary>
        /// Событие: движение мышью.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTask_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        /// <summary>
        /// Событие: кнопка мыши отпущена.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTask_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        /// <summary>
        /// Событие: закрыть форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Событие: нажатие кнопки Сохранить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            Task task = new Task();

            task.Name = textName.Text;
            task.Description = textDescription.Text;
            task.Status = boxStatus.SelectedItem.ToString();
            task.Deadline = Int32.Parse(textDeadline.Text);
            task.Priority = boxPriority.Text;
            task.Responsible = boxResponsible.Text;
            var lastListTask = ListTask.AllTask.LastOrDefault();
            task.Id = lastListTask.Id + 1;

            ListTask.AllTask.Add(task);

            this.Close();

            db.SaveTask(!this.labelTask.Text.Equals(task.Id.ToString()), task);
        }
        /// <summary>
        /// Событие: в поле Трудозатраты можно ввести только цифры, либо backspace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textDeadline_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Служебные методы

        /// <summary>
        /// Открыть форму задачи из плитки.
        /// </summary>
        /// <param name="taskID"></param>
        internal void ViewTaskInfoByTile(int taskID)
        {
            var task = ListTask.AllTask.Where(t => t.Id == taskID).FirstOrDefault();

            TaskForm taskForm = new TaskForm();

            taskForm.labelTask.Text = task.Id.ToString();
            taskForm.textName.Text = task.Name;
            taskForm.textDescription.Text = task.Description;
            taskForm.textDeadline.Text = task.Deadline.ToString();
            var indexStatus = taskForm.boxStatus.FindString(task.Status);
            taskForm.boxStatus.SelectedIndex = indexStatus;
            var indexPriority = taskForm.boxPriority.FindString(task.Priority);
            taskForm.boxPriority.SelectedIndex = indexPriority;
            var indexResponsible = taskForm.boxResponsible.FindString(task.Responsible);
            taskForm.boxResponsible.SelectedIndex = indexResponsible;

            taskForm.Show();
        }

        /// <summary>
        /// Добавить ответственных для выбора.
        /// </summary>
        private void FillResponsible()
        {
            DataBase db = new DataBase();
            
            db.openConnection();

            var data = db.GetAllResponsible();

            while(data.Read())
            {
                boxResponsible.Items.Add(data.GetString("name"));
            }

            db.closeConnection();
        }

        #endregion

    }
}
