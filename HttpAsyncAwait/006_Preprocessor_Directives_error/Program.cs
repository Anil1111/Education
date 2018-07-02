using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Preprocessor_Directives_error
{
    class Program
    {
        static void Main(string[] args)
        {
            //#error - позволяет создавать ошибку ПЕРВОГО УРОВНЯ из определенного места в коде. Проект не сможет сбилдится.

            //#error Ошибка определенная пользователем //Снять комментарий

            Console.WriteLine(1);

            //Delay
            Console.ReadKey();
        }
    }
}
