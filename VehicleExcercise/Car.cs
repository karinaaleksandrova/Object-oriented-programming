using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VehicleExcercise
{
    internal class Car : Vehicle
    {
        protected int engine;
        protected string type;
        protected int doors;

        public Car(string brand, string model, int modelYear, string price, int engine, string type, int doors) : base(brand, model, modelYear, price)

        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Car Information: Brand: {brand}, Model: {model} Model Year: {modelYear},Type: {type}, Engine: {engine}, Doors: {doors}, Price: {price}€");
        }

    }

}
