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
        }

        static void Task01()
        {
            List<string> str = new List<string> { "Ali", "Usman", "Haider", "Zubair", "Numan" };

            List<float> flo = new List<float> { 0.3F, 0.1F, 0.6F, 1.3F, 5 };

            str.Sort();
            flo.Sort();

            foreach(var x in str)
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine();
            foreach (var y in flo)
            {
                Console.WriteLine(y + " ");
            }
            Console.ReadKey();
        }

        static void Task02()
        {
            Student stu1 = new Student("Ali", 500);
            Student stu2 = new Student("Asad", 600);
            Student stu3 = new Student("Saad", 300);
            Student stu4 = new Student("Anas", 450);

            List<Student> data = new List<Student> { stu1, stu2, stu3, stu4 };

            List<Student> sortedData = data.OrderBy(o => o.marks).ToList();

            foreach (var x in data)
            {
                Console.WriteLine(x.name + " " + x.marks);
            }
            Console.WriteLine(" ");
            foreach (var y in sortedData)
            {
                Console.WriteLine(y.name + " " + y.marks);
            }
            Console.ReadKey();
        }

    }
}
