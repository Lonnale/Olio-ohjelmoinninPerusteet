 using Olio_ohjelmointi.Book_exercise;
using Olio_ohjelmointi.Literature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Author_Exercise
{
    class Author
    {
        public string name;
        public string birthday;
        public Book2 book;

        public Author()
        {
            this.name = string.Empty;
            this.birthday = string.Empty;
            this.Book = null;
        }

        public Author(string name, string birthday, Book2 book)
        {
            this.name = name;
            this.birthday = birthday;
            this.Book = book;
        }

        internal Book2 Book
        {
            get { return book; }
            set 
            {
                if (value != null && value.Author == this.name)
                {
                    book = value;
                }
               
            }
        }
        
        public void Printinfo()
        {
            Console.WriteLine($"Kirjailijan Nimi: {this.name}");
            Console.WriteLine($"Kirjailijan syntymäaika: {this.birthday}");
            if (this.book != null)
            {
                Console.WriteLine($"Kirjailijan kirjoittama kirja:{this.book.ToString()}");
            }

         

        }

    }
}
