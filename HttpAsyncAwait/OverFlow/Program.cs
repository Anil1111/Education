using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            short b = 25599; // если я выведу (byte)(b+1) , то будет 0001 0000 0000 а C# в типе short видет только 2 байта
                           // т.е он выведет 0!
                           // тожно так же если я сделаю short b = 25599 ошибки не будет , но при явном кастинге в byte у нас значение 
                           //обрежется и выведется 255
            Console.WriteLine((byte)b);

            //Delay
            Console.ReadLine();
        }
    }
}
