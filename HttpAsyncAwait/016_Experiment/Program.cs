using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Experiment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число:");
            //Принимаем ввод от пользователя и преобразуем его в целочисленное значение
            string operand2 = Console.ReadLine();
            //int summand2 = Int32.Parse(operand2);

            bool isParsed;
            int result;
            isParsed = int.TryParse(operand2, out result);

            Console.WriteLine($"{result} ");

            //Delay
            Console.ReadKey();
        }
    }
}
