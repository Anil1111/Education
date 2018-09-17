using System;

namespace _002_Binary_Serializable
{
    //Класс Car будет доступен для сериализации
    [Serializable] //если я использую БИНАРНУЮ СЕРИАЛИЗАЦИЮ или SOAP СЕРИАЛИЗАЦИЮ, то мне нужно пометить этим атрибутом все что я хочу сериализовать
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
