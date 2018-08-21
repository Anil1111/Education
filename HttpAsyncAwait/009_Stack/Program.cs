using System;
using System.Collections;
using System.Collections.Generic;

namespace _009_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIFO
            var stack1 = new Stack();
            var stack = new Stack<string>(); //мы создаем экземпляр класса Stack of string

            //при добавлении каждый новый элемент становится ПЕРВЫМ(т.е с индексом 0), а в Queue - наоборот - ПОСЛЕДНИМ(так во многих коллекциях)
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            // Peek() - возвращает элемент с вершины стека, на удаляя его.
            Console.WriteLine(stack.Peek());

            //Pop - удаляет ПОСЛЕДНИЙ элемент из коллекции и возвращает его
            Console.WriteLine(stack.Pop()); 

            //Count - возвращает количество элементов в стеке(коллекции)
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            //Коллекция Stack используется для моделирования програмных стеков, решения математически уравнений и т.д
            //Delay
            Console.ReadKey();
        }
    }
}
