using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _007_Regex_Match.Success
{
    /*
      Match представляет подстроку соответствующую шаблону.
      Match.Success - булево значение, которое показываем найдено ли вхождение или нет 
      исходя из метода match.NextMatch. Подебажь for (Match match = regex.Match(input); match.Success; match = match.NextMatch())
      Все переменные объявленные в шаблоне ((?<myLink>) и (?<myLinkText>)) хранятся в коллекции Match.Groups
      В нашем случае нам придется использовать m.Groups["myLink"] и m.Groups["myLinkText"],
      для вывода значений каждой переменной.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            input += "<a href='http://vasya.com'>Home-page</a>";
            input += "<a href='http://google.com'>Search</a>";
            input += "<a href='https://ya.ru'>Yandex</a>";
            input += "<a href='http://yandex.ru'>Yandex Full</a>";
            input += "<a href='http://microsoft.com'>Microsoft</a>";

            //в каждом Match`е будут переменные link и text. К ним доступиться можно через match.Groups["link"] или match.Groups["text"]
            var regex = new Regex(@"<a href='(?<link>\S+)'>(?<text>\S+)</a>"); //'' потому, что они есть в реальном примере
            Console.WriteLine(input); 

            //for(текущее_значение_m;          условие;  действие_при_каждой_итерации).
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
                where match.Groups["link"].Value.StartsWith("http")
                select match;

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
