using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Dynamic_operator_overload_restriction
{
    struct Point
    {
        private dynamic x, y;

        public Point(dynamic x, dynamic y)
        {
            this.x = x;
            this.y = y;
        }

        //Один из параметров БИНАРНОГО оператора, должен иметь тип класса/структуры где он объявлен.
        //public static dynamic operator +(dynamic pointA, dynamic pointB) //- ошибка
        public static dynamic operator +(Point pointA, dynamic pointB)
        {
            return new Point(pointA.x + pointB.x, pointA.y + pointB.y);
        }

        //В унарных операторах недопустимо использовать динамические типы(ВООБЩЕ).
        //public static  dynamic operator ++(dynamic pointA) //- недопустмоы
        public static Point operator ++(Point pointA)
        {
            return new Point(pointA.x + 1, pointA.y + 1);
        }

        public override string ToString()
        {
            return $"x = {x}, y = {y}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
