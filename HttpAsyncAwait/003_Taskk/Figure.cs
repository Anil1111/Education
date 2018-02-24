using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Taskk
{
    class Figure
    {
        private Point[] points;
        private string type;

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow (B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public string Type => type;

        public double PerimeretCalculator()
        {
            double sum = 0;
            for (int i = 0; i < points.Length-1; i++)
            {
                sum += LengthSide(points[i], points[i + 1]);
            }

            sum += LengthSide(points[points.Length - 1], points[0]);
            return sum;
        }

        public Figure(Point p1, Point p2, Point p3)
        {
            points=new Point[]{p1,p2,p3};
            type = "Triangle";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3,p4 };
            type = "Tetragon";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4,Point p5)
        {
            points = new Point[] { p1, p2, p3, p4,p5 };
            type = "Pentagon";
        }
    }
}
