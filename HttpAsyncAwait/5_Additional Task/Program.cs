using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Введите число для проверки:");
            int x = Convert.ToInt32(Console.ReadLine());
            s = x & (x - 1);
            
            //Допустим мы ввели 16  0001 0000  - 16
            //  отнимем еденицу     0000 0001  - 1
            //                      ---------
            //                      0000 1111  - 15
            //Теперь выполним операцию побитового И с этим числом
            // 0001 0000
            // 0000 1111
            // 0000 0000

            if (s == 0 )
            {
                Console.WriteLine("Число является степенью двойки");
            }
            else
            {
                Console.WriteLine("Число НЕ является степенью двойки");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
