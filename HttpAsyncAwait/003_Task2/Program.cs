using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(50000, 130, 2018) { Passengers = 28, Port = "Одесса" };
            Console.WriteLine($"Цена корабля {ship.Price}, скорость {ship.Speed}, " +
                              $"год выпуска {ship.Year}, количество пассажиров {ship.Passengers}, порт {ship.Port}");

            //Delay
            Console.ReadKey();
        }
    }
}
