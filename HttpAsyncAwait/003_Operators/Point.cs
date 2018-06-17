using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Operators
{
    //Использовать ключевое слово operator, можно только вместе с ключевым словом static!
    public struct Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //Перегружаем оператор инкремента
        public static Point operator ++(Point p1)
        {
            return new Point(p1.x + 1, p1.y + 1);
        }
        //Перегружаем оператор декремента
        public static Point operator --(Point p1)
        {
            return new Point(p1.x - 1, p1.y - 1);
        }
        public override string ToString()
        {
            return $"[{this.x}, {this.y}]";
        }
    }
}
