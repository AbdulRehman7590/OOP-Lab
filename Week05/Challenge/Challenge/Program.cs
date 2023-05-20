using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.BL;
using Challenge.DL;
using Challenge.UI;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                option = Display.Menu();

                if (option == 1)
                {
                    if (DegreeProgramCRUD.programList.Count > 0)
                    {
                        StudentCRUD.AddStudentInList(Display.AddStudent(DegreeProgramCRUD.programList));
                    }
                    else
                    {
                        Display.AddDegreeWarning();
                    }
                }

                else if (option == 2)
                {
                    DegreeProgramCRUD.AddDegreeInList(Display.AddDegree());
                }

                else if (option == 3)
                {
                    StudentCRUD.SortedStudentsByMerit();
                    StudentCRUD.GiveAdmission(StudentCRUD.stuList);
                    Display.PrintStudents(StudentCRUD.stuList);
                }

                else if (option == 4)
                {
                    Display.ViewRegStudents(StudentCRUD.stuList);
                }

                else if (option == 5)
                {
                    DegreeProgram deg = DegreeProgramCRUD.IsProgramExists(Display.GetDegreeName());
                    if (deg != null)
                    {
                        Display.ViewStudentsInDegree(deg, StudentCRUD.stuList);
                    }
                    else
                    {
                        Display.NoDegree();
                    }
                }

                else if (option == 6)
                {
                    Student s = StudentCRUD.StudentPresent(Display.GetStudentName());
                    if (s != null)
                    {
                        Display.ViewSubjects(s);
                        Display.RegisterSubjects(s);
                    }
                    else
                    {
                        Display.AddStudentWarning();
                    }
                }

                else if (option == 7)
                {
                    StudentCRUD.CalculateFeesForAll();
                }

                else if (option == 8)
                {
                    break;
                }

                else
                {
                    Display.InvalidData();
                }

                Console.ReadKey();
            }
            while (true);


        }
    }
}