using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.BL
{
    class Student
    {
        public Student()
        {
            sname = "AR";
            matricMarks = 1038F;
            fscMarks = 1029;
            ecatMarks = 140F;
            aggregate = 81.7F;
        }

        public Student(string sname)
        {
            this.sname = sname;
        }

        public Student(string sname, float matricMarks, float fscMarks, float ecatMarks, float aggregate)
        {
            this.sname = sname;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.aggregate = aggregate;
        }

        public Student(Student s)
        {
            sname = s.sname;
            matricMarks = s.matricMarks;
            fscMarks = s.fscMarks;
            ecatMarks = s.ecatMarks;
            aggregate = s.aggregate;
        }

        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
}
