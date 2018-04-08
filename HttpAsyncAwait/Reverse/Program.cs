using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите сначала слово с правильным порядком букв");
            //var word = Console.ReadLine();
            //Console.WriteLine("Введите слово палиндром");
            //var wordToCheck = Console.ReadLine();
            var word = "qwerty";
            var wordToCheck = "ytrewq";

            var reversedWord = string.Concat(wordToCheck.ToCharArray().Reverse());

            if (reversedWord == word)
                Console.WriteLine($"Cлово {wordToCheck} является палиндромом к слову {word}");
            else
                Console.WriteLine($"Cлово {wordToCheck} НЕ является палиндромом к слову {word}");

            //Delay
            Console.ReadKey();
        }
    }
}
