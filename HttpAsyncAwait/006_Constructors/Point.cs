using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Constructors
{
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
