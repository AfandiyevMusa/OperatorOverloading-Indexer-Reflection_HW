using System;
namespace OperatorOverloading_Indexer_Reflection_HW.Models
{
	public class Library
	{
		public int ID { get; set; }
		public string? Name { get; set; }
		public Book[]? Books { get; set; }

		public Library(int size = 100)
		{
			Books = new Book[size];
		}

		public Book this[int index]
		{
			get
			{
				return Books[index];
			}

			set
			{
				Books[index] = value;
			}
		}
	}
}

