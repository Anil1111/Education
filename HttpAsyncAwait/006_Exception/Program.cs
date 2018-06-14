using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception = System.Exception;

namespace _006_Exception
{
    //Для создания пользовательского исключения, требуется наследование от System.Expection.
    class MyExpection : Exception
    {
        public void Method()
        {
            Console.WriteLine("Мое исключение!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyExpection();
            }
            catch (MyExpection myExpection)
            {
                Console.WriteLine("Обработка исключения.");
                myExpection.Method();
                try
                {
                    FileStream fs = File.Open(@"C:\NonExistentFile.log", FileMode.Open);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.GetType()); //System.IO.FileNotFoundException
                }
            }

            //Delay
            Console.ReadKey();
        }
    }
}
