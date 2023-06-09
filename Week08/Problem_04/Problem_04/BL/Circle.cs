using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.BL
{
    class Circle : Shape
    {
        private double Radius;

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override string GetType()
        {
            return "Circle";
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
