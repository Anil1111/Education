using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack - список, организованный по принципу LIFO - Last In - First Out
            //Stack - это неправильная очеред наоборот.

            Stack stack = new Stack();
            stack.Push("An item");           // Push() - добавляет элемент в конец стека
            Console.WriteLine(stack.Pop());  // Pop() - возвращает первый элмент стека, удаляя его.

            //Delay.
            Console.ReadKey();
        }
    }
}
