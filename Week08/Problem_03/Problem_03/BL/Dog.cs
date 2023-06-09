using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.BL
{
    class Dog : Mammal
    {
        public Dog(string Name) : base(Name)
        {

        }

        public override void Greets()
        {
            Console.WriteLine("Woof");
        }
        
        public void Greets(Dog another)
        {
            Console.WriteLine("Woooooof");
        }

        public override string TString()
        {
            return "[Dog] " + base.TString();
        }





    }
}
