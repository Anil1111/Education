using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_AutoProperties
{
    /// <summary>
    /// В С# 6.0 мы можем инициализировать свойства со значениями, написав справа от них значение.
    /// Это поможет избежать ошибки в null и пустыми значениями свойства.
    /// </summary>
    class Customer
    {
        //Автосвойство с инициализацией
        public int Id { get; set; } = 3;
        public string FirstName { get; set; } = "Roman";
        public string LastName { get; set; } = "Borodavka";
        public int PhoneNumber { get; } = 56789; //можем даже автосвойства только для чтения инициализировать

        public override string ToString()
        {
            return string.Format("Id: {0}, First Name: {1}, Last Name: {2}, Phone Number: {3}", Id, FirstName, LastName,
                PhoneNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine(customer);

            Console.WriteLine(new string('-', 50));

            customer.Id = 24;
            customer.FirstName = "Vasya";
            customer.LastName = "Puplin";
            //customer.PhoneNumber = 1;

            Console.WriteLine(customer);

            //Delay
            Console.ReadKey();
        }
    }
}
