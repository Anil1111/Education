using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Join
{
    //join (операция обьединения) - устанивливает соотношение данных из двух разных источников.
    public class EmployeeId
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeNationality
    {
        public string Id { get; set; }
        public string Nationality { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Строим коллекцию сотрудников.
            var employees = new List<EmployeeId>
            {
                new EmployeeId{Id = "111", Name = "Ivan Ivanov"},
                new EmployeeId{Id = "222", Name = "Andrey Andreev"},
                new EmployeeId{Id = "333", Name = "Petr Petrov"},
                new EmployeeId{Id = "444", Name = "Alex Alexeev"},
            };
            //Строим коллекцию национальностей.
            var empNationalities = new List<EmployeeNationality>
            {
                new EmployeeNationality {Id = "111", Nationality = "Russian"},
                new EmployeeNationality {Id = "222", Nationality = "Ukrainian"},
                new EmployeeNationality {Id = "333", Nationality = "American"},
            };

            //Строим запрос
            //Получение списка имет всех сотрудников вместе с их национальностями, при этом отсортировав список по убыванию.
            var query = from employee in employees
                        join employeeNationality in empNationalities
                            on employee.Id equals employeeNationality.Id
                        orderby employeeNationality.Nationality
                            descending //по умолчанию - ascending - по возрастанию | descinding - по убыванию.
                        select new //СОЗДАЕМ ЭКЗЕМПЛЯР АНОНИМНОГО ТИПА
                        {
                            Id = employee.Id,
                            Name = employee.Name,
                            Nationality = employeeNationality.Nationality
                        };

            //Строим запрос
            //Получение списка имет всех сотрудников вместе с их национальностями, при этом отсортировав список по убыванию.
            var query1 = employees
                .Join(empNationalities, //все сходится с тем, что метод Join принимает(наведи на метод Join)
                    employee => employee.Id, //on employee.Id equals
                    employeeNationality => employeeNationality.Id, //employeeNationality.Id
                    (employee, employeeNationality) => new { employee, employeeNationality }) //создаем экземпляр анонимного типа(специфично для Join)
                .OrderByDescending(@t => @t.employeeNationality.Nationality)
                .Select(@t => new //СОЗДАЕМ ЭКЗЕМПЛЯР АНОНИМНОГО ТИПА
                { Id = @t.employee.Id, Name = @t.employee.Name, Nationality = @t.employeeNationality.Nationality });

            foreach (var preson in query)
            {
                Console.WriteLine($"{preson.Id}, {preson.Name}, \t{preson.Nationality}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
