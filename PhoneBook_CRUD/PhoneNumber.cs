using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_CRUD
{
    internal class PhoneNumber
    {

        private int number = 1234567890;

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
    }
}
