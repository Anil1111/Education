using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _004_Custom
{
    //ISerializable - интерфейс, который помагает реализовать пользовательскую сериализацию/десериализацию.
    //Есть класс с большим количеством открытых полей. Мы реализуем метод GetObjectData , в теле которого САМИ ЗАБРАСЫВАЕМ В МЕШОЧЕК то, что хотим 
    //сериализовать. Так же создаем специальный конструктор, который поможет потом десериализовать объект.
    
    //Тут не используются механизмы рефлексии, чтобы лазить по полям. Мы сами указываем какие поля мы хотим сериализовать.
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mersedes-Benz", 250);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream stream = File.Create("CarData.dat"))
            {
                //Вызов метода ISerializable.GetObjectDate()) 
                //Метод Serialize проверяет, наследуюсь ли я от ISerializable : if(car is ISerializable) { GetObjectData(SerializationInfo propertyBag, StreamingContext context); }
                //и если мы наследуемся от ISerializable, то метод Serialize говорит: ребята програмисты, я не буду сам лазить и вытаскивать рефлексией все значения полей.
                //берите ПУСТОЙ МЕШОК СО СВОЙСТВАМИ SerializationInfo propertyBag, который я сам передаю с метод GetObjectDate и закидуйте(во время реализации метода) туда все,
                //что вы хотите, чтобы я сериализовал.
                binaryFormatter.Serialize(stream, car);
            }

            using (Stream stream = File.OpenRead("CarData.dat"))
            {
                //Десериализация (Вызов спецконструктора).
                //А метод Deserialize проверяет: ага, если у Car есть реализация интерфейса ISerializable, то скорее всего, мой брат GetObjectData замантулил туда 
                //МЕШОК СО СВОЙСТВАМИ и теперь я должен 1.Достать мешок со свойствами 2.Десериализовать мешок со свойствами
                //3.Создать экземпляр класса Car с помошью специального конструктора, куда передается уже десериализованный мешочек со свойствами
                //4.Востановить значение полей по ключам, которые мы указали
                car = binaryFormatter.Deserialize(stream) as Car;
            }

            Console.WriteLine(car?.Name + "\n" + car?.Speed);


            //Delay
            Console.ReadKey();
        }
    }
}
