using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _001_Threads
{
    class Program
    {
        //многозадачность может быть либо на ОСНОВЕ ПРОЦЕССОВ либо НА ОСНОВЕ ПОТОКОВ.
        //НА ОСНОВЕ ПРОЦЕССОВ - регулирует ОПЕРАЦИОНАЯ СИСТЕМА, а на ОСНОВЕ ПОТОКОВ - мы можем сами.
        //Многозадачность свойство обеспечивать возможность параллельной или псевдопаралельной нескольких процессов.

        //Процессор настолько быстрый, что он выполяет немного одной программы, потом немного другой, потом немного
        //третьей и он делает это настолько быстро, что создается ИЛЛЮЗИЯ, что эти задачи выполняются параллельно, А ЭТО НЕ ТАК.

        //Обычно двухядерные процессоры работают в режиме ДВОЙНОГО ФУНКЦИОНИРОВАНИЯ. Одно ядро выполняет программу, а второе
        //выполняет ту же программу но с небольшим отставанием. Это позволяет избежать зависания если одно ядро "запутается".
        //Если это случится, то второе ядре возьмет на себя лидерство.

        //Процесс - это программа во время выполнения(когда она находится в ОЗУ).

        //НЕ ПУТАТЬ THREAD(нити) и STREAM(потоки)!
        static void Method()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 10) + "Secondary");
            }
        }
        //СИНХРОННО - В КОНТЕКСТЕ ПЕРВИЧНОГО ПОТОКА.
        //ЭТИ МЕТОДЫ БУДУТ ВЫПОЛНЯТСЯ АССИНХРОННО - т.е В КОНТЕКСТЕ ВТОРИЧНОГО ПОТОКА.
        static void Method2()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 20) + "Thirdly");
            }
        }
        static void Method3()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 30) + "Fourthly");
            }
        }
        static void Method4()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 40) + "Fifthly");
            }
        }
        static void Main(string[] args) //метод Main ЭТО ВСЕГДА ПЕРВИЧНЫЙ ПОТОК
        {//А из первичного потока создаются вторичные
            //для каждого потока выделяется 1мб стека.
            ThreadStart delegateStart1 = new ThreadStart(Method);
            Thread thread1 = new Thread(delegateStart1); //Thread - некое обьектно-ориентированное представление отдельного потока.
            thread1.Start();

            ThreadStart delegateStart2 = new ThreadStart(Method2);
            Thread thread2 = new Thread(delegateStart2);
            thread2.Start();

            ThreadStart delegateStart3 = new ThreadStart(Method3);
            Thread thread3 = new Thread(delegateStart3);
            thread3.Start();

            ThreadStart delegateStart4 = new ThreadStart(Method4);
            Thread thread4 = new Thread(delegateStart4);//Конфигурируем делегатом(конфигурируем - это передаем в качестве агрумента)
            thread4.Start(); //как только выполняется Start - процессор сразу начинает выполнять поток

            while (true)
            {
                Console.WriteLine("Primary");
            }

            //СТЕКА ВСЕ РАВНО БОЛЬШЕ ИЛИ МЕНЬШЕ 1МБ НИКТО НЕ ДАСТ. //ОТРЕЖТЕ МНЕ ПОЛОВИНУ ЛИТРОВОЙ БАНКИ МЁДА
            //public Thread(ThreadStart start, int maxStackSize); - бесполезные конструкторы
            //public Thread(ParameterizedThreadStart start, int maxStackSize); - бесполезные конструкторы

            //Планировщик потоков управляеN ПКП- Программируемый констроллер прерываний.
            //Есть процессор, у которого есть ножка Int(errapt) a и эта ножка связанна с ПКП.

            //Планировщик поток выдает каждой программа определенное кол-во КВАНТОВ ПРОЦЕССОРНОГО ВРЕМЕНИ.
            //Пример с Васей-  ешь печенье 3 секунды, выплевывай то, что не дожевал, когда будет будет опять твое время - дожуешь-
            // чувак выплевывает - это означает кеширование промежуточных вычислений потока.

            //Процессор, выполнив программу, прашует у Планировщика потоков - что ему делать дальше.

            //Планировщик потоков, ПКП и т.д - это часть OS (Windows), а раньше на Assembler`e такие программы делали сами.

        }
    }
}
