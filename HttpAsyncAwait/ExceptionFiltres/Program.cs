using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFiltres
{
    /// <summary>
    /// Фильтры исключений, помагают отловить НУЖНУЮ ошибку
    /// </summary>
    class MyException : Exception
    {
        public int ErrorCode { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyException { ErrorCode = 3 };
            }
            catch (MyException ex) when(ex.ErrorCode ==1)
            {
                Console.WriteLine("First Catch");
            }
            catch (MyException ex) when (ex.ErrorCode == 2)
            {
                Console.WriteLine("Second Catch");
            }
            catch (MyException ex) when (ex.ErrorCode == 3)
            {
                Console.WriteLine("Third Catch");
            }
            catch (Exception)
            {
                Console.WriteLine("Last Catch");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
