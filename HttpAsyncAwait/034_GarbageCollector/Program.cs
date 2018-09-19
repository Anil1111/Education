using System;
using System.Threading;

namespace _034_GarbageCollector
{
    //ЛУЧШЕ НЕ ВМЕШИВАТЬСЯ в работу уборщика мусора!
    class Program
    {
        //Поколения (Генерации)
        //Поколение 0 - объекты НЕ ПРОВЕРЯЛИСЬ сборщиком мусора
        //Поколение 1 - Обьекты пережившие одну проверку сборщиком мусора
        //              (а так же обьекты, помеченные как удаленные, но не удаленные, так
        //              как на управляемой куче было достаточно свободного места)
        //Поколение 2 - Объекты которые пережили более чем одну проверку сборщиком мусора
        static void Main(string[] args)
        {
            Thread.Sleep(4000);

            // Смотрим Размер памяти в байтах которую занимают объекты на управляемой куче.
            // Метод GetTotalMemory() возвращает размер памяти в байтах которую занимают объекты на управляемой куче.
            // Этот метод принимает параметр, указывающий, запускать или нет процесс сборки мусора.
            Console.WriteLine("Размер памяти в байтах в управляемой куче: {0}", GC.GetTotalMemory(false)); //true ставим если хотим, чтобы перед выполнением метода GetTotalMemory() выполнилась сборка мусора

            // Свойство MaxGeneration - возвращает максимальное количество поколений,
            // поддерживаемое данной системой. (Отсчет с нуля поэтому + 1)
            Console.WriteLine("Система поддерживает {0} поколения.\n", (GC.MaxGeneration + 1));

            //Создается ссылка на этот объект и присваивается переменной car.

            Car car = new Car("RENAULT", 120);

            //Перегруженный ToString()
            Console.WriteLine(car.ToString());

            //Метод GetGeneration() возвращаем поколение к которому относится данный объект.
            Console.WriteLine("\nОбъект car отностися к {0} поколению", GC.GetGeneration(car));

            Console.WriteLine("Размер памяти в байтах в управляемой куче: {0}", GC.GetTotalMemory(false));

            //Массив объектов для тестирования.
            object[] array = new object[10000000];

            ShowGCStat();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new object();
            }

            Console.WriteLine("Размер памяти в байтах в управляемой куче: {0}", GC.GetTotalMemory(false));
            array = null;

            Console.WriteLine("\nМассив построен, запускаем GC ");

            ShowGCStat();
            var start = DateTime.Now;
            //Метод Collect - дает указание сборщику мусора проверить объекты определенного поколения(В данном случае 2)
            GC.Collect(2);

            // Метод WaitForPendingFinalizers() - приостанавливает выполнение текущего потока, пока
            // не будут отработаны все объекты, предусматривающие финализацию.
            // Вызывается обычно непосредственно после вызова GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("GC отработал                    " + (DateTime.Now - start).TotalMilliseconds + " miliseconds\n");
            Console.WriteLine("Размер памяти в байтах в управляемой куче: {0}", GC.GetTotalMemory(false));
            Console.WriteLine("\nОбъект car относится к {0} поколению.\n", GC.GetGeneration(car));

            //Метод CollectionCount() - возвращаем числовое значение, сколько раз данная генерация(поколение) выживала при сборке мусора

            ShowGCStat();

            //Delay
            Console.ReadKey();
        }

        private static void ShowGCStat()
        {
            Console.WriteLine("\nПоколение 0 проверялось {0} раз", GC.CollectionCount(0));
            Console.WriteLine("\nПоколение 1 проверялось {0} раз", GC.CollectionCount(1));
            Console.WriteLine("\nПоколение 2 проверялось {0} раз", GC.CollectionCount(2));
        }
    }
}
