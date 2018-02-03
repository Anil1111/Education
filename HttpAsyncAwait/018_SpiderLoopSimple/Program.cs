using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_SpiderLoopSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            char character;
            for (; ; )
            {
                character = Console.ReadKey().KeyChar;
                switch (character)
                {
                    case 'l': // 'l' - охраняющее условие 1.
                        {
                            Console.WriteLine("Go left"); continue;//охраняемая команда
                        }
                    case 'r': // 'r' - охраняющее условие 2.
                        {
                            Console.WriteLine("Go right"); continue;//охраняемая команда
                        }
                }
                switch (character)
                {
                    case 'x': // 'x' - условие выхода 1.
                        {
                            Console.WriteLine("Exit"); break;//команда завершения
                        }
                    case 'q': // 'q' - условие выхода 2.
                        {
                            Console.WriteLine("Quit"); break;//команда завершения
                        }
                    default: //Ветвь альтернативного завершения
                        {
                            Console.WriteLine("Alternative exit"); break;
                        }
                } 
                break; //прерывание цикла for
            }
            //Delay
            Console.ReadKey();
        }
    }
}
