using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Roman", "Borodavka");
            employee.Rang = 10;
            employee.WorkTime = 25;

            var info = employee.CountEverithing();

            Console.WriteLine($"Имя {employee.FirstName}\r\n" +
                              $"Фамилия {employee.LastName}\r\n" +
                              $"Ранг рабочего {employee.Rang}\r\n" +
                              $"Стаж {employee.WorkTime}\r\n" +
                              $"Оклад {info.First()}\r\n" +
                              $"Налог {info.Last()}\r\n");


            //Delay
            Console.ReadKey();
        }
    }
}
