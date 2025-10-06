using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Library
{
    class Book
    {
        private string title;
        private string author;
        private string isbn;

        public string Title
        {
            get { return title; }  // get method
            set { title = value; } // set method
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {title}");
            Console.WriteLine($"Book Author: {author}");
            Console.WriteLine($"Book ISBN: {isbn}");
            Console.WriteLine();
        }
    }
}
