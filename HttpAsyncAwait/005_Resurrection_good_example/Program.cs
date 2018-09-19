using System;

//Воскрешение (Resurrection) из мертвых
namespace _005_Resurrection_good_example
{
    internal sealed class SomeType
    {
        ~SomeType()
        {
            Console.WriteLine("Finalizer {0}", Program.counter++);

            // В этом случае при вызове метода Finalize объекта SomeType ссылка на него
            // помещается в статическую параменную живого объекта (Program)
            // и объект (SomeType) становится доступным из кода приложения.
            // Теперь объект "возрождается", а сборщик мусора не принимает его за мусор.
            Program.Instance = this;

            if (Program.counter < 50)
            {
                // Вызов ReRegisterForFinalize используется для повторного вызова деструктора
                GC.ReRegisterForFinalize(this); //ЭТО неотъемлевая часть любого воскрешения!
            }

            //ИТОГО: есть 2 очереди: Finalization Reachable и Finalization. 
            // -Если у объекта есть диструктор - он попадает в очередь Finalization Reachable, там выполняется его последнее
            //  желание - деструктор(в очереди Finalization Reachable нельзя убивать) и потом этот объект перемещается в очередь Finalization, где его убивают.
            //- Если у объекта нету деструктора - он сразу попадает в очередь Finalization и умирает.
        }
    }
    class Program
    {
        public static int counter;
        public static SomeType Instance { get; set; }
        static void Main(string[] args)
        {
            Instance = new SomeType();

            Instance = null; // Освобождение объекта (потеря ссылки), щас GC распустить свои шаловливые рученки на new SomeType().
            GC.Collect(); //Отработает деструктор ~SomeType() - мало того, что мы сделаем Program.Instance = this,
                          //так мы ещё и перевызовем деструктор GC.ReRegisterForFinalize(this) - ЭТО ОЧЕНЬ ВАЖНО. Без этого не получится ничего!

            //Delay
            Console.ReadKey();

            Instance = null; // Освобождение объекта (потеря ссылки);
            GC.Collect();  //Отработает деструктор ~SomeType() - мы оживим опять экземпляр класса SomeType

            //Delay
            Console.ReadKey();
        }
    }
}
