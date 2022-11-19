using System;
using OperatorOverloading_Indexer_Reflection_HW.Models;
using OperatorOverloading_Indexer_Reflection_HW.Services.Interfaces;

namespace OperatorOverloading_Indexer_Reflection_HW.Services
{
    public class EmployeeService : IEmployeeService
    {
        public double GetAverage(Predicate<Employee> predicate)
        {
            var datas = GetAllInfo();

            var res = datas.FindAll(predicate).Average(m=>m.Age);
            return res;
        }

        private List<Employee> GetAllInfo()
        {
            Employee employee1 = new Employee()
            {
                FullName = "Elchin Muradov",
                Age = 50
            };

            Employee employee2 = new Employee()
            {
                FullName = "Anar Ekberov",
                Age = 30
            };

            Employee employee3 = new Employee()
            {
                FullName = "Farid Ahmadli",
                Age = 24
            };

            List<Employee> employees = new() { employee1, employee2, employee3 };

            return employees;
        }
    }
}

