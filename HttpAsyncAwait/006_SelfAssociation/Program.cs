using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_SelfAssociation
{
    class  MyClass
    {
        private MyClass instance;

        public MyClass()//StackOverfowException
        {
            Console.WriteLine("Constructor MyClass");
            //Самоассациация после первой попытки инстанцирования приводит к циклическому инстанцированию
            instance = new MyClass();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            //Delay
            Console.ReadKey();
        }
    }
}
