using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность словаря:");
            var a = Convert.ToInt32(Console.ReadLine());

            var dictionary = new MyDictionary<string, string>(a);

            for (int i = 0; i < a; i++)
            {
                dictionary.Add(i, "Привет", "Hello");
            }

            Console.WriteLine(new string('-', 30));
            for (int i = 0; i < dictionary.Length; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary.Length);

            //Delay
            Console.ReadKey();
        }
    }
}
