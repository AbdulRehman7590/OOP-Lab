using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.UI
{
    public class Display
    {
        public static double GetWidth()
        {
            Console.Write("Enter the Width : ");
            return double.Parse(Console.ReadLine());
        }
        
        public static double GetHeight()
        {
            Console.Write("Enter the Height : ");
            return double.Parse(Console.ReadLine());
        }
        
        public static double GetRadius()
        {
            Console.Write("Enter the radius : ");
            return double.Parse(Console.ReadLine());
        }
        
        public static double GetSide()
        {
            Console.Write("Enter the Side : ");
            return double.Parse(Console.ReadLine());
        }


        public static void Print(string typ, double area)
        {
            Console.WriteLine("This Shape is " + typ + " and its area is " + area);
        }
    }
}
