using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03.BL;
using Problem_03.DL;

namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("TOM");
            Cat c2 = new Cat("Oggy");
            Dog d1 = new Dog("Scooby do");
            Dog d2 = new Dog("Droopy");

            AnimalDL.AddinList(c1);
            AnimalDL.AddinList(c2);
            AnimalDL.AddinList(d1);
            AnimalDL.AddinList(d2);

            foreach(var i in AnimalDL.animals)
            {
                Console.WriteLine(i.TString());
                i.Greets();
            }

            Console.Read();
        }
    }
}
