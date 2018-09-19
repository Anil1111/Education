using System;
using System.Threading;

namespace _001_GarbageCollector
{
    /*
     Поколения (Генерации)
     Поколение 0 - объекты НЕ ПРОВЕРЯЛИСЬ сборщиком мусора
     Поколение 1 - Обьекты пережившие одну проверку сборщиком мусора
                   (а так же обьекты, помеченные как удаленные, но не удаленные, так
                   как на управляемой куче было достаточно свободного места)
     Поколение 2 - Объекты которые пережили более чем одну проверку сборщиком мусора
     */

    //Суть примера: поместить маленький обьект NormalObject на кучу и загружать кучу обьектами побольше - OtherObject 
    //и периодически отслеживать состояние маленького объекта NormalObject
    class NormalObject
    {
        byte[] array = new byte[1024]; // 1kb

        public NormalObject()
        {
            Console.WriteLine("Constructor {0}", this.GetHashCode());
        }

        ~NormalObject()
        {
            Console.WriteLine("Destructor {0}", this.GetHashCode());
        }
    }

    class OtherObject
    {
        byte[] array = new byte[1024 * 50]; //50 кб
    }
    class Program
    {
        static void AxiliaryMethod()
        {
            OtherObject[] objects = new OtherObject[1000];

            for (int i = 0; i < objects.Length; i++)
            {
                //Случай 1 - массив objects удерживает все экземпляры, а массив содержится в методе, а на метод ссылается делегат ThreadStart и GC понимает, что их удалять нельзя.
                objects[i] = new OtherObject();

                //Случай 2 - на обьекты @object никто ссылаться не будет и следовательно GC будет их удалять
                //OtherObject @object = new OtherObject();

                Thread.Sleep(5);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Система поддерживает {0} поколения", (GC.MaxGeneration + 1));
            Console.WriteLine(new string('-', 40));

            NormalObject normalObject = new NormalObject(); //запускаем маленький объект и будем периодически наблюдать за ним.

            //Паралельное наполнение малой кучи другими обьектами
            new Thread(AxiliaryMethod).Start();

            //Следуим за кучей
            for (int i = 0; i < 30; i++)
            {
                Console.Write("Поколение в котором находится normalObject: {0} | ", GC.GetGeneration(normalObject));
                Console.WriteLine("Размер кучи, занимаемый этим приложением = {0} КВ", GC.GetTotalMemory(false) / 1024); //1024 - чтобы результат был в КБ,
                //false - означает то, что я не буду просить GC запустить процесс сборки мусора каждый раз когда выполняется метод
                //если я заменю на true, то в //Случай 1 эффекта не будет. Нам все равно как часто GC проводит сборку мусора, у нас все объекты должны жить
                //а вот в //Случай 2 эффект будет и очень сильно заметный
                Thread.Sleep(100);

            }

            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Поколение 0 проверялось {0} раз", GC.CollectionCount(0));
            Console.WriteLine("Поколение 1 проверялось {0} раз", GC.CollectionCount(1));
            Console.WriteLine("Поколение 2 проверялось {0} раз", GC.CollectionCount(2));
            Console.WriteLine(new string('-', 40));

            //Запускать через Ctrl + F5
        }
    }
}
