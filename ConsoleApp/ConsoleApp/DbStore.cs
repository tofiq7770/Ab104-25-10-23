using ConsoleApp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class DbStore
    {
        List<Book> books = new List<Book>();

        private List<Book> ReadFromDb()
        {
            string result1;
            StreamReader sr = new StreamReader(@"C:\\Users\\ca.r214.10\\Desktop\\Taskhere\\ConsoleApp\\ConsoleApp\\Files\\books.json");
            result1 = sr.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Book>>(result1);
        }
        public void WriteToDb(List<Book> books)
        {
            StreamWriter sw = new StreamWriter(@"C:\\Users\\ca.r214.10\\Desktop\\Taskhere\\ConsoleApp\\ConsoleApp\\Files\\books.json");
            sw.Write(books);
            Console.WriteLine(JsonConvert.SerializeObject(books));

        }
        public DbStore(List<Book> books)
        {
           File.Create(@"C:\Users\ca.r214.10\Desktop\Taskhere\ConsoleApp\ConsoleApp\Files\books.json");
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            WriteToDb(Book);
        }
        public void AddRange(List<Book> books)
        {
            books.AddRange(books);
        }
        public void Remove(string id)
        {
            foreach (Book book in books)
            {
                if (id == book.Id)
                {
                    books.Remove(book);
                }
            }
        }

        public void Update(string id)
        {
            foreach (Book book in books)
            {
                if (id == book.Id)
                {
                    Console.WriteLine("Enter new Name: ");
                    book.Name = Console.ReadLine();
                    Console.WriteLine("Enter new Author: ");
                    book.Author = Console.ReadLine();

                    Console.WriteLine("Enter new Year: ");
                    book.Year = int.Parse(Console.ReadLine());
                }
            }
        }
        public void ShowBooks(string id)
        {
            foreach (Book book in books)
            {
                if (id == book.Id)
                {
                    Console.WriteLine($"Name: {book.Name} Author: {book.Author} Year: {book.Year}");
                }
            }
        }
        public void ShowAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Name: {book.Name} Author: {book.Author} Year: {book.Year}");

            }
        }
    }
}

//List<Book> books = new List<Book>()
//        {
//            new Book("book1","author1",2001),
//            new Book("book2","author2",2002),
//            new Book("book3","author3",2003),
//            new Book("book4","author4",2004)
//        };
