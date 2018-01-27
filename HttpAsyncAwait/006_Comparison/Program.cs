using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Операция сравнения и проверка на равенство (<, <=, >, >=, ==, !=)
            byte value1 = 0, value2 = 1;
            bool result = false;

            //Less than
            result = value1 < value2;
            Console.WriteLine(result);

            //Greater than
            result = value1 > value2;
            Console.WriteLine(result);

            //Less than or equal to
            result = value1 <= value2;
            Console.WriteLine(result);

            //Greater than or equal to
            result = value1 >= value2;
            Console.WriteLine(result);

            //Equals
            result = value1 == value2;
            Console.WriteLine(result);

            //Not equals
            result = value1 != value2;
            Console.WriteLine(result);

            //Delay
            Console.ReadLine();
        }
    }
}
