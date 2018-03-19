using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPlayable playable = new Player();
            //playable.Play();
            //playable.Pause();
            //playable.Stop();

            //IRecordable recordable = new Player();
            //recordable.Record();
            //recordable.Pause();
            //recordable.Stop();

            Player player = new Player();
            player.Play();
            (player as IPlayable).Stop(); //чтобы использовать этот метод нужно привестись к определенному типу т.к
                                          //методы с одинаковыми именами по умолчанию private!
            player.Record();
            (player as IRecordable).Stop();


            //Delay
            Console.ReadKey();
        }
    }
}
