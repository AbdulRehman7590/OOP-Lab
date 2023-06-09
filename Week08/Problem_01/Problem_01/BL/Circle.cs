using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.BL
{
    class Circle
    {
        private double Radius;
        private string Color;

        public Circle()
        {
            Radius = 1.0F;
            Color = "Red";
        }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public Circle(double Radius, string Color)
        {
            this.Radius = Radius;
            this.Color = Color;
        }

        public double GetRadius()
        {
            return this.Radius;
        }

        public void SetRadius(double Radius)
        {
            this.Radius = Radius;
        }
        
        public string GetColor()
        {
            return this.Color;
        }

        public void SetColor(string Color)
        {
            this.Color = Color;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public string TString()
        {
            return "Circle radius : " + GetRadius() + " and Circle color : " + GetColor();
        }
    }
}
