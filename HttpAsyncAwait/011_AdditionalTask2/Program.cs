using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_AdditionalTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var carPark = new CarCollection<Car>();
            Console.WriteLine("Введите название автомобиля");
            var carName = Console.ReadLine();
            Console.WriteLine("Введите год выпуска автомобиля");
            var carYear = Console.ReadLine();

            carPark.Add(new Car { CarName = carName, CarYear = carYear });
            var a = carPark.Count;
            var b = carPark[0];
            carPark.DeleteAll();
        }
    }
}
