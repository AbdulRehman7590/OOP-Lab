using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClockType.BL;

namespace ClockType
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock time = new Clock();
            Console.Write("Empty time : ");
            time.PrintTime();
            Console.WriteLine(" ");

            Clock time1 = new Clock(8);
            Console.Write("Hour time : ");
            time1.PrintTime();
            Console.WriteLine(" ");

            Clock time2 = new Clock(8, 10);
            Console.Write("Minutes time : ");
            time2.PrintTime();
            Console.WriteLine(" ");

            Clock time3 = new Clock(8, 10, 10);
            Console.Write("Full time : ");
            time3.PrintTime();
            Console.WriteLine(" ");

            time3.IncrementSecond();
            Console.Write("Full time (Increment sec): ");
            time3.PrintTime();
            Console.WriteLine(" ");

            time3.IncrementMinutes();
            Console.Write("Full time (Increment min): ");
            time3.PrintTime();
            Console.WriteLine(" ");

            time3.IncrementHours();
            Console.Write("Full time (Increment hr): ");
            time3.PrintTime();
            Console.WriteLine(" ");

            bool flag = time3.IsEqual(9, 11, 11);
            Console.WriteLine("Flag : " + flag);
            Console.WriteLine(" ");

            Clock cmp = new Clock(10, 12, 1);
            flag = time3.IsEqual(cmp);
            Console.Write("Object flag : " + flag);

            Console.Read();

        }
    }
}
