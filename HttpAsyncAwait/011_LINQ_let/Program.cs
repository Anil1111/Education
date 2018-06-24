using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_LINQ_let
{
    //let - это ЛОКАЛЬНЫЙ ИДЕНТЕФИКАТОР, на который можно ссылаться в остальной части запроса.
    //Его можно представить как локальную переменную видимую только внутри выражения запроса.
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Построить коллекцию сотрудников
            var employees = new List<Employee>
            {
                new Employee {LastName = "Ivanov", FirstName = "Ivan"},
                new Employee {LastName = "Andreev", FirstName = "Andrew"},
                new Employee {FirstName = "Petrov", LastName = "Petr"}
            };
            //query - переменная запроса, emp переменная диапазона
            var query = from emp in employees
                        let fullName = emp.FirstName + " " + emp.LastName //let - новый локальный идентефикатор.
                        orderby fullName descending
                        select fullName;

            //сначала в новый анонимный тип запихиваем fullName, а потом уже в OrderByDescending и последнем Select работаем с ней.
            var query2 = employees.Select(emp => new { emp, fullName = emp.FirstName + " " + emp.LastName })
                .OrderByDescending(@t => @t.fullName)
                .Select(@t => @t.fullName);
            //person - переменная итерации
            foreach (var person in query)
            {
                Console.WriteLine(person);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
