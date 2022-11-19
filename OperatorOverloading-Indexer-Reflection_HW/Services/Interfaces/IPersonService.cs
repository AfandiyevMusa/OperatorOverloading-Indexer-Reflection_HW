using System;
using OperatorOverloading_Indexer_Reflection_HW.Models;

namespace OperatorOverloading_Indexer_Reflection_HW.Services.Interfaces
{
	public interface IPersonService
	{
		public List<string> GetFullInfo(Predicate<Person> predicate);
	}
}

