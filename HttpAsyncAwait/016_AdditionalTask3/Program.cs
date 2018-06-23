using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_AdditionalTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new House(new Street("Марашала Малиновского"), "Киев");

            House clone;
            //clone = house.Clone(); //ссылаются на один и тот же обьект (смотри ниже метод ReferenceEquals)
            clone = house.DeepClone();

            Console.WriteLine($"Original: {house.City}, {house.Street.Str}");
            Console.WriteLine($"Clone   : {clone.City}, {clone.Street.Str}");
            Console.WriteLine(new string('-', 50));

            clone.City = "Одесса";
            clone.Street = new Street("Солнечная");
            Console.WriteLine($"Original: {house.City}, {house.Street.Str}");
            Console.WriteLine($"Clone   : {clone.City}, {clone.Street.Str}");
            var a = ReferenceEquals(house, clone);

            //Delay
            Console.ReadKey();
        }
    }
}
