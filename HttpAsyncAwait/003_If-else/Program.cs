using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.25;
            int b = 5;

            //Если тело блока if или else состоит из одного выражения, то операторные скобки можно упустить
            if (a < b)
                Console.WriteLine($"{nameof(a)} < {nameof(b)}"); //Ветвь 1
            else
                Console.WriteLine($"{nameof(a)} > {nameof(b)}"); //Ветвь 2
            Console.WriteLine("Нужно быть аккуратным т.к можно подумать, что это выражение" +
                             "\nотносится к блоку else, но это НЕ ТАК! Лучше все таки ставить" +
                             "\nоператорные скобки и все будет ок");

            //Delay
            Console.ReadKey();
        }
    }
}
