using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Task1
{
    class Rectangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public double Area => this.AreaCalculator();
        public double Perimeter => this.PerimeterCalculator();

        public Rectangle(double Side1, double Side2)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;
        }

        public double PerimeterCalculator()
        {
            return (this.Side1 + this.Side2) * 2;
        }

        public double AreaCalculator()
        {
            return this.Side1 * this.Side2;
        }
    }
}
