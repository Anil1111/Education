using System;

namespace _016_try_finally_without_catch
{
    class Program
    {
        //Эта конструкция НЕ будет хэндлить исключения, но за то она гарантирует, что даже если в блоке try будет исключение, то finally отработает!
        //есть другие примеры, и finally СРАБОТАЕТ если в блоке и catch будет исключение, но если запускать через Ctr + F5
        static void Main(string[] args)
        {
            int i = 123;
            string s = "Some string";
            object obj = s;

            try
            {
                // Invalid conversion; obj contains a string, not a numeric type.
                i = (int)obj;

                // The following statement is not run.
                Console.WriteLine("WriteLine at the end of the try block.");
            }
            finally
            {
                //!!!!!!!!!!!!! To run the program in Visual Studio, type CTRL+F5. Then  
                // click Cancel in the error dialog.
                //Running ctrl + F5 will run the application without debugger.
                Console.WriteLine("\nExecution of the finally block after an unhandled\n" +
                                  "error depends on how the exception unwind operation is triggered.");
                Console.WriteLine("i = {0}", i);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
