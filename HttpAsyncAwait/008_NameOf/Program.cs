using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_NameOf
{
    /// <summary>
    /// В C# 6.0 оператор nameof можно использовать, чтобы ИЗБЕЖАТЬ ПОЯВЛЕНИЯ В КОДЕ СТРОКОВЫХ ЛИТЕРАЛО СВОЙСТВ- это очень важно!!!
    /// </summary>
    class Customer
    {
        public string FirstName { get; set; } = "Roman";
        public string LastName { get; set; } = "Borodavka";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            //Выведет значение свойств.
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);

            Console.WriteLine(new string('-', 30));

            //Выведет наименование свойств.
            Console.WriteLine(nameof(Customer.FirstName)); //если используется оператор nameof, то можно как статическое свойство указать //returns FirstName
            Console.WriteLine(nameof(customer.LastName)); //returns LastName

            //Delay
            Console.ReadKey();
        }
    }
}
