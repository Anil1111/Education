using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = 20;
            double h = 10;
            const double pi = Math.PI;

            //double V = pi * Math.Pow(R, 2)* h;
            //double S = 2 * pi * R*(R + h); 
            
            //Можно и так и так

            Console.WriteLine($"Площадь поверхности цилиндра {2 * pi * R * (R + h)}");
            Console.WriteLine($"Обьем цилиндра {pi * Math.Pow(R, 2)* h}");

            //Delay
            Console.ReadLine();


            
        }
    }
}
