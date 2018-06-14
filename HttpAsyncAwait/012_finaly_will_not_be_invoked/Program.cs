using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_finaly_will_not_be_invoked
{
    // finally - не срабатывает если не завершается работа блока catch.
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                //throw new Exception();

                // или так ...

                while (true)
                {
                    Console.WriteLine("catch");
                }
            }
            finally
            {
                //finally не сработает!
                while (true)
                {
                    Console.WriteLine("finally");
                }
            }

            //Delay
            Console.ReadKey();
        }
    }
}
