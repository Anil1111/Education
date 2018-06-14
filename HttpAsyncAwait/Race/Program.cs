using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race.Game;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Car";
            Console.SetWindowSize(100,50);
            Console.CursorVisible = true;

            Game.Game game = new Game.Game();
            game.Run();

            //Delay
            Console.ReadKey();
        }
    }
}
