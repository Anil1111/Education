using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _002_Binary_Serializable
{
    //Сериализация в двоичном формате
    //ОЧЕНЬ ВАЖНО!!
    //Этот BinaryFormatter(Serializer) очень быстрый и он работает только с програмами Microsoft.
    //Т.е мы если мы сериализуюем используя BinaryFormatter, то мы и десериализовать можем только под Windows,
    //а если мы используем XmlSerializer, то мы можем под Windows сериализовать, а под Linux - дересериализовать
    class Program
    {
        static void Main(string[] args)
        {
            Mersedes auto = new Mersedes("CLK 500", 250, Mode.Lux);
            auto.TurnOnRadio();
            auto.ShowMode();

            //Помещает объектный граф (для базовых типов) в поток в двоичном формате.
            //Вообще BinaryFormatter - это BinarySerializer, но Microsoft решили назвать его BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = File.Create("CarData.dat"))
            {
                //Сериализация
                //BinaryFormatter побежит по графу НАСЛЕДОВАНИЯ и по графу АССОЦИАЦИИ и будет искать атрибуты [Serializable]
                //члены, помечены атрибутом [NonSerialized] сеарилизовываться не будут.
                formatter.Serialize(fileStream, auto);
            }

            using (FileStream fileStream = File.OpenRead("CarData.dat"))
            {
                //Десериализация
                //Информация о волшебнике была записана в файл скрыто от нас во время сериализации 
                //И из файла берется полное квалифицированное имя и волшебник создается по способу Type.GetType("полное квалиф имя типа")
                auto = formatter.Deserialize(fileStream) as Mersedes;
            }

            Console.WriteLine("Имя        : " + auto?.Name);
            Console.WriteLine("Скорость   : " + auto?.Speed);
            auto?.TurnOffRadio();

            //Delay
            Console.ReadKey();
        }
    }
}
