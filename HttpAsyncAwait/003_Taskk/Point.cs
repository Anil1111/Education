using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Taskk
{
    class Point
    {
        private string name;
        private int x;
        private int y;

        public string Name => name;
        public int X => x;
        public int Y => y;

        public Point(string name,int x, int y )
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
    }
}
