using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _013_Task1
{
    class Matrix
    {
        static readonly object locker = new object(); //Объект синхронизации доступа к разделяемому ресурсу (объект блокировки)
        private Random rand; //Создание екземпляра класса Random
        private const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; //Статическое строковое поле

        public int Column { get; set; }

        public Matrix(int col)
        {
            Column = col;
            rand = new Random((int)DateTime.Now.Ticks);
        }

        private char GetChar() => litters.ToCharArray()[rand.Next(0, litters.Length)]; //Возвращает оодно значение из строкового поля litters

        public void Move()//Метод отображения одной цепочки
        {
            int length;
            int count;
            while (true)
            {
                count = rand.Next(3, 6);//Метод возвращает случайное значение в указаном промежутке
                length = 0;
                Thread.Sleep(rand.Next(20, 5000));// Останавливаем поток на время полученое выполнением метода rand.Next в указаном прромеж
                for (int i = 0; i < 40; i++)//Цикл со счетчиком
                {
                    lock (locker)// Блокирует блок кода, предназначен для контроля доступа к критической секции
                    {
                        Console.CursorTop = 0; //Устанавливае курсор в указанное положение
                        Console.ForegroundColor = ConsoleColor.Black; //Устанавливает цвет
                        for (int j = 0; j < i; j++)
                        {
                            Console.CursorLeft = Column; //Устанавливаем позицию столбца курсора
                            Console.WriteLine("█");
                        }
                        if (length < count)
                            length++;//Увеличение длинны цепочки
                        else
                            if (length == count) //Если длинна цепочки достигла требуемой обнуляем переменную count 
                            count = 0;

                        if (39 - i < length)
                            length--;//Уменьшение длинны цепочки по достижении нижней границы консоли
                        Console.CursorTop = i - length + 1;//Устанавливаем координату курсора от верхнего края консоли
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int j = 0; j < length - 2; j++)
                        {
                            Console.CursorLeft = Column; //Устанавливаем позицию курсора в рядке
                            Console.WriteLine(GetChar()); //Вызов метода GetChar
                        }
                        if (length >= 2) //Для каждого второго символа в цепочке
                        {
                            Console.ForegroundColor = ConsoleColor.Green; //устанавливаем цвет
                            Console.CursorLeft = Column; //и позицию в столбце
                            Console.WriteLine(GetChar());
                        }
                        if (length >= 1) //Для каждого первого символа в цепочке
                        {
                            Console.ForegroundColor = ConsoleColor.White; //Устанавливаем цвет
                            Console.CursorLeft = Column; //и позицию в столбце
                            Console.WriteLine(GetChar());
                        }
                        Thread.Sleep(20);
                    }
                }
            }
        }
    }
}
