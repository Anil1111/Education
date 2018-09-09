using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _001_RegularExpressions
{
    /*
      System.Text.RegularExpressions - пространство имён где, хранятся нужные методы для работы с Regex`ами

      МЕТАСИМВОЛЫ - это символы для составления Шаблона поиска.

      \d  Определяет символы цифр.
      \D  Определяет любой символ, который не является цифрой.
      \w  Определяет любой символ цифры, буквы или подчеркивания.
      \S  Определяет любой символ, который не является цифрой, буквой или подчеркиванием.
      \s  Определяет любой непечатный символ, включая проблел
      \S  Определяет любой символ, кроме символов табуляции, новой строки и возврата каретки.
      .   Определяет любой символ кроме символа новой стоки.  в тестах SpecFlow испольуется символ .* т.е любой символ кроме символа новой стоки 0 или более раз
      \.  Определяет символ точки

      */
    class Program
    {
        static void Main(string[] args)
        {
            //Данный шаблок определяет символы цифр.
            const string pattern = @"\d";

            //Создаем экземпляр класса Regex и передаем в качестве аргумента кнструктора шаблон.
            var regex = new Regex(pattern); //спаниэль в Аэропорту

            while (true)
            {
                //Строка с которой удет сравниваться шаблон.
                string @string = Console.ReadKey().KeyChar.ToString();

                if (@string == " ")
                    break;

                //Проверка соотвествия строки шаблону.

                // Метод IsMatch - сравнивает принимаемую в первом параметре строку с шаблоном.
                // IsMatch - метод, возвращающий bool. True - в слуае, если шабло соответствует строке, False - если нет.
                bool IsCorrespondant = regex.IsMatch(@string);

                Console.WriteLine(
                    IsCorrespondant
                    ? " соответствует шаблону \"{0}\""
                    : " НЕ соответствует шаблону \"{0}\"", pattern);
            }
        }
    }
}
