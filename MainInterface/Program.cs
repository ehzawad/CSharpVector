using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CategoryOfObjects;

namespace MainInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Cool");

            Book csharpBook = new Book("C#", "Microsoft", "101", "Language", 5);
            csharpBook.ShowInfo();

            Book javaBook = new Book("Java By Gosling", "Oracle", "102", "Language", 2);
            javaBook.AddBookCopy(2);
            javaBook.ShowInfo();

            Book devOps = new Book()
            {
                BookName = "Learn Vim",
                BookAuthor = "Bram",
                BookId = "103",
                BookType = " Software development",
                BookCopy = 2
            };


            Book dummy = new Book();
            dummy.ShowInfo();

            devOps.AddBookCopy(4);
            devOps.ShowInfo();

            Book.ShowTotalBookInfo();

        }
    }
}
