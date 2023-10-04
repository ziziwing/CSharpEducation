using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class TileTaks : UserControl
    {
        public TileTaks()
        {
            InitializeComponent();
        }
        #region enum
        private enum Status
        {
            TODO,
            InWork,
            Review,
            Closed
        }
        private enum Priority
        {
            High,
            Low,
            Mid,
            Critical
        }
        #endregion
        #region Make Tile for tasks
        public void setID(int id)
        {
            labelId.Text = "Задача " + id.ToString();
        }
        public void setName(string name)
        {
            textName.Text = name;
        }
        public void setDiscription(string discription)
        {
            textDiscription.Text = discription;
        }
        public void setDeadline(int deadline)
        {
            textDeadline.Text = deadline.ToString();
        }
        public void setResponcible(string name)
        {
            DataBase db = new DataBase();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `responsible`", db.getConnection());

            MySqlDataReader data;
            data = command.ExecuteReader();

            while (data.Read())
            {
                boxResponcible.Items.Add(data.GetValue(1));
            }
            
            db.closeConnection();

            boxResponcible.Items.Contains(name);
        }
        public void setStatus(string status)
        {
            boxStatus.Items.Add(Status.TODO);
            boxStatus.Items.Add(Status.InWork);
            boxStatus.Items.Add(Status.Review);
            boxStatus.Items.Add(Status.Closed);

            boxStatus.Items.Contains(status);
        }
        public void setPriority(string priority)
        {
            boxPriority.Items.Add(Priority.Low);
            boxPriority.Items.Add(Priority.Mid);
            boxPriority.Items.Add(Priority.High);
            boxPriority.Items.Add(Priority.Critical);

            boxPriority.Items.Contains(priority);
        }
        #endregion
    }
}
