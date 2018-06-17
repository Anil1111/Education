using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_GetHashCode
{
    class MyClass
    {
        //Переопределять только GetHashCode() - это плохой подход. Его нужно переопределять в связке с Equals()
        //Закомментировать - выведется hash, который присвоила система экземпляру
        public override int GetHashCode() 
        {
            return 1234567890;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            Console.WriteLine(instance.GetHashCode());

            //Delay
            Console.ReadKey();

        }
    }
}
