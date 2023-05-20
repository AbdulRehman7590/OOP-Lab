using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_02.BL;

namespace Problem_02.UI
{
    public class Display
    {

        public static void ClearScreen(char[,] Shape, Point axis)
        {
            int x = axis.GetX();
            int y = axis.GetY();

            for (int m = 0; m < Shape.GetLength(0); m++)
            {
                for (int i = 0; i < Shape.GetLength(1); i++)
                {
                    Console.SetCursorPosition(x + m, y + i);
                    Console.WriteLine(" ");
                }
            }
        }
        
        public static void DrawShape(char[,] Shape, Point axis)
        {
            int x = axis.GetX();
            int y = axis.GetY();

            for (int m = 0; m < Shape.GetLength(0); m++)
            {
                for (int i = 0; i < Shape.GetLength(1); i++)
                {
                    Console.SetCursorPosition(x + m, y + i);
                    Console.WriteLine(Shape[m, i]);
                }
            }
        }














    }
}
