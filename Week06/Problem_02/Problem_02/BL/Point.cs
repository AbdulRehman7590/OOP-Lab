using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.BL
{
    public class Point
    {
        public int X;
        public int Y;

        public Point()
        {
            X = 3;
            Y = 10;
        }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public void SetX(int X)
        {
            this.X = X;
        }

        public void SetY(int Y)
        {
            this.Y = Y;
        }

        public void SetXY(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        
    }
}
