using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task3
{
    class Figure
    {
        private Point[] point;
        private string type;

        public string Type => type;

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public double PerimeterCalculator()
        {
            double sum = 0;
            for (int i = 0; i < point.Length - 1; i++)
            {
                sum += LengthSide(point[i], point[i + 1]);
            }

            sum += LengthSide(point[point.Length - 1], point[0]);
            return sum;
        }

        public Figure(Point p1, Point p2, Point p3)
        {
            point = new Point[3] { p1, p2, p3 };
            type = "Triangle";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            point = new Point[4] { p1, p2, p3, p4 };
            type = "Tetragon";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            point = new Point[5] { p1, p2, p3, p4, p5 };
            type = "Pentagon";
        }
    }
}
