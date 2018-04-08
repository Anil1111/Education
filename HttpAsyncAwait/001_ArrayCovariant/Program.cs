using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Ковариантночть не применима к массивам элементов структурных типов.
namespace _001_ArrayCovariant
{
    interface IAnimal
    {
        void Voice();
    }

    public struct Dog:IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Voice");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ПРАВИЛО!
            //Массивы элементов ССЫЛОЧНЫМ типов ковариантны, но НЕ контрвариантны
            //Массивы элементов СТРУКТУРНЫХ типов И НЕ ковариантны и НЕ контрвариантны
            //1
            Dog[] dogs = {new Dog(), new Dog(), new Dog()};

            //IAnimal[] animals = dogs; //Ковариантность не работает
            //IAnimal[] animals = (IAnimal)dogs; // так тоже не работает
            //dogs = array; //Контрвариантность.
            ValueType i = new Int32() as ValueType;

            //2
            int[] vector = new int[3] {1, 2, 3};
            //object[] array = vector; //Ковариантность не работает
            //object[] array = (object)vector; так тоже не работает

            //Delay
            Console.ReadKey();
        }
    }
}
