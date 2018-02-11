using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AdditionalTask
{
    class Program
    {
        private const int DivideInto = 5;

        static string DivideIntoValue(int i, int valueForDivisionEnteredParametr = 0, int number = DivideInto)
        {
            i--;
            if (i >= 0)
            {
                Console.WriteLine("Введите параметр");
                int valueForDivision = Convert.ToInt32(Console.ReadLine());
                return (valueForDivision / DivideInto) + "," + DivideIntoValue(i, valueForDivision);
            }
            return null;

        }
        static void Main(string[] args)
        {
            int iParametr = 3;
            var ww = DivideIntoValue(iParametr);
            Console.WriteLine(ww);

            //Delay
            Console.ReadKey();
        }
    }
}
