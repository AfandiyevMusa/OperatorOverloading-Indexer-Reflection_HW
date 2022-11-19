using System;
using OperatorOverloading_Indexer_Reflection_HW.Models;
using OperatorOverloading_Indexer_Reflection_HW.Services.Interfaces;

namespace OperatorOverloading_Indexer_Reflection_HW.Services
{
    public class PersonService : IPersonService
    {
        public List<string> GetFullInfo(Predicate<Person> predicate)
        {
            var allData = GetAllInfo();

            var res = allData.FindAll(predicate);
            return GetPeopleDetails(res);
        }

        private List<Person> GetAllInfo()
        {
            Person person1 = new()
            {
                Name = "Elchin",
                Surname = "Muradov",
                Address = "Neftchiler",
                Salary = 500
            };

            Person person2 = new()
            {
                Name = "Anar",
                Surname = "Ekberov",
                Address = "Genclik",
                Salary = 5000
            };

            Person person3 = new()
            {
                Name = "Remzi",
                Surname = "Aliyev",
                Address = "Xalqlar",
                Salary = 900
            };

            Person person4 = new()
            {
                Name = "Farid",
                Surname = "Ahmadli",
                Address = "Yasamal",
                Salary = 3000
            };

            Person person5 = new()
            {
                Name = "Cavad",
                Surname = "Heyderov",
                Address = "Nerimanov",
                Salary = 1000
            };

            List<Person> people = new List<Person>() { person1, person2, person3, person4, person5 };

            return people;
        }

        private List<string> GetPeopleDetails(List<Person> people)
        {
            List<string> fulldata = new();

            foreach (var item in people)
            {
                string data = $"{item.Name} + {item.Surname} + {item.Address}";
                fulldata.Add(data);
            }

            return fulldata;
        }
    }
}

