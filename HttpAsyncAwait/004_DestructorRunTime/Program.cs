using System;
using System.Threading;

namespace _004_DestructorRunTime
{
    //Если мы в теле деструктора укажем код, который будет выполнятся долго, то его выполнение
    //принудительно прирвется через определенный промежуток времени. 
    public class MyClass
    {
        //Время жизни деструктора ограничено
        //(индивидуально для разных конфигураций систем)
        ~MyClass()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
    class Program
    {
        //На проект(004_DestructorRunTime) -> ПКМ -> Properties -> Build -> check the "Optimize Code" checkbox
        static void Main(string[] args)
        {
            //ВАРИАНТ 1 ---------------------------- Запускаем через Ctrl + F5
            //MyClass my = new MyClass(); //через 3 секунды работа деструктора прирвется

            //ВАРИАНТ 2 ---------------------------- Запускаем через Ctrl + F5
            //MyClass my = new MyClass(); //деструктор не сработает вовсе.
            //Console.ReadKey();  

            //ВАРИАНТ 3 ---------------------------- Запускаем через Ctrl + F5
            MyClass my = new MyClass();
            GC.Collect(); //Собираем мусор.Заставляет сборщик мусора проверить все объекты: живы они или нет. Деструктор сработал полностью. Даже если поставлю int i = 0; i < 99; i++ будет ждать 99 секунд.
            Console.ReadKey(); //если убрать Console.ReadKey();, то деструктор не сработает вовсе.
        }
    }
}
