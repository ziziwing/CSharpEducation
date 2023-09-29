using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    internal class Responsible
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }

        public Responsible(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Responsible(int id, string name, string contact)
        {
            this.Id = id;
            this.Name = name;
            this.Contact = contact;
        }
    }
}
