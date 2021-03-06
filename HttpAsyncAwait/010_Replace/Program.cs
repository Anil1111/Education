﻿using System;
using System.Text.RegularExpressions;

namespace _010_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;

            //Замена даты в формате (месяц/день/год) на дату в формате (день-месяц-год).
            result = Regex.Replace("04/17/1992",
                @"(?<month>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})", //как только поставил кавычки в 3м параметре метода Regex.Replace, то все подсверилось
                "${day}-${month}-${year}");

            Console.WriteLine(result);

            //Замена недопустимых символов пустыми символами.
            result = Regex.Replace("@_H e ll o-777.,:;'!@#$%^&*()_-+<>?/",
                @"[^\w\.@-]",
                " ");

            Console.WriteLine(result);

            //В синтаксисе регулярных выражений в каждом языке програмирования есть свой "оттенок".
            //Все идет к тому, что если я найду вроде нормальную регулярку, но она почему-то не работает - главное
            //не расстраиваться и понять почему так. В каждом языке программирования по-разному, есть свой оттенок.
            //И проверить, все ли элементы регулярного выражения соответствуют стандарту, например Майкрософта(если я пишу на C#).
            //Delay
            Console.ReadKey();
        }
    }
}
