using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.BL
{
    class Student : Person
    {
        private string Program;
        private int Year;
        private double Fee;

        public Student(string Name, string Address, string Program, int Year, double Fee) : base (Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        public string GetProgram()
        {
            return this.Program;
        }

        public void SetProgram(string Program)
        {
            this.Program = Program;
        }

        public int GetYear()
        {
            return this.Year;
        }

        public void SetYear(int Year)
        {
            this.Year = Year;
        }

        public double GetFees()
        {
            return this.Fee; ;
        }

        public void SetFees(double Fee)
        {
            this.Fee = Fee;
        }

        public override string TString()
        {
            return base.TString() + " , Program = " + GetProgram() + " , Year = " + GetYear() + " , Fee = " + GetFees() + " ]";
        }






    }
}
