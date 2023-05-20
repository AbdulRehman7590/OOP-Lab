using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.BL;

namespace Challenge.DL
{
    public class StudentCRUD
    {
        public static List<Student> stuList = new List<Student>();

        public static void AddStudentInList(Student s)
        {
            stuList.Add(s);
        }

        public static void SortedStudentsByMerit()
        {
            foreach (var x in stuList)
            {
                x.merit = x.CalculateMerit(60, 40);
            }
            stuList.Sort((a, b) => a.merit.CompareTo(b.merit));
            stuList.Reverse();
        }


        public static Student StudentPresent(string n)
        {
            foreach (var x in stuList)
            {
                if (n == x.name && x.regDegree != null)
                {
                    return x;
                }
            }
            return null;
        }


        public static void CalculateFeesForAll()
        {
            bool flag = false;
            Console.WriteLine("Student Name".PadRight(20, ' ') + "Fees");
            foreach (var x in stuList)
            {
                if (x.regDegree != null && x.regSubjects.Count > 0)
                {
                    Console.WriteLine(x.name.PadRight(20, ' ') + x.CalculateFee());
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Register first !!!");
            }
        }

        public static void GiveAdmission(List<Student> stuList)
        {
            foreach (var x in stuList)
            {
                foreach (var i in x.preferences)
                {
                    if (i.seats > 1 && x.regDegree == null)
                    {
                        x.regDegree = i;
                        i.seats--;
                        break;
                    }
                }
            }
        }


    }
}
