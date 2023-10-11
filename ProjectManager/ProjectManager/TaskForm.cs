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
        /// Событие: зажатие кнопки мыши.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
        /// Событие: нажатие кнопки Сохранить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string request = "INSERT INTO `taskDB` (name, description, status, deadline, priority, responsible) " +
                "VALUES (@name, @description, @status, @deadline, @priority, @responsible)";

            MySqlCommand command = new MySqlCommand(request, db.getConnection());

            DateTime timeNow = DateTime.Now;

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textName.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = textDescription.Text;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = boxStatus.SelectedItem;
            command.Parameters.Add("@deadline", MySqlDbType.Int32).Value = Int32.Parse(textDeadline.Text);
            command.Parameters.Add("@priority", MySqlDbType.VarChar).Value = boxPriority.Text;
            command.Parameters.Add("@responsible", MySqlDbType.VarChar).Value = boxResponsible.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Добавлен");

            db.closeConnection();

            this.Close();
            
            MainForm mainForm = new MainForm();
            mainForm.ViewTasks();
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

        /// <summary>
        /// Открыть форму задачи из плитки.
        /// </summary>
        /// <param name="taskID"></param>
        internal void ViewTaskInfoByTile(int taskID)
        {
            DataBase db = new DataBase();
            var taskInfo = db.taksById(taskID);

            TaskForm taskForm = new TaskForm();
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
                boxResponsible.Items.Add(data.GetValue(1));
            }

            db.closeConnection();
        }
    }
}
