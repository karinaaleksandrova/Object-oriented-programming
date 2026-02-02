using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExcercise
{
    internal class Truck : Car
    {
        public double load;
        public double consumption;
        public Truck(string brand, string model, string modelYear, string color, double price, double engine, string type, int doors, double load, double consumption) : base(brand, model, modelYear, color, engine, type, doors, price)
        {
            this.load = load;
            this.consumption = consumption;
        }

        public double Calculateconsumption(double distance)
        {
            return (distance / 100) * consumption;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Kuorman kapasiteetti: {this.load} kg, Polttoaine: {this.consumption} L/100km");
        }
        public override string ToString()
        {
            return $"Auton merkki: {this.brand}\n" +
                $"Malli : {this.model}\n" +
                $"Vuosimalli: {this.modelYear}\n" +
                $"Hinta : {this.price} euroa\n" +
                $"Tyyppi: {this.type}\n" +
                $"Ovet: {this.doors}\n" +
                $"Kuorma: {this.load} kg\n" +
                $"Kulutus: {this.consumption} L/100km\n";
        }
    }


}

