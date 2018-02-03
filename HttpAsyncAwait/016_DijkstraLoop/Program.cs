using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_DijkstraLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = '\0';
            for (; ; )
            {  
                character = Console.ReadKey().KeyChar;
                switch (character)
                {
                    case 'l': // 'l' - охраняющее условие 1.
                        {
                            Console.WriteLine("Go left"); //охраняемая команда
                            continue;
                        }
                    case 'r': // 'r' - охраняющее условие 2.
                        {
                            Console.WriteLine("Go right"); //охраняемая команда
                            continue;
                        }
                }
                break;
            }
            //Delay
            Console.ReadKey();
        }
    }
}
