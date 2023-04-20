using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.BL
{
    class StoreData
    {
        public string productName;
        public string category;
        public float price;
        public int quantity;
        public int minimumQuantity;

        public float TaxCalculate()
        {
            float tax;
            if (category == "grocery")
            {
                tax = (price * 10) / 100F;
            }
            else if (category == "fruit")
            {
                tax = (price * 5) / 100F;
            }
            else
            {
                tax = (price * 15) / 100F;
            }
            return tax;
        }


    }
}
