using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    class Student
    {
        protected string Name;
        protected int Session;
        protected bool IsDayScholar;
        protected float EntryTestMarks;
        protected float HSMarks;

        public Student (string Name, int Session, bool IsDayScholar, float EntryTestMarks, float HSMarks)
        {
            this.Name = Name;
            this.Session = Session;
            this.IsDayScholar = IsDayScholar;
            this.EntryTestMarks = EntryTestMarks;
            this.HSMarks = HSMarks;
        }

        public float CalculateFee()
        {
            return 0;
        }
    }
}
