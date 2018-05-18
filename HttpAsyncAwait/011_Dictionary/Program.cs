using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cловарь:");

            var dic = new Dictionary<string,string>();

            dic.AddToDictionaty("table", "стол");
            dic.AddToDictionaty("apple", "яблоко");
            dic.AddToDictionaty("sun", "солнце");

            Console.WriteLine(dic.ToString());
            Console.WriteLine();
            Console.WriteLine($"В словаре {dic.Length} записей");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Введите номер записи в словаре");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Вы не ввели номер записи в словаре");
            }
            else
            {
                int number = Convert.ToInt32(str);
                Console.WriteLine(dic[number]);
            }

            Console.WriteLine("Введите значение для поиска");
            var p = Console.ReadLine();
            Console.WriteLine(dic[p]);
            
            //Delay
            Console.ReadKey();
        }
    }
}
