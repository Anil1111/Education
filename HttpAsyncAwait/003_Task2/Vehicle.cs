using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task2
{
    public class Vehicle
    {
        private readonly int xLocation;
        public int XLocation => xLocation;

        private readonly int yLocation;
        public int YLocation => yLocation;

        private readonly int price;
        public int Price => price;

        private readonly int speed;
        public int Speed => speed;

        private readonly int year;
        public int Year => year;

        public Vehicle(int xLocation, int yLocation, int price, int speed, int year)
        {
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public Vehicle(int price, int speed, int year)
            :this(0,0,price,speed,year)
        {
        }
    }

    public class Car : Vehicle
    {
        public Car(int xLocation, int yLocation, int price, int speed, int year)
            :base(xLocation, yLocation, price, speed, year)
        {
        }

        public Car(int price, int speed, int year)
            : base(price, speed, year)
        {
        }
    }

    public class Ship : Vehicle
    {
        public Ship(int xLocation, int yLocation, int price, int speed, int year)
            : base(xLocation, yLocation, price, speed, year)
        {
        }

        public Ship(int price, int speed, int year)
            : base(price, speed, year)
        {
        }

        private int passengers;
        public int Passengers
        {
            get => passengers;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Количество пассажиров не может быть отрицательным");
                }
                else
                {
                    passengers = value;
                }
            }
        }

        private string port;

        public string Port
        {
            get => port ?? "Порт не задан";
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Значение пустое");
                }
                else
                {
                    port = value;
                }
            }
        }
    }

    public class Plane : Vehicle
    {
        public Plane(int xLocation, int yLocation, int price, int speed, int year)
            : base(xLocation, yLocation, price, speed, year)
        {
        }

        public Plane(int price, int speed, int year)
            : base(price, speed, year)
        {
        }

        public  int Height { get; set; }

        private int passengers;
        public int Passengers
        {
            get => passengers;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Количество пассажиров не может быть отрицательным");
                }
                else
                {
                    passengers = value;
                }
            }
        }
    }
}
