using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.BL
{
    class Staff : Person
    {
        private string School;
        private double Pay;

        public Staff(string Name, string Address, string School, double Pay) : base (Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        public string GetSchool()
        {
            return this.School;
        }

        public void SetSchool(string School)
        {
            this.School = School;
        }
        
        public double GetPay()
        {
            return this.Pay;
        }

        public void SetPay(double Pay)
        {
            this.Pay = Pay;
        }


        public override string TString()
        {
            return base.TString() + ", School = " + GetSchool() + " , Pay = " + GetPay() + " ]";
        }


    }
}
