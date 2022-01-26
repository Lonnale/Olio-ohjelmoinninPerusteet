using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Company_Exercise
{
    class Company
    {
        public string title;
        public string address;
        public int phone;
        public int outcome;
        public int expense;

        // empty constructor
        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = 0;
            this.outcome = 0;
            this.expense = 0;
        }

        public Company(string title, string address, int phone, int outcome, int expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }

        // Copy constructor
        public Company(Company company)
        {
            this.address = company.address;
            this.title = company.title;
            this.phone = company.phone;
            this.outcome = company.outcome;
            this.expense = company.expense;
        }
        public void Printinfo()
        {
            Console.WriteLine($"Yrityksen nimi: {this.title}, yrityksen osoite: {this.address}, yrityksen puhelin: {this.phone}, yrityksen tulot: {this.outcome}, yrityksen menot:{this.expense}");
        }

        public void CalculateProfit()
        {

            double profit =(double) (this.outcome - this.expense) / this.expense * 100;
             Console.WriteLine($"Firman voitto: {profit}");
            if (profit < this.expense)
            {
                Console.WriteLine("Firmalla menee kehnosti");
            }
            else if (profit > this.expense)
            {
                Console.WriteLine("Firmalla menee välttävästi");
            }
            else if (profit > this.expense)
            {
                Console.WriteLine("Firmalla menee tyydyttävästi");
            }
            else if (profit > this.expense)
            {
                Console.WriteLine("Firmalla menee hyvin");
            }
        }
    }
}
