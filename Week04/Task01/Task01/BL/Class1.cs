using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.BL
{
    class Student
    {
        public string name;
        public int rollNumber;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public float cGPA;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;

        public Student(string name, int rollNumber, int matricMarks, int fscMarks, int ecatMarks, float cGPA, string homeTown, bool isHostelite, bool isTakingScholarship)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.cGPA = cGPA;
            this.homeTown = homeTown;
            this.isHostelite = isHostelite;
            this.isTakingScholarship = isTakingScholarship;
        }

        public float CalculateMerit()
        {
            return ((0.6F * (fscMarks *  100 /1100)) + (0.4F * (ecatMarks * 100 / 1100)));
        }

        public bool IsEligibleforScholarship(float meritPercentage)
        {
            bool x = false;
            if (meritPercentage > 80 && this.isHostelite == true)
            {
                x = true;
            }
            return x;
        }
    }
}
