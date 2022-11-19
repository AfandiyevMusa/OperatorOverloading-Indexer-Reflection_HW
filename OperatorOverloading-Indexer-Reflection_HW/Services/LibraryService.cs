using System;
using OperatorOverloading_Indexer_Reflection_HW.Models;
using OperatorOverloading_Indexer_Reflection_HW.Services.Interfaces;

namespace OperatorOverloading_Indexer_Reflection_HW.Services
{
    public class LibraryService : ILibraryService
    {
        public void GetNames()
        {
            var data = GetAll();

            foreach (var item in data)
            {
                //Console.WriteLine(item.Name);
                foreach (var item2 in item.Name)
                {
                    Console.WriteLine(item2);
                }
            }
        }

        private List<Library> GetAll()
        {
            Library book1 = new Library()
            {
                Name = "Book1"
            };

            Library book2 = new Library()
            {
                Name = "Book2"
            };

            Library book3 = new Library()
            {
                Name = "Book3"
            };

            Library book4 = new Library()
            {
                Name = "Book4"
            };

            Library book5 = new Library()
            {
                Name = "Book5"
            };

            List<Library> books = new() { book1, book2, book3, book4, book5};

            return books;
        }
    }
}

