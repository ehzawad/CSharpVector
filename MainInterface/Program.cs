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
            // BOOK

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


            //Book dummy = new Book();
            //dummy.ShowInfo();

            devOps.AddBookCopy(4);
            devOps.ShowInfo();

            Book.ShowTotalBookInfo();

            // CONTACT
            //Contact hafezul = new Contact("Hafezul Talukder", "42225", 17, "017XXXX", 'M');
            //hafezul.DetectMobileOperator();
            //hafezul.ShowPersonInfo();

            // ACCOUNT
            //    Account a = new Account();
            //    Console.WriteLine("Input Account Info:\n" + "Account Name: ");
            //    a.AccName = Console.ReadLine();
            //    Console.WriteLine("AccId:");
            //    a.Acid = Console.ReadLine();
            //    Console.WriteLine("Balance:");
            //    a.Balance = Convert.ToDouble(Console.ReadLine());

            //    //enter deposit amount
            //    Console.WriteLine("Enter deposit amount: ");
            //    a.Deposit(Convert.ToDouble(Console.ReadLine()));

            //    Console.WriteLine("Enter Withdraw Amount");
            //    a.WithDraw(Convert.ToDouble(Console.ReadLine()));

            //    Console.WriteLine("Your Bank Account Info" + "\nName:" + a.AccName + "\nId: " + a.Acid + "\nBalance: " + a.Balance);

            //    Console.WriteLine("Enter amount you want to transfer: ");
            //    double transferAmount = Convert.ToDouble(Console.ReadLine());
            //    a.Transfer(transferAmount, new Account("Sohan", "15-30111-2", 0.000));
            //    Console.WriteLine("Your Bank Account Info" + "\nName:" + a.AccName + "\nId: " + a.Acid + "\nBalance: " + a.Balance);
            //}
        }
    }
}
