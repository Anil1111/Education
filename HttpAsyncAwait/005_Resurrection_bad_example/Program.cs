using System;

//Воскрешение (Ressurection) из мертвых.
namespace _005_Resurrection_bad_example
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

            if (Program.counter < 3) //если закоментить блок if полностью, то получится рекурсия - я только выполняю последнее желание объекта, а он говорит "хочу ожить" и так постоянно!
            {
                // Вызов ReRegisterForFinalize используется для повторного вызова деструктора
                GC.ReRegisterForFinalize(this); //вызываем этот метод, чтобы GC вызвал диструктор для SomeType ещё разок! И ЭТО НЕОТЬЕМЛИВАЯ ЧАСТЬ ЛЮБОГО ВОСКРЕШЕНИЯ
                //На самом деле, метод ReRegisterForFinalize(instance) перемещает instance из ОЧЕРЕДИ СМЕРТНИКОВ(Finalization) в специальную очередь, которая называается FReachible(Finalization Reachable).
                //Эта хитрая очередь(FReachible) содержит ссылки на те обьекты, которые требуется удалить(СМЕРТНИКИ) НО ЭТИ ОБЪЕКТЫ ИМЕЮТ ДИСТРУКТОР.
            }
            //Те объекты, которые которые потенциальные смертники, но БЕЗ диструткора - не попадают в FReachible

            //ИТОГО: есть 2 очереди: Finalization Reachable и Finalization. 
            // -Если у объекта есть диструктор - он попадает в очередь Finalization Reachable, там выполняется его последнее
            //  желание - деструктор(в очереди Finalization Reachable нельзя убивать) и потом этот объект перемещается в очередь Finalization, где его убивают.
            //- Если у объекта нету диструктора - он сразу попадает в очередь Finalization и умирает.
        }
    }
    class Program
    {
        public static int counter;
        public static SomeType Instance { get; set; }
        static void Main(string[] args)
        {
            SomeType instance = new SomeType(); // optimize

            GC.Collect(); //Отрабатывает деструктор ~SomeType()

            //Delay
            Console.ReadKey();

            GC.Collect(); // тут деструктор отработает ещё 2 раза т.к уже конец программы, и получится так, что при
                          // выполнении последнего желания объект сказал "хочу жить"(Program.Instance = this;) 
                          //и теперь получается то, что ниже написано

            //Не отраюотает деструктор SomeType() так как 
            //ссылка на объект держится в статическом поле и 
            // объект считается доступным

            //Delay
            Console.ReadKey();

            //Отработает деструктор ~SomeType()
        }
    }
}
