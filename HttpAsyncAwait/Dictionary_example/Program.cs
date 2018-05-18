using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(0, "Ноль");
            myDictionary.Add(1, "Один");
            myDictionary.Add(2, "Два");
            myDictionary.Add(3, "Три");

            for (int i = 0; i < myDictionary.Count; i++)
            {
                Console.WriteLine(myDictionary[i]); //выводятся value
            }

            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Собака", "Dog");
            dictionary.Add("Кот", "Cat");

            Console.WriteLine("Введите русское слово, которое хотите перевести на английский:");
            var word = Console.ReadLine();
            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine(word + " - "+ dictionary[word]);
            }
            else
            {
                Console.WriteLine("Такого слова нет!");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
