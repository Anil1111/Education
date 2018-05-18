using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Task2
{
    class CarCollection<T> : MyList<T>
    {
        private readonly MyList<string> carNames;
        private readonly MyList<DateTime> carYears;

        public CarCollection()
        {
            this.carNames = new MyList<string>();
            this.carYears = new MyList<DateTime>();
        }

        public void AddCar(string name, DateTime year)
        {
            this.carNames.Add(name);
            this.carYears.Add(year);
        }

        public new string this[int index]
        {
            get
            {
                if (index < carNames.Count)
                {
                    return carNames[index] + " " + carYears[index].Year + " rод";
                }

                return "В списке нет машины под таким номером!";
            }
        }

        public int Length => carNames.Count;

        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i < carNames.Count; i++)
            {
                stroka += "№" + (i + 1) + " " + carNames[i] + " " + carYears[i].Year+"\r\n";
            }

            if (stroka != null) return stroka;
            return "В парке нет ни одной машины!";
        }
    }
}
