using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.BL;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stuList = new List<Student>();
            List<DegreeProgram> programList = new List<DegreeProgram>();

            int option;
            do
            {
                Console.Clear();
                option = Menu();

                if (option == 1)
                {
                    if (programList.Count > 0)
                    {
                        stuList.Add(AddStudent(programList));
                    }
                    else
                    {
                        Console.WriteLine("Add Degree Programs 1st !!!");
                    }
                }

                else if (option == 2)
                {
                    programList.Add(AddDegree());
                }

                else if (option == 3)
                {
                    SortedStudentsByMerit(stuList);
                    GiveAdmission(stuList, programList);
                    PrintStudents(stuList);
                }

                else if (option == 4)
                {
                    ViewRegStudents(stuList);
                }

                else if (option == 5)
                {
                    Console.Write("Enter Degree Name : ");
                    DegreeProgram deg = IsProgramExists(Console.ReadLine(), programList);
                    if (deg != null)
                    {
                        Console.WriteLine("Name".PadRight(20, ' ') + "Age".PadRight(20, ' ') + "FSC".PadRight(20, ' ') + "ECAT".PadRight(20, ' '));
                        ViewStudentsInDegree(deg, stuList);
                    }
                    else
                    {
                        Console.WriteLine("No Degree Exists !!!");
                    }
                }

                else if (option == 6)
                {
                    Console.Write("Enter the student name : ");
                    Student s = StudentPresent(Console.ReadLine(), stuList);
                    if (s != null)
                    {
                        ViewSubjects(s);
                        RegisterSubjects(s);
                    }
                    else
                    {
                        Console.WriteLine("Add Students first !!!");
                    }
                }

                else if (option == 7)
                {
                    CalculateFees(stuList);
                }

                else if (option == 8)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Option !!!");
                }

                Console.ReadKey();
            }
            while (true);
        }


        static int Menu()
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
        static void Header()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("                     UAMS                     ");
            Console.WriteLine("**********************************************");
            Console.WriteLine(" ");
        }

        static string AskingOption()
        {
            Console.Write("Do you want to enter more (Y/N): ");
            return Console.ReadLine();
        }


        static Student AddStudent(List<DegreeProgram> programsList)
        {
            Console.Write("Enter Student name : ");
            string name = Console.ReadLine();

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
            ShowAvailablePrograms(programsList);
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
                    Console.WriteLine("Incorrect Data !");
                }
                count = AskingOption();
            }
            while (count != "N");
            return prefer;
        }
        static void ShowAvailablePrograms(List<DegreeProgram> programsList)
        {
            Console.WriteLine("Available programs are : ");
            Console.WriteLine("Degree".PadRight(20, ' ') + "Seats".PadRight(20, ' ') + "Duration".PadRight(20, ' '));
            foreach (var x in programsList)
            {
                Console.WriteLine(x.degreeName.PadRight(20, ' ') + x.seats.ToString().PadRight(20, ' ') + x.degreeDuration.ToString().PadRight(20, ' '));
            }
        }


        static DegreeProgram AddDegree()
        {
            Console.Write("Enter Degree name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Degree duration : ");
            float duration = float.Parse(Console.ReadLine());

            Console.Write("Enter Degree seats : ");
            int seats = int.Parse(Console.ReadLine());

            DegreeProgram degpro = new DegreeProgram(name, duration, seats);

            Console.Write("How many subjects to Enter : ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                degpro.AddSubject(TakingSubjectInput());
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

         
        static void SortedStudentsByMerit(List<Student> stuList)
        {
            foreach (var x in stuList)
            {
                x.merit = x.CalculateMerit(60, 40);
            }
            stuList.Sort((a, b) => a.merit.CompareTo(b.merit));
            stuList.Reverse();
        }
        static void GiveAdmission(List<Student> stuList, List<DegreeProgram> programList)
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
        static void PrintStudents(List<Student> stuList)
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


        static void ViewRegStudents(List<Student> stuList)
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


        static void ViewStudentsInDegree(DegreeProgram n, List<Student> stuList)
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
        static DegreeProgram IsProgramExists(string n, List<DegreeProgram> programsList)
        {
            foreach (var x in programsList)
            {
                if (n == x.degreeName)
                {
                    return x;
                }
            }
            return null;
        }


        static Student StudentPresent(string n, List<Student> stuList)
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

        static void ViewSubjects(Student s)
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

        static void RegisterSubjects(Student s)
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
                        s.RegStudentSubject(x);
                        break;
                    }
                }

                option = AskingOption();
            }
            while (option != "N");
        }


        static void CalculateFees(List<Student> stuList)
        {
            bool flag = false;
            Console.WriteLine("Student Name".PadRight(20,' ') + "Fees");
            foreach (var x in stuList)
            {
                if (x.regDegree != null && x.regSubjects.Count > 0)
                {
                    Console.WriteLine(x.name.PadRight(20,' ') + x.CalculateFee());
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Register first !!!");
            }
        }

    }
}