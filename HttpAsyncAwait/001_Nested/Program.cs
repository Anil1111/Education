﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Nested
{
    //Тип, определнный внутри класса или структуры, называется вложенным типом.
    //Экземпляр внутреннего класса не может существовать без привязки к включающему его классу верхнего уровня.
    class MyClass
    {
        public class NestedClass // если уберу public, то будет ошибка на 26 строке.
        {                         //т.е класс NestedClass будет доступен только для класса MyClass
            public void Method()
            {
                Console.WriteLine("Method from Nested Class");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Указывает весь путь вложенности через точку  MyClass.NestedClass
            MyClass.NestedClass instance = new MyClass.NestedClass();
            instance.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
