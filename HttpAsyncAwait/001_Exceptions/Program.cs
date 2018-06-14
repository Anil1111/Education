using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, n = 2;
            //пример с баскетбольным мячем с запиской(Exception e) и кольцом.
            try
            {
                //Попытка деления на ноль.
                a = a / (2 - n); // в процессоре вообще нету возможности поделить на 0.
                //код после исключения в блоке try НИКОГДА НЕ ВЫПОЛНИТСЯ
                Console.WriteLine("This message will not be shown.");
            }
            catch (Exception e) //DivideByZeroException -> ArithmeticException -> SystemException -> Exception
            {
                Console.WriteLine("Обработка исключения.");
                Console.WriteLine(e.Message);
                Console.WriteLine($"Тип исключения - {e.GetType()}");
            }

            //Delay
            Console.ReadKey();
        }
        //нарешуние стека - одно из самых сильных исключений и его нельзя "словить"
        //любые коды преобразуются в машинные коды и скармливаются процессору, а он их уже выполняет.    
    }
}
