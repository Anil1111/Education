using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сравнение значяений разных типов
            bool result = false;

            int a = 1;
            float b = 2.0f;
            result = a < b; //Сравнение типа int , со значением типа float - допустимо.

            string c = "Hello";
            //result = c < a; //Сравнение значения типа int, со значением типа string - не допустимо.

            //Delay
            Console.ReadKey();
            
        }
    }
}
