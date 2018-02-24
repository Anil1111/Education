using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Constructors
{//ВАЖНО:
    //Если вы создали пользовательский конструктор (принимающий аргументы),
    //то конструктор по умолчанию, АВТОМАТИЧЕСКИ СОЗДАВАТЬСЯ НЕ БУДЕТ, его прийдется создать явно.
    class Point
    {
        //Поля
        private int x, y;

        //Свойства
        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y => y;

        //Конструткор по умолчанию инициализирует значения по умолчанию.
        //Закоментировать!!
        public Point()
        {
            Console.WriteLine("Конструктор по умолчанию!");
        }
        //Пользовательский конструктор, инициализирует поля значениями заданными пользователем.
        public Point(int x, int y)
        {
            Console.WriteLine("Пользовательский конструктор!");
            this.x = x;
            this.y = y;
        }
    }
}
