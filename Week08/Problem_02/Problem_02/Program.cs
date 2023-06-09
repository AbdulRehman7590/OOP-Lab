using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_02.BL;
using Problem_02.DL;

namespace Problem_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("AR", "Unknown", "Cs", 2022, 10000);
            Student s2 = new Student("AR", "Unknown", "Cs", 2022, 10000);
            Staff st1 = new Staff("AR", "Unknown", "Oriel", 10000);
            Staff st2 = new Staff("AR", "Unknown", "Oriel", 10000);

            PersonDL.AddinList(s1);
            PersonDL.AddinList(s2);
            PersonDL.AddinList(st1);
            PersonDL.AddinList(st2);

            foreach(var i in PersonDL.P)
            {
                Console.WriteLine(i.TString());
            }

            Console.Read();
        }
    }
}
