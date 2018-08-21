using System;
using System.Collections;
using System.Collections.Generic;

namespace _008_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIFO
            //Суть Queue в том, что она представляет абстракцию очереди. И есть 2 метода Enqueue и Dequeue.
            //Пользуемся этими методами и ниочем не задумываемся.

            var queue1 = new Queue(); //И в гетерогенной и в обобщенной версии главные методы одинаковы.
            var queue = new Queue<string>(); //обобщенная версия
            //при добавленнии новый элемент становится ПОСЛЕДНИМ(а в Stack`е наоборот- первым.)
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            //Peek() - возвращает первый элемент из очереди не удаляя его.
            object element = queue.Peek();
            Console.WriteLine(element); //Выведет First

            Console.WriteLine(new string('-', 20));

            Console.WriteLine(queue.Dequeue()); //метод Dequeue удаляет элемент и возвращает его

            //Count - вовзращает количество элемнтов в очереди.
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            //Delay
            Console.ReadKey();
        }
    }
}
