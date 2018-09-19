using System;

namespace _002_FinalizationPattern
{
    //CleanUp() - УПРАВЛЯЕМЫЕ РЕСУРСЫ + НЕУПРАВЛЯЕМЫЕ РЕСУРСЫ
    //Finalization() - НЕУПРАВЛЯЕМЫЕ РЕСУРСЫ

    //Вот посмотри как оно будет идти если метод CleanUp(bool) будет вызван из Dispose(), и если из Finalize()
    public class MyClass : IDisposable
    {
        private bool disposed = false;

        //Реализация интерфейса IDisposable.
        public void Dispose()
        {
            CleanUp(true); //true говорит о том, что эта штука вызывается из метода CleanUp()
            //Мы тут говорим "Garbage Collector, уже была финализация, так что не вызывай деструктор"
            GC.SuppressFinalize(this); //метод SuppressFinalize делает так, чтобы не вызывался деструктор т.к ПЕРЕКИДЫВАЕТ ИЗ очереди Finalization Reachable в Finalization
            //противоловжный метод - ReRegisterForFinalize(), который наоборот из очереди Finalization перебрасывает в очередь Finalization Reachable 
        }

        //Чтобы уменьшить дублирование кода в Finalize() (Дестрокторе) 
        protected virtual void CleanUp(bool disposing)
        {
            if (!disposed)
            {
                if (disposing) 
                {
                    Console.WriteLine("очищение УПРАВЛЯЕМЫХ ресурсов");
                }

                Console.WriteLine("очищение НЕУПРАВЛЯЕМЫХ ресурсов"); //файлы, подключения, разные системные ресурсы, сокеты
                //т.е те, которые находятся ВНЕ нашей программы и по этому они НЕУПРАВЛЯЕМЫЕ!

                this.disposed = true;
            }
        }

        ~MyClass()
        {
            CleanUp(false); //false говорит о том, что эта штука вызывается из метода Finalize() (Деструктора)
            Console.WriteLine("Finalize");
        }
    }
}
