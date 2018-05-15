using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _002_AdditionalTask_MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            var str = Console.ReadLine();
            var u = String.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);

            var list = new MyList<int>();

            var t = new Random();
            for (int i = 0; i < u; i++)
            {
                list.Add(t.Next(100));
            }
            Console.WriteLine("Массив элементов:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите значение для поиска:");
            var enteredValue = Console.ReadLine();
            if (list.Contains(Convert.ToInt32(enteredValue)))
            {
                Console.WriteLine($"Введенное значение {enteredValue} содержится в массиве.");
            }
            else
            {
                Console.WriteLine("Значение не найдено.");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
