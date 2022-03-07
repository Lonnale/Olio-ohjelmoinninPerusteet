using Olio_ohjelmointi.Book_exercise;
using System;
using Olio_ohjelmointi.Company_Exercise;
using Olio_ohjelmointi.Car_exercise;
using Olio_ohjelmointi.Author_Exercise;
using Olio_ohjelmointi.Literature;
using System.Collections.Generic;
using Olio_ohjelmointi.Rajapinta_Exercise;
using Olio_ohjelmointi.Shape_exercise;

namespace Olio_ohjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Switch case rakenne
            Book_exercise();
            Company_Exercise();
            Car_exercise();
            Book2_exercise();
            Author_Exercise();
            Rajapinta_Exercise();
            Shape_exercise();
        }

        static void Shape_exercise()
        {
         /*   List<Shapes> allShapes = new List<Shapes>
            {
                new Circle("red", 6),
                new Circle("blue", 2),
                new Triangle(2, 5, "green"),
                new Rectangle(2,6,"yellow")
            };
            foreach (Shapes s in allShapes)
            {
                Console.WriteLine($"A= {s.GetArea()}");
            }
         */
        }


        static void Rajapinta_Exercise()
        {
            Console.WriteLine("\n\n Rajapinta esimerkki");
            List<Product> productsList = new List<Product>();
            productsList.Add(new Product("Teltta", 124.99, 450));
            productsList.Add(new Product("Aurinkotuoli", 19.99, 300));
            productsList.Add(new Product("Uimapatja", 39.99, 200));

            foreach(Product currentProduct in productsList)
            {
                if (currentProduct.GetProduct("Uimapatja") != null)
                {
                    Console.WriteLine("Uimapatja löytyi");
                    Console.WriteLine($"Varaston arvo: {currentProduct.CalculateTotal()}");
                    Console.WriteLine("------------ ");
                }
                Console.WriteLine(currentProduct.ToString());
            }
            
            Console.WriteLine("--------------- ");
            Console.WriteLine("-----STORE----- ");
            Console.WriteLine("--------------- ");

            Store myStore = new Store("Retkeilykauppa");
            myStore.AddProduct(new Product("Teltta", 124.99, 450));
            myStore.AddProduct(new Product("Aurinkotuoli", 19.99, 300));
            myStore.AddProduct(new Product("Uimapatja", 39.99, 200));
            myStore.PrintProducts();
            myStore.AddCustomer(new Customer("Axo", 15));
            myStore.AddCustomer(new Customer("Riigis", 1000));
            myStore.AddCustomer(new Customer("Axo", 999));

            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer("Axo", 15));
            customerList.Add(new Customer("Riiigs", 1000));
            customerList.Add(new Customer("Kimomies", 999));

            foreach(Customer currentCustomer in customerList)
            {
                if (currentCustomer.GetCustomer("Axo") != null)
                {
                    Console.WriteLine("Asiakas Axo löytyi");
                    Console.WriteLine($"Bonus arvo: {currentCustomer.GetBonus()}");
                    Console.WriteLine("------------ ");
                }
                Console.WriteLine(currentCustomer.ToString());
            }
            
            
           

        }




        static void Author_Exercise() 
        {
            Console.WriteLine("\n\nAuthor - ominaisuudet");

            Book2 book1 = new Book2("Astrid Lindgren");
            book1.Name = "Peppi Pitkätossu";

            Author author1 = new Author("Astrid Lindgren", "01.01.1929", book1);

            Author author2 = new Author("Astrid Lindgren", "01.01.1929", null);
            author1.Printinfo();
            author2.Printinfo();

        }
        static void Book2_exercise()
        {
            Console.WriteLine("\n\nBook2 - ominaisuudet");
            Book2 book = new Book2 ();
             book.Name = "ABC";
             book.author = "Kirsi Kirjailija";
             book.Publisher = "Kalevi kustantaja";
             book.Price = 25;
             book.Isbn = "12345asdfgPPPas";
             book.Changetheme("lasten");
             Console.WriteLine($"Kirjan nimi on: {book.Name}");
             Console.WriteLine($"Kirjailijan nimi on: {book.Author}");
             Console.WriteLine($"Kustantajan nimi on: {book.Publisher}");
             Console.WriteLine($"Hinta on: {book.Price}");
             Console.WriteLine($"ISBN tunnus on: {book.Isbn}"); 
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
            auto1.Accelerate(20);
           
            Car auto2 = new Car("Audi", 270);
            auto2.AskData();
            auto2.ShowCarInfo();
            auto2.Brake();
            auto2.Accelerate(-10);

          

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
