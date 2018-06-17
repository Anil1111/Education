using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Operators
{
    //Использовать ключевое слово operator, можно только вместе с ключевым словом static!
    //Суть примера: как только я перегружу оператор - я сразу могу его использовать в том же классе/структуре где он был перегружен.
    public struct Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }
        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.x * p2.x, p1.y * p2.y);
        }
        public static Point operator /(Point p1, Point p2)
        {
            return new Point(p1.x / p2.x, p1.y / p2.y);
        }

        //Методы
        public override string ToString()
        {
            return $"[{this.x}, {this.y}]";
        }
        //Operator + через Add
        public static Point Add(Point p1, Point p2)
        {
            return p1 + p2;
        }
        //Operator - через Subtract
        public static Point Subtract(Point p1, Point p2)
        {
            return p1 - p2;
        }
    }
}
