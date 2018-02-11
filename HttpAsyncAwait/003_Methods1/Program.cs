using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Methods1
{//Перегрузка методов
    class Program
    {
        static void Operation()                                              //1-я перегрузка
        {
            Operation("val",10,12.2);
        }
        static void Operation(string value1)                                //2-я перегрузка
        {
            Operation(value1,10,12.2);
        }
        static void Operation(string value1, int value2)                    //3-я перегрузка
        {
            Operation(value1,value2,12.2);
        }
        static void Operation(string value1, int value2, double value3)     //4-я перегрузка
        {
            Console.WriteLine($"{value1}, {value2}, {value3}");
        }
        static void Main(string[] args)
        {
            Operation();
            Operation("val");
            Operation("val",10);
            Operation("val",10,12.2);

            //Delay
            Console.ReadKey();
        }
    }
}
