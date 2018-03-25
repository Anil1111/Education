using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Params
{//Параметр с ключевым словом params, должен быть ТОЛЬКО ОДИН и стоять ПОСЛЕДНИМ в списке параметров метода.
    class Program
    {
        static void ShowArray(string name, params int[] array)
        {
            Console.Write(name);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
            }
        }
        static void Main(string[] args)
        {
            ShowArray("Number: ",0,1,2,3,4,5,6,7,8,9);

            //Delay
            Console.ReadKey();
        }
    }
}
