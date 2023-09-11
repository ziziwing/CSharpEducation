using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_CRUD
{
    internal class Menu
    {
        public void GetMenu()
        {
            while (true)
            {

                Console.WriteLine("1.Создать запись\n2.Удалить запись\n3.Вывести на экран все записи телефонной книги\n4.Выход");
                Console.Write("Ведите команду: ");

                string readKey = Console.ReadLine();

                MenuServices menu = new MenuServices();

                switch (readKey)
                {
                    case "1":
                        menu.phoneNew();
                        break;
                    case "2":
                        menu.phoneDelete();
                        break;
                    case "3":
                        menu.phoneView();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Не верная команда. Попробуйте еще раз.\n");
                        break;
                }
            }
        }
    }
}
