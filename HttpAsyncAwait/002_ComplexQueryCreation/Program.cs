using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _002_ComplexQueryCreation
{
    class Program
    {
        private static string[] names = { "Tom", "Dick", "Harry", "Mary" };
        static void Main(string[] args)
        {
            //Построение сложных запросов могут строиться 3мя способами:
            //1. Последовательно
            //2. Используя ключевое слово into
            //3. Используя оболочки для запросов

            //1.Последовательно
            var filtered = names.Where(x => x.Contains("r"));
            var ordered = filtered.OrderBy(x => x.Length);
            var result = ordered.Select(x => x.ToUpper());

            //2. Используя ключевое слово into
            //into позволяет записать в переменную значение одного запроса и выполнять другой запрос с этой переменной.
            //Этот запрос будет проходится по списку имен и производить замену всех букв, которые попадают в перечень "[aeiou]" на пустое место
            IEnumerable<string> query = from name in names
                                        select Regex.Replace(name, "[aeiou]", "");

            query = from n in query
                    where n.Length > 2
                    orderby n
                    select n;
            //ВОТ ТО, ЧТО НАПИСАНО ВЫШЕ МОЖНО ПЕРЕПИСАТЬ ИСПОЛЬЗУЯ КЛЮЧЕВОЕ СЛОВО into

            IEnumerable<string> query2 =
                from name in names
                select Regex.Replace(name, "[aeiou]", "")
                into newValue
                where newValue.Length > 2
                orderby newValue
                select newValue;

            IEnumerable<string> query3 = names.Select(name => Regex.Replace(name, "[aeiou]", ""))
                .Where(newValue => newValue.Length > 2)
                .OrderBy(newValue => newValue);

            //3. Используя оболочки для запросов
            //Это точно то же самое, что и сверху, она не несет никаких дополнительных расходов, но выглядит она по другому.
            //Это не подзапрос! С использованием into просто более эллегантно смотрится.
            var query4 = from a in
                    (from b in names
                     select Regex.Replace(b, "[aeiou]", ""))
                         where a.Length > 2
                         orderby a
                         select a;

            var query5 = (from b in names select Regex.Replace(b, "[aeiou]", "")).Where(a => a.Length > 2)
                .OrderBy(a => a);
        }
    }
}
