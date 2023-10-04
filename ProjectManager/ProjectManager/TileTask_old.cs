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
    public partial class TileTask_old : UserControl
    {
        public TileTask_old()
        {
            InitializeComponent();
        }
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
        public void setID(int id)
        {
            labelID.Text = "Задача " + id.ToString();
        }
        public void setName(string name)
        {
            labelName.Text = name;
        }
        public void setDiscription(string discription)
        {
            labelDiscription.Text = discription;
        }
        public void setDeadline(int deadline)
        {
            labelDeadline.Text = $"Труднозатраты {deadline.ToString()} дн.";
        }
        public void setResponcible(string name)
        {
            labelResponsible.Text = name;
        }
        public void setStatus(string status)
        {
            listStatus.Items.Add(Status.TODO);
            listStatus.Items.Add(Status.InWork);
            listStatus.Items.Add(Status.Review);
            listStatus.Items.Add(Status.Closed);

            listStatus.SelectedItem = status;
        }
        public void setPriority(string priority)
        {
            listPriority.Items.Add(Priority.Low);
            listPriority.Items.Add(Priority.Mid);
            listPriority.Items.Add(Priority.High);
            listPriority.Items.Add(Priority.Critical);

            listPriority.SelectedItem = priority;
        }

    }
}
