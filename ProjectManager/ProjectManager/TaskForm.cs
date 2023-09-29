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
        internal Point lastPoint;
        public TaskForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTask_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelTask_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

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
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = textStatus.Text;
            command.Parameters.Add("@deadline", MySqlDbType.Int32).Value = Int32.Parse(textDeadline.Text);
            command.Parameters.Add("@priority", MySqlDbType.VarChar).Value = textPriority.Text;
            command.Parameters.Add("@responsible", MySqlDbType.VarChar).Value = textResponsible.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Добавлен");

            db.closeConnection();

            this.Close();
        }

        private void textDeadline_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
