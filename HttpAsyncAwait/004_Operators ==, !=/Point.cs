using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Operators_______
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
        //Если перегружаем или == или !=, то другой оператор тоже нужно перегрузить, иначе - ошибка компиляции.
        //Перегружаем оператор ==    
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        //Перегружаем оператор !=
        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }
        public override string ToString()
        {
            return $"[{this.x}, {this.y}]";
        }
        //Переопределение Equals()
        // В исходной реализации, по умолчанию, Equals() поддерживаем сравнение только ссылочных типов.
        //Переопределние его для сравнения структурный типов
        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                if (((Point)obj).x == this.x && ((Point)obj).y == this.y)
                {
                    return true;
                }
            }

            return false;
        }
        //Переопределение GetHashCode обязательно при переопределении Equals();
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
