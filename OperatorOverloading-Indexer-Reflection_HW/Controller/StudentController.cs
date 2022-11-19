using System;
using OperatorOverloading_Indexer_Reflection_HW.Services;

namespace OperatorOverloading_Indexer_Reflection_HW.Controller
{
	public class StudentController
	{
		public void GetResult()
		{
            StudentServices students = new StudentServices();
			var res = students.GetCount(m => m.Name.ToLower().StartsWith("C".ToLower()));
			Console.WriteLine(res);
        }

		
	}
}

