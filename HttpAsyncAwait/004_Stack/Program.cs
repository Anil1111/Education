 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push("First"); //послений добавленный элемент окажется под индексом [0]
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            // Peek() возвращает элемнт в сершины стека, НЕ удаляя его
            string element = stack.Peek() as string; //Fourth
            Console.WriteLine(element);

            if (stack.Peek() is string)
            {
                Console.WriteLine(stack.Pop()); // Pop() - возвращает первый элмент стека, удаляя его.
            }

            // Count - возвращает количество элементов в стеке
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}

