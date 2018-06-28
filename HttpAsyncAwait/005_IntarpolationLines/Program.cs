using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_IntarpolationLines
{
    /// <summary>
    /// В С# 6.0 появилась возможность заменить маркеры подстановки(типо как {0}, field) сразу же элементами подстановки {field},
    /// это особенно удобно когда нужно вывести или сделать конкатенацию множества элементов.
    /// </summary>
    class Customer
    {
        //Автосвойство с инициализацией
        public int Id { get; set; } = 3;
        public string FirstName { get; set; } = "Roman";
        public string LastName { get; set; } = "Borodavka";

        public override string ToString() //для экземпляра этого класса
        {
            return string.Format($"Id: {Id}, First Name: {FirstName}, Last Name: {LastName}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Console.WriteLine(customer);

            Console.ReadKey();
        }
    }
}
