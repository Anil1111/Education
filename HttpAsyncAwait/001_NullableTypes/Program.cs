using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тип Nullable применяется при работе с базой данных.
            //Допустим я работаю с БД и там есть поле, в котором есть допущение, что я могу ничего не указывать.- пустота!
            //Моя программа SQL запросом обращается к БД и в цикле выбирает значения определенных ячеек.
            //И тут встречается поле, в котором нет ничего. Чтобы программа продолжила выполнение нужно успользовать Nullable type
            //a - содержит неизвестное значение

            //Нужно считать так: null -это как знак безконечности в математике.
            int? a = null; //int? это все равно, что Nullable<int> 
            int? b = a + 4; //b = null
            int? c = a * 5; //c = null

            Console.WriteLine($"->{a}<-");
            //Delay
            Console.ReadKey();
        }
    }
}
