using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Operators
{
    //Синтаксис перегрузки оператора.
    //Point operator + (Point p1, Point p2) - метод, где:
    //Point - тип возвращаемого методов значения,
    //operator + - имя метода,
    //(Point p1, Point p2) - агрументы метода

    public struct Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //Использовать ключевое слово operator, можно только вместе с ключевым словом static!
        //Перегрузка оператора +.
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public override string ToString()
        {
            return $"[{this.x}, {this.y}]";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);

            Point c = a + b;
            Console.WriteLine($"c = {c}");
            int g = 2, h = 4;
            int s = g + h; //Обычный оператор + остается. Т.е мы используем ту перегрузку оператора, которая нам нужна!
            Console.WriteLine(s);

            //Delay
            Console.ReadKey();
        }
    }
}
