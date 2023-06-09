using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.BL
{
    public class Shape
    {
        public virtual string GetType()
        {
            return null;
        }
        
        public virtual double GetArea()
        {
            return 0.0;
        }
    }
}
