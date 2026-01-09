using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExcercise
{
    internal class car
    {
        public string brand;
        public double speed;

        public car()
        {
            this.brand = String.Empty;
            this.speed = 0;
        }

        public car(string brand, double speed)
        {
            this.brand = brand;
            this.speed = speed;
        }
        public void AskData()
        {
            Console.WriteLine("Anna auton merkki ");
            this.brand = Console.ReadLine();
            Console.WriteLine("Anna auton nopeus ");
            double.TryParse(Console.ReadLine(), out this.speed);
        }
        public void ShowCarinfo()
        {
            Console.WriteLine($"{this.brand} : {this.speed}");
        }
        public void Accelerate(double value)
        {
            this.speed += value;
        }
        public void Brake()
        {
            this.speed *= 0.9;

        }

    }

}
