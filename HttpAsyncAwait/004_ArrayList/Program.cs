using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList { 2, 3, 1 };

            list.Sort(new DescendingComparer());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Delay
            Console.ReadKey();
        }
    }

    public class DescendingComparer : IComparer
    {
        //Язык С# - это CaseSensative
        //Проверяет равеноство двух объектов без учета регистра строк.
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare(object x, object y)
        {
            //Первый способ

            //Для сотрировки по убыванию:
            //Объекты, переданные для сравнения, меняются местами.

            //int result = (int)x - (int)y; //по возрастанию (ASC)
            //int result = (int)y - (int)x; //по убыванию (DESC)

            //Второй способ
            //int result = comparer.Compare(x, y); //по возрастанию (ASC)
            int result = comparer.Compare(y, x); //по убыванию (DESC)

            return result;
        }
    }
}
