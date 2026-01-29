using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExcercise
{
    internal class Vehicle
    {
        protected string brand;
        protected string model;
        protected int modelYear;
        protected string price;

      

        public Vehicle(string brand, string model, int modelYear, string price)
        {
            this.brand = brand;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }
        public virtual void PrintInformation()
        {
            Console.WriteLine("Vehicle information");
            Console.WriteLine($"Brand: {brand}, Model: {model}, Model year {modelYear}, Price: {price}");
        }
    }
}
