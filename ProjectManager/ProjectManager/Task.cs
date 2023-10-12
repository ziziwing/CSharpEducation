using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProjectManager
{
    internal static class Task
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Description { get; set; }
        public static int Deadline { get; set; }
        public static string Responsible { get; set; }
        public static string Status { get; set; } 
        public static string Priority { get; set; }
    }
}
