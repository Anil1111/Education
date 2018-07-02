using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Preprocessor_Directives
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.

#line 100500    //В окне ошибок покажет строку 100500
            Console.WriteLine(1); //Снять комментарий ТУТ. (строка с ошибкой)

            //Console.WriteLine();
            //2.

            Console.WriteLine("Строка #1");
#line hidden //Скрывает строку от отладчика.
            Console.WriteLine("Скрытая строка."); //Установить BreakPoint
#line default
            Console.WriteLine("Строка #2");

            //Delay
            Console.ReadKey();
        }
    }
}
