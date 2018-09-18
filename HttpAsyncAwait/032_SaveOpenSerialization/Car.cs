using System;

namespace _032_SaveOpenSerialization
{
    [Serializable]
    public class Car
    {
        public string name, make, color;

        public Car(string name, string make, string color)
        {
            this.name = name;
            this.make = make;
            this.color = color;
        }
    }
}
