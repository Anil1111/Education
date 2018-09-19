using System;

namespace _002_FinalizationPattern
{
    public class MyClass : IDisposable
    {
        private bool disposed = false;

        //Реализация интерфейса IDisposable.
        public void Dispose()
        {
            Dispose(true);
            //Мы тут говорим "Garbage Collector, уже была финализация, так что не вызывай деструктор"
            GC.SuppressFinalize(this); //метод SuppressFinalize делает так, чтобы не вызывался деструктор т.к ПЕРЕКИДЫВАЕТ ИЗ очереди Finalization Reachable в Finalization
            //противоловжный метод - ReRegisterForFinalize(), который наоборот из очереди Finalization перебрасывает в очередь Finalization Reachable 
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Соединение с базой данных закрыто");
                }

                this.disposed = true;
            }
        }

        ~MyClass()
        {
            Dispose(false);
            Console.WriteLine("Finalize");
        }
    }
}
