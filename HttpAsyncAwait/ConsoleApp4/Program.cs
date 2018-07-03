using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNamespace; //тут назавыется так, а в dependencies - 001_Namespace. Я поменял имя после создания файла

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class my = new Class();
            my.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
