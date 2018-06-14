using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Exception
{
    //Для создания пользовательского исключения, требуется наследование от System.Expection.
    class UserExpection : Exception //класс Exception является базовым классом для всех исключений! От него наследуются АБСОЛЮТНО все исключения. 
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
            catch (UserExpection e)
            {
                Console.WriteLine("Обработка исключения.");
                e.Method();
                //throw; - если просто слово throw, то подразумевается что выбрасываться будет исключение catch (UserExpection e).
                //т.е у нас возникло исключение, мы его словили, что-то сделали, а потом его пробросили ещё раз.
            }

            //Delay
            Console.ReadKey();
        }
    }
}
