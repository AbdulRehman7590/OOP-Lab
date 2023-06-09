using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01.BL;

namespace Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(2, 5);
            Cylinder c3 = new Cylinder(10, 5, "Orange");

            c1.SetHeight(10);

            Console.WriteLine(c1.GetVolume());
            Console.Read();
        }
    }
}
