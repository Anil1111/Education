using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_AdditionalTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Index = "12345",
                Country = "Ukraine",
                City = "Kyiv",
                Street = "Kablykova",
                House = "34",
                Apartment = "33"
            };

            Console.WriteLine($"Index = {address.Index}");
            Console.WriteLine($"Country = {address.Country}");
            Console.WriteLine($"City = {address.City}");
            Console.WriteLine($"Street = {address.Street}");
            Console.WriteLine($"House = {address.House}");
            Console.WriteLine($"Apartment = {address.Apartment}");

            //Delay
            Console.ReadKey();
        }
    }
}
