using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Events
{
    public delegate void EventDelegate();

    public class Keyboard
    {
        public event EventDelegate pressA;
        public event EventDelegate pressB;
        public event EventDelegate pressC;
        //C ... Z

        public void InvokePressAEvent()
        {
            if (this.pressA != null)
            {
                this.pressA.Invoke();
            }
        }

        public void InvokePressBEvent()
        {
            if (this.pressB != null)
            {
                this.pressB.Invoke();
            }
        }
        public void InvokePressCEvent()
        {
            if (this.pressC != null)
            {
                this.pressC.Invoke();
            }
        }


        public void Start()
        {
            while (true)
            {
                var symbol = Console.ReadLine();
                switch (symbol)
                {
                    case "a":
                    case "A":
                        InvokePressAEvent();
                        break;
                    case "b":
                    case "B":
                        InvokePressBEvent();
                        break;
                    case "c":
                    case "C":
                        InvokePressCEvent();
                        break;
                    case "exit":
                        goto Exit;
                    default:
                        Console.WriteLine($"Нет обработчика нажатия на клавишу {symbol}.");
                        break;
                }
            }
            Exit:
            Console.WriteLine("EXIT!");
        }
    }
    class Program
    {
        //Методы обработчики
        private static void ShowA()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("    A    ");
            Console.WriteLine("  A   A  ");
            Console.WriteLine(" AAAAAAA ");
            Console.WriteLine("A       A");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void ShowB()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" BBBBBBB ");
            Console.WriteLine(" B      B  ");
            Console.WriteLine(" BBBBBBBB ");
            Console.WriteLine(" B      B");
            Console.WriteLine(" BBBBBBB");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void ShowС()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ССС ");
            Console.WriteLine(" с     С ");
            Console.WriteLine(" С       ");
            Console.WriteLine(" С     С ");
            Console.WriteLine("   ССС   ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main(string[] args)
        {
            var keyboard = new Keyboard();
            //Подписка на событие
            keyboard.pressA += ShowA;
            keyboard.pressB += ShowB;
            keyboard.pressC += ShowС;
            //Запуск метода, который будет следить за нажатием клавиш и генерировать события!
            keyboard.Start();
        }
    }
}
