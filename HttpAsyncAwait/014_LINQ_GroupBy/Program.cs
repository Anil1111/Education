using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_LINQ_GroupBy
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FistName { get; set; }
        public string Nationality { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee{LastName = "Andreev", FistName = "Andrew", Nationality = "Ukrainian"},
                new Employee{LastName = "Ivanov", FistName = "Ivan", Nationality = "Russian"},
                new Employee{LastName = "Andreev", FistName = "Ivan", Nationality = "Ukrainian"},
                new Employee{LastName = "Petrov", FistName = "Petr", Nationality = "American"},
                new Employee{LastName = "Andreev", FistName = "Sergey", Nationality = "Ukrainian"},
                new Employee{LastName = "Petrov", FistName = "Slava", Nationality = "American"},
                new Employee{LastName = "Petrov", FistName = "Eugene", Nationality = "American"}
            };

            //Построить запрос
            var query = from employee in employees
                        group employee by new { Nationality = employee.Nationality, LastName = employee.LastName };

            var query2 = employees.GroupBy(employee => new {Nationality = employee.Nationality, LastName = employee.LastName});

            foreach (var group in query)
            {
                Console.WriteLine(group.Key); //если мы групируем по условию, то будет Key

                foreach (var employee in group)
                {
                    Console.WriteLine(employee.FistName);
                }
            }

            //Delay
            Console.ReadKey();
        }
    }
}
