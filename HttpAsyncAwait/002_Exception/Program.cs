using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _002_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            //пользовательские исключения используются при разработке классов. один класс бросает
            //исключение -другой обрабатывает его.
            Exception ex = new Exception("My exception"); 

            try
            {
                //if(some condition) 
                throw ex;
            }
            catch (Exception e)
            {
                Console.WriteLine("Handling of my exception");
                Console.WriteLine(e.Message);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
