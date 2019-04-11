using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            //Peek() - вовзвращает первый элемент из очережи не удаляя его.
            object element = queue.Peek(); //как буд-то спрашуют "Кто первый?"
            Console.WriteLine(element as string); //First

            Console.WriteLine(new string('-', 10));

            if (element is string)
            {
                Console.WriteLine(queue.Dequeue()); // облучиваем ПЕРВЫЙ элемент в очереди и выкидываем его из очереди(возвращает его)
            }

            Console.WriteLine(new string('-', 10));

            // Count - возвращает количество элементов в очереди
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue()); //Second, Third, Fourth.
            }

            //Delay
            Console.ReadKey();
        }
    }
}
