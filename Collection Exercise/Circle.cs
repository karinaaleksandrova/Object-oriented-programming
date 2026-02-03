using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Exercise
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(string type, string color, double radius) : base(type, color)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override string GetType()
        {
            return this.type;
        }

        public override double GetInfo()
        {
            return GetInfo();
        }

        public override string ToString()
        {
            return $"Type: {type}, Color: {color}, Radius: {radius}, Area: {GetArea}";
        }

        
    }
}
