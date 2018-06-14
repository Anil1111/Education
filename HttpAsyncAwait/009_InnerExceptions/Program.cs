using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_InnerExceptions
{
    class ClassWithException
    {
        public void ThrowInner()
        {
            throw new Exception("Это внутренее исключение!");
        }

        public void CatchInner()
        {
            try
            {
                ThrowInner();
            }
            catch (Exception exception) //это следствие возникновение new Exception("Это внутренее исключение!"); исключения. 
            { //Если бы оно не возникло то мы бы никогда не вошли в блок catch и не вызвалось бы new Exception("Это внешнее исключение!", exception);
                throw new Exception("Это внешнее исключение!", exception); //в этом исключении есть инфо об внутреннем исключении.
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            ClassWithException instance = new ClassWithException();
            //instance.CatchInner(); // попробовать вызвать
            try
            {
                instance.CatchInner();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception caught: {0}", exception.Message);
                Console.WriteLine("Inner Exception : {0}", exception.InnerException?.Message);
            }

            //Delay
            Console.ReadKey();
        }
        //во 'View Detail' - смотрим на Inner Exception - это настоящая причина внешнего исключения. И именно внутренние исключения нужно фиксить.
        //ВНЕШНЕЕ исключение - это причина ВНУТРЕННЕГО.
    }
}
