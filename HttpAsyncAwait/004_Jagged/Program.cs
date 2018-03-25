using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];

            jagged[0] = new[] { 1, 2, 3 };
            jagged[1] = new[] { 4, 5, 6 };
            jagged[2] = new[] { 7, 8, 9 };

            //Во  внешнем цикле выполняется проход по всем вложенным массивам.
            for (int i = 0; i < jagged.Length; i++)
            {
                //Во внутреннем цикле выполняется обращение к каждому  элементу вложенного массива.
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]}");
                }
                Console.Write("\n");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
