using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_CRUD
{
    internal class PhoneNumber
    {
        private string number = "0123456789";
        public string Number 
        {
            get { return number; }
            set { number = value; }
        }
    }
}
