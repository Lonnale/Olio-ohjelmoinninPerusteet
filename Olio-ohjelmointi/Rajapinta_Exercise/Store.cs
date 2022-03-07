using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Rajapinta_Exercise
{
    class Store : IProducts, ICustomers
    {
        private string name;
        private List<Product> allProducts = new List<Product>();
        private List<Customer> allCustomers = new List<Customer>();


        public Store(string name)
        {
            this.name = name;
        }

        public void AddCustomer(Customer customer)
        {
            this.allCustomers.Add(customer);
        }

        public void AddProduct(Product product)
        {
            this.allProducts.Add(product);
        }

        public void PrintCustomers()
        {
            foreach (Customer c in allCustomers)
            {  
                Console.WriteLine(c.ToString());
            }
        }

        public void PrintProducts()
        {
            foreach (Product p in allProducts)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }

}
