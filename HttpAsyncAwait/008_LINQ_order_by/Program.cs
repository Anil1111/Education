using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_LINQ_order_by
{
    //orderBy - используется для сортировки (последовательности) результата запроса.
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Строим коллекцию сотрудников с национальностями.
            var employees = new List<Employee>
            {
                new Employee{FirstName = "Ivanov", LastName ="Ivan",Nationality = "Russian"},
                new Employee{FirstName = "Andreev", LastName ="Andrew",Nationality = "Ukrainian"},
                new Employee{FirstName = "Petrov", LastName ="Petr",Nationality = "American"}
            };
            //Строим запрос
            //Получение списка имен всех сотрудников вместе с их национальностями.
            var query = from employee in employees
                        orderby employee.Nationality ascending, //по умолчанию
                            employee.LastName descending, //ascending - по возрастанию | descending - по убыванию.
                            employee.FirstName descending
                        select employee;

            var query2 = employees.OrderBy(employee => employee.Nationality)
                .ThenByDescending(employee => employee.LastName)
                .ThenByDescending(employee => employee.FirstName); //тут без Select`a т.к он здесь не нужен.

            foreach (var person in query)
            {
                Console.WriteLine($"{person.LastName}, \t{person.FirstName}, \t{person.Nationality}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
