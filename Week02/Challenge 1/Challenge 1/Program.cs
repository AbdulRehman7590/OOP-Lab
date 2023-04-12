using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge_1.NewFolder1;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            products[] items = new products[10];
            char option;
            int count = 0;
            do
            {
                option = Menu();
                if (option == '1')
                {
                    items[count] = AddProduct();
                    count++;
                }
                else if (option == '2')
                {
                    ViewProducts(items, count);
                }
                else if (option == '3')
                {
                    TotalWorth(items, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            while(true);
            Console.WriteLine("Press any key to Exit...");
            Console.Read();
        }
        static char Menu()
        {
            Console.Clear();
            char option;
            Console.WriteLine("Press 1 to add product");
            Console.WriteLine("Press 2 to show product");
            Console.WriteLine("Press 3 to see total store worth");
            Console.WriteLine("Press 4 to Exit");
            Console.WriteLine(" ");
            Console.Write("Select Option : ");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static products AddProduct()
        {
            Console.Clear();
            products item1 = new products();
            Console.Write("Enter the name of the product : ");
            item1.productName = Console.ReadLine();
            Console.Write("Enter the id of the product : ");
            item1.productID = Console.ReadLine();
            Console.Write("Enter the category : ");
            item1.category = Console.ReadLine();
            Console.Write("Enter the price : ");
            item1.price = int.Parse(Console.ReadLine());
            Console.Write("Enter the Brand name : ");
            item1.brandName = Console.ReadLine();
            Console.Write("Enter the country : ");
            item1.country = Console.ReadLine();
            return item1;
        }

        static void ViewProducts(products[] items, int count)
        {
            Console.Clear();
            if (count > 0)
            {
                Console.WriteLine("Product ID".PadRight(20,' ') + "Product Name".PadRight(20, ' ') + "Price".PadRight(20, ' ') + "Category".PadRight(20, ' ') +  "Brand Name".PadRight(20, ' ') + "Country");
                Console.WriteLine(" ");
                for (int x = 0; x < count; x++)
                {
                    Console.WriteLine(items[x].productID.PadRight(20,' ') + items[x].productName.PadRight(20,' ') + items[x].price.ToString().PadRight(20,' ') + items[x].category.PadRight(20,' ') + items[x].brandName.PadRight(20,' ') + items[x].country);
                }
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("NO products found !");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void TotalWorth(products[] items, int count)
        {
            float worth = 0F;
            for (int x = 0; x < count; x++)
            {
                worth = worth + items[x].price;
            }
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("Total worth is : " + worth);
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to Exit...");
            Console.ReadKey();
        }

    }
}
