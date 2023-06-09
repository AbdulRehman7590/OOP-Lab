using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_02.BL;

namespace Problem_02.DL
{
    class PersonDL
    {
        public static List<Person> P = new List<Person>();

        public static void AddinList(Person p)
        {
            P.Add(p);
        }

    }
}
