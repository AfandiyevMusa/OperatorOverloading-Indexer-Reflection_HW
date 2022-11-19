using System;
namespace OperatorOverloading_Indexer_Reflection_HW.Models
{
	public class Person
	{
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? Address { get; set; }
		public double Salary { get; set; }
		public int Age { get; set; }

		public static bool operator > (Person a, Person b)
		{
			return a.Age > b.Age;
		}

        public static bool operator < (Person a, Person b)
        {
            return a.Age < b.Age;
        }
    }
}

