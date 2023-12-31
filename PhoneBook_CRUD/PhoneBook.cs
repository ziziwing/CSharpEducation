﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PhoneBook_CRUD
{
    internal class PhoneBook
    {
        private string personName;
        private string personNumber;

        public PhoneBook(string name, string number) 
        {
            this.personName = name;
            this.personNumber = number;
        }

        public void WriteNew(PhoneBook entry)
        {
            List<PhoneBook> phoneBooks = new List<PhoneBook>();
            phoneBooks.Add(entry);
            
            string json = JsonSerializer.Serialize(phoneBooks);
            File.WriteAllText(@"C:\phonebook.json", json);
        }
    }
}
