using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_04.BL;

namespace Problem_04.DL
{
    class ShapeDL
    {
        public static List<Shape> S = new List<Shape>();

        public static void AddinList(Shape a)
        {
            S.Add(a);
        }
    }
}
