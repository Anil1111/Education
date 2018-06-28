using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002_AwaitInCatchAndFinally
{
    /// <summary>
    /// Использование оператора Await в блоках catch и finally.
    /// До C# 6.0 нельзя было использовать.
    /// </summary>
    class Program
    {
        public static async void TestFunctionAsync()
        {
            try
            {
                throw new Exception();
            }
            catch
            {
                Console.WriteLine("Start Task Catch!");
                await Task.Delay(1000);
                Console.WriteLine("Done Task Catch");
            }
            finally
            {
                Console.WriteLine("Start Task Finally");
                await Task.Delay(1000);
                Console.WriteLine("Done Task Finally");
            }
        }
        static void Main(string[] args)
        {
            TestFunctionAsync();
            Console.WriteLine("Done!");
            Thread.Sleep(2000);

            //Delay
            Console.ReadKey();
        }
    }
}
