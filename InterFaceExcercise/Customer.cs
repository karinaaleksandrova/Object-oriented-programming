using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceExcercise
{
    internal class Customer  : ICustomer
    {
        public string name;
        public double purchases;

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }
        public void addCustomer()
        {
            this.addCustomer();
        }

       
        public double GetBonus()
        {
            if (purchases <= 1000 )
            {
                return purchases * 0.02;
            }
            else if (purchases <= 2000)
            {
                return purchases * 0.03;
            }
            else
            {
                return purchases * 0.05;
            }
        }

        public bool MatchesName(string name)
        { 
           if (this.name == name)
            {
                return true;
            }
            else
            {
               return false;
            }
        }

        public override string ToString()
        {
            return $"Name: {name}, Purchases: {purchases}";
        }
    }
}
