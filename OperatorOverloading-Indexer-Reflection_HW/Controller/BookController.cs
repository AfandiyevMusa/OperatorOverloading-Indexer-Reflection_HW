using System;
using OperatorOverloading_Indexer_Reflection_HW.Services;

namespace OperatorOverloading_Indexer_Reflection_HW.Controller
{
	public class BookController
	{
		public void GetCount()
		{
			BookService bookService = new BookService();

			Console.WriteLine(bookService.GetTheNumberOfBook(m => m.Author == "Nizami"));
		}
	}
}

