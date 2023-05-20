using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge02.DL;

namespace Challenge02.BL
{
    public class Product
    {
        public Product(string name, string category, float price, int stock, int stockLow)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stock = stock;
            this.stockLow = stockLow;
        }

        public string name;
        public string category;
        public float price;
        public int stock;
        public int stockLow;

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
