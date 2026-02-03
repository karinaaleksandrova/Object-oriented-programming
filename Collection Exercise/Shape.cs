using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Exercise
{
    internal abstract class Shape
    {
        public string type;
        public string color;

        protected Shape(string type, string color)
        {
            type = type;
            this.color = color;
        }

        public abstract double GetArea();
        
        public abstract string GetType();
        public abstract double GetInfo();

       
    }
}
