using System;
using _000_ICarr;

namespace _001_CarLibrary
{
    // Добавил в References 000_ICar и теперь есть dll в C:\project\Education\HttpAsyncAwait\001_CarLibrary\bin\Debug\000_ICarr.dll
    public abstract class Car : ICar
    {
        protected string name;
        protected int currentSpeed;
        protected int maxSpeed;
        protected EngineState state;

        protected Car()
        {
            state = EngineState.EngineAlive;
        }

        protected Car(string name, int maxSpeed, int currentSpeed)
            : this()
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.currentSpeed = currentSpeed;
        }

        public abstract void Acceleration();

        //Метод - водитель
        public void Driver(string name, int age)
        {
            Console.WriteLine($"Имя водителя: {name}. Возраст: {age}");
        }

        #region Свойства

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int CurrentSpeed
        {
            get => currentSpeed;
            set => currentSpeed = value;
        }

        public int MaxSpeed => currentSpeed;

        public EngineState EngineState => state;

        #endregion
    }
}
