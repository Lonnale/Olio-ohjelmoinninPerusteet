using Olio_ohjelmointi.Book_exercise;
using System;
using Olio_ohjelmointi.Company_Exercise;
using Olio_ohjelmointi.Car_exercise;


namespace Olio_ohjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Switch case rakenne
            Book_exercise();
            Company_Exercise();
            Car_exercise();
            Book2_exercise();
        }

        static void Book2_exercise()
        {
          
        }

        static void Car_exercise()
        {
            Console.WriteLine("\n\nCar Exercise");
            Car auto1 = new Car();
            auto1.brand = "Mersu";
            auto1.speed = 280;
            auto1.AskData();
            auto1.ShowCarInfo();
            auto1.Brake();
           
            Car auto2 = new Car("Audi", 270);
            auto2.AskData();
            auto2.ShowCarInfo();
            auto2.Brake();

        }

        static void Company_Exercise()
         {
            Console.WriteLine("Company Exercise");
            Console.WriteLine("\n\nKalveosGym");
            Company yritys1 = new Company();
            yritys1.title = "KalevosGym";
            yritys1.address = "Punttikatu 1, 00100";
            yritys1.phone = 0406352852;
            yritys1.outcome = 15000;
            yritys1.expense = 4700;
            yritys1.Printinfo();
            yritys1.CalculateProfit();

            Console.WriteLine("\n\nVapenPunttis");
            Company yritys2 = new Company("VapenPunttis", "siimakuja 2, 00140", 0407653425, 10000, 2500);
            yritys2.Printinfo();
            yritys2.CalculateProfit();
            Console.WriteLine("\n\nCopyConstructor");
            // create object using copy constructor
            Company kopioyritys = new Company(yritys2);
            kopioyritys.Printinfo();
            kopioyritys.CalculateProfit();

        }

        static void Book_exercise()
        {
            Console.WriteLine("Book exercise");
            {
                Book my1book = new Book();

                my1book.title = "Aapinen";
                my1book.author = "aulikki aurinko";
               my1book.SetId("12345");
                my1book.price = 20;

            Console.WriteLine("Aapinen tiedot: " + my1book.GetName());
                Book my2book = new Book("ABC", "kalevi kuu", "12346", 15);
                Console.WriteLine("ABC tiedot: " + my2book.GetName());


                my1book.CompareBook(my2book);
            }

           




        }
    }
}
