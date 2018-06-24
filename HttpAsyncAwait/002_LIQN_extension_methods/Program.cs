using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_LIQN_extension_methods
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //База данных сотрудников
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Salary = 94000,
                    StartDate = DateTime.Parse("1/4/1992")
                },
                new Employee
                {
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Salary = 123000,
                    StartDate = DateTime.Parse("12/3/1985")
                },
                new Employee
                {
                    FirstName = "Andrew",
                    LastName = "Andreev",
                    Salary = 1000000,
                    StartDate = DateTime.Parse("1/12/2005")
                }
            };

            //Выражение запроса
            var query = //query - переменная запроса
                employees.Where(employee => employee.Salary > 100000) //навестин на метод Where и надать F12
                    .OrderBy(employee => employee.LastName)
                    .ThenBy(employee => employee.FirstName)
                    .Select(employee => new //select - Операция проекции
                    {
                        LastName = employee.LastName, //можно навести на имя и выбрать "Convert LINQ to method chain"
                        FirstName = employee.FirstName
                    });
            Console.WriteLine("Высокооплачиваемые сотрудники: ");
            //Навести на query ниже и там будет "Anonymous Types"
            foreach (var item in query) //query - переменная запроса, item - переменная итерации
            {
                Console.WriteLine($"{item.LastName}, {item.FirstName}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
