using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Methods
{
    class Program
    {
        //Методы Функции
        //На 15-й строке, создаем метод с именем Function, который ничего 
        //не принимает и возвращает сроковое значение.
        //В теле метода, используется ключевое слово return, возвращаем строку "Hello!"
        static string Function()
        {
            return "Hello!";
        }
        static void Main(string[] args)
        {
            //В теле метода Main на 23-й строке, создаем строковую локальную переменную с именем
            //@string и присваиваем ей возвращаемое значение метода Function.
            string @string = Function(); //Создаем строковую локальную переменную
            Console.WriteLine(@string);

            //Delay
            Console.ReadKey();
        }
    }
}
