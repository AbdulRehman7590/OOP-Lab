using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Challenge02.BL;
using Challenge02.DL;
namespace Challenge02.UL
{
    public class Display
    {
        public static int Login()
        {
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Enter Your Option: ");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
        public static MUser SignIn()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            MUser U = new MUser(username, password);
            return U;
        }
        public static void NotFound()
        {
            Console.WriteLine("User Not Found Sign Up First");
        }
        public static MUser SignUp()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            MUser U = new MUser(username, password);
            return U;
        }
        public static int Admin()
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Product with Highest Unit Price");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Products to be Ordered");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Enter Your Option: ");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
        public static Product AddProduct()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Category: ");
            string category = Console.ReadLine();
            Console.Write("Price: ");
            float price = float.Parse(Console.ReadLine());
            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine());
            Console.Write("Low Stock: ");
            int lowStock = int.Parse(Console.ReadLine());
            Product P = new Product(name, category, price, stock, lowStock);
            return P;
        }
        public static void PrintHead(string huh)
        {
            Console.WriteLine("Name".PadRight(15) + "Category".PadRight(15) + "Price".PadRight(15) + "Stock".PadRight(15) + huh.PadRight(15));
            Console.WriteLine();
        }

        public static void ViewProduct(Product i)
        {
            Console.WriteLine(i.name.PadRight(15) + i.category.PadRight(15) + i.price.ToString().PadRight(15) + i.stock.ToString().PadRight(15) + i.stockLow.ToString().PadRight(15));
        }
        public static void Tax()
        {
            foreach (var i in ProductCRUD.products)
            {
                float tax = i.TaxCalculate();
                Console.WriteLine(i.name.PadRight(15) + i.category.PadRight(15) + i.price.ToString().PadRight(15) + i.stock.ToString().PadRight(15) + tax.ToString().PadRight(15));
            }
        }
        public static void OrderToBe()
        {
            bool flag = true;
            foreach (var i in ProductCRUD.products)
            {
                if (i.stock < i.stockLow)
                {
                    Console.Write("Products Having Low Stock: ");
                    Console.WriteLine("Name: " + i.name + "--- Stock: " + i.stock);
                    flag = false;
                }

            }
            if (flag == true)
            {
                Console.WriteLine("None of the Products having Low Stock");
            }
        }
        public static int Customer()
        {
            Console.WriteLine("1.View all the products");
            Console.WriteLine("2.Buy the products");
            Console.WriteLine("3.Generate invoice");
            Console.WriteLine("4.Exit");
            Console.WriteLine();
            Console.Write("Enter Your Option: ");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
        public static void WrongInput()
        {
            Console.WriteLine("Wrong Input.. Try Again");
            Thread.Sleep(300);
        }
        public static void Clear()
        {
            Console.Clear();
        }
        public static void AnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("Press any Key for Back");
            Console.ReadKey();
        }
    }
}
