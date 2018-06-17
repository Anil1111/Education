using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Operators
{
    //Унарные операторы (где 1 агрумент), а бинарные операторы - 2 аргумента
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0, 0);

            //Оператор один и тот же! что на префиксную, что на постфикную форму. Компилятор сам смотрит когда нужно применить
            //этот оператор: ПЕРЕД использованием или ПОСЛЕ использования.

            Console.WriteLine($"a    = {a}");
            Console.WriteLine($"a++  = {a++}"); // покажет [0,0] а потом сделает инкремент т.к эти ПОСТФИКСНЫЙ инкремент
            Console.WriteLine($"a    = {a}");

            Console.WriteLine($"a--  = {a--}");// покажет [1,1] а потом сделает декремент т.к эти ПОСТФИКСНЫЙ декремент
            Console.WriteLine($"a    = {a}");

            Console.WriteLine($"++a  = {++a}"); // сначала сделает инкремент, а потом уже покажет т.к эти ПРЕФИКСНЫЙ инкремент
            Console.WriteLine($"a    = {a}");

            Console.WriteLine($"--a  = {--a}"); // сначала сделает декремент, а потом уже покажет т.к эти ПРЕФИКСНЫЙ декремент
            Console.WriteLine($"a    = {a}");

            //Delay
            Console.ReadKey();

        }
    }
}
