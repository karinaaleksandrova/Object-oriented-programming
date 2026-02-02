using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceExcercise
{
    internal class Store : IProducts,ICustomers
 
    {
        private string name;
        private double revenue;

        private List<Product> productsList = new List<Product>();
        private List<Customer> customers = new List<Customer>();
        
        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
        }
      

        

        public void AddProduct(Product product)
        {
            this.productsList.Add(product);
        }

        public void PrintProducts()
        {
            foreach(Product p in this.productsList)
            {
                Console.WriteLine(p);
            }
        }

       public void AddCustomer(Customer customer)
        {
            this.CustomerList.Add(Customer);
        }
    }

   
}
