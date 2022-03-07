using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Literature
{
    class Book2
    {
        private string name;
        public string author;
        private string publisher;
        private int price;
        private string isbn;
        public static string theme;
        private const int MaxLength = 13;


        public Book2()
        {
            this.Name = string.Empty;
            author = "Kirsi kirjailija";
            this.Publisher = string.Empty;
            this.Price = 0;
            this.Isbn = string.Empty;
           
        }

        public Book2(string author)
        {
            this.author = author;
        }

        public string Name
        {
            get {return name; }
            set {name = value.ToLower(); }
        }

        public string Author 
        { 
            get { return author;  }
        }

        public string Publisher { get => publisher; set => publisher = value; }
        public int Price 
        {
            get { return this.price; }
            set
            {
                this.price = value;
                if (this.price > 30)
                {
                    double vähennys = this.price * 0.9;
                    Console.WriteLine($"Uusi hinta on: {vähennys}");
                    this.price = (int)vähennys;
                }
            } 
        }

        public string Isbn
        {
            get { return isbn; }
            set 
            {
                Console.WriteLine(value);
                if (value.Length > MaxLength)
                {
                    Console.WriteLine("ISBN tunnus on liian pitkä");
                }
                else
                {
                    isbn = value;
                }
            }
        }

        public void Changetheme(string teema)
        {
            theme = teema;
        }

        public void Getbookdetails(string isbn)
        {
            if (isbn.Length == 13)
            {
                Console.WriteLine($"Kirjailijan nimi: {this.name}, Julkaisija: {this.author}, Kustantaja: {this.author}, Hinta: {this.price}");
            }
            else
            {
                Console.WriteLine("Kirjan tietoja ei voida tulostaa väärä isbn");
            }
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Author}";
        }
    }
}
