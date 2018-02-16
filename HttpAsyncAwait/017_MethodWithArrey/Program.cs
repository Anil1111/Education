using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_MethodWithArrey
{
    class Program
    {
        public static int[] ModifyArray(int[] array, int modifier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= modifier;
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int modifier = 60;
            var myArray = ModifyArray(array, modifier);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
