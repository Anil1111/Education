using System;

namespace _001_CarLibrary
{
    public class SportsCar : Car
    {
        public SportsCar() { }

        public SportsCar(string name, int maxSpeed, int currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        { }

        public override void Acceleration()
        {
            Console.WriteLine("SPORTSCAR:  Быстрая скорость!");
        }
    }

    internal class SecretCar : Car
    {
        public override void Acceleration()
        {
            throw new NotImplementedException();
        }
    }
}
