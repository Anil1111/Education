using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _023_Regex
{
    /*
     http://www.javascriptkit.com/javatutors/redev2.shtml
    System.Text.RegularExpressions - пространство имён где, хранятся нужные методы для работы с Regex`ами

    МЕТАСИМВОЛЫ - это символы для составления Шаблона поиска.

    \d  Определяет символы цифр.
    \D  Определяет любой символ, который не является цифрой.
    \w  Определяет любой символ цифры, буквы или подчеркивания.
    \W  Определяет любой символ, который не является цифрой, буквой или подчеркиванием.
    \s  Определяет любой непечатный символ, включая проблел(т.е символ, который нельзя напечатать)
    \S  Определяет любой символ, кроме символов табуляции, новой строки и возврата каретки.
    .   Определяет любой символ кроме символа новой стоки.
    \.  Определяет символ точки

    КВАНТИФИКАТОРЫ - это символы которые определяют, где и сколько раз необходимое вхождение символов может быть

     ^ - с начала строки (^ называется циркумфлекс)
     $ - с конца строки
     + - одно и более вхождений подшаблона в строке
     * - ноль или более вхождений
     | - символ для указания вариантов шаблона (ИЛИ)
     {1,2}  определяет кол-во повторов нужного нам элемента как + или * (например \S, \d etc). Формат: {min,max}.
       Пример: \d{2,4} - числа длиной от двух до четырех символов (12, 123, 1234) , а 12345 - уже не подходит
       а \d{4} только 4 - не более и не мение

    */
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^\d*\D+\d+$");

            Console.WriteLine(regex.IsMatch("123")); //False т.к нету \D+

            //Regex.Replace есть только в C#
            Console.WriteLine(Regex.Replace("test123aaa4x5x6bbb789ccc",             //Исходная строка
                @"\d+",                                                             //Шаблон, чтобы определять какие элементы мы будем менять
                " "));                                                              //То на что мы будем менять каждый из элементов, подходящий по шаблону

            Console.WriteLine(Regex.Replace("02/05/1982",                           //Исходная строка - 5 февраля
                @"(?<месяц>\d{1,2})/(?<день>\d{1,2})/(?<год>\d{2,4})",              //Шаблон
                "${день}-${месяц}-${год}"));                                        //Использование переменных в новой фразе


            Console.WriteLine(Regex.Replace("123456",                               //Исходная строка
                @"\d",                                                              //Шаблон, по которому определяем элементы, к которым будет применяться функция
                match => (int.Parse(match.Value) + 1).ToString()));



            //---------------------------------------------------------------------------------





            string input = "";
            input += "<a href='http://vasya.com'>Home-page</a>";
            input += "<a href='http://google.com'>Search</a>";
            input += "<a href='https://ya.ru'>Yandex</a>";
            input += "<a href='https://yandex.ru'>Yandex Full</a>";
            input += "<a href='http://microsoft.com'>Microsoft</a>";

            //в каждом Match`е будут переменные link и text. К ним доступиться можно через match.Groups["link"] или match.Groups["text"]
            regex = new Regex(@"<a href='(?<link>\S+)'>(?<text>\S+)</a>"); //'' потому, что они есть в реальном примере
            Console.WriteLine(input);
            
            //СПОСОБ 1
            //for(текущее_значение_match;          условие;       действие_при_каждой_итерации).
            for (Match match = regex.Match(input); match.Success; match = match.NextMatch()) //regex.Match возвращает тип Match match и match.Success - true тогда, 
                                                                                             //когда получилсь что-то найти по твоему шаблону.
                                                                                             //match.NextMatch() - ищет что-то в input дальше.
            {
                //{0,-25} - значит что выделять 25 знакомест под вывод {0}. (-) - значит "прижаться" влево.
                Console.WriteLine("ССЫЛКА: {0,-25} на: {1,-4} позиции с именем: {2}",
                    match.Groups["link"],
                    match.Groups["link"].Index,
                    match.Groups["text"]);
            }

            Console.WriteLine(new string('-', 25));

            //СПОСОБ 2 - проще, как по мне.
            // regex.Matches(input) возвращает MatchCollection
            foreach (Match match in regex.Matches(input))
            {
                Console.WriteLine("ССЫЛКА: {0,-25} на: {1,-4} позиции с именем: {2}",
                    match.Groups["link"],
                    match.Groups["link"].Index,
                    match.Groups["text"]);
            }

            Console.WriteLine(new string('-', 25));

            var htmlQuery = from Match match in regex.Matches(input)
                            where match.Groups["link"].Value.StartsWith("https")
                            select match; // "<a href='https://yandex.ru'>Yandex Full</a> не прошел, потому, из-за проблема между Yandex и Full
                                          //new Regex(@"<a href='(?<link>\S+)'>(?<text>\S+)</a>"); - тут сказано, что проблела быть не может (\S- любой непробельный символ)               

            var htmlQuery2 = regex.Matches(input)
                .Cast<Match>()
                .Where(match => match.Groups["link"].Value.StartsWith("https"));

            foreach (var match in htmlQuery)
            {
                Console.WriteLine("ССЫЛКА: {0,-25} на: {1,-4} позиции с именем: {2}",
                    match.Groups["link"],
                    match.Groups["link"].Index,
                    match.Groups["text"]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
