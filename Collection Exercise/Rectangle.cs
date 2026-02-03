using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Exercise
{
    internal class Rectangle : Shape
    {
        private double lenght;
        private double width;
        
        public Rectangle(string type, string color) : base(type, color)
        {

        }
        
            public override double GetArea()
        {
            return lenght * width;
        }

        public override double GetInfo()
        {
            return GetInfo();
        }

        public override string GetType()
        {
            return type;
        }

        public override string ToString()
        {
            return $"Type: {type}, Color: {color}, Leght: {lenght}, Width: {width}, Area: {GetArea}";
        }


    
    }
}
