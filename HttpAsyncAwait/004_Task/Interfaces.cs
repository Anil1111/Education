using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Task
{
    interface IPlayable:
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable:
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player: IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Play melody");
        }

        public void Record()
        {
            Console.WriteLine("Record melody");
        }

        void IRecordable.Pause() // методы то одноименные, но я использую технику указания имени интерфейса в имени методаю
        {
            Console.WriteLine("Stop recording melody");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause playing melody");
        }

        //public void Pause()   //можно было бы пойти и таким путем и этот метод был бы виден в классе Player т.к он public, а не private,
        //{                     //но реализация у такого метода одна и это не подойдет если для метода из определенного 
        //                      //интерфейса нужно сделать определенную реализацию.
        //    Console.WriteLine("IRecordable/IPlayable pause!"); 
        //}

        void IRecordable.Stop()
        {
            Console.WriteLine("Stop recording melody");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop playing melody");
        }
    }

}
