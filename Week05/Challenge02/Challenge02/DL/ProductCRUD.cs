using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge02.BL;

namespace Challenge02.DL
{
    class ProductCRUD
    {
        public static List<Product> products = new List<Product>();
        public static void ProductToList(Product P)
        {
            products.Add(P);
        }
        public static Product PrintHighPrice()
        {
            Product HProduct = null;
            float price = -1f;
            foreach (var P in products)
            {
                if (price <= P.price)
                {
                    HProduct = P;
                }
            }
            return HProduct;
        }
    }
}
