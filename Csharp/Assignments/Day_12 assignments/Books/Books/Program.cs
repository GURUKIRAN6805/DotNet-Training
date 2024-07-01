using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Books
    {
        private string bookName;
        private string authorName;
        public Books(string bookName, string authorName)
        {
            this.bookName = bookName;
            this.authorName = authorName;
        }
        public void Display()
        {
            Console.WriteLine("Book Name: " + bookName);
            Console.ReadLine();
            Console.WriteLine("Author Name: " + authorName);
            Console.ReadLine();
        }
    }
    public class BookShelf
    {
        private Books[] books = new Books[5];
        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                    return books[index];
                else
                    throw new IndexOutOfRangeException("Index out of range");
            }
            set
            {
                if (index >= 0 && index < books.Length)
                    books[index] = value;
                else
                    throw new IndexOutOfRangeException("Index out of range");
            }
        }
        public void DisplayBooks()
        {
            Console.WriteLine("Books on the Bookshelf:");
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    Console.WriteLine($"Book {i + 1}:");
                    books[i].Display();
                    Console.WriteLine();
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            BookShelf shelf = new BookShelf();
            shelf[0] = new Books("Book1", "Author1");
            shelf[1] = new Books("Book2", "Author2");
            shelf[2] = new Books("Book3", "Author3");
            shelf[3] = new Books("Book4", "Author4");
            shelf[4] = new Books("Book5", "Author5");
            shelf.DisplayBooks();
            Console.ReadLine();
        }
    }
}

