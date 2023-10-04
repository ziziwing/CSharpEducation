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

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `taskDB` ", db.getConnection());

            MySqlDataReader data;
            
            data = command.ExecuteReader();

            while (data.Read())
            {
                TileTaks tileTask= new TileTaks()
                {
                    Name = data.GetValue(1).ToString(),
                    Tag = data.GetValue(1),
                    Parent = flowPanel
                };

                tileTask.setID((int)Convert.ToInt64(data.GetValue(0)));
                tileTask.setName(data.GetValue(1).ToString());
                tileTask.setDiscription(data.GetValue(2).ToString());
                tileTask.setDeadline((int)Convert.ToInt64(data.GetValue(4)));
                tileTask.setResponcible(data.GetValue(6).ToString());
                tileTask.setStatus(data.GetValue(3).ToString());
                tileTask.setPriority(data.GetValue(5).ToString()); 
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
            ViewTasks();
        }

        private void AddResponsible_Click(object sender, EventArgs e)
        {
            ResponcibleForm responcibleForm = new ResponcibleForm();
            responcibleForm.Show();
        }
    }
}
