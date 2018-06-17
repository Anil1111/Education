using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_DeepCloning
{//Граф наследования клонируется глубоко
    class A { public int a = 1; }
    class B : A { public int b = 2; }//a унаследовалось
    class C : B { public int c = 3; }//a,b унаследовалось
    class X : C { } //a,b,c унаследовалось
    class Program : X //a,b,c унаследовалось
    {
        static void Main(string[] args)
        {
            Program original = new Program();
            Console.WriteLine("Оригинал :" + original.a + " " + original.b + " " + original.c);

            //Клонирование обьекта - клонирование выполняется глубоко т.е в памяти создаются клоны  class A, class B : A, class C : B, class X : C, Program.
            Program clone = original.MemberwiseClone() as Program;
            Console.WriteLine("Клон :" + clone.a + " " + clone.b + " " + clone.c);

            //Проверка на глубокое клонирование. 
            clone.a = clone.b = clone.c = 7;

            Console.WriteLine("Оригинал :" + original.a + " " + original.b + " " + original.c);
            Console.WriteLine("Клон :" + clone.a + " " + clone.b + " " + clone.c);
            //поля a,b,c поменялось ТОЛЬКО клоне потому, что СОЗДАЛСЯ ГРАФ НАСЛЕДОВАНИЯ с комиями текущих обьектов

            //Delay
            Console.ReadKey();
        }
    }
}
