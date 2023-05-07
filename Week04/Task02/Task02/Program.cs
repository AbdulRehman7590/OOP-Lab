using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.BL;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chapters = new List<string> {
                "Avengers, The Start",
                "Avengers, Age of ultron",
                "Avengers, Infinity War",
                "Avengers, Endgame"
                };
            Book data = new Book("AR", 300, chapters, 130, 1000);

            Console.WriteLine("Chapter 3 : {0}", data.GetChapter(3));
            
            Console.WriteLine("BookMark : {0}", data.GetBookMark());
            
            data.SetBookMark(200);
            Console.WriteLine("New BookMark : {0}", data.GetBookMark());
            
            Console.WriteLine("Bookprice : {0}", data.GetBookPrice());
            
            data.SetBookPrice(2000);
            Console.WriteLine("New Bookprice : {0}", data.GetBookPrice());
            
            Console.ReadKey();
        }
    }
}
