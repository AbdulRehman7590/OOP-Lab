using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.BL;

namespace Challenge.DL
{
    public class DegreeProgramCRUD
    {
        public static List<DegreeProgram> programList = new List<DegreeProgram>();

        public static void AddDegreeInList(DegreeProgram deg)
        {
            programList.Add(deg);
        }

        public static DegreeProgram IsProgramExists(string n)
        {
            foreach (var x in programList)
            {
                if (n == x.degreeName)
                {
                    return x;
                }
            }
            return null;
        }

    }
}
