using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2.BL;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StoreData> data = new List<StoreData>();
            int option;
            do
            {
                option = Menu();
                if (option == 1)
                {
                    AddProduct(data);
                }
                else if (option == 2)
                {
                    ViewProduct(data);
                }
                else if (option == 3)
                {
                    HighPrice(data);
                }
                else if (option == 4)
                {
                    SaleTax(data);
                }
                else if (option == 5)
                {
                    LowStock(data);
                }
                else if (option == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                    Console.Read();
                }
                
            }
            while (true);
        }

        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. View all products");
            Console.WriteLine("3. Highest price product");
            Console.WriteLine("4. View sales tax of all products");
            Console.WriteLine("5. Products to be ordered");
            Console.WriteLine("6. Exit");
            Console.WriteLine(" ");
            Console.Write("Select option : ");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }

        static void AddProduct(List<StoreData> data)
        {
            Console.Clear();

            StoreData s = new StoreData();

            Console.Write("Enter name of the product : ");
            s.productName = Console.ReadLine();

            Console.Write("Enter category of product : ");
            s.category = Console.ReadLine();

            Console.Write("Enter price of the product : ");
            s.price = float.Parse(Console.ReadLine());

            Console.Write("Enter quantity of product : ");
            s.quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter minimum quantity : ");
            s.minimumQuantity = int.Parse(Console.ReadLine());

            data.Add(s);

            Console.WriteLine("Product added !!!");
            Console.Read();
        }

        static void ViewProduct(List<StoreData> data)
        {
            Console.Clear();
            Console.WriteLine("Name".PadRight(15) + "Category".PadRight(15) + "Price".PadRight(15) + "Quantity".PadRight(15));
            Console.WriteLine();

            foreach (var i in data)
            {
                float tax = i.TaxCalculate();
                Console.WriteLine(i.productName.PadRight(15) + i.category.PadRight(15) + (i.price.ToString()).PadRight(15) + (i.quantity.ToString()).PadRight(15));
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key for Back");
            Console.ReadKey();
        }

        static void HighPrice(List<StoreData> data)
        {
            Console.Clear();
            string hName = "";
            string hCategory = "";
            float hPrice = 0;
            int hQuantity = 0;
            foreach (var i in data)
            {
                if ( hPrice < i.price)
                {
                    hName = i.productName;
                    hCategory = i.category;
                    hPrice = i.price;
                    hQuantity = i.quantity;
                }
            }

            Console.WriteLine("Name \t\t Category \t\t Price \t\t Quantity");
            Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3}", hName, hCategory, hPrice, hQuantity);
            Console.WriteLine(" ");
            Console.Read();
        }

        static void SaleTax(List<StoreData> data)
        {
            Console.Clear();
            Console.WriteLine("Name".PadRight(15) + "Category".PadRight(15) + "Price".PadRight(15) + "Tax".PadRight(15));
            Console.WriteLine();
            float tax;
            foreach (var i in data)
            {
                tax = i.TaxCalculate();
                Console.WriteLine(i.productName.PadRight(15) + i.category.PadRight(15) + (i.price.ToString()).PadRight(15) + (tax.ToString()).PadRight(15));
            }
            Console.WriteLine();
            Console.WriteLine("Press Any Key for Back");
            Console.ReadKey();
        }

        static void LowStock(List<StoreData> data)
        {
            Console.Clear();
            bool flag = true;
            foreach (var i in data)
            {
                if (i.quantity < i.minimumQuantity)
                {
                    Console.Write("Products Having Low Stock: ");
                    Console.WriteLine("Name: " + i.productName + "--- Stock: " + i.quantity);
                    flag = false;
                }

            }
            if (flag == true)
            {
                Console.WriteLine("None of the Products having Low Stock");
            }

            Console.WriteLine();

            Console.WriteLine("Press Any Key for Back");
            Console.ReadKey();
        }


    }
}
