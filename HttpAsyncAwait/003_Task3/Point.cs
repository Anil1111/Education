using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task3
{
    class Point
    {
        private int x;
        private int y;
        public string nameOfPoint;

        public int X => x;
        public int Y => y;
        public string NameOfPoint => nameOfPoint;

        public Point(int x, int y, string nameOfPoint)
        {
            this.x = x;
            this.y = y;
            this.nameOfPoint = nameOfPoint;
        }

    } 
}
