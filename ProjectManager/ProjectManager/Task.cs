using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    internal class Task
    {
        public enum Status
        {
            TODO,
            InWork,
            Review,
            Closed
        }
        public enum Priority
        {
            High,
            Low,
            Mid,
            Critical
        }
            
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Deadline { get; set; }
        public Responsible Responsible { get; set; }
    }
}
