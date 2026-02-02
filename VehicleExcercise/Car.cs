using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VehicleExcercise
{
    internal class Car : Vehicle
    {
        protected double engine;
        protected string type;
        protected int doors;
        private object car3;

        public Car(string brand, string model, string modelYear, string color,  double engine, string type, int doors, double price) : base(brand, model, modelYear, price)

        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        public Car Car1
        {
            get;
            set;
        }
        public Car Car2
        {
            get;
            set;
        }
        public Car Car3
        {
            get;
            set;
        }
        public override bool Equals(object? obj)
        {
            Car? car = obj as Car;
            return car !=null &&
                this.brand == car.brand &&
                this.model == car.model &&
                this.modelYear == car.modelYear &&
                this.price == car.price &&
                this.engine == car.engine &&
                this.type == car.type &&
                this.doors == car.doors;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void printInformation()
        {
            Console.WriteLine(this.ToString());
        }
        public override string? ToString()
        {
            return $"Auton merkki: {this.brand}\n" +
                $"Auton malli: {this.model}\n" +
                $"Vuosimalli: {this.modelYear}\n" +
                $"Hinta: {this.price}euroa\n" +
                $"Tyyppi: {this.type}\n" +
                $"Moottorin koko:{this.engine}\n" +
                $"Ovien lukumäärä:{this.doors}\n";
        }

    }

}
