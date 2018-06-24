using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_LINQ_expression_execution
{
    public class Result
    {
        public int Input { get; set; }
        public int Output { get; set; }

        public Result(int input, int output)
        {
            this.Input = input;
            this.Output = output;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            //Cтроим запрос
            var query = from x in numbers //query - ПЕРЕМЕННАЯ ЗАПРОСА, х- переменная диапазона
                        select new Result(x, x * 2);
            var query2 = numbers.Select(x => new Result(x, x * 4)); //не обязательно использовать анонимные типы. Можно сущевствующий класс.

            numbers[0] = 777; //Выражение запроса выполняется в момент ОБЩРАЩЕНИЯ К ПЕРЕМЕННОЙ ЗАПРОСА в foreach
            //ПОЧЕМУ ТАК? чтобы увеличить производительность! потому, что запросов может быть сотни, а те которые мы реально будем использовать - единицы.

            //ХЗ почему, но у меня отрабатывает сразу, а когда я меняю  numbers[0] = 777, то значение уже в готовой переменной запроса query2 ПЕРЕСЧИТЫВАЕТСЯ!
            //item - перменная итерации
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Input}, \t{item.Output}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
