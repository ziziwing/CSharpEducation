using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProjectManager
{
    internal class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Deadline { get; set; }
        public string Responsible { get; set; }
        public string Status { get; set; } 
        public string Priority { get; set; }
    }
}
