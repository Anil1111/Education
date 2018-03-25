using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _005_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            MyArray array= new MyArray(n);

            array.ShowMinValue();
            array.ShowMaxValue();

            array.ShowAvarage();
            array.Odd();

            //Delay
            Console.ReadKey();
        }
    }
}
