using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_NullableTypes
{
    //Значение по умолчанию для NullableTypes == null;
    class Program
    {
        private static int? i; //глобальной переменной присваивается значение по умолчанию, а локальным переменным - нет.
        static void Main(string[] args)
        {
            if (i == null)
            {
                Console.WriteLine("null");
            }
            else if (i == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("Другое");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
