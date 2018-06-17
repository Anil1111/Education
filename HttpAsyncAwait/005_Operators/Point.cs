using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Operators
{
    //Использовать ключевое слово operator, можно только вместе с ключевым словом static!
    public struct Point: IComparable
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"[{this.x}, {this.y}]";
        }

        public static bool operator <(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) < 0);
        }
        public static bool operator >(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) > 0);
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) <= 0);
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) >= 0);
        }
        //Реализация интерфейса IComparable
        public int CompareTo(object obj) //посколько тут сравниваются ОБЬЕКТЫ класса Point, а этот МЕТОД ВЫЗЫВАЕТСЯ НА ОБЪЕКТЕ ТИПА Point
        {// то один сравниваемый обьект будет this. т.к МЫ ВЫЗВАЛИ МЕТОД НА ОБЪЕКТЕ - а другой - тот, который передается как аргумент.
            if (obj is Point)
            {
                Point p = (Point) obj;
                if (this.x > p.x && this.y > p.y)
                {
                    return 1;
                }
                else if (this.x < p.x && this.y < p.y)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException("Переданный в метод аргумент нельзя привести с Point");
            }
        }
    }
}
