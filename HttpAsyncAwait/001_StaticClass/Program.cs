using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_StaticClass
{

    class Program
    {
        static void Main(string[] args)
        {
            //мы не можем сделать так:
            //StaticClass instance = new StaticClass();

            StaticClass.StaticMethod();

            //Delay
            Console.ReadKey();  //Консоль - клавиатура+экран. Консоль может быть только одна. 
                                //- такие сущности называются СИНГЛЕТНЫМИ
        }
    }
}
