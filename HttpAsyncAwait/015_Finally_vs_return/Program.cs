using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Finally_vs_return
{
    class Program
    {
        static void Method()
        {

            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine("catch");
                return;
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
        static void Main(string[] args)
        {
            Method(); //сначала finally, а потом уже return;

            //Delay
            Console.ReadKey();
        }
    }
}
