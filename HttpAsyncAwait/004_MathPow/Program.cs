using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_MathPow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math.Pow - возведеие числа в степень( 1-й аргумент - число, которое возводим в степень,
            // 2-й - степень , в которую возводим 1-й агрумент

            double x = 2, y = 8;
            double result = Math.Pow(x, y);
            Console.WriteLine(result);

            //Dealy
            Console.ReadLine();
        }
    }
}
