using System;
using OperatorOverloading_Indexer_Reflection_HW.Models;

namespace OperatorOverloading_Indexer_Reflection_HW.Services.Interfaces
{
	public interface IStudentServices
	{
		public double GetCount(Predicate<Students> predicate);
	}
}

