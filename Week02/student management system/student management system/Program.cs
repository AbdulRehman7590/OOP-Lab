using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using student_management_system.BL;

namespace student_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            students[] s = new students[10];
            char option;
            int count = 0;
            do
            {
                option = Menu();
                if (option == '1')
                {
                    s[count] = AddStudent();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    ViewStudents(s, count);
                }
                else if (option == '3')
                {
                    TopStudents(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            while (option != '4');
            Console.WriteLine("Press Enter to Exit..");
            Console.Read();
        }


        static char Menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press 1 for adding a student");
            Console.WriteLine("Press 2 for view student ");
            Console.WriteLine("Press 3 for Top three students ");
            Console.WriteLine("Press 4 to exit");
            Console.WriteLine(" ");
            Console.Write("Select Option : ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }

        static students AddStudent()
        {
            Console.Clear();
            students s1 = new students();
            Console.Write("Enter Name :");
            s1.name = Console.ReadLine();
            Console.Write("Enter roll no. : ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter CGPA : ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter Department : ");
            s1.department = Console.ReadLine();
            Console.Write("Is hostelide (y || n) : ");
            s1.isHostelide = char.Parse(Console.ReadLine());
            return s1;
        }

        static void ViewStudents(students[] s, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: {0}  Roll no: {1}  CGPA: {2}  Department: {3}  ISHostelide: {4}", s[i].name, s[i].roll_no, s[i].cgpa, s[i].department, s[i].isHostelide);
            }
            Console.WriteLine("Press any key to continue..");
            Console.Read();
        }

        static void TopStudents(students[] s, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No record present");
            }
            else if (count == 1)
            {
                ViewStudents(s, 1);
            }
            else if (count == 2)
            {
                for (int x = 0; x < 2; x++)
                {
                    int index = Largest(s, x, count);
                    students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;                
                }
                ViewStudents(s, 2);
            }
            else
            {
                for (int x = 0; x < 3; x++)
                {
                    int index = Largest(s, x, count);
                    students temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                ViewStudents(s, 3);
            }
        }

        static int Largest(students[] s, int start, int end)
        {
            int index = start;
            float large = s[start].cgpa;
            for(int x = start; x < end; x++)
            {
                if(large < s[x].cgpa)
                {
                    large = s[x].cgpa;
                    index = x;
                }
            }
            return index;
        }
    }
}
