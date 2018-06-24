using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _012_LINQ_let2
{
    //let - это локальный идентификатор, на который можно ссылаться в остальной части запроса.
    // Его можно представить, как локальную переменную, видимую только внутри выражения запроса. 
    class Program
    {
        static void Main(string[] args)
        {
            //Построить запрос.
            var query = from x in Enumerable.Range(0, 10)
                let innerRange = Enumerable.Range(0, 10)
                from y in innerRange
                select new { X = x, Y = y, Product = x * y };

            var query2 = Enumerable.Range(0, 10)
                .Select(x => new {x, innerRange = Enumerable.Range(0, 10)})
                .SelectMany(@t => @t.innerRange, (@t, y) => new {X = @t.x, Y = y, Product = @t.x * y});

            foreach (var item in query)
            {
                Console.WriteLine($"{item.X} * {item.Y} = {item.Product}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
