using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.BL;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("AbdulRehman", 79, 1038, 1029, 140, 3.8F, "Lahore", false, false);
            Console.WriteLine("Merit is : {0} ", stu.CalculateMerit());
            Console.WriteLine("Scholarship Eligibility : {0} ", stu.IsEligibleforScholarship(stu.CalculateMerit()));
            Console.ReadKey();
        }
    }
}
