using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ICloneable
{
    class Point : ICloneable
    {
        public int x, y;

        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //Реализация метода интерфейса ICloneable
        public object Clone()
        { //создается глубокая копия с помощью конструктора
            return new Point(this.x, this.y); 
        }

        public override string ToString()
        {
            return $"X: {this.x} Y: {this.y}";
        }
    }
}
