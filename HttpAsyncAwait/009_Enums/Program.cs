using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Получение информации о количестве элементов перечисления. Получение всех элементов перечисления и их значений.
namespace _009_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enum.GetValues() - возвращает экземпляр System.Array, при этом каждому элементу массива
            // будет соответствовать член указанного перечисления.

            // Помещаем в массив элементы перечисления.
            Array array = Enum.GetValues(typeof(MyEnum));
            
            //Получаем информацию о количестве элементов в массиве.
            Console.WriteLine($"Это перечисление содержит {array.Length} членов \n");

            //Вывод на экран всех элементов перечисления.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Имя константы: {array.GetValue(i)}, значение {array.GetValue(i):D}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
