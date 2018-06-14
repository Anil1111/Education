using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("My exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("Expection handling");
                Console.WriteLine(e.Message);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
