using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Структуры.
//Структуры могут содержать статические члены.
//Статические структуры - недопустимы.
// Вся статика - в стеке.

namespace _005_Structure
{
    struct MyStruct //структура не может быть static т.к структура и так представляет собой некудю СТАТИЧЕСКУЮ СУЩНОСТЬ.
    {               // а экземпляры класса представляют собой ДИНАМИЧЕСКУЮ СУЩНОСТЬ.
                    // по этому СТРУКТУРЫ -В СТЕКЕ, КЛАССЫ - НА КУЧЕ.
        public static int StaticField { get; set; }
        public  int NotStaticField { get; set; }

        //обычные методы могут обращаться к статическим свойствам,

        public static void Show()   
        {
            Console.WriteLine(StaticField);
        }
        //// а статические методы к обычным свойствам - нет.
        //public  static void Show1()
        //{
        //    Console.WriteLine(NotStaticField);
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация статических полей необязательна.
            //MyStruct.StaticField = 1;

            MyStruct.Show(); //Мы на структуре-обьекте вызываем метод Show

            //Delay
            Console.ReadKey();
        }
    }
}
