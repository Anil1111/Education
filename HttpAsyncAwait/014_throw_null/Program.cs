using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_throw_null
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Exception my = null;
                throw my;
                //throw null; // это одно и то же
            }
            catch (NullReferenceException e )
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }

            //Delay
            Console.ReadKey();
        }
    }
}
