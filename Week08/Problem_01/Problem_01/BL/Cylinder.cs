using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.BL
{
    class Cylinder : Circle
    {
        private double Height;

        public Cylinder()
        {
            Height = 1.0F;
        }

        public Cylinder(double Radius) : base(Radius)
        {
            Height = 1.0F;
        }
        
        public Cylinder(double Radius, double Height) : base(Radius)
        {
            this.Height = Height;
        }

        public Cylinder(double Radius, double Height, string Color) : base(Radius, Color)
        {
            this.Height = Height;
        }

        public double GetHeight()
        {
            return Height;
        }

        public void SetHeight(double Height)
        {
            this.Height = Height;
        }

        public double GetVolume()
        {
            return GetArea() * GetHeight();
        }

    }
}
