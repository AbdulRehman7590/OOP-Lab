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
            Task03a();
            Task03b();
            Task04();
            Task05a();
            Task05b();
            Task06();
            Task07();
        }

        static void Task01()
        {
            Student s = new Student();
            Console.WriteLine(s.sname);
            Console.WriteLine(s.matricMarks);
            Console.WriteLine(s.fscMarks);
            Console.WriteLine(s.ecatMarks);
            Console.WriteLine(s.aggregate);
            Console.Read();
        }

        static void Task02()
        {
            Student s = new Student();
            Console.WriteLine(s.sname);
            Console.Read();
        }

        static void Task03a()
        {
            Student s = new Student();
            Console.WriteLine(s.sname);
            Console.WriteLine(s.matricMarks);
            Console.WriteLine(s.fscMarks);
            Console.WriteLine(s.ecatMarks);
            Console.WriteLine(s.aggregate);
            Console.Read();
        }

        static void Task03b()
        {
            Student s = new Student();
            Console.WriteLine(s.sname);
            Console.WriteLine(s.matricMarks);
            Console.WriteLine(s.fscMarks);
            Console.WriteLine(s.ecatMarks);
            Console.WriteLine(s.aggregate);
            Console.Read();

            Student s1 = new Student();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.Read();
        }

        static void Task04()
        {
            Student s1 = new Student("AR");
            Console.WriteLine(s1.sname);
            Student s2 = new Student("AR");
            Console.WriteLine(s2.sname);
            Console.Read();
        }

        static void Task05a()
        {
            Student s = new Student("A", 1.1F, 2.2F, 3.4F, 4.0F);
            Console.WriteLine(s.sname);
            Console.WriteLine(s.matricMarks);
            Console.WriteLine(s.fscMarks);
            Console.WriteLine(s.ecatMarks);
            Console.WriteLine(s.aggregate);
            Console.Read();
        }

        static void Task05b()
        {
            Student s = new Student("A", 1.1F, 2.2F, 3.4F, 4.2F);
            Console.WriteLine(s.sname);
            Console.WriteLine(s.matricMarks);
            Console.WriteLine(s.fscMarks);
            Console.WriteLine(s.ecatMarks);
            Console.WriteLine(s.aggregate);
            Console.Read();

            Student s1 = new Student("B", 1.9F, 2.8F, 7.6F, 4.5F);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.Read();
        }

        static void Task06()
        {
            Student s = new Student();
            s.sname = "AR";
            Student s1 = new Student(s);
            Console.WriteLine(s.sname);
            Console.WriteLine(s1.sname);
            Console.Read();
        }

        static void Task07()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
