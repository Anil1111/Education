using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Циклическая конструкция - while ( с досрочным выходом из цикла - break)
            int counter = 0;
            while(counter<3)
            {
                Console.WriteLine($"Counter {++counter}");

                if(counter==2) //Оператор break имеет смысл использовать в связке с условной конструкцией
                break; //Нет никогой логики.Оператор break просто берет и прерывает  работу оператора цикла.

                Console.WriteLine("Эта строка никогда не выполнится");
            }
            Console.WriteLine($"Произведено {counter} итераций");

            //Delay
            Console.ReadKey();
        }
    }
}
