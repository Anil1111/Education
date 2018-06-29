using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_SQL_mix_syntax_LINQ_execution_every_time
{
    class Program
    {
        private static List<string> names = new List<string> { "Tom", "Dick", "Harry", "Mary" };
        private static List<string> anotherNames = new List<string> { "Tom", "Dick", "Harry", "Mary" };
        static void Main(string[] args)
        {
            //SQL синтаксис LINQ немного урезан, он не позволяет делать то, что можно сделать с помощью объектного синтаксиса(методы расширения)
            //Любая последовательность на SQL синтаксисе LINQ будет трансформироваться в методы расширения.
            //В некоторых случаях SQL синтаксис LINQ смотрится лучше и более элегантно
            //SQL синтаксис LINQ и синтаксис методов расширения могут хорошо совмещаться между собой.

            var query = (from name in names
                         where name.Contains("r")
                         select name.ToUpper()).Count();

            var query2 = from name in names //вот щас мы сохранили сам запрос как он есть. Мы не преобразовывали его ни в List но Array
                         where name.Contains("r") //но нужно понимать, что когда мы обратимся к нему в след раз - он ВЫПОЛНИТСЯ ЗАНОВО(см. ниже)
                         select name.ToUpper();

            var countWithCondition = query2.Count(x => x.StartsWith("T"));


            //Если мы сохранили запрос в исходном виде(не преобразовывали его в List или Array) запрос query2 выполнятся заново! 
            //T.e Count - это то е самое, что и foreach. Он вызывает перебор элементов
            var count = query2.Count(); //returns 2

            names.Add("Horn");

            var count2 = query2.Count();//returns 3, потому, что выполняется заново

            //Сохраним не са запрос как он есть, а данные с него:
            var query3 = (from name in anotherNames
                          where name.Contains("r")
                          select name.ToUpper()).ToList();

            var anotherNameCount1 = query3.Count(); //returns 2

            anotherNames.Add("Horn");

            var anotherNameCount2 = query3.Count(); //returns 2 потому, что query3 уже НЕ ЗАПРОС, а List
        }
    }
}
