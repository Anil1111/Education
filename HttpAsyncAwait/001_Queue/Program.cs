using System;
using System.Collections;

namespace _001_Queue
{
    class Program
    {
        //Стеком назваетс область памяти для хранения одресов возврата из процедур. Но так же есть коллекции Stack.
        //В стеке помещаются адреса возврата из процедур.
        //Есть команды push - поместить что-то в стек и pop - извлечь что-то из стека.
        //Прежде чем вызвать метод нужно:
        //1. поместить все аргументы в стек
        //2. прыгнуть туда, где лежить тело этого метода(выполняется команда pop - вытащить метод из стека)

        //Queue работает по принципу FIFO - First In - First Out
        //Stack работает по принципу LIFO - Last In- First Out
        static void Main(string[] args)
        {
            //Очередь - набор элементов, огранизованный по принципу FIFO  First In - First Out
            var queue = new Queue();

            queue.Enqueue("An item");            //Enqueue() - добавляет элемент в конец очереди.
            Console.WriteLine(queue.Dequeue());  //Dequeue() - озвращает первый элемент очереди ...

            //Delay
            Console.ReadKey();
        }
    }
}
