using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количесво клиентов");
            ulong clientsAmount = Convert.ToUInt64(Console.ReadLine());
            ulong result = 1;
            ulong variable = clientsAmount;
            do
            {
                result *= variable--;//Сначала умножение, а потом декремент т.к дек
                                     // декремент у нас ПОСТФИКСНЫЙ
            }
            while (variable > 0); //Кстати, можно и обычным while обойтись
                                  //просто 1я операция в do-while выполнится всегда,
                                  //а в while может не пустить
            Console.WriteLine($"Количество марштуров для {clientsAmount} клиентов равно {result}");

            //Delay
            Console.ReadKey();
        }
    }
}
