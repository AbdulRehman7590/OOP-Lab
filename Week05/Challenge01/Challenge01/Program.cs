using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Challenge01.UI;
using Challenge01.BL;

namespace Challenge01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint point = new MyPoint(0, 0);
            MyLine line = new MyLine(point, point);
            int opt;
            do
            {
                Display.Clear();
                opt = Display.Menu();
                
                if (opt == 1)
                {
                    Display.Clear();
                    line = Display.MakeLine();
                    Display.AnyKey();
                }
                
                else if (opt == 2)
                {
                    Display.Clear();
                    line.Begin = Display.UpdatePoint("Begin");
                    Display.AnyKey();
                }
                
                else if (opt == 3)
                {
                    Display.Clear();
                    line.End = Display.UpdatePoint("End");
                    Display.AnyKey();
                }
                
                else if (opt == 4)
                {
                    Display.Clear();
                    Display.ShowPoint(line.Begin, "Begin");
                    Display.AnyKey();
                }
                
                else if (opt == 5)
                {
                    Display.Clear();
                    Display.ShowPoint(line.End, "End");
                    Display.AnyKey();
                }
                
                else if (opt == 6)
                {
                    Display.Clear();
                    Display.ShowLength(line);
                    Display.AnyKey();
                }
                
                else if (opt == 7)
                {
                    Display.Clear();
                    Display.ShowSlope(line);
                    Display.AnyKey();
                }
                
                else if (opt == 8)
                {
                    Display.Clear();
                    Display.ShowDistanceFromOrigin(line.Begin);
                    Display.AnyKey();
                }
                
                else if (opt == 9)
                {
                    Display.Clear();
                    Display.ShowDistanceFromOrigin(line.End);
                    Display.AnyKey();
                }
                
                else if (opt > 10)
                {
                    Display.WrongIuput();
                    Thread.Sleep(300);
                }
            }
            while (opt != 10);
            Display.AnyKey();
        }
    }
}
