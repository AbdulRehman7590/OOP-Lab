using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.BL
{
    public class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<DegreeProgram> preferences;
        public List<Subject> regSubjects;
        public DegreeProgram regDegree;           

        public Student(string name, int age, double fscMarks, double ecatMarks, List<DegreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preferences = preferences;
        }

        public double CalculateMerit(int fsc, int ecat)
        {
            return (((fsc / 100.0F) * (this.fscMarks * 100 / 1100)) + ((ecat / 100.0F) * (this.ecatMarks * 100 / 1100)));
        }

        public int GetCreditHours()
        {
            int ch = 0;
            foreach (var x in regSubjects)
            {
                ch += x.creditHours;
            }
            return ch;
        }

        public float CalculateFee()
        {
            float fees = 0;
            if (regDegree != null)
            {
                foreach (var x in regSubjects)
                {
                    fees += x.subjectFees * x.creditHours;
                }
            }
            return fees;
        }

        public bool RegStudentSubject(Subject s)
        {
            int stCH = GetCreditHours();
            if (regDegree != null && regDegree.IsSubjectExists(s) && stCH + s.creditHours <= 9)
            {
                regSubjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
