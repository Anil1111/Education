using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_AdditionalTask2
{
    public class Car
    {
        public string CarName { get; set; }
        public string CarYear { get; set; }
        public string[] CarNames { get; set; } = new string[0];
        public string[] CarYears { get; set; } = new string[0];

        public void AddNewCar(Car car)
        {

            var helpCarNames = new string[this.CarNames.Length + 1];
            for (int i = 0; i < this.CarNames.Length; i++)
            {
                helpCarNames[i] = this.CarNames[i];
            }

            helpCarNames[this.CarNames.Length] = car.CarName;
            this.CarNames = helpCarNames;

            var helpCarYears = new string[this.CarYears.Length + 1];
            for (int i = 0; i < this.CarYears.Length; i++)
            {
                helpCarYears[i] = this.CarYears[i];
            }

            helpCarYears[this.CarYears.Length] = car.CarYear;
            this.CarYears = helpCarYears;
        }
    }
    public class CarCollection<T> : ICarPark<T> where T : Car, new()
    {
        public T instance = new T();

        public T this[int index] => new T() { CarName = this.instance.CarNames[index], CarYear = this.instance.CarYears[index] };

        public int Count
        {
            get
            {
                if (this.instance.CarNames.Length == this.instance.CarYears.Length)
                {
                    return this.instance.CarNames.Length;
                }

                return 0;
            }
        }

        public void Add(T a)
        {
            this.instance.AddNewCar(a);
        }

        public void DeleteAll()
        {
            this.instance.CarNames = null;
            this.instance.CarYears = null;
        }
    }
}
