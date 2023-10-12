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
        static public int Id { get; set; }
        static public string Name { get; set; }
        static public string Description { get; set; }
        static public int Deadline { get; set; }
        static public string Responsible { get; set; }
        static public string Status { get; set; } 
        static public string Priority { get; set; }
    }
}
