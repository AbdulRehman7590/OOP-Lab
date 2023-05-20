using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.BL;

namespace Challenge.UI
{
    public class Display
    {
        public static int Menu()
        {
            Header();
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate merit");
            Console.WriteLine("4. View Registered students");
            Console.WriteLine("5. View students of a specific program");
            Console.WriteLine("6. Register subjects for a specific student");
            Console.WriteLine("7. Calculate fees for all registered students");
            Console.WriteLine("8. Exit ");
            Console.WriteLine(" ");
            Console.Write("Select Option : ");
            return int.Parse(Console.ReadLine());
        }

        public static void Header()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("                     UAMS                     ");
            Console.WriteLine("**********************************************");
            Console.WriteLine(" ");
        }

        public static string AskingOption()
        {
            Console.Write("Do you want to enter more (Y/N): ");
            return Console.ReadLine();
        }

        public static void AddDegreeWarning()
        {
            Console.WriteLine("Add Degree Programs 1st !!!");
        }

        public static void NoDegree()
        {
            Console.WriteLine("No Degree Exists !!!");
        }

        public static void AddStudentWarning()
        {
            Console.WriteLine("Add Students first !!!");
        }
        
        public static void InvalidData()
        {
            Console.WriteLine("Invalid Data !!!");
        }

        public static void ShowAvailablePrograms(List<DegreeProgram> programList)
        {
            Console.WriteLine("Available programs are : ");
            Console.WriteLine("Degree".PadRight(20, ' ') + "Seats".PadRight(20, ' ') + "Duration".PadRight(20, ' '));

            foreach (var x in programList)
            {
                Console.WriteLine(x.degreeName.PadRight(20, ' ') + x.seats.ToString().PadRight(20, ' ') + x.degreeDuration.ToString().PadRight(20, ' '));
            }
        }

        public static void PrintStudents(List<Student> stuList)
        {
            foreach (var x in stuList)
            {
                if (x.regDegree != null)
                {
                    Console.WriteLine(x.name + " got admission in " + x.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(x.name + " did not get admission");
                }
            }
        }

        public static void ViewRegStudents(List<Student> stuList)
        {
            Console.WriteLine("Name".PadRight(20, ' ') + "Age".PadRight(20, ' ') + "FSC".PadRight(20, ' ') + "ECAT".PadRight(20, ' '));
            foreach (var x in stuList)
            {
                if (x.regDegree != null)
                {
                    Console.WriteLine(x.name.PadRight(20, ' ') + x.age.ToString().PadRight(20, ' ') + x.fscMarks.ToString().PadRight(20, ' ') + x.ecatMarks.ToString().PadRight(20, ' '));
                }
            }
        }

        public static void ViewStudentsInDegree(DegreeProgram n, List<Student> stuList)
        {
            Console.WriteLine("Name".PadRight(20, ' ') + "Age".PadRight(20, ' ') + "FSc Marks".PadRight(20, ' ') + "Ecat Marks".PadRight(20, ' '));

            foreach (var x in stuList)
            {
                if (n == x.regDegree)
                {
                    Console.WriteLine(x.name.PadRight(20, ' ') + x.age.ToString().PadRight(20, ' ') + x.fscMarks.ToString().PadRight(20, ' ') + x.ecatMarks.ToString().PadRight(20, ' '));
                }
            }
        }


        public static Student AddStudent(List<DegreeProgram> programsList)
        {
            string name = GetStudentName();

            Console.Write("Enter Student Age : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Fsc marks : ");
            int fsc = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Ecat marks : ");
            int ecat = int.Parse(Console.ReadLine());

            Student stu = new Student(name, age, fsc, ecat, AddPreferences(programsList));

            return stu;
        }
        static List<DegreeProgram> AddPreferences(List<DegreeProgram> programsList)
        {
            Display.ShowAvailablePrograms(programsList);
            List<DegreeProgram> prefer = new List<DegreeProgram>();
            string count;
            do
            {
                Console.Write("Enter name of program : ");
                string name = Console.ReadLine();
                if (name != null)
                {
                    foreach (var x in programsList)
                    {
                        if (name == x.degreeName && !(prefer.Contains(x)))
                        {
                            prefer.Add(x);
                        }
                    }
                }
                else
                {
                    InvalidData();
                }
                count = AskingOption();
            }
            while (count != "N");
            return prefer;
        }
        public static string GetStudentName()
        {
            Console.Write("Enter the student name : ");
            return Console.ReadLine();
        }


        public static DegreeProgram AddDegree()
        {
            string name = GetDegreeName();

            Console.Write("Enter Degree duration : ");
            float duration = float.Parse(Console.ReadLine());

            Console.Write("Enter Degree seats : ");
            int seats = int.Parse(Console.ReadLine());

            DegreeProgram degpro = new DegreeProgram(name, duration, seats);

            Console.Write("How many subjects to Enter : ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                if (degpro.AddSubject(TakingSubjectInput()))
                {
                    Console.WriteLine("Subject Added !!!");
                }
                else
                {
                    Console.WriteLine("20 credit hour limit exceeded");
                }
            }
            return degpro;
        }
        static Subject TakingSubjectInput()
        {
            Console.Write("Enter subject code : ");
            string code = Console.ReadLine();

            Console.Write("Enter subject type : ");
            string type = Console.ReadLine();

            Console.Write("Enter subject credit hours : ");
            int ch = int.Parse(Console.ReadLine());

            Console.Write("Enter subject fees : ");
            int fee = int.Parse(Console.ReadLine());

            Subject subj = new Subject(code, type, ch, fee);

            return subj;
        }
        public static string GetDegreeName()
        {
            Console.Write("Enter Degree Name : ");
            return Console.ReadLine();
        }


        public static void ViewSubjects(Student s)
        {
            if (s.regDegree != null)
            {
                Console.WriteLine("Subject Code".PadRight(20, ' ') + "Type".PadRight(20, ' ') + "Credit Hours".PadRight(20, ' ') + "Subject Fees");
                foreach (var x in s.regDegree.subjects)
                {
                    Console.WriteLine(x.code.PadRight(20, ' ') + x.type.PadRight(20, ' ') + x.creditHours.ToString().PadRight(20, ' ') + x.subjectFees);
                }
            }
            else
            {
                Console.WriteLine("NO data Found !!!");
            }
        }



        public static void RegisterSubjects(Student s)
        {
            string option;
            do
            {
                Console.Write("Enter the Subject code : ");
                string cod = Console.ReadLine();

                foreach (var x in s.regDegree.subjects)
                {
                    if (cod == x.code && !(s.regSubjects.Contains(x)))
                    {
                        if (s.RegStudentSubject(x))
                        {
                            Console.WriteLine("Subject Added !");
                        }
                        else
                        {
                            Console.WriteLine("A student can not have more than 9 credit hours or Wrong subject");
                        }
                        break;
                    }
                }

                option = AskingOption();
            }
            while (option != "N");
        }


    }
}
