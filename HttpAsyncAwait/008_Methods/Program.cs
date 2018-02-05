using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Methods
{
    class Program
    {//Пример: использование сторожевого оператора, для защиты номинального варианта.

        static string Function(string name)
        {
            //Выполняем проверку. При обнаружении ошибок завершаем работу.
            if(name == "fool") //Сторожевой оператор.
            {
                return "Вы использовали недпустимое имя";
            }
            //Код номинального варианта
            string sentance = "Hello " + name + "!";
            return sentance;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string word = Console.ReadLine();
            string sentance = Function(word);
            Console.WriteLine(sentance);

            //Delay
            Console.ReadKey();
        }
    }
}
