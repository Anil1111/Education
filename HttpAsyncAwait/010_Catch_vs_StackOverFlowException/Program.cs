using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Catch_vs_StackOverFlowException
{
    //finally - НЕ сработает в случае возникновения StackOverflowException.
    class Program
    {
        public static void Method()
        {
            int [] arr = new int[10]; //с каждой итерацией в Stack записывается адрес возврата из процедуры и ссылка на созданный на куча массив arr.
            Console.WriteLine(arr);
            Method();
        }
        static void Main(string[] args)
        {
            try
            {
                //Method();
                //или так
                Action n = null;
                n = () => {
                    Console.WriteLine("!!!!!!");
                    n();
                };
                n();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //finally - не сработает
                while (true)
                {
                    Console.WriteLine("finally");
                }
            }
        }
    }
}
