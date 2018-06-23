using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_AdditionalTask1
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point operator +(Point pointA, Point pointB)
        {
            return new Point(pointA.X + pointB.X, pointA.Y + pointB.Y, pointA.Z + pointB.Z);
        }

        public override string ToString()
        {
            return $" x= {X}, y= {Y}, z= {Z}";
        }
    }
}
