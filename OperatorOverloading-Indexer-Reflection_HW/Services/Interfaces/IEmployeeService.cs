using System;
using OperatorOverloading_Indexer_Reflection_HW.Models;

namespace OperatorOverloading_Indexer_Reflection_HW.Services.Interfaces
{
	public interface IEmployeeService
	{
        public double GetAverage(Predicate<Employee> predicate);
    }
}

