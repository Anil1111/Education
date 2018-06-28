using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        private static string[] names = { "Tom", "Dick", "Harry", "Mary" };
        private static string[] forUnion = { "Tom", "Dick", "Harry", "Borry" };
        static void Main(string[] args)
        {
            //3. Объединение
            //names.Join()
            //names.GroupJoin()

            //4.Упорядочивание

            //OrderBy
            //по умолчанию сортирует по увеличению
            var orderedBy = names.OrderBy(x => x); //returns "Dick", "Harry", "Mary", "Tom"

            //OrderByDescending
            //по умолчанию сортирует по убыванию
            var orderByDescending = names.OrderByDescending(x => x);  //returns "Tom", "Mary", "Harry", "Dick" 

            //5.Множества

            //Concat 
            //Соединяет 2 последовательности в одну.
            var concat = names.Concat(names); //return  "Tom", "Dick", "Harry", "Mary", "Tom", "Dick", "Harry", "Mary"

            //Union
            //Делает то же самое, что и Concat, но повторяющиеся элементы не будут включены дважды
            var union = names.Union(forUnion); //returns  "Tom", "Dick", "Harry", "Mary", "Borry"

            //Intersect
            //Определяет пересечение
            var intersect = names.Intersect(forUnion); //return "Tom", "Dick", "Harry"

            //Except
            //Определяет элементы в одной коллекции, которых нету в другой
            var except = names.Except(forUnion); //returns  "Mary"

            //6. Экспорт - часто используются тогда, когда не нужно сохранять сам запрос и использовать его повторно.

            //ToArray
            var array = names.ToArray();

            //ToList
            var list = names.ToList();

            //ToDictionary
            var dictionary = names.ToDictionary(x => x, x => true);

            //7. Поэлементные

            //Single
            //Вовзращает один элемент, который подходит под условие. Если элементов больше - то Single бросает исключение.
            var single = names.Single(x => x == "Tom"); //retuns "Tom"

            //SingleOrDefalut
            //Вовзращает один элемент, который подходит под условие или значение по умолчанию.
            //Если элементов больше - то Single бросает исключение.
            var singleOrDefault = names.SingleOrDefault(x => x == "Tom"); //retuns "Tom"

            Enumerable.Empty<string>();
            List<string> list1 = new List<string>();
            //if (list != null)
            //{
            //    foreach (var item in list.Where(/* etc */))
            //    {

            //    }
            //}
            
            //Нету никаких if
            foreach (var item in list1.EmptyIfNull().Where(x=>x.Contains("r")))
            {
                
            }
        }
    }

    public static class Extensions
    {
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> collection)
        {
            return collection == null
                ? Enumerable.Empty<T>()
                : collection;
        }
    }
}
