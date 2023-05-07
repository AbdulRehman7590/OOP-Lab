using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03.BL;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Product P = new Product();
            P.name = "Choco";
            P.category = "Grocery";
            P.price = 100;

            Product R = new Product();
            R.name = "Apple";
            R.category = "Fruit";
            R.price = 200;

            Product O = new Product();
            O.name = "Anas";
            O.category = "Mix";
            O.price = 10;

            Customer cust1 = new Customer();
            cust1.name = "AR";
            cust1.addresss = "UET";
            cust1.contact = "700009";

            cust1.AddProduct(O);
            cust1.AddProduct(R);
            
            cust1.products = cust1.GetAllProducts();

            foreach(var x in cust1.products)
            {
                Console.WriteLine(x.name + " " + x.price + " " + x.category);
            }

            Console.WriteLine("Total tax is : {0} ", cust1.CalculateTax());

            Console.ReadKey();
        }
    }
}
