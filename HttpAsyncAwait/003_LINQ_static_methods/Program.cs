using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_LINQ_static_methods
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
                Enumerable.Select( //представитель операции проекции
                    Enumerable.ThenBy(
                        Enumerable.OrderBy(
                            Enumerable.Where(
                                employees, employee => employee.Salary > 100000),
                            employee => employee.LastName),
                        employee => employee.FirstName),
                    employee => new { LastName = employee.LastName, FirstName = employee.FirstName }); //имена такие же как и свойства нету смысла давать

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
