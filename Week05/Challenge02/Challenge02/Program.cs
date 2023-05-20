using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge02.BL;
using Challenge02.DL;
using Challenge02.UL;
namespace Challenge02
{
    class Program
    {
        static void Main(string[] args)
        {
            MUserCRUD.LoadUsers();
            int opt;
            do
            {
                Display.Clear();
                opt = Display.Login();
                if (opt == 1)
                {
                    Display.Clear();
                    MUser user = Display.SignIn();
                    int choice = user.CheckRole();
                    if (choice == 1)
                    {
                        Display.Clear();
                        Admin();
                        Display.AnyKey();
                    }
                    else if (choice == 2)
                    {
                        Display.Clear();
                        Customer();
                        Display.AnyKey();
                    }
                    else if (choice == 0)
                    {
                        Display.Clear();
                        Display.NotFound();
                        Display.AnyKey();
                    }
                }
                else if (opt == 2)
                {
                    Display.Clear();
                    MUser user = Display.SignUp();
                    MUserCRUD.UserToList(user);
                    MUserCRUD.UserToFile(user);
                    Display.AnyKey();
                }
                if (opt > 3)
                {
                    Display.WrongInput();
                }
            }
            while (opt != 3);
            Display.AnyKey();
        }
        static void Admin()
        {
            int opt;
            do
            {
                Display.Clear();
                opt = Display.Admin();
                if (opt == 1)
                {
                    Display.Clear();
                    Product P = Display.AddProduct();
                    ProductCRUD.ProductToList(P);
                    Display.AnyKey();
                }
                else if (opt == 2)
                {
                    Display.Clear();
                    Display.PrintHead("Low Stock");
                    foreach (var P in ProductCRUD.products)
                    {
                        Display.ViewProduct(P);
                    }
                    Display.AnyKey();
                }
                else if (opt == 3)
                {
                    Display.Clear();
                    Product P = ProductCRUD.PrintHighPrice();
                    Display.PrintHead("Low Stock");
                    Display.ViewProduct(P);
                    Display.AnyKey();
                }
                else if (opt == 4)
                {
                    Display.Clear();
                    Display.PrintHead("Tax");
                    Display.Tax();
                    Display.AnyKey();
                }
                else if (opt == 5)
                {
                    Display.Clear();
                    Display.OrderToBe();
                    Display.AnyKey();
                }
                else if (opt > 6)
                {
                    Display.WrongInput();
                }
            }
            while (opt != 6);
        }
        static void Customer()
        {
            int opt;
            do
            {
                Display.Clear();
                opt = Display.Customer();
                if (opt == 1)
                {
                    Display.Clear();
                    Display.PrintHead("Low Stock");
                    foreach (var P in ProductCRUD.products)
                    {
                        Display.ViewProduct(P);
                    }
                    Display.AnyKey();
                }
                else if (opt == 2)
                {
                    Display.Clear();

                    Display.AnyKey();
                }
                else if (opt == 3)
                {
                    Display.Clear();

                    Display.AnyKey();
                }

                else if (opt > 4)
                {
                    Display.WrongInput();
                }
            }
            while (opt != 4);
        }
    }
}

