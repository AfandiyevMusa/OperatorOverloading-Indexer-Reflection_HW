using System;
using OperatorOverloading_Indexer_Reflection_HW.Models;
using OperatorOverloading_Indexer_Reflection_HW.Services.Interfaces;

namespace OperatorOverloading_Indexer_Reflection_HW.Services
{
    public class BookService : IBookService
    {
        public int GetTheNumberOfBook(Predicate<Book> predicate)
        {
            var data = GetBooksInfo();
            var res = data.FindAll(predicate).Count;
            return res;
        }

        private List<Book> GetBooksInfo()
        {
            Book book1 = new()
            {
                BookName = "Book1",
                Author = "Nizami"
            };

            Book book2 = new()
            {
                BookName = "Book2",
                Author = "Anar"
            };

            Book book3 = new()
            {
                BookName = "Book3",
                Author = "Nizami"
            };

            Book book4 = new()
            {
                BookName = "Book4",
                Author = "Elchin"
            };

            Book book5 = new()
            {
                BookName = "Book5",
                Author = "Nizami"
            };

            List<Book> books = new() { book1, book2, book3, book4, book5 };
            return books;
        }
    }

}

