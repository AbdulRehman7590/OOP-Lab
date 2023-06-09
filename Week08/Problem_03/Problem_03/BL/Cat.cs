using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.BL
{
    class Cat : Mammal
    {
        public Cat(string Name) : base(Name)
        {

        }

        public override void Greets()
        {
            Console.WriteLine("Meow");
        }

        public override string TString()
        {
            return "[Cat] " + base.TString();
        }




    }
}
