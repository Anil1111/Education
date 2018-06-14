using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Exceptions_where_to_catch
{
    //Обработка исключений. (Порядок обработки исключений)
    class MyExceptionA : Exception
    {
        public MyExceptionA(string message)
           : base(message)
        { }
    }

    class MyExceptionB : MyExceptionA
    {
        public MyExceptionB(string message)
            : base(message)
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new Exception("Exception");
                throw new MyExceptionA("MyExceptionA");
                //throw new MyExceptionB("MyExceptionB");
            }
            //catch (Exception e)     //попробуй раскоментить - будет ошибка!
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch (MyExceptionB e)                                                         //Самый большой мяч
            {
                Console.WriteLine(e.Message);
            }
            catch (MyExceptionA e)                                                         //Средний мяч
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)                                                            //Самый маленький мяч
            {
                Console.WriteLine(e.Message);
            }
            //т.е чем ВЫШЕ класс исключения в наследовании, тем НИЖЕ он должен быть в блоке catch
            //Delay
            Console.ReadKey();
        }
    }
}
