using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.BL;

namespace Tasks
{
    class Program
    { 
        static void Main(string[] args)
        {
            Task01();
            Task02();
            Task03();
        }

        static void Task01()
        {
            students s1 = new students();
            s1.name = "Ahmad";
            s1.roll_no = 5;
            s1.cgpa = 3.25F;
            Console.WriteLine("Name : {0} Roll no. : {1} CGPA : {2}",s1.name, s1.roll_no, s1.cgpa);
            Console.Read();
        }

        static void Task02()
        {
            students s1 = new students();
            s1.name = "Ahmad";
            s1.roll_no = 5;
            s1.cgpa = 3.25F;
            Console.WriteLine("Name : {0} Roll no. : {1} CGPA : {2}", s1.name, s1.roll_no, s1.cgpa);

            students s2 = new students();
            s2.name = "Bilal";
            s2.roll_no = 6;
            s2.cgpa = 3.75F;
            Console.WriteLine("Name : {0} Roll no. : {1} CGPA : {2}", s2.name, s2.roll_no, s2.cgpa);

            Console.Read();
        }

        static void Task03()
        {
            students s1 = new students();
            Console.Write("Enter name : ");
            s1.name = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Enter roll no. : ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Enter CGPA : ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Name : {0} Roll no. : {1} CGPA : {2}", s1.name, s1.roll_no, s1.cgpa);
            Console.Read();
        }

    }
}
