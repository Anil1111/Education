using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_LINQ_2_from
{
    //Таблица умножения.
    class Program
    {
        static void Main(string[] args)
        {
            //Конструкция from похожа на оператор foreach.
            //Использование нескольких конструкций from, аналогично вложенным операторам foreach

            //LINQ операции возвращает ссылку на коллекцию элементов анонимного типа
            var query = from x in Enumerable.Range(1, 9)
                        from y in Enumerable.Range(1, 10)
                        select new  //- возвращаем коллекцию экземпляров анонимного типа
                        {
                            X = x,
                            Y = y,
                            Product = x * y
                        };

            //SelectMany :2 делегата- один Func<int, IEnumerable<int>> - принимает int, возвращает IEnumerable<int>, а другой,
            //формирует коллекцию экземпляров анонимного типа Func<int, int, a`> - принимает int, int, возвращает а`
            var quer1y = Enumerable.Range(1, 9)
                .SelectMany(x => Enumerable.Range(1, 10), (x, y) => new { X = x, Y = y, Product = x * y });

            foreach (var item in query)
            {
                Console.WriteLine($"{item.X} * {item.Y} = {item.Product}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
