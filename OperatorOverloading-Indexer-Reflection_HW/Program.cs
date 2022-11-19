

using System.Reflection;
using OperatorOverloading_Indexer_Reflection_HW.Controller;
using OperatorOverloading_Indexer_Reflection_HW.Models;
using OperatorOverloading_Indexer_Reflection_HW.Services;

#region Task_2
//PersonController person = new PersonController();
//person.FilteredDatas();
#endregion

#region Task_3
//BookController book = new BookController();
//book.GetCount();
#endregion

#region Task_4
//EmployeeController employee = new EmployeeController();
//employee.GetFilteredAverage();
#endregion

#region Task
//static Book GetBook()
//{
//    Book book = new Book() { BookName = "Book1", Author = "Nizami"};
//    return book;
//}

//Console.WriteLine(GetBook());
#endregion

#region ClassTask
//StudentController studentController = new StudentController();
//studentController.GetResult();
#endregion

#region Task
//Person person1 = new();
//person1.Age = 18;
//Person person2 = new();
//person2.Age = 20;

//Console.WriteLine(person1 > person2);
#endregion

//List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
//Console.WriteLine(nums[1]);

//Book book = new Book() { BookName = "Book1", Author = "Nizami" };
//Library library = new();
//library.Books[0] = book;
//var res = library.Books[0];
//Console.WriteLine(res.BookName + " " + res.Author);

//Book book = new Book() { BookName = "Book1", Author = "Nizami" };
//Library library = new();
//library.Books[0] = book;
//Console.WriteLine(library.Books[0].BookName);
//Console.WriteLine(library.Books[0].Author);

//Book book1 = new Book() { BookName = "Book1", Author = "Nizami" };
//Book book2 = new Book() { BookName = "Book2", Author = "Elchin" };
//Book book3 = new Book() { BookName = "Book3", Author = "Anar" };

//Library library = new();
//library[0] = book1;
//library[1] = book2;
//library[2] = book3;

//Console.WriteLine(library[0].BookName + " " + library[0].Author);
//Console.WriteLine(library[1].BookName + " " + library[1].Author);
//Console.WriteLine(library[2].BookName + " " + library[2].Author);

#region Reflection
//Assembly assembly = Assembly.GetExecutingAssembly();

//foreach (var item in assembly.GetTypes())
//{
//    Console.WriteLine(item);
//}

//foreach (var item2 in assembly.GetTypes())
//{
//    foreach (var item3 in item2.GetMembers())
//    {
//        Console.WriteLine(item3);
//    }
//}
#endregion

#region HW_Task2
LibraryService library = new LibraryService();
library.GetNames();
#endregion