using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Equals_obj1__obj2__vs_obj1.Equals_obj2_
{
    class Point : Object
    {
        protected int x, y;

        public Point(int xValue, int yValue)
        {
            this.x = xValue;
            this.y = yValue;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Point p = (Point)obj;
            return (p.x == this.x) && (p.y == this.y);
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 2);
            Point c = new Point(0, 0);

            Console.WriteLine("a == b : {0}", a.Equals(b));
            Console.WriteLine("a == c : {0}", a.Equals(c));

            Console.WriteLine("a == b : {0}", Equals(a, b)); //Статический метод Equals(obj1, obj2) можем вызывать без 'Object.' потому, что все наследуется от Object!
            Console.WriteLine("a == c : {0}", Object.Equals(a, c));

            Console.WriteLine(Equals(null,null)); // а тут не возникает!
            string d = null;
            Console.WriteLine(d.Equals(null)); //возникает NullReference Exception

            //Delay
            Console.ReadKey();

        }
    }
}
