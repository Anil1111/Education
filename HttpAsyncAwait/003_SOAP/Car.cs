using System;

namespace _003_SOAP
{
    //Класс Car будет доступен для сериализации
    [Serializable]
    public class Car
    {
        protected int speed;
        protected string name;
        protected Radio radio;

        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
            this.radio = new Radio();
        }

        //Метод включения и выключения радио
        public void TurnOnRadio()
        {
            this.radio.OnOff(true);
        }

        public void TurnOffRadio()
        {
            this.radio.OnOff(false);
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Speed
        {
            get => speed;
            set => speed = value;
        }
    }
}
