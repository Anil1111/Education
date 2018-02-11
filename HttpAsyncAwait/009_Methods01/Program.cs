using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Methods01
{//Вывод в двоичном формате числа, переданного в десятичном формате
    class Program
    {
        static void Converter(int n)
        {
            int temp = n % 2;
            if(n>=2)
                Converter(n/2);
            Console.Write(temp);
        }
        static void Main(string[] args)
        {
            int n = 12;
            Converter(n);


            int c = 18% 15;
            Console.WriteLine(c);
            //Delay
            Console.ReadKey();
        }
    }
}
