using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02.BL
{
    public class Customer
    {
        public Customer(string name, string address, string contact)
        {
            this.name = name;
            this.address = address;
            this.contact = contact;
            Products = new List<Product>();
        }

        public string name;
        public string address;
        public string contact;
        public List<Product> Products;

        public List<Product> GetProducts()
        {
            return Products;
        }
        public void AddProduct(Product P)
        {
            Products.Add(P);
        }
        public float GetInvoice()
        {
            float total = 0;
            foreach (var P in Products)
            {
                total = total + P.price;
            }
            return total;
        }
    }
}
