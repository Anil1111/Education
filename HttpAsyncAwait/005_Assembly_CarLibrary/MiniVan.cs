using System;

namespace _005_Assembly_CarLibrary
{
    public class MiniVan : Car
    {
        public MiniVan() { }

        public MiniVan(string name, int maxSpeed, int currentSpeed)
        : base(name, maxSpeed, currentSpeed)
        { }

        public override void Acceleration()
        {
            //Мини-вэны разгоняются плохо
            state = EngineState.EngineDead;
            Console.WriteLine("MINIVAN:  Двигатель сгорел!");
        }
    }
}
