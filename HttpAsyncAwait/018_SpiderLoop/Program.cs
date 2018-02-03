using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_SpiderLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            char character;
            bool flag = default(bool);
            for (; ; )
            {
                Start:
                flag = false;
                character = Console.ReadKey().KeyChar;
                switch (character)
                {
                    case 'l': // 'l' - охраняющее условие 1.
                        {
                            Console.WriteLine("Go left"); flag = true; break;//охраняемая команда
                        }
                    case 'r': // 'r' - охраняющее условие 2.
                        {
                            Console.WriteLine("Go right"); flag = true; break;//охраняемая команда
                        }
                }
                switch (character)
                {
                    case 'x': // 'x' - условие выхода 1.
                        {
                            Console.WriteLine("Exit"); goto End;//команда завершения
                        }
                    case 'q': // 'q' - условие выхода 2.
                        {
                            Console.WriteLine("Quit"); goto End;//команда завершения
                        }
                }
                //Ветвь альтернативного завершения
                if(flag)
                {
                    goto Start;
                }
                Console.WriteLine("Alternative exit");
                End:

                break; //прерывание цикла for
            }
            //Delay
            Console.ReadKey();
        }
    }
}
