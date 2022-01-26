using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olio_ohjelmointi.Book_exercise;

namespace Olio_ohjelmointi
{
     class Program
     {
        static void Main(string[] args)
        {
            Book_exercise();
        }

        static void Book_exercise()
        {
            Book myFirstBook = new Book();
            myFirstBook.title = "Aapinen";
            myFirstBook.author = "aulikki aurinko";
            myFirstBook.id = "12345";
            myFirstBook.price = "12.5";
            Console.WriteLine("Kirja 1 tiedot: " + myFirstBook.GetName());
            Book mySecondBook = new Book("")
            
        }


     }
}
