using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace _029_1_JsonSerialize
{
    [DataContract]
    public class Contact
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Comment { get; set; }

        //Тут метод коля серилизуются отдельно друг от друга - следовательно методы тригерятся для каждого поля!
        [OnSerializing] //ДО ВЫПОЛНЕНИЯ СЕРИАЛИЗАЦИИ
        void CalculateTotal(StreamingContext context) 
        {
            Console.WriteLine("OnSerializing");
        }

        [OnSerialized]  //ПОСЛЕ ВЫПОЛНЕНИЯ СЕРИАЛИЗАЦИИ
        void CalculateTotal2(StreamingContext context)
        {
            Console.WriteLine("OnSerialized");
        }

        [OnDeserializing] //ДО ВЫПОЛНЕНИЯ СЕРИАЛИЗАЦИИ
        void CheckTotal(StreamingContext context)
        {
            Console.WriteLine("OnDeserializing");
        }

        [OnDeserialized] //ПОСЛЕ ВЫПОЛНЕНИЯ ДЕСЕРИАЛИЗАЦИИ
        void CheckTotal2(StreamingContext context)
        {
            Console.WriteLine("OnDeserialized");
        }
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

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Contact>));

            using (FileStream stream = new FileStream("Contacts.json", FileMode.Create))
            {
                jsonSerializer.WriteObject(stream,contacts);
            }

            using (FileStream stream = new FileStream("Contacts.json", FileMode.Open))
            //using (FileStream stream = new FileStream("Contacts_bad.json", FileMode.Open)) //Плохой файл
            {
                List<Contact> listOfContacts = jsonSerializer.ReadObject(stream) as List<Contact>;  //а тут ошибка если десерилизирую "плохой" файл
                foreach (var contact in listOfContacts)
                {
                    Console.WriteLine($"{contact.FirstName}, {contact.LastName}, {contact.Age}, {contact.Phone}, {contact.Comment}");
                }
            }

            //Delay
            Console.ReadKey();
        }
    }
}
