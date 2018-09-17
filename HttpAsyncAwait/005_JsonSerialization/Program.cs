using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace _005_JsonSerialization
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public Company Company { get; set; }
 
        public Person()
        { }
 
        public Person(string name, int age, Company comp)
        {
            Name = name;
            Age = age;
            Company = comp;
        }
    }

    public class Company
    {
        public string Name { get; set; }
 
        public Company() { }
 
        public Company(string name)
        {
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            Person person1 = new Person("Tom", 29, new Company("Microsoft"));
            Person person2 = new Person("Bill", 25, new Company("Apple"));
            Person[] people = new Person[] { person1, person2 };
 
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Person[]));
 
            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, people); // WriteObject  - это Serialize
            }
 
            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                Person[] newpeople = (Person[])jsonFormatter.ReadObject(fs); // ReadObject - Deserialize
 
                foreach (Person p in newpeople)
                {
                    Console.WriteLine("Имя: {0} --- Возраст: {1} --- Компания: {2}", p.Name, p.Age, p.Company.Name);
                }
            }
            //Когда открываешь json файл и он не отформатирован - правая кнопка мышки -> Format Document
            //Delay
            Console.ReadLine();
        }
    }
}
