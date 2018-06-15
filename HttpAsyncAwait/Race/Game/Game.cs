using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Race.Game
{
    class Game
    {
        private Car car;
        private Road road;

        public Game()
        {
            this.car = new Car(new Engine(), new CarBody(40,20));
            this.road = new Road();
        }

        public void Run()
        {
            car.Show();
            road.Move();

            //Игровая петля
            while (true)
            {
                try
                {
                    Thread.Sleep(1000);
                    road.Speed = car.Accelerate(10);
                }
                catch (Exception e)
                {
                    road.Speed = 0;
                    Console.SetCursorPosition(38, 20);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(e.Message);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.SetCursorPosition(0, 46);

                    foreach (DictionaryEntry elements in e.Data)
                    {
                        Console.WriteLine($"{elements.Key} : {elements.Value}");
                    }

                    break;
                }
            }
        }
    }
}
