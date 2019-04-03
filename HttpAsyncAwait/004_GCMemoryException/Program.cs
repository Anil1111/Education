using System;

//Большие объекты размещаются в БОЛЬШОЙ КУЧЕ и сразу относятся ко ВТОРОМУ поколению.
namespace _004_GCMemoryException
{
    //BigObject - ОБЕРТКА для большого объекта. Будет размещен в МАЛОЙ КУЧЕ и будет ссылатться на то, что внутри - на БОЛЬШОЙ КУЧЕ.
    public class BigObject
    {
        //Действительно большой объект. Будет размещен на БОЛЬШОЙ КУЧЕ.
        // 100 000 000 * 4Б = 400 000 000 Б = 390 625 КБ = 381 МБ
        public Array array = new int[100000000];

        public BigObject() => Console.WriteLine("Сonstructor {0}", this.GetHashCode());
        ~BigObject() => Console.WriteLine("Объект {0} удален", this.GetHashCode());
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Mассив объектов - BigObject
            //Массив будет наполняться объектами по 381 МБ
            //381 * 1000 = 381 000 МБ = 372 ГБ - размер всего массива. Очень много для ОЗУ
            BigObject[] objects = new BigObject[1000];

            try
            {
                for (int i = 0; i < objects.Length; i++)
                {
                    objects[i] = new BigObject(); //щас будет OutOfMemoryException потому, что массив будет ссылаться на объекты и GC не сможет их удалить.
                    //BigObject @object = new BigObject(); // optimize. А вот щас объекты будут создаваться, а СБОРЩИК МУСОРА будет успевать все очищать и у нас выполнится весь цикл
                }
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
