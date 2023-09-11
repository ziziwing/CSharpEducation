using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_CRUD
{
    internal class Person
    {
        private string name = "Безымянный";
        public string Name
        { 
            get { return name; }
            set { name = value; } 
        }
    }
}
