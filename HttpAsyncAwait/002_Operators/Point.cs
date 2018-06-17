using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Operators
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
        public override string ToString()
        {
            return $"[{this.x}, {this.y}]";
        }
    }
}
