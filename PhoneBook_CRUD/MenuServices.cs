using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_CRUD
{
    internal class MenuServices
    {
        public void phoneNew() 
        {
            Console.Clear();
            Console.Write("Введите имя абонента");
            string name = Console.ReadLine();
            Console.Write("Введите номер абонента");
            string number = Console.ReadLine();

            PhoneBook entry = new PhoneBook(name, number);

        }
        public void phoneDelete()
        {

        }
        public void phoneView()
        {

        }

    }
}
