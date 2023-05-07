using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.BL
{
    class Book
    {
        public string author;
        public int pages;
        public List<string> chapters = new List<string>();
        public int bookMarks;
        public int price;

        public Book(string author, int pages, List<string> chapters, int bookMarks, int price)
        {
            this.author = author;
            this.pages = pages;
            this.chapters = chapters;
            this.bookMarks = bookMarks;
            this.price = price;
        }

        public string GetChapter(int chapterNumber)
        {
            string name = "Inavlid";
            if (chapters.Count > chapterNumber)
            {
                name = chapters[chapterNumber - 1];
            }
            return name;
        }

        public int GetBookMark()
        {
            return this.bookMarks;
        }

        public void SetBookMark(int pageNumber)
        {
            this.bookMarks = pageNumber;
        }

        public int GetBookPrice()
        {
            return this.price;
        }

        public void SetBookPrice(int newPrice)
        {
            this.price = newPrice;
        }
    }
}
