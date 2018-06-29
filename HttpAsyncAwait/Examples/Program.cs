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

        private static List<string> namesWithClones = new List<string> { "Tom", "Dick", "Harry", "Mary", "Tom", "Dick", "Harry", "Mary" };
        static void Main(string[] args)
        {
            //1. Операторы, которые позволяют фильтровать
            var where = names.Where(x => x.Contains("T"));

            //Take
            //takes elements from start
            var take = names.Take(1); //returns "Tom"


            //Skip
            //skips elements and return other elements
            var skip = names.Skip(1); //returns "Dick", "Harry", "Mary"

            //SkipWhile
            //будет пропускать элементы до тех пор, пока выполняется условие. 
            //Когда условие перестанет выполнятся, то вернет оставшаяся коллекция элементов.
            var skipWhile = names.SkipWhile(x => x.Contains("o")); //returns "Dick", "Harry", "Mary"


            //TakeWhile
            //будет брать элементы до тех пор, пока выполняется условие.
            //Когда условие перестанет выполняться, то вернет те элементы, которые он успел взять
            var takeWhile = names.TakeWhile(x => !x.Equals("Harry")); //returns "Tom", "Dick"


            //Distinct
            //Фильтрует последовательность таким образом, чтобы в ней не было повторяющихся элементов.
            var distinctNames = namesWithClones.Distinct();

            //2. Проекцирование(операция проекции)

            //Select
            var selectedNames = names.Select(x => x.ToUpper());

            //SelectMany
            var selectedManyNamesSqlSyntax = from n in names
                from n2 in names
                select new { Name = n, Name2 = n2 };

            var selectedManyNamesExtensionSyntax = names.SelectMany(n => names, (n, n2) => new { Name = n, Name2 = n2 });

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
