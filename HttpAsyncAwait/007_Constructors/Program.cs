﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Применение конструтора по умолчанию.
            Point pointA = new Point();
            Console.WriteLine($"pointA.X = {pointA.X} pointA.Y = {pointA.Y}");

            Console.WriteLine(new string(' ', 50));

            //Применяем конструктор с параметрами.
            Point pointB = new Point(100, 200);
            Console.WriteLine($"pointB.X = {pointB.X} pointB.Y = {pointB.Y}");

            //Delay
            Console.ReadKey();
        }
    }
}
