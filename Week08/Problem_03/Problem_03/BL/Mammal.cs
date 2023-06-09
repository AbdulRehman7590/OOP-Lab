using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.BL
{
    class Mammal : Animal
    {
        public Mammal(string Name) : base (Name)
        {

        }

        public override void Greets()
        {

        }

        public override string TString()
        {
            return "[Mammal] [" + base.TString() + " ]";
        }
    }
}
