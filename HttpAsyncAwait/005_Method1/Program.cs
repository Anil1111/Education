﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Method1
{
    //Возвращение значеинй из метода Main()
    //По завершении порограммы имеется возможность вернуть значение из метода Main () вызывающему процессу или
    //операционной системе.
    //Возвращаемое значение метода Main() может быть только типа int.
    //Как правило, значение , возвращаемое значение методом Main(), указывает на нормальное завершение программы,
    //или на аварийное ее завершение из-за сложившихся ненормальных условий выполнения.
    //Условно нулевое возвращаемое значение обычно указыает на нормальное завершение программы,
    //а все остальные значения обозначают тип возникшей ошибки.
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello world");

            //Delay
            Console.ReadKey();

            return 0;
        }
    }
}
