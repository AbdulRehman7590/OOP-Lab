using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03.BL
{
    class Customer
    {
        public string name;
        public string addresss;
        public string contact;
        public List<Product> products = new List<Product>();

        public void AddProduct(Product P)
        {
            products.Add(P);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public float CalculateTax() 
        {
            float m = 0.0F;
            foreach (var x in products)
            {
                m += x.CalculateTax();
            }
            return m;
        }
    }
}
