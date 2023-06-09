using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.BL
{
    class Square : Shape
    {
        private double Side;        

        public Square(double Side)
        {
            this.Side = Side;
        }

        public override string GetType()
        {
            return "Square";
        }

        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
