using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_04.BL;
using Problem_04.DL;
using Problem_04.UI;

namespace Problem_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(Display.GetRadius());
            Rectangle r = new Rectangle(Display.GetHeight(), Display.GetWidth());
            Square s = new Square(Display.GetSide());

            ShapeDL.AddinList(c);
            ShapeDL.AddinList(r);
            ShapeDL.AddinList(s);

            foreach (var i in ShapeDL.S)
            {
                Display.Print(i.GetType(), i.GetArea());
            }

            Console.Read();


        }
    }
}
