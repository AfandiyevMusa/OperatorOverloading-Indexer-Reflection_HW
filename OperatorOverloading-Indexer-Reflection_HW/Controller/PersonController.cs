using System;
using OperatorOverloading_Indexer_Reflection_HW.Services;

namespace OperatorOverloading_Indexer_Reflection_HW.Controller
{
	public class PersonController
	{
		public void FilteredDatas()
		{
			PersonService personService = new PersonService();

			var res = personService.GetFullInfo(m => m.Salary > 1000);

			foreach (var item in res)
			{
				Console.WriteLine(item);
			}
		}
	}
}

