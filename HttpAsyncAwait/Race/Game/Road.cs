using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Race.Game
{
    class Road
    {
        private int left = 0;
        private int top = 0;

        private int speed = 0;

        public int Speed
        {
            set
            {
                if (value != 0)
                {
                    speed = 10000 / value;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public Road(int left = 30, int top = 0)
        {
            this.left = left;
            this.top = top;
        }

        public void Move()
        {
            Thread th = new Thread(DrawStrips);
            th.Start();
            th.IsBackground = true;
        }

        private void DrawStrips()
        {
            while (true)
            {
                if (this.speed != 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        this.top = i;

                        //Очистка старой полосы
                        for (int j = 0; j < 45; j++)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(left, j); //Левая полоса
                            Console.Write(" ");

                            Console.SetCursorPosition(left + 35, j); //Правая полоса
                            Console.Write(" ");
                        }

                        //Отрисовка новой полосы
                        for (int k = 0; k < 15; k++)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;

                            Console.SetCursorPosition(left, top); //Левая полоса
                            Console.Write(" ");

                            Console.SetCursorPosition(left + 35, top); //Правая полоса
                            Console.Write(" ");

                            top += 3;
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        Thread.Sleep(this.speed);
                    }
                }
            }
        }
    }
}
