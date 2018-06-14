using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, n = 2;
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Попытка деления на ноль");
                Console.WriteLine("a / (2 - n) = {0}", a / (2 - n));
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Обработка исключения");
                Console.WriteLine(e.Message);
            }
            finally //finally выполнится всегда(независимо от того: было исключение или не было исключения). если бы его не было нужно было бы блок кода дублировать и try и catch
            {//т.к мы не знаем, выполнится ли catch(будет ли исключение вообще), а если будет исключение, то в блоке try часть кода может не выполниться.
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            //try //дублирование кода.
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("Попытка деления на ноль");
            //    Console.WriteLine("a / (2 - n) = {0}", a / (2 - n));
            //    //
            //    Console.ForegroundColor = ConsoleColor.Gray;
            //    Console.BackgroundColor = ConsoleColor.Black;
            //}
            //catch (Exception e)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.BackgroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Обработка исключения");
            //    Console.WriteLine(e.Message);
            //    //
            //    Console.ForegroundColor = ConsoleColor.Gray;
            //    Console.BackgroundColor = ConsoleColor.Black;
            //}

            Console.WriteLine("Press any key...");

            //Delay
            Console.ReadKey();
        }
    }
}
