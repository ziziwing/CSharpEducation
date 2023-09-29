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
    public partial class TileTask : UserControl
    {
        public TileTask()
        {
            InitializeComponent();
        }

        public void setID(int id)
        {
            labelID.Text = "Задача " + id.ToString();
        }
        public void setName(string name)
        {
            labelName.Text = name.ToString();
        }
        public void setDiscription(string discription)
        {
            labelDiscription.Text = discription.ToString();
        }
        public void setDeadline(int deadline)
        {
            labelDeadline.Text = $"Труднозатраты {deadline.ToString()} дней";
        }
        
        public void setStatus(string status)
        {
            listStatus.Items.Clear();
        }

    }
}
