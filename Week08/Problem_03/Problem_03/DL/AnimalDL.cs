using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03.BL;

namespace Problem_03.DL
{
    class AnimalDL
    {
        public static List<Animal> animals = new List<Animal>();

        public static void AddinList(Animal a)
        {
            animals.Add(a);
        }
    }
}
