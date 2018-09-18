using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Бинарная серилизация - самая быстрая из всех серилизаций которая есть в .Net. Скорей всего от нее откужутся в .NetCore потому, что она сильно завязана на платформу!
namespace _030_BinarySerializer
{
    public enum Mode
    {
        Lux, Sport
    }

    //Класс будет доступен для серилизации. Атрибут [Serializable] обязательно ставить если нужно чтобы класс сериализовался
    [Serializable]
    public class Car
    {
        protected int speed;
        protected string name;

        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
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

    //Класс Mersedes будет доступен для сериализации.
    [Serializable] //Выскочил Exception когда я забыл пометить класс, который сериализую/десериализую.
    public class Mersedes : Car
    {
        //Два режима работы - Спорт и Люкс
        protected Mode mode;

        public Mersedes(string name, int speed, Mode mode)
        : base(name, speed)
        {
            this.mode = mode;
        }

        public void SetMode(Mode mode)
        {
            this.mode = mode;
            Console.WriteLine($"Mode '{this.mode}' was succefsully set");
        }

        public void ShowMode() => Console.WriteLine(this.mode);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mersedes auto = new Mersedes("G500", 250, Mode.Lux);
            auto.ShowMode();

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("CarData.dat"))
            {
                //Сериализация
                formatter.Serialize(stream, auto); //сохраняется эта штука в виде специального бинарного файла
                //Т.е этот тип сериализации расчитан на то, что его читать будут МАШИНЫ, а НЕ ПРОГРАМИСТЫ, но зато он гораздо быстрее работает
                //BinaryFormatter - платформо зависим и зависим от версии. Если я , напрмер серилизировал в 2й версии, то не фект, что этот файл откроется в 4й версии.
            }

            using (FileStream stream = File.OpenRead("CarData.dat"))
            {
                auto = formatter.Deserialize(stream) as Mersedes;

                Console.WriteLine("Имя       :" + auto?.Name);
                Console.WriteLine("Скорость  :" + auto?.Speed);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
