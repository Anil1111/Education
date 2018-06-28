using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Task2
{
    class Auto
    {
        private readonly string marka;
        private readonly string model;
        private readonly int year;
        private readonly string color;

        public Auto(string marka, string model, int year, string color)
        {
            this.marka = marka;
            this.model = model;
            this.year = year;
            this.color = color;
        }


        public string Marka => marka;
        public string Model => model;
        public int Year => year;
        public string Color => color;

        public override string ToString()
        {
            return $"Марка: {Marka} Модель: {Model} Год выпуска: {Year} Цвет: {Color}";
        }
    }
}
