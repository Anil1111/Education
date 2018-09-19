using System;

namespace _038_IDisposablePattern
{
    // Шаблон Microsoft для освобождения ресурсов.
    // Данный паттерн ГАРАНТИРУЕТ, что пользователь, сможет многократно вызвать метод Dispose();

    //CleanUp() - УПРАВЛЯЕМЫЕ РЕСУРСЫ + НЕУПРАВЛЯЕМЫЕ РЕСУРСЫ
    //Finalization() - НЕУПРАВЛЯЕМЫЕ РЕСУРСЫ
    public class ResourseWrapper : IDisposable
    {
        private bool disposed = false;

        public void Dispose()
        {
            // Вызов вспомагательного метода.
            // Если true - значит очистку инициировал пользователь объекта.

            //SuppressFinalize() - устанавливает флаг запрещения завершения для объектов
            // которые в противном случае могли бы быть завершены сборщиком мусора - т.е отменяет работу деструктора для данного класса.
            GC.SuppressFinalize(this); //true - показывает, что очистка инициарована методом Dispose() а не Деструктором
        }

        //Сборщик мусора вызывает метод Finalize() (Деструктор), если пользователь объекта забудет вызвать метод Dispose().
        ~ResourseWrapper()
        {
            Console.WriteLine("Finalize!!!!!!!");
            CleanUp(false);
        }

        //Метод, для избежания дублирования кода в Деструкторе и методе Dispose()
        private void CleanUp(bool clean)
        {
            //Проверка, что ресурсы ещё не освобождены.
            if (!this.disposed)
            {
                //Если clean равно true, освободить все управляемые ресурсы!
                if (clean)
                {
                    Console.WriteLine("очищение УПРАВЛЯЕМЫХ ресурсов");

                    for (int i = 0; i < 40; i++)
                    {
                        Console.Write("F");
                    }
                }

                Console.WriteLine("очищение НЕУПРАВЛЯЕМЫХ ресурсов"); //файлы, подключения, разные системные ресурсы, сокеты
                                                                      //т.е те, которые находятся ВНЕ нашей программы и по этому они НЕУПРАВЛЯЕМЫЕ!
            }

            this.disposed = true;
        }

        public void DoWork()
        {
            // Эта проверка необходима если кто-то вызвал Dispose(), а потом решил вызвать метод DoWork().
            // У меня уже все соединения закрыты, все коллекции освобождены, они пустые и т.д
            if (disposed) throw new ObjectDisposedException("Some text");

            //Тело метода
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
