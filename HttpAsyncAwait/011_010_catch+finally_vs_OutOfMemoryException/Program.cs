using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_010_catch_finally_vs_OutOfMemoryException
{
    //finilly - cрабатывает в случае возникновения OutOfMemoryException.
    class Program
    {
        public static void Method()
        {
            int[] arr = new int[100000000];
            Console.WriteLine(arr);
            Method();
        }
        static void Main(string[] args)
        {
            try
            {
                Method();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
              //finally сработает
                Console.WriteLine("finally");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
