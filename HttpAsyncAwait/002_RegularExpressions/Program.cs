using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _002_RegularExpressions
{
    /*
      System.Text.RegularExpressions - пространство имён где, хранятся нужные методы для работы с Regex`ами

      МЕТАСИМВОЛЫ - это символы для составления Шаблона поиска.

      \d  Определяет символы цифр.
      \D  Определяет любой символ, который не является цифрой.
      \w  Определяет любой символ цифры, буквы или подчеркивания.
      \w  Определяет любой символ, который не является цифрой, буквой или подчеркиванием.
      \s  Определяет любой непечатный символ, включая проблел
      \s  Определяет любой символ, кроме символов табуляции, новой строки и возврата каретки.
      .   Определяет любой символ кроме символа новой стоки.
      \.  Определяет символ точки

      */
    class Program
    {
        static void Main(string[] args)
        {
            //Данный шаблок определяет символы цифр.
            const string pattern = @"\d+"; //+ - это кварнтификатор. @"\d+" - найди одну цифру или более. 
            //Даже если в строке есть другие символы - ничего страшного. Главное, что есть цифра и regex.IsMatch(element) вернет True

            //Создаем экземпляр класса Regex и передаем в качестве аргумента кнструктора шаблон.
            var regex = new Regex(pattern); //спаниэль в Аэропорту

            //Массив строк для сравнения
            var array = new[] { "test", "123", "test123test", "123test", "test123" };

            foreach (var element in array)
            {
                Console.WriteLine(
                   regex.IsMatch(element)
                        ? "Строка \"{0}\" соответствует шаблону \"{1}\""
                        : "Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", element, pattern);

                Console.WriteLine(new string('-', 50));
            }

            Console.WriteLine("\n\n");

            while (true)
            {
                Console.WriteLine("Введи строку для сравнения: ");

                //Строка с которо будет сравниваться шаблон
                string input = Console.ReadLine();

                if (input == "exit")
                    break;

                Console.WriteLine(
                    (input != null && regex.IsMatch(input))
                        ? "Строка \"{0}\" соответствует шаблону \"{1}\""
                        : "Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", input, pattern);

                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
