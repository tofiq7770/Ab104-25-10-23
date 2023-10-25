using Newtonsoft.Json;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new();
            DbStore dbStore = new DbStore(books);
            Book book = new ("book1","author1",2001);
            dbStore.AddBook(book);
            dbStore.ShowAllBooks();

        }
    }
}