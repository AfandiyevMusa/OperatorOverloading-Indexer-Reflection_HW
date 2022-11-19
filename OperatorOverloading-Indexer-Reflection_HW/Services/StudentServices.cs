using OperatorOverloading_Indexer_Reflection_HW.Models;
using OperatorOverloading_Indexer_Reflection_HW.Services.Interfaces;


namespace OperatorOverloading_Indexer_Reflection_HW.Services
{
	public class StudentServices : IStudentServices
	{
		public double GetCount(Predicate<Students> predicate)
        {
            var datas = GetInfo();

            var res = datas.FindAll(predicate).Count;
            return Math.Pow(res, 2);
        }

        private List<Students> GetInfo()
        {
            Students student1 = new Students()
            {
                Name = "Cabir",
                Age = 28
            };

            Students student2 = new Students()
            {
                Name = "Cabbar",
                Age = 30
            };

            Students student3 = new Students()
            {
                Name = "Cavad",
                Age = 40
            };

            Students student4 = new Students()
            {
                Name = "Murad",
                Age = 45
            };

            Students student5 = new Students()
            {
                Name = "Ali",
                Age = 23
            };

            List<Students> students = new List<Students>() { student1, student2, student3, student4, student5 };

            return students;

        }
    }
}

