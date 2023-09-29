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
        private void ViewTasks()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `taskDB` ", db.getConnection());

            MySqlDataReader data;
            
            data = command.ExecuteReader();

            while (data.Read())
            {
                var item = listTasks.Items.Add(data[0].ToString());
                item.Name = data[1].ToString();
                item.SubItems.Add(data[2].ToString());
                item.SubItems.Add(data[3].ToString());
                item.SubItems.Add(data[4].ToString());
                item.SubItems.Add(data[5].ToString());
                item.SubItems.Add(data[6].ToString());
            }

            db.closeConnection();
        }

        public MainForm()
        {
            InitializeComponent();
            ViewTasks();
        }

        private void Newtask_Click(object sender, EventArgs e)
        {
            TaskForm openForm = new TaskForm();
            openForm.Show();
        }

        private void AddResponsible_Click(object sender, EventArgs e)
        {
            ResponcibleForm responcibleForm = new ResponcibleForm();
            responcibleForm.Show();
        }
    }
}
