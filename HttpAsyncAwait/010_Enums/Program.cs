using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Итог: мы можем сравнивать КАК переменные, ТАК И константы.
            MyEnum x = MyEnum.Five;
            MyEnum y = MyEnum.One;
            //if(x < y)                 //Первый вариант сравнения.
            if (MyEnum.Five < MyEnum.One) //Второй способ сравнения.
            {
                Console.WriteLine($"X = {x} (меньше чем ) Y = {y}");
            }
            else
            {
                Console.WriteLine($"Y = {y} (меньше чем ) X = {x}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
