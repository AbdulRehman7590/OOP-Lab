using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03.BL
{
    class Product
    {
        public string name;
        public string category;
        public int price;

        public float CalculateTax()
        {
            return (price * 5.0F/ 100);
        }
    }
}
