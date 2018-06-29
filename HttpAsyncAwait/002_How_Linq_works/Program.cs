using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_How_Linq_works
{
    class Program
    {
        private static string[] names = { "Tom", "Dick", "Harry", "Mary" };
        static void Main(string[] args)
        {
            //LINQ - технология ОТЛОЖЕННОГО ВЫПОЛНЕНИЯ. Это означает, что все операторы НЕ ВЫПОЛНЯЮТСЯ сразу. Они выполняются только при итерации элементов.
            //Например при foreach:
            foreach (var item in names)
                Console.WriteLine(item);
            //Зачем так сделано? Это дает нам возможность строить запросы используя разные операторы В ЗАВИСИМОСТИ ОТ УСЛОВИЙ. И так же в зависимости от условий
            // выполнять их. Т.е мы сначала строим(проверяем кучу условий), а потом уже перед самым использованием - применили эти операторы.
            //Скачал бесплатный .dotPeek и заглянул во внутрь Where.
            //Методы перемебора(MoveNext, Reset, Current) будут вызываться только когда я начну перебор элементов последовательности(например foreach)

            //public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
            //{
            //    if (source == null)
            //        throw Error.ArgumentNull(nameof(source));
            //    if (predicate == null)
            //        throw Error.ArgumentNull(nameof(predicate));
            //    if (source is Enumerable.Iterator<TSource>)
            //        return ((Enumerable.Iterator<TSource>)source).Where(predicate);
            //    if (source is TSource[])
            //        return (IEnumerable<TSource>)new Enumerable.WhereArrayIterator<TSource>((TSource[])source, predicate);
            //    if (source is List<TSource>)
            //        return (IEnumerable<TSource>)new Enumerable.WhereListIterator<TSource>((List<TSource>)source, predicate);
            //    return (IEnumerable<TSource>)new Enumerable.WhereEnumerableIterator<TSource>(source, predicate);
            //}

            //Как мы видим, создается экземпляр nested класса и там просходит сама проверка(подходит ли нам элемент или нет).

            //ВАЖНО понимать, что ВОТ ЗДЕСЬ 
            //private static string[] names = { "Tom", "Dick", "Harry", "Mary" };
            var query3 = names.Where(x => x.Contains("r")).Select(x => x.ToUpper());
            foreach (var s in query3)
                Console.WriteLine(s);
            //НЕ происходит 2 перебора(сначала Where все элементы, потом Select все элементы) как это может показаться. (ЭТО БЫ ОЧЕНЬ ЗАМЕДЛИЛО ПРОИЗВОДИТЕЛЬНОСТЬ)
            //Алгоритм такой:
            //1. В цикле foreach запрашивается первый элемент последовательности
            //2. Select обращается к Where, Where обращается к names и получает первый элемент - в данном случае "Tom"
            //3. Том не подходит т.к он не содержит буквы "r" - дальше "Tom" никуда не идет.
            //3.1 По цепочке Select - Where запрашивается элемент номер 2. "Dick" тоже не подходит - дальше "Dick" никуда не идет.
            //3.2 По цепочке Select - Where запрашивается элемент номер 3. "Harry" подходит.
            //4. Where вернет элемент "Harry" выше в Select
            //5. Select сделает с ним ToUpper() и вернет его foreach
            //6. Произойдет Console.WriteLine(s);
            //7. И так далее

            //ВЫВОД - элементы из names проходят 'LINQ преграды(в данном случае Contains, Select)' один за одним. 
            //Т.е один элемент прошел от начала и до конца, потом второй 

            //ПОПРОБОВАЛ ОТДЕБАЖИТЬ foreach - ТАК ОНО И ЕСТЬ.
            //Пример с "цепочками оберток и сложенностий":
            //foreach -> Select -> Where -> names . Из names берется ОДИН элемент и пытается дойти до foreach.

            //Различие между IEnumerable и IQueryable, пишется то же самое, но работает по разному.
            //IEnumerable - базовый обобщенный интерфейс, который позволяет использовать LINQ методы.(Только если IEnumerable<T>)
            //IQueryable - интерфейс для интерпретируемых запросов. IQueryable<T> - это тот же LINQ, но не к объектам, а к удаленным источникам. 
            //IQueryable наследуется от IEnumerable. Мы можем использовать все те же операторы LINQ, но будет выполняться немного по-другому.
            //IQueryable применяется в LINQ to SQL. Тут схема выполнения совсем другая.
            //ВКРАТЦЕ: IQueryable - создает дерево выражений, которое потом будет специальным образом интерпретировано и преобразовано в SQL запрос.

            //ПРИМЕР - картинка. Select, Where - это ДЕКОРАТОРЫ с позиции паттернов.
            //Они обварачивают одну последовательность в себя и сами могут быть обернутыми другими декораторами.
            //Т.Е LINQ - это цепочка декораторов, каждый из которых включает предидущего и тем самым позволяет обращаться к 
            //определенному декоратору, который будет выпонять свое необходимое действие.
        }
    }
}
