﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_IsAs
{//операторы is и as
    class ClassA { /* ...*/}
    class ClassB:ClassA { /* ...*/}

    class Program
    {
        static void Main(string[] args)
        {
            ClassB b = new ClassB();
            ClassA a = null;
            //-----------------------------------is----------------------------------------
            //Оператор is - проверяет совместимость обьекта с заданным типом.
            //Если предоставленный обьект может быть приведен к предоставленному типу не вызывая исключение,
            //выражение is принимает значение true

            //Например, в следующем коде определяется, является ли обьект экземпляром типа А или типа, производного А

            if (b is ClassA)
            {
                a = (ClassA) b; //Это UpCast и (ClassA) можно не писать
            }
            else
            {
                a = null;
            }

            //-----------------------------------as----------------------------------------
            // Оператор as используется для выполнения преобразований между совместимыми ссылочными типами.
            // Оператор as подобен оператору приведения. Однако, если проебразование невозможно,
            // as возвращает значение null, а не вызывает исключение.

            // В общем виде логика работы оператора as представляет собой механизм использование оператора is
            // (пример от 25й до 32 стоки включительно), только в сокращенном виде.

            a=b as ClassA;
            
            //Delay
            Console.ReadKey();
        }
    }
}
