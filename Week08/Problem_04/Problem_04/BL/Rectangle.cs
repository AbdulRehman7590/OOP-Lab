using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.BL
{
    class Rectangle : Shape 
    {
        private double Height;
        private double Width;

        public Rectangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public override string GetType()
        {
            return "Rectangle";
        }

        public override double GetArea()
        {
            return Height * Width;
        }
    }
}
