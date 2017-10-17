using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryOfObjects
{
    public class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;

        // static members
        static int bookCounter;


        public Book()
        {
            bookCounter++;
        }

        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
            // https://stackoverflow.com/questions/29733515/how-count-number-of-objects-created-with-a-static-class-variable
            // this is anecdotal to C# locking mechanism, don't know the details
            // use bookCounter++ for simplicity
            // Interlocked.Increment(ref bookCounter);
            bookCounter++;

        }

        public string BookName
        {
            set => this.bookName = value;
            get => this.bookName;
        }

        public string BookAuthor
        {
            set => this.bookAuthor = value;
            get => this.bookAuthor;
        }

        public string BookId
        {
            set => this.bookId = value;
            get => this.bookId;
        }

        public string BookType
        {
            set => this.bookType = value;
            get => this.bookType;
        }

        public int BookCopy
        {
            set => this.bookCopy = value;
            get => this.bookCopy;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Info of the Book:");
            Console.WriteLine("BookName: " + this.bookName);
            Console.WriteLine("BookAuthor: " + this.bookAuthor);
            Console.WriteLine("BookId: " + this.bookId);
            Console.WriteLine("BookType: " + this.bookType);
            Console.WriteLine("Number of copies of " + this.bookName + " book: " + this.bookCopy);
            Console.WriteLine("");
        }


        public void AddBookCopy(int x) => this.bookCopy = this.bookCopy + x;

        static Book()
        {
            Console.WriteLine("Welcome to Console Book Application !!! \n");
        }

        public static void ShowTotalBookInfo() => Console.WriteLine("Total Number of book objects {0} !", bookCounter);

    }

}