using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_VarArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массивы - это коллекции!
            //Массив Int32
            var array1 = new[] {1, 2, 3, 4, 5};
            Console.WriteLine(array1.GetType());

            //Массив Doubles - у нас формируется массив ТАКОГО ТИПА, к которому могут быть БЕЗОПАСНО приведены все зачения.
            var array2 = new []{3.156766, 5, 6, 7, 8};
            Console.WriteLine(array2.GetType());

            //Не компилируется. (Несовместимые типы)
            //var array3 = new [] {1,"string"};

            //Delay
            Console.ReadKey();
        }
    }
}
