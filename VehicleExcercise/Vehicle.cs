using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExcercise
{
    abstract class Vehicle
    {
        protected string brand = string.Empty;
        protected string model = string.Empty;
        protected string modelYear = string.Empty;
        protected double price = 0;

      public string Brand
        {
            get
            {
                return brand;
            }
            set => brand = null;
        }

        public Vehicle(string brand, string model, string modelYear, double price)
        {
            this.brand = brand;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }

        public virtual void PrintInformation()
        {
            Console.WriteLine($"Merkki: {this.brand}, Malli: {this.model}, Vuosimalli: {this.modelYear}, Hinta: {this.price}");
        }
        public override bool Equals(object? obj)
        {
            Vehicle? vehicle = obj as Vehicle;
            return (vehicle != null) &&
                this.brand == Brand;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
