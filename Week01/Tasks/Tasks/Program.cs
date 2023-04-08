using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task01();
            Task02();
            Task03();
            Task04();
            Task05();
            Task06();
            Task07();
            Task08();
            Task09();
            Task10();
            Task11();
            Task12();
            Task13();
            Task14();
            Task15();*/
        }

        static void Task01()
        {
            Console.WriteLine("Hello World! ");
            Console.WriteLine("Hello World! ");
            Console.Read();
        }

        static void Task02()
        {
            int variable = 7;
            Console.WriteLine("Value is : ");
            Console.WriteLine(variable);
            Console.Read();
        }

        static void Task03()
        {
            float variable = 77.67F;
            Console.WriteLine("Value is : ");
            Console.WriteLine(variable);
            Console.Read();
        }

        static void Task04()
        {
            int variable = 0;
            Console.WriteLine("Write the value : ");
            variable = int.Parse(Console.ReadLine());
            Console.WriteLine("Value is : ");
            Console.WriteLine(variable);
            Console.Read();
        }

        static void Task05()
        {
            int length = 0, area = 0;
            Console.Write("Enter The Length = ");
            length = int.Parse(Console.ReadLine());
            area = length * length;
            Console.Write("The Area is : " + (area));
            Console.Read();
        }

        static void Task06()
        {
            int marks = 0;
            Console.Write("Enter your marks = ");
            marks = int.Parse(Console.ReadLine());
            if (marks > 50)
            {
                Console.WriteLine("Your are passed ");
            }
            else
            {
                Console.WriteLine("You are failed ");
            }
            Console.Read();
        }

        static void Task07()
        {
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Welcome Jack ");
            }
            Console.Read();
        }

        static void Task08()
        {
            int num = 0, sum = 0;
            Console.WriteLine("Enter the number = ");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                sum = sum + num;
                Console.Write("Enter the number = ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The total is {0} : ", sum);
            Console.Read();
        }

        static void Task09()
        {
            int num = 0, sum = 0;
            do
            {
                sum = sum + num;
                Console.WriteLine("Enter number : ");
                num = int.Parse(Console.ReadLine());
            }
            while (num != -1);
            Console.WriteLine("The sum is {0} : ", sum);
            Console.Read();
        }

        static void Task10()
        {
            int[] array = new int[3];
            for (int idx = 0; idx < 3; idx++)
            {
                Console.Write("Enter the number {0} : ", idx);
                array[idx] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            for (int idx = 0; idx < 3; idx++)
            {
                if (array[idx] > largest)
                {
                    largest = array[idx];
                }
            }
            Console.WriteLine("The largest number is {0}:", largest);
            Console.Read();
        }

        static void Task11()
        {
            int num1 = 0, num2 = 0;
            Console.Write("Enter 1st number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            num2 = int.Parse(Console.ReadLine());
            int result = Add(num1, num2);
            Console.WriteLine("The sum is {0}: ", result);
            Console.ReadKey();
        }
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static void Task12()
        {
            StreamWriter fileVariable = new StreamWriter("Textfile.txt", true);
            fileVariable.WriteLine("Hello! Orewa Namikaze Minato");
            fileVariable.Flush();
            fileVariable.Close();
        }

        static void Task13()
        {
            int age = 0, evenAge = 0, oddAge = 0;
            Console.Write("Enter Lily's age : ");
            age = int.Parse(Console.ReadLine());
            if (age % 2 == 0)
            {
                evenAge = age / 2;
                oddAge = evenAge;
            }
            else
            {
                age = age - 1;
                evenAge = age / 2;
                oddAge = evenAge + 1;
            }
            int toysReceived = oddAge;
            int moneyReceived = 0;
            for (int x = 1; x <= evenAge; x++)
            {
                moneyReceived = (moneyReceived + (10 * x)) - 1;
            }
            
            Console.Write("Enter washing machine price : ");
            int machinePrice = int.Parse(Console.ReadLine());
            
            Console.Write("Enter toys sold price : ");
            
            int sellPrice = int.Parse(Console.ReadLine());
            int price = toysReceived * sellPrice;
            int amount = moneyReceived + price;
            
            if (amount > machinePrice)
            {
                Console.Write("Yes! the remaining are ");
                Console.Write(amount - machinePrice);
                Console.Write(" dollars");
            }
            else
            {
                Console.Write("No! She needs ");
                Console.Write(machinePrice - amount);
                Console.Write(" dollars");
            }
            Console.Read();
        }

        static void Task14()
        {
            string path = "D:\\2nd semester\\OOP\\Lab\\Week01\\Tasks\\Tasks\\TextFiles\\";
            string[] names = new string[5];
            string[] password = new string[5];
            int option;
            do
            {
                ReadData(path, names, password);
                Console.Clear();
                option = Menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter new Name : ");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter new passwword : ");
                    string Pass = Console.ReadLine();
                    SignUp(path, Name, Pass);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter Name : ");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter password : ");
                    string Pass = Console.ReadLine();
                    SignIn(Name, Pass, names, password);
                }
            }
            while (option < 3);
            Console.Read();
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("1. Sign Up ");
            Console.WriteLine("2. Sign In ");
            Console.WriteLine("3. Exit ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }

            }
            return item;
        }
        static void ReadData(string path, string[] names, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                string textname = "SignUp.txt";
                StreamReader myFile = new StreamReader(path+textname);
                string record;
                while (!(myFile.EndOfStream))
                {
                    record = myFile.ReadLine();
                    if (record != "")
                    {
                        names[x] = ParseData(record, 1);
                        password[x] = ParseData(record, 2);
                        x++;
                        if (x >= 5)
                        {
                            break;
                        }
                    }
                }
                myFile.Close();
            }
            else
            {
                Console.WriteLine("File does not exists ");
            }
        }
        static void SignIn(string Name, string Pass, string[] names, string[] password)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if (Name == names[x] && Pass == password[x])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
        static void SignUp(string path, string Name, string Pass)
        {
            string textname = "SignUp.txt";
            StreamWriter myFile = new StreamWriter(path+textname, true);
            myFile.WriteLine(Name + "," + Pass);
            myFile.Flush();
            myFile.Close();
        }


        static void Task15()
        {
            Console.Write("Enter the number of orders : ");
            int orderInput = int.Parse(Console.ReadLine());
            Console.Write("Enter the price : ");
            int price = int.Parse(Console.ReadLine());

            string name;
            int totalOrders;
            string priceArray;
            string path = "D:\\2nd semester\\OOP\\Lab\\Week01\\Tasks\\Tasks\\TextFiles\\Data.txt";
            if (File.Exists(path))
            {
                StreamReader myFile = new StreamReader(path);
                string record;
                while (!(myFile.EndOfStream))
                {
                    record = myFile.ReadLine();
                    if (record != "")
                    {
                        string[] aplitarray = record.Split(' ');
                        name = aplitarray[0];
                        totalOrders = int.Parse(aplitarray[1]);
                        priceArray = aplitarray[2];
                        if (Calculation(priceArray, price, orderInput))
                        {
                            Console.WriteLine(name);
                        }
                    }
                }
                Console.Read();
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

        }
        static bool Calculation(string array, int price, int order)
        {
            bool flag = false;
            int counter = 0;
            string[] splitarr = array.Split(',');
            for (int x = 1; x < splitarr.Length - 1; x++)
            {
                if (price <= int.Parse(splitarr[x]))
                {
                    counter++;
                }
            }
            if (counter >= order)
            {
                flag = true;
            }
            return flag;
        }

    }
}
