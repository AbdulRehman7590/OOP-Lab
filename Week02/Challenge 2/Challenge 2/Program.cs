using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge_2.BL;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Credentials[] data = new Credentials[10];
            int count = 0;
            char option;
            do
            {
                option = Menu();
                if (option == '1')
                {
                    data[count] = SignUp();
                    count++;
                }
                else if (option == '2')
                {
                    SignIn(data, count);
                }
                else if (option == '3')
                {
                    break;
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Invaid Option !");
                }
            }
            while (true);

            Console.WriteLine(" ");
            Console.WriteLine("Press any key to Exit..");
            Console.ReadKey();
        }

        static char Menu()
        {
            Console.Clear();
            char option;
            Console.WriteLine("Press 1 to Sign Up");
            Console.WriteLine("Press 2 to Sign In");
            Console.WriteLine("Press 3 to Exit");
            Console.WriteLine(" ");
            Console.Write("Select Option : ");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static Credentials SignUp()
        {
            Console.Clear();
            Credentials data1 = new Credentials();
            Console.Write("Enter the UserName : ");
            data1.userName = Console.ReadLine();
            Console.Write("Enter the password : ");
            data1.password = Console.ReadLine();
            return data1;
        }

        static void SignIn(Credentials[] data, int count)
        {
            Console.Clear();
            string name, pass;
            bool flag = false;
            Console.Write("Enter the Username : ");
            name = Console.ReadLine();
            Console.Write("Enter the password : ");
            pass = Console.ReadLine();

            for (int x = 0; x < count; x++)
            {
                if (data[x].userName == name && data[x].password == pass)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Invalid User");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }


    }
}
