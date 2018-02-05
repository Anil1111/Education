using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Methods
{
    class Program
    { //Методы с ИЗМЕНЯЕМЫМИ параметрами (ref = in/out)

        //Если в теле метода выполнится изменение значения переменной 
        //КОТОРАЯ БЫЛА ПЕРЕДАНА ПО ССЫЛКЕ, ее значение будет изменено везде
        static int Method(ref int a)
        {
            int b = 2 * a;
            a = 5;
            return b;
        }
        static void Main(string[] args)
        {
            int operand = 2;
            int result = Method(ref operand);
            Console.WriteLine($"{operand} ; {result}");

            //Delay
            Console.ReadKey();
        }
    }
}
