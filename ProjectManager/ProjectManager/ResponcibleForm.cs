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
    public partial class ResponcibleForm : Form
    {
        internal Point lastPoint;
        public ResponcibleForm()
        {
            InitializeComponent();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panelTask_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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

            MySqlCommand command = new MySqlCommand("INSERT INTO `responsible` (name, contact) VALUES (@name, @contact)", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textResponcible.Text;
            command.Parameters.Add("@contact", MySqlDbType.VarChar).Value = textContact.Text;

            db.openConnection();

            if (isNewResponcible())
            {
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Добавлен");
                db.closeConnection();

                this.Close();
            }
            

            
        }
        public Boolean isNewResponcible()
        {
            bool checkInfo = false;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `responsible` WHERE `name` = @name", db.getConnection());
            
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textResponcible.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Такой ответственный существует");
            else
                checkInfo = true;

            return checkInfo;
        }
    }
}
