using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Params
{
    class Program
    {
        public static void ShowArray(string name, params int[] array)
        {
            Console.Write(name);
            for (int i = 0; i <array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
        static void Main(string[] args)
        {
            ShowArray("Numbers: ",1,2,3,4,5,6,7,8,9);

            //Delay
            Console.ReadKey();
        }
    }
}
