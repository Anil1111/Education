using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите слово но русском языке");
                string word = Console.ReadLine();
                switch (word)
                {
                    case "дождь":
                        Console.WriteLine("rain");
                        break;
                    case "солнце":
                        Console.WriteLine("sun");
                        break;
                    case "облачно":
                        Console.WriteLine("cloudy");
                        break;
                    case "ветренно":
                        Console.WriteLine("windy");
                        break;
                    case "холодно":
                        Console.WriteLine("cold");
                        break;
                    case "тепло":
                        Console.WriteLine("warm");
                        break;
                    case "температура":
                        Console.WriteLine("temperature");
                        break;
                    case "зонт":
                        Console.WriteLine("umbrella");
                        break;
                    case "снег":
                        Console.WriteLine("snow");
                        break;
                    case "бриз":
                        Console.WriteLine("breeze");
                        break;
                    case "фаренгейт":
                        Console.WriteLine("Fahrenheit");
                        break;
                    default:
                        Console.WriteLine($"Слова '{word}' нету в словаре");
                        break;

                }
            }
        }
    }
}
