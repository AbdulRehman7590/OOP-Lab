using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.BL
{
    class Animal
    {
        protected string Name;

        public Animal(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public virtual void Greets()
        {

        }

        public virtual string TString()
        {
            return "Name = " + GetName();
        }
    }
}
