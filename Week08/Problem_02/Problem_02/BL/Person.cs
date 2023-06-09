using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.BL
{
    class Person
    {
        protected string Name;
        protected string Address;

        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetAddress()
        {
            return this.Address;
        }

        public void SetAddress(string Address)
        {
            this.Address = Address; 
        }

        public virtual string TString()
        {
            return "Person [ name = " + GetName() + " , address = " + GetAddress();
        }
    }
}
