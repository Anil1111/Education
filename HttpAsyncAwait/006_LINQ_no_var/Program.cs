using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_LINQ_no_var
{
    //Применение запроса к коллекции, которая поддерживает только IEnumerable не параметризированный.
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList(); //гетерогенная коллекция
            numbers.Add(1); //Add(object a) - по этому тут boxing
            numbers.Add(2);

            //Т.к public class ArrayList : IList, ICollection, IEnumerable, ICloneable - не поддерживает IEnumerable<T>
            //ЯВНОЕ указание типа Int32 переменной ДИАПАЗОНА - n.(var невозможно использовать т.к IEnumerable не параметризированный!)

            //query - переменная ЗАПРОСА
            //var - это когда тип ОПРЕДЕЛЕН, но тут его нужно определить и мы должны явно указать тип, вместо var
            var query = from int n in numbers
                select n * 2; //щас тут анонимный тип не используется

            foreach (var item in query) //item переменная итерации
            {
                Console.WriteLine(item);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
