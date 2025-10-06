using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Library
{
    internal class Book
    {
        string Title;
        string Author;
        string ISBN;

        void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Create a new instance (object) of the Book class
            // Note how the object name differs from the class name
            Book myBook1 = new Book();

            // This information is for one book in our library
            myBook1.Title = "C# for beginners";
            myBook1.Author = "Bill Gates";
            myBook1.ISBN = "1234";

            // This is another book object.
            // Note that the object name is 'book1' and not 'book'
            Book myBook2 = new Book();
            myBook2.Title = "C# methods";
            myBook2.Author = "Microsoft";
            myBook2.ISBN = "3456778";

            // Output book information to the console
            myBook1.DisplayInfo();
            myBook2.DisplayInfo();

        }

    }
}
