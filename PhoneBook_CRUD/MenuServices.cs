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
           
            var name = Console.ReadLine();
            if (name == null || name.Length == 0)
            {
                name = name = "Безымянный";
            }
            
            Console.Write("Введите номер абонента");
            var number = Console.ReadLine();
            if (number == null || number.Length == 0)
            {
                number = "0123456789";
            }

            PhoneBook entry = new PhoneBook(name, number);
            entry.WriteNew(entry);

        }
        public void phoneDelete()
        {

        }
        public void phoneView()
        {

        }

    }
}
