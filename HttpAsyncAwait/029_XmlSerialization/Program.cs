using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace _029_XmlSerialization
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }

        //Эти методы НЕ работают, а BinaryFormatter, DataContractJsonSerializer работают, но с каждым - по разному!
        //[OnSerializing]
        //void CalculateTotal(StreamingContext context) 
        //{
        //    Console.WriteLine("OnSerializing");
        //}

        //[OnSerialized] 
        //void CalculateTotal2(StreamingContext context)
        //{
        //    Console.WriteLine("OnSerialized");
        //}

        //[OnDeserializing] 
        //void CheckTotal(StreamingContext context)
        //{
        //    Console.WriteLine("OnDeserializing");
        //}

        //[OnDeserialized] 
        //void CheckTotal2(StreamingContext context)
        //{
        //    Console.WriteLine("OnDeserialized");
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>
            {
                  new Contact {FirstName = "Vasya", LastName = "Vasiliev", Age = 1, Phone = "+3805434678", Comment = "Privet, Vasya"},
                  new Contact {FirstName = "Luke", LastName = "Skywalker", Age = 33, Phone = "+3805464566", Comment = "Privet, Luke"},
                  new Contact {FirstName = "Obi-Wan", LastName = "Kenobi", Age = 77, Phone = "+3805444444", Comment = "Privet, Obi-Wa"},
                  new Contact {FirstName = "Yoda",  Age = 920, Phone = "+380676767676", Comment = "Privet, Yoda"},
            };

            XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>)); //не забывать передавать сюда List<Contact>, а не просто Contact

            using (FileStream stream = new FileStream("PhoneBook.xml", FileMode.Create))
            {
                serializer.Serialize(stream, contacts);
            }

            using (FileStream stream = new FileStream("PhoneBook.xml", FileMode.Open))
            //using (FileStream stream = new FileStream("PhoneBook _bad.xml", FileMode.Open)) //тут плохой файл
            {
                //List<Contact> contactList = serializer.Deserialize(stream) as List<Contact>; 
                object contactList1 = serializer.Deserialize(stream); //тоже норм, но удобнее если мы приводим к List<Contact>
                //НО оно десериализирует в специальный тип(в тот, который передавался в констукторе XmlSerializer(typeof(List<Contact>));)
                //и туда подставляются поля по умолчанию если их нету в файле, который десериализируется, а В DataContractJsonSerializer НЕ ТАК. Там ошибка - если поля не те(файл плохой)

                //Вывод - реакция на "плохие файлы" - это присваивание полям значения по умолчанию при UpCast`е к желаемому типу из object`a
            }

            //Delay
            Console.ReadKey();
        }
    }
}
