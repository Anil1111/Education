using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace _003_SOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Mersedes auto = new Mersedes("CLK 500", 250, Mode.Lux);
            auto.TurnOnRadio();
            auto.ShowMode();

            SoapFormatter formatter = new SoapFormatter(); //SOAP - Simple Object Access Protocol

            using (FileStream fileStream = File.Create("CarData.xml")) //тут CarData1.XML и это важно!
            {
                formatter.Serialize(fileStream, auto);
            }

            using (FileStream fileStream = File.OpenRead("CarData.xml"))
            {
                auto = formatter.Deserialize(fileStream) as Mersedes;
            }
            
            Console.WriteLine("Имя        : " + auto?.Name);
            Console.WriteLine("Скорость   : " + auto?.Speed);
            auto?.TurnOffRadio();

            //Зайди и посмотри что получилось после сериализации
            //То, что получилось - это формат протокола SOAP.
            //Раньше форматы протоколов прикладных уровней делали руками. Но он очень устарел и остался неудел.
            //Его нам использовтаь просто нет смысла
            //Этот формат нужен был для того, чтобы сформировать сообщение, которое мы передавали с одного компьютера на другой - общение между сервисами.

            //Delay
            Console.ReadKey();
        }
    }
}
