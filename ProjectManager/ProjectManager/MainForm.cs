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
        private void CreateTaskControl()
        {
            UserControl TilePanel = new UserControl();
            TilePanel.Controls.Add(TilePanel);
            TilePanel.CreateControl();

            TilePanel.Show();
        }
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
                TileTask tileTask= new TileTask()
                {
                    Name = data.GetValue(1).ToString(),
                    Tag = data.GetValue(1),
                    Parent = flowPanel
                };

                Task task = new Task();
                task.Id = (int)Convert.ToInt64(data.GetValue(0));
                task.Name = data.GetValue(1).ToString();
                task.Description = data.GetValue(2).ToString(); ;
                task.Deadline = (int)Convert.ToInt64(data.GetValue(4));
                task.Responsible = new Responsible(100, "Bad Boy", "ugly@bad.com");

                Name = task.Name;
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
