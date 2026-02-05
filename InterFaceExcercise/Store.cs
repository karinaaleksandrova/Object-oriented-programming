using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceExcercise
{
    internal class Store : IProducts, ICustomers
 
    {
        private string name;
        private double revenue;

        private List<Product> productList = new List<Product>();
        private List<Customer> customers = new List<Customer>();
        
        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
            
        }

        public int GetCustomerCount()
        {
            return customers.Count;
        }
        public void AddCustomers(Customer customer)
        {
            this.customers.Add(customer);
        }

        public int GetProductCount()
        {
            return productList.Count;
        }
        
        public void AddProduct(Product product)
        {
            this.productList.Add(product);
        }

        public void PrintProducts()
        {
            foreach(Product p in this.productList)
            {
                Console.WriteLine(p);
            }
        }

        public void PrintCustomers()
        {
            foreach(Customer c in this.customers)
            {
                Console.WriteLine(c);
            }
        }

        public override string ToString()
        {
            return $"Kaupan nimi: {this.name}, Kaupan liikevaihto: {this.revenue}, Kaupan tuotteiden määrä: {GetProductCount()}, Asiakkaiden määrä: {GetCustomerCount()}";
        }
    }

   
}
