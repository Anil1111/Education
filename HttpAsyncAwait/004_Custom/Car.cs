using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _004_Custom
{
    //интерфейс ISerializable нужен для того, чтобы оргиназовать некую избирательную сериализацию.
    //Представь что у меня в классе есть 100 свойсв и я не хочу их сериализовать, а хочу только 2.
    //или я хочу сериализовать так, чтобы ИНФОРМАЦИЯ БЫЛА ЗАШИФРОВАНА.

    //Правило следующее: когда мы хотим наладить ИЗБИРАТЕЛЬНУЮ СЕРИАЛИЗАЦИЮ, т.е не все подряд сериализовать, а то, что нужно,
    //мы должны унаследоваться от интерфейса ISerializable,
    //реализовать метод GetObjectData и создать СПЕЦИАЛЬНЫЙ КОНСТРУКТОР(желательно его делать либо private либо  protected чтобы никто его не мог вызвать руками)!
    
    [Serializable]
    public class Car: ISerializable 
    {
        private string name;
        private int speed;
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

        //Специальный вариант конструктора.
        //SerializationInfo - объекте в который помещаем все пары имя-значение представляющие состояние объекта
        //SerializationInfo - мешок со свойствами
        private Car(SerializationInfo propertyBag, StreamingContext context)
        {
            //Значение All перечисления StreamingContextState для свойства context.State, указывает,
            //что данные могут быть переданы в любое место или получены из любого места
            Console.WriteLine("[ctor] ContextState: {0}", context.State.ToString());

            //Из мешка со свойствами извлекаем значения свойств помещенных ранее в методе GetObjectData
            //А если мы зашифровывали значения перед сериализацией,тут уже можно и расшифровать те значения, которые мы получили
            this.name = propertyBag.GetString("name");
            this.speed = propertyBag.GetInt32("speed");
        }

        //Вызывается во время сериализации.
        //SerializationInfo - МЕШОК СО СВОЙСТВАМИ, который пустой автоматически передается в этот метод
        void ISerializable.GetObjectData(SerializationInfo propertyBag, StreamingContext context)
        {
            //Значение All перечисления  StreamingContextStates свойства contex.State, указывает,
            //что данные могут быть переданые в любое место или быть получены с любого места.
            Console.WriteLine("[GetObjectData] ContextState: {0}", context.State.ToString());

            //В МЕШОК СО СВОЙСТВАМИ добавляем два свойства и соотвественно. И ТУТ МЫ МОЖЕМ ЗАШИФРОВАТЬ ЛИБО "name", либо значение поля name
            //с помощью XOR - C# Start там есть пример.
            propertyBag.AddValue("name", name);
            propertyBag.AddValue("speed", speed);
        }
    }
}
