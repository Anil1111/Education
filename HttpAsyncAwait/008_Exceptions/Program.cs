using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Exceptions
{
    class UserExpection : Exception
    {
        public void Method()
        {
            Console.WriteLine("My Exception!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserExpection();
            }
            catch (UserExpection userExpection)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Обработка исключения 1:");
                userExpection.Method();

                try
                {
                    //throw userExpection; // точно то же самое, что и throw; т.к мы исключение приняли и перебросили дальше.
                    throw; //throw(просто без ничего) сохраняет StackTrace. - его можно посомтреть в свойствах исключения. это порядок вызова методов, при котором 
                    //исключение произошло.
                }
                catch (UserExpection expection) //userExpection уже мне могу использовать т.к имя этой переменной занято
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Обработка исключения 2:");
                    expection.Method();
                }
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine("Press any key...");

            //Delay
            Console.ReadKey();
        }
    }
}
