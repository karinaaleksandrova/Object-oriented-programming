using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Exercise
{
    internal class Triangle : Shape
    {
        private double lenght;
        private double width;

        public Triangle(string type, string color) : base(type, color)
        {
        }

        public override double GetArea()
        {
            return 0.5 * lenght * width;
        }

        public override string GetType()
        {
            return type;
        }

        public override double GetInfo()
        {
            return GetInfo();
        }

        public override string ToString()
        {
            return $"Type: {type}, Color: {color}, Leght: {lenght}, Width: {width}, Area: {GetArea}";
        }
    }
}
