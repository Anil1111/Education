using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Наш парк машин:");
            var park = new CarCollection<string>();
            park.AddCar("Жигули", new DateTime(1985, 2, 5));
            park.AddCar("Toyota", new DateTime(2018, 1, 5));
            park.AddCar("Ford", new DateTime(1977, 12, 6));
            park.AddCar("Chevrolet", new DateTime(2003, 4, 7));

            Console.WriteLine(park.ToString());

            Console.WriteLine($"В парке находится {park.Length} машин");

            Console.WriteLine("Введите номер интересующей вас машины");
            var a = Console.ReadLine();
            if (string.IsNullOrEmpty(a))
            {
                Console.WriteLine("Вы не ввели значение, поиск не выполнен.");
            }
            else
            {
                int number = Convert.ToInt32(a);
                Console.WriteLine(park[number - 1]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
