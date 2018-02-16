using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_ThreeDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[3, 3, 3]
            {
                {{1,2,3 },{4,5,6 },{7,8,9}},
                {{1,2,3 },{4,5,6 },{7,8,9}},
                {{1,2,3 },{4,5,6 },{7,8,9}}
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(array[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
