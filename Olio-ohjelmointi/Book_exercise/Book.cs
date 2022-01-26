using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Book_exercise
{
    class Book
    {
        public string title;
        public string author;
        public string id;
        public int price;

        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.id = string.Empty;
            this.price = 0;
        }

        public Book(string title, string author, string id, int price)
        {
            this.title = title;
            this.author = author;
            SetId(id);
            this.price = 0;
        }

        public void SetId(string idValue)
        {
            if (idValue.Length == 5)
            {
                this.id = idValue;
            }
            
        }



        public String GetName()
        {
            return this.title + " " + this.author + " " + this.id + " " + this.price;
        }

        public void CompareBook(Book book)
        {
            Console.WriteLine("kutsuvan olion title: " + this.title + ", " +
                "parametrina välitettävän olion title: " + book.title);
            if (this.price > book.price)
            {
                Console.WriteLine(this.title + " on kalliimpi kuin " + book.title);
            }

            else if (this.price < book.price)
            {
                Console.WriteLine(book.price + " on kalliimpi kuin " + this.title);
            }
            else if (this.price == book.price)
            {
                Console.WriteLine("hinnat yhtäsuuret");
            }

        }
    }
}
