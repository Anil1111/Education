﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _003_RegularExpression_Квантификаторы
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

     КВАНТИФИКАТОРЫ - это символы которые определяют, где и сколько раз необходимое вхождение символов может быть

      ^ - с начала строки (^ называется циркумфлекс)
      $ - с конца строки
      + - одно и более вхождений подшаблона в строке
      * - ноль или более вхождений
      {1,2}  определяет кол-во повторов нужного нам элемента как + или * (например \S, \d etc). Формат: {min,max}.
        Пример: \d{2,4} - числа длиной от двух до четырех символов (12, 123, 1234) , а 12345 - уже не подходит
        а \d{4} только 4 - не более и не мение

     */
    class Program
    {
        static void Main(string[] args)
        {
            string pattern;

            //Одно вхождение подстроки(\d+) в строку
            //pattern = @"\d+"; //"123", "test123", "123test", "te123st", "4556yyy789"

            //Нужная подстрока (\d+) должна быть в начале строки
            //pattern = @"^\d+"; // "123", "123test", "4556yyy789"

            //Нужная подстрока (\d+) должна быть в конце строки
            //pattern = @"\d+$"; //"123", "test123", "4556yyy789"

            //Вся строка полностью от начала (^) и до конца ($) должна соответствовать тому, что между (^) ($) могут быть ТОЛЬКО (\d+) символы
            //pattern = @"^\d+$"; //"123"

            //И в начала и в конце строки - цифры, а по середине - НЕ ЦИФРЫ
            pattern = @"^\d*\D+\d+$"; // "4556yyy789"

            var regex = new Regex(pattern);

            //Массив строк для сравнения.
            var array = new[] { "test", "123", "test123", "123test", "te123st", "4556yyy789" };

            foreach (var element in array)
            {
                Console.WriteLine(
                    (element != null && regex.IsMatch(element))
                        ? "Строка \"{0}\" соответствует шаблону \"{1}\""
                        : "Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", element, pattern);

                Console.WriteLine(new string('-', 50));
            }

            //Delay
            Console.ReadKey();
        }
    }
}
