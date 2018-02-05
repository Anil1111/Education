using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Methods
{
    class Program
    {
         //Методы (Процедуры)
         //На 15 строчке создаем метод с именем Procedure,который ничего не принимает 
         //и ничего не возвращает.
         //В теле метода на 17 строке выводим на экран строку "Hello"
        static void Procedure()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            //В теле метода Main на 21 строке, вызываем метод Procedure
            Procedure();

            //Delay
            Console.ReadKey();
        }
    }
}
