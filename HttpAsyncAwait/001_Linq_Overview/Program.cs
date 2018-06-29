using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Linq_Overview
{
    class Program
    {
        delegate int MyDelegate(int x, int y);
        private static string[] names = { "Tom", "Dick", "Harry", "Mary" };
        static void Main(string[] args)
        {
            var list = new List<string>();
            foreach (var name in names) //сложно. нужно упростить методы
            {
                if (name.Contains("r"))
                {
                    list.Add(name.ToUpper());
                }
            }
            // У нас ниже в вообще левом классе обьявлен метод Where с такой же сигнатурой.
            var query = names.Where(x => x.Contains("r")).Select(x => x.ToUpper()); //то же самое, но намного меньше кода

            //LINQ позволяет делать запросы к разным источникам(в том числе и к базам данных), но используя те же самые привычные операторы.

            //LINQ - Language Integrated Query (ЛИНК)
            //LINQ работает с IEnumerable<T> и требует, чтобы все обьекты с которыми он работает - реализовывали этот интерфейс.
            //Можна создават свои коллекции - главное реализовать интерфейс IEnumerable<T> - и тогда можно применять LINQ к ним.

            var collection = new ArrayList { 1, 2, 3, 4, 5 }; //ArrayList не реализует IEnumerable<T>  - по этому нельзя применять LINQ к коллекциям типа ArrayList
            //var a = collection.Where<string>(x => x.Contains("r")).Select(x => x.ToUpper());

            //Все методы находятся в статическом классе Enumerable, а пространство имен - namespace System.Linq

            //Если бы не синтаксических сахар - приходилось бы писать вот такое.
            Enumerable.Select(Enumerable.Where(names, x => x.Contains("r")), x => x.ToUpper());

            //Смотри пример Where ниже

            //Делегат - это безопасная обертка над указателями на метод. В С++ можно использовать указатели на методы, но это не безопасно. 
            //В С# есть конструкция делегат, которая помагает ссылаться на метод безопасно и удобно.

            //Лямбда выражения - способ записи делегата - x => x.Contains("r"). Читается так: на 46 строке мы создаем лямбда выражение, которое принимает параметр х, котороый входит в тело лямбда выражения.
            //Как понять, что лямбда выражение/оператор должны вернуть? Нужно посмотреть на СИНГАТУРУ делегата вместо которого мы используем лямбда выражение.
            MyDelegate my = (a, b) => a + b;

            //Синтаксис запросов(SQL подобный синтаксис)
            //query2- переменна запроса, name - переменная диапазона
            var query2 = from name in names
                         where name.Contains("r")
                         select name.ToUpper();

            //Сортировка по длине строки.
            var sortedCollection = names.Where(x => x.Contains("r")).OrderBy(x => x.Length).Select(x => x.ToUpper());
        }
    }
    public static class Extensions
    {
        //делегат 'пропускает через себя' каждый элемент коллекции типа IEnumerable<T> и возвращает bool
        public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Func<T, bool> func)
        {
            Console.WriteLine("Вызвана собственная реализация метода Where");
            return Enumerable.Where(collection, func);
        }
    }
}
