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
            var readLine = Console.ReadLine();
            var name = string.IsNullOrEmpty(readLine) ? readLine : "Безымянный";
            
            Console.Write("Введите номер абонента");
            readLine = Console.ReadLine();
            var number = string.IsNullOrEmpty(readLine) ? readLine : "0123456789";

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
