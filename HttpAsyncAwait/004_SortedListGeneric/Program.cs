using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_SortedListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Когда новый элемент добавяется - происходит сортировка

            var sortList = new SortedList<string, int>();
            sortList["Zero"] = 0;
            sortList["One"] = 1;
            sortList["Two"] = 2;
            sortList["Three"] = 3;

            foreach (var i in sortList)
            {
                Console.WriteLine(i); // Выведет [One , 1] и так далее
            }

            //Delay
            Console.ReadKey();
        }
    }
}
