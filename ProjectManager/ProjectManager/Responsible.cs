using MySql.Data.MySqlClient;
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

        #region Конструкторы
        /// <summary>
        /// По умолчанию.
        /// </summary>
        public Responsible() { }

        /// <summary>
        /// Создать экземпляр со свойством name.
        /// </summary>
        /// <param name="name"></param>
        public Responsible(string name) 
        {
            this.Name = name;
        }

        /// <summary>
        /// Создать экземпляр со свойствами Id и name.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Responsible(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Создать экземпляр со свойствами Id, name и contact.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="contact"></param>
        public Responsible(int id, string name, string contact)
        {
            this.Id = id;
            this.Name = name;
            this.Contact = contact;
        }
        #endregion
    }
}
