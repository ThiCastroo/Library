using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Models
{
    public class Book
    {
        private int id { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private Author author { get; set; }
        internal Category category { get; set; }
        private bool available { get; set; }

        public Book(int id)
        {
            this.id = id;
        }

        public Book() : this(0) { }

        public Book(int id, string name, string description, Author author, Category category, bool available)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.author = author;
            this.category = category;
            this.available = available;
        }
    }
}
