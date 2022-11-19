using System;
using OperatorOverloading_Indexer_Reflection_HW.Services;

namespace OperatorOverloading_Indexer_Reflection_HW.Controller
{
	public class EmployeeController
	{
		public void GetFilteredAverage()
		{
			EmployeeService employeeService = new EmployeeService();

			Console.WriteLine(employeeService.GetAverage(m => m.Age > 20 && m.Age < 40));
		}
	}
}

