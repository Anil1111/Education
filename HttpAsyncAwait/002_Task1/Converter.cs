using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task1
{
    public class Converter
    {
        private double usd;
        private double eur;
        private double rub;

        public double USD
        {
            get => usd;
            set => usd = value <= 0 ? 0 : value;
        }

        public double EUR
        {
            get => eur;
            set => eur = value <= 0 ? 0 : value;
        }

        public double RUB
        {
            get => rub;
            set => rub = value <= 0 ? 0 : value;
        }

        public Converter(double usd, double eur, double rub)
        {
            this.USD = usd;
            this.EUR = eur;
            this.RUB = rub;
        }
    }
}
