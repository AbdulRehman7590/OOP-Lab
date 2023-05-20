using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.BL
{
    public class DegreeProgram
    {
        public string degreeName;
        public float degreeDuration;
        public List<Subject> subjects;
        public int seats;


        public DegreeProgram(string degreeName, float degreeDuration, int seats)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seats = seats;
            subjects = new List<Subject>();
        }

        public int CalculateCreditHours()
        {
            int count = 0;
            foreach(var x in subjects)
            {
                count += x.creditHours;
            }
            return count;
        }

        public bool IsSubjectExists(Subject s)
        {
            bool flag = false;
            foreach (var x in subjects)
            {
                if (s.code == x.code && s.type == x.type)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool AddSubject(Subject s)
        {
            int creditHours = CalculateCreditHours();
            if (creditHours + s.creditHours <= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
